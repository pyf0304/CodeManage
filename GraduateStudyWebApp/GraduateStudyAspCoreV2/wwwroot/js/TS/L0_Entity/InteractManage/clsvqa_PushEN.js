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
    exports.clsvqa_PushEN = void 0;
    /**
    * 类名:clsvqa_PushEN
    * 表名:vqa_Push(01120634)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:46:21
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
    * v答疑推送(vqa_Push)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvqa_PushEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.pushId = 0; //推送d
            this.questionsId = ""; //提问Id
            this.questionsContent = ""; //提问内容
            this.receiveUser = ""; //接收用户
            this.receiveDate = ""; //接收日期
            this.userName = ""; //用户名
            this.isReceive = false; //是否接收
            this.updDate = ""; //修改日期
            this.answerCount = 0; //回答计数
            this.isEnd = false; //是否结束
            this.voteCount = 0; //点赞计数
            this.memo = ""; //备注
            this.id_CurrEduCls = ""; //教学班流水号
            this.pdfContent = ""; //Pdf内容
            this.qa_PaperId = ""; //论文答疑Id
            this.isPublic = false; //是否公开
            this.paperId = ""; //论文Id
            this.paperTitle = ""; //论文标题
            this.pdfPageNum = 0; //Pdf页码
            this.isReply = false; //是否回复
            this.isRequestReply = false; //是否要求回复
            this.replyDate = ""; //回复日期
            this.questionsTypeId = ""; //问题类型Id
            this.questionsTypeName = ""; //问题类型名称
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
                case clsvqa_PushEN.con_PushId:
                    return this.pushId;
                case clsvqa_PushEN.con_QuestionsId:
                    return this.questionsId;
                case clsvqa_PushEN.con_QuestionsContent:
                    return this.questionsContent;
                case clsvqa_PushEN.con_ReceiveUser:
                    return this.receiveUser;
                case clsvqa_PushEN.con_ReceiveDate:
                    return this.receiveDate;
                case clsvqa_PushEN.con_UserName:
                    return this.userName;
                case clsvqa_PushEN.con_IsReceive:
                    return this.isReceive;
                case clsvqa_PushEN.con_UpdDate:
                    return this.updDate;
                case clsvqa_PushEN.con_AnswerCount:
                    return this.answerCount;
                case clsvqa_PushEN.con_IsEnd:
                    return this.isEnd;
                case clsvqa_PushEN.con_VoteCount:
                    return this.voteCount;
                case clsvqa_PushEN.con_Memo:
                    return this.memo;
                case clsvqa_PushEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvqa_PushEN.con_PdfContent:
                    return this.pdfContent;
                case clsvqa_PushEN.con_qa_PaperId:
                    return this.qa_PaperId;
                case clsvqa_PushEN.con_IsPublic:
                    return this.isPublic;
                case clsvqa_PushEN.con_PaperId:
                    return this.paperId;
                case clsvqa_PushEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvqa_PushEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsvqa_PushEN.con_IsReply:
                    return this.isReply;
                case clsvqa_PushEN.con_IsRequestReply:
                    return this.isRequestReply;
                case clsvqa_PushEN.con_ReplyDate:
                    return this.replyDate;
                case clsvqa_PushEN.con_QuestionsTypeId:
                    return this.questionsTypeId;
                case clsvqa_PushEN.con_QuestionsTypeName:
                    return this.questionsTypeName;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vqa_Push]中不存在！`;
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
                case clsvqa_PushEN.con_PushId:
                    this.pushId = Number(strValue);
                    break;
                case clsvqa_PushEN.con_QuestionsId:
                    this.questionsId = strValue;
                    break;
                case clsvqa_PushEN.con_QuestionsContent:
                    this.questionsContent = strValue;
                    break;
                case clsvqa_PushEN.con_ReceiveUser:
                    this.receiveUser = strValue;
                    break;
                case clsvqa_PushEN.con_ReceiveDate:
                    this.receiveDate = strValue;
                    break;
                case clsvqa_PushEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvqa_PushEN.con_IsReceive:
                    this.isReceive = Boolean(strValue);
                    break;
                case clsvqa_PushEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvqa_PushEN.con_AnswerCount:
                    this.answerCount = Number(strValue);
                    break;
                case clsvqa_PushEN.con_IsEnd:
                    this.isEnd = Boolean(strValue);
                    break;
                case clsvqa_PushEN.con_VoteCount:
                    this.voteCount = Number(strValue);
                    break;
                case clsvqa_PushEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvqa_PushEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvqa_PushEN.con_PdfContent:
                    this.pdfContent = strValue;
                    break;
                case clsvqa_PushEN.con_qa_PaperId:
                    this.qa_PaperId = strValue;
                    break;
                case clsvqa_PushEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    break;
                case clsvqa_PushEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvqa_PushEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvqa_PushEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    break;
                case clsvqa_PushEN.con_IsReply:
                    this.isReply = Boolean(strValue);
                    break;
                case clsvqa_PushEN.con_IsRequestReply:
                    this.isRequestReply = Boolean(strValue);
                    break;
                case clsvqa_PushEN.con_ReplyDate:
                    this.replyDate = strValue;
                    break;
                case clsvqa_PushEN.con_QuestionsTypeId:
                    this.questionsTypeId = strValue;
                    break;
                case clsvqa_PushEN.con_QuestionsTypeName:
                    this.questionsTypeName = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vqa_Push]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PushId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PushId() { return "pushId"; } //推送d
        /**
        * 常量:"QuestionsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsId() { return "questionsId"; } //提问Id
        /**
        * 常量:"QuestionsContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsContent() { return "questionsContent"; } //提问内容
        /**
        * 常量:"ReceiveUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReceiveUser() { return "receiveUser"; } //接收用户
        /**
        * 常量:"ReceiveDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReceiveDate() { return "receiveDate"; } //接收日期
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"IsReceive"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsReceive() { return "isReceive"; } //是否接收
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"AnswerCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerCount() { return "answerCount"; } //回答计数
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
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
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
        * 常量:"qa_PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_qa_PaperId() { return "qa_PaperId"; } //论文答疑Id
        /**
        * 常量:"IsPublic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsPublic() { return "isPublic"; } //是否公开
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
        * 常量:"PdfPageNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfPageNum() { return "pdfPageNum"; } //Pdf页码
        /**
        * 常量:"IsReply"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsReply() { return "isReply"; } //是否回复
        /**
        * 常量:"IsRequestReply"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRequestReply() { return "isRequestReply"; } //是否要求回复
        /**
        * 常量:"ReplyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReplyDate() { return "replyDate"; } //回复日期
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
    exports.clsvqa_PushEN = clsvqa_PushEN;
    clsvqa_PushEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvqa_PushEN.CacheModeId = "05"; //未知
    clsvqa_PushEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvqa_PushEN.WhereFormat = ""; //条件格式串
    clsvqa_PushEN._CurrTabName = "vqa_Push"; //当前表名,与该类相关的表名
    clsvqa_PushEN._KeyFldName = "PushId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvqa_PushEN.mintAttributeCount = 24;
    clsvqa_PushEN.AttributeName = ["pushId", "questionsId", "questionsContent", "receiveUser", "receiveDate", "userName", "isReceive", "updDate", "answerCount", "isEnd", "voteCount", "memo", "id_CurrEduCls", "pdfContent", "qa_PaperId", "isPublic", "paperId", "paperTitle", "pdfPageNum", "isReply", "isRequestReply", "replyDate", "questionsTypeId", "questionsTypeName"];
});
