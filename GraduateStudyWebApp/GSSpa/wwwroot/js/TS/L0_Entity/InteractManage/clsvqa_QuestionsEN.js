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
    exports.clsvqa_QuestionsEN = void 0;
    /**
    * 类名:clsvqa_QuestionsEN
    * 表名:vqa_Questions(01120636)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:31
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:互动管理(InteractManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v答疑提问(vqa_Questions)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvqa_QuestionsEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.questionsId = ""; //提问Id
            this.paperId = ""; //论文Id
            this.isSubmit = false; //是否提交
            this.qa_PaperId = ""; //论文答疑Id
            this.questionsContent = ""; //提问内容
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.isDelete = false; //是否删除
            this.isPublic = false; //是否公开
            this.isEnd = false; //是否结束
            this.voteCount = 0; //点赞计数
            this.answerCount = 0; //回答计数
            this.orderNum = 0; //序号
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.userName = ""; //用户名
            this.id_CurrEduCls = ""; //教学班流水号
            this.paperTitle = ""; //论文标题
            this.pdfDivLet = ""; //PdfDivLet
            this.pdfDivTop = ""; //PdfDivTop
            this.pdfPageNumIn = ""; //PdfPageNumIn
            this.pdfPageTop = 0; //pdf页面顶部位置
            this.pdfZoom = ""; //PdfZoom
            this.userId = ""; //用户ID
            this.questionsTypeId = ""; //问题类型Id
            this.questionsTypeName = ""; //问题类型名称
            this.discussCount = 0; //DiscussCount
            this.groupDiscussCount = 0; //GroupDiscussCount
            this.recommendAnswerCount = 0; //RecommendAnswerCount
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
                case clsvqa_QuestionsEN.con_QuestionsId:
                    return this.questionsId;
                case clsvqa_QuestionsEN.con_PaperId:
                    return this.paperId;
                case clsvqa_QuestionsEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvqa_QuestionsEN.con_qa_PaperId:
                    return this.qa_PaperId;
                case clsvqa_QuestionsEN.con_QuestionsContent:
                    return this.questionsContent;
                case clsvqa_QuestionsEN.con_PdfContent:
                    return this.pdfContent;
                case clsvqa_QuestionsEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsvqa_QuestionsEN.con_IsDelete:
                    return this.isDelete;
                case clsvqa_QuestionsEN.con_IsPublic:
                    return this.isPublic;
                case clsvqa_QuestionsEN.con_IsEnd:
                    return this.isEnd;
                case clsvqa_QuestionsEN.con_VoteCount:
                    return this.voteCount;
                case clsvqa_QuestionsEN.con_AnswerCount:
                    return this.answerCount;
                case clsvqa_QuestionsEN.con_OrderNum:
                    return this.orderNum;
                case clsvqa_QuestionsEN.con_UpdUser:
                    return this.updUser;
                case clsvqa_QuestionsEN.con_UpdDate:
                    return this.updDate;
                case clsvqa_QuestionsEN.con_Memo:
                    return this.memo;
                case clsvqa_QuestionsEN.con_UserName:
                    return this.userName;
                case clsvqa_QuestionsEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvqa_QuestionsEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvqa_QuestionsEN.con_PdfDivLet:
                    return this.pdfDivLet;
                case clsvqa_QuestionsEN.con_PdfDivTop:
                    return this.pdfDivTop;
                case clsvqa_QuestionsEN.con_PdfPageNumIn:
                    return this.pdfPageNumIn;
                case clsvqa_QuestionsEN.con_PdfPageTop:
                    return this.pdfPageTop;
                case clsvqa_QuestionsEN.con_PdfZoom:
                    return this.pdfZoom;
                case clsvqa_QuestionsEN.con_UserId:
                    return this.userId;
                case clsvqa_QuestionsEN.con_QuestionsTypeId:
                    return this.questionsTypeId;
                case clsvqa_QuestionsEN.con_QuestionsTypeName:
                    return this.questionsTypeName;
                case clsvqa_QuestionsEN.con_DiscussCount:
                    return this.discussCount;
                case clsvqa_QuestionsEN.con_GroupDiscussCount:
                    return this.groupDiscussCount;
                case clsvqa_QuestionsEN.con_RecommendAnswerCount:
                    return this.recommendAnswerCount;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vqa_Questions]中不存在！`;
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
                case clsvqa_QuestionsEN.con_QuestionsId:
                    this.questionsId = strValue;
                    break;
                case clsvqa_QuestionsEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvqa_QuestionsEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvqa_QuestionsEN.con_qa_PaperId:
                    this.qa_PaperId = strValue;
                    break;
                case clsvqa_QuestionsEN.con_QuestionsContent:
                    this.questionsContent = strValue;
                    break;
                case clsvqa_QuestionsEN.con_PdfContent:
                    this.pdfContent = strValue;
                    break;
                case clsvqa_QuestionsEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    break;
                case clsvqa_QuestionsEN.con_IsDelete:
                    this.isDelete = Boolean(strValue);
                    break;
                case clsvqa_QuestionsEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    break;
                case clsvqa_QuestionsEN.con_IsEnd:
                    this.isEnd = Boolean(strValue);
                    break;
                case clsvqa_QuestionsEN.con_VoteCount:
                    this.voteCount = Number(strValue);
                    break;
                case clsvqa_QuestionsEN.con_AnswerCount:
                    this.answerCount = Number(strValue);
                    break;
                case clsvqa_QuestionsEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvqa_QuestionsEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvqa_QuestionsEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvqa_QuestionsEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvqa_QuestionsEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvqa_QuestionsEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvqa_QuestionsEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvqa_QuestionsEN.con_PdfDivLet:
                    this.pdfDivLet = strValue;
                    break;
                case clsvqa_QuestionsEN.con_PdfDivTop:
                    this.pdfDivTop = strValue;
                    break;
                case clsvqa_QuestionsEN.con_PdfPageNumIn:
                    this.pdfPageNumIn = strValue;
                    break;
                case clsvqa_QuestionsEN.con_PdfPageTop:
                    this.pdfPageTop = Number(strValue);
                    break;
                case clsvqa_QuestionsEN.con_PdfZoom:
                    this.pdfZoom = strValue;
                    break;
                case clsvqa_QuestionsEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvqa_QuestionsEN.con_QuestionsTypeId:
                    this.questionsTypeId = strValue;
                    break;
                case clsvqa_QuestionsEN.con_QuestionsTypeName:
                    this.questionsTypeName = strValue;
                    break;
                case clsvqa_QuestionsEN.con_DiscussCount:
                    this.discussCount = Number(strValue);
                    break;
                case clsvqa_QuestionsEN.con_GroupDiscussCount:
                    this.groupDiscussCount = Number(strValue);
                    break;
                case clsvqa_QuestionsEN.con_RecommendAnswerCount:
                    this.recommendAnswerCount = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vqa_Questions]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"QuestionsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsId() { return "questionsId"; } //提问Id
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"qa_PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_qa_PaperId() { return "qa_PaperId"; } //论文答疑Id
        /**
        * 常量:"QuestionsContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsContent() { return "questionsContent"; } //提问内容
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
        * 常量:"IsDelete"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsDelete() { return "isDelete"; } //是否删除
        /**
        * 常量:"IsPublic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsPublic() { return "isPublic"; } //是否公开
        /**
        * 常量:"IsEnd"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsEnd() { return "isEnd"; } //是否结束
        /**
        * 常量:"VoteCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteCount() { return "voteCount"; } //点赞计数
        /**
        * 常量:"AnswerCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerCount() { return "answerCount"; } //回答计数
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
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
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"PdfDivLet"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfDivLet() { return "pdfDivLet"; } //PdfDivLet
        /**
        * 常量:"PdfDivTop"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfDivTop() { return "pdfDivTop"; } //PdfDivTop
        /**
        * 常量:"PdfPageNumIn"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfPageNumIn() { return "pdfPageNumIn"; } //PdfPageNumIn
        /**
        * 常量:"PdfPageTop"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfPageTop() { return "pdfPageTop"; } //pdf页面顶部位置
        /**
        * 常量:"PdfZoom"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfZoom() { return "pdfZoom"; } //PdfZoom
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"QuestionsTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsTypeId() { return "questionsTypeId"; } //问题类型Id
        /**
        * 常量:"QuestionsTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsTypeName() { return "questionsTypeName"; } //问题类型名称
        /**
        * 常量:"DiscussCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DiscussCount() { return "discussCount"; } //DiscussCount
        /**
        * 常量:"GroupDiscussCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GroupDiscussCount() { return "groupDiscussCount"; } //GroupDiscussCount
        /**
        * 常量:"RecommendAnswerCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RecommendAnswerCount() { return "recommendAnswerCount"; } //RecommendAnswerCount
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
    exports.clsvqa_QuestionsEN = clsvqa_QuestionsEN;
    clsvqa_QuestionsEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvqa_QuestionsEN.CacheModeId = "02"; //客户端缓存
    clsvqa_QuestionsEN._CurrTabName = "vqa_Questions"; //当前表名,与该类相关的表名
    clsvqa_QuestionsEN._KeyFldName = "QuestionsId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvqa_QuestionsEN.mintAttributeCount = 30;
    clsvqa_QuestionsEN.AttributeName = ["questionsId", "paperId", "isSubmit", "qa_PaperId", "questionsContent", "pdfContent", "pdfPageNum", "isDelete", "isPublic", "isEnd", "voteCount", "answerCount", "orderNum", "updUser", "updDate", "memo", "userName", "id_CurrEduCls", "paperTitle", "pdfDivLet", "pdfDivTop", "pdfPageNumIn", "pdfPageTop", "pdfZoom", "userId", "questionsTypeId", "questionsTypeName", "discussCount", "groupDiscussCount", "recommendAnswerCount"];
});
