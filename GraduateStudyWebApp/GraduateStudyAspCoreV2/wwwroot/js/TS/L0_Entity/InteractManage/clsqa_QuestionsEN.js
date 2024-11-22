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
    exports.clsqa_QuestionsEN = void 0;
    /**
    * 类名:clsqa_QuestionsEN
    * 表名:qa_Questions(01120642)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:52:48
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
    * 答疑提问表(qa_Questions)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsqa_QuestionsEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrQuestionsId = ""; //提问Id
            this.mstrqa_PaperId = ""; //论文答疑Id
            this.mstrQuestionsContent = ""; //提问内容
            this.mstrPdfContent = ""; //Pdf内容
            this.mintPdfPageNum = 0; //Pdf页码
            this.mbolIsDelete = false; //是否删除
            this.mbolIsPublic = false; //是否公开
            this.mbolIsEnd = false; //是否结束
            this.mintVoteCount = 0; //点赞计数
            this.mintAnswerCount = 0; //回答计数
            this.mintOrderNum = 0; //序号
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            this.mstrPdfDivLet = ""; //PdfDivLet
            this.mstrPdfDivTop = ""; //PdfDivTop
            this.mstrPdfPageNumIn = ""; //PdfPageNumIn
            this.mintPdfPageTop = 0; //pdf页面顶部位置
            this.mstrPdfZoom = ""; //PdfZoom
            this.mstrPaperId = ""; //论文Id
            this.mstrUserId = ""; //用户ID
            this.mstrQuestionsTypeId = ""; //问题类型Id
            this.mintDiscussCount = 0; //DiscussCount
            this.mintGroupDiscussCount = 0; //GroupDiscussCount
            this.mintRecommendAnswerCount = 0; //RecommendAnswerCount
            this.mstrCreateDate = ""; //建立日期
            this.mstrid_CurrEduCls = ""; //教学班流水号
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.questionsId = ""; //提问Id
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
            this.pdfDivLet = ""; //PdfDivLet
            this.pdfDivTop = ""; //PdfDivTop
            this.pdfPageNumIn = ""; //PdfPageNumIn
            this.pdfPageTop = 0; //pdf页面顶部位置
            this.pdfZoom = ""; //PdfZoom
            this.paperId = ""; //论文Id
            this.userId = ""; //用户ID
            this.questionsTypeId = ""; //问题类型Id
            this.discussCount = 0; //DiscussCount
            this.groupDiscussCount = 0; //GroupDiscussCount
            this.recommendAnswerCount = 0; //RecommendAnswerCount
            this.createDate = ""; //建立日期
            this.id_CurrEduCls = ""; //教学班流水号
        }
        /**
         * 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionsId(value) {
            if (value != undefined) {
                this.questionsId = value;
                this.hmProperty["questionsId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 论文答疑Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setqa_PaperId(value) {
            if (value != undefined) {
                this.qa_PaperId = value;
                this.hmProperty["qa_PaperId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 提问内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionsContent(value) {
            if (value != undefined) {
                this.questionsContent = value;
                this.hmProperty["questionsContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfContent(value) {
            if (value != undefined) {
                this.pdfContent = value;
                this.hmProperty["pdfContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfPageNum(value) {
            if (value != undefined) {
                this.pdfPageNum = value;
                this.hmProperty["pdfPageNum"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsDelete(value) {
            if (value != undefined) {
                this.isDelete = value;
                this.hmProperty["isDelete"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsPublic(value) {
            if (value != undefined) {
                this.isPublic = value;
                this.hmProperty["isPublic"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否结束(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsEnd(value) {
            if (value != undefined) {
                this.isEnd = value;
                this.hmProperty["isEnd"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVoteCount(value) {
            if (value != undefined) {
                this.voteCount = value;
                this.hmProperty["voteCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 回答计数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerCount(value) {
            if (value != undefined) {
                this.answerCount = value;
                this.hmProperty["answerCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOrderNum(value) {
            if (value != undefined) {
                this.orderNum = value;
                this.hmProperty["orderNum"] = true;
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
         * PdfDivLet(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfDivLet(value) {
            if (value != undefined) {
                this.pdfDivLet = value;
                this.hmProperty["pdfDivLet"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * PdfDivTop(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfDivTop(value) {
            if (value != undefined) {
                this.pdfDivTop = value;
                this.hmProperty["pdfDivTop"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * PdfPageNumIn(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfPageNumIn(value) {
            if (value != undefined) {
                this.pdfPageNumIn = value;
                this.hmProperty["pdfPageNumIn"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * pdf页面顶部位置(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfPageTop(value) {
            if (value != undefined) {
                this.pdfPageTop = value;
                this.hmProperty["pdfPageTop"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * PdfZoom(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfZoom(value) {
            if (value != undefined) {
                this.pdfZoom = value;
                this.hmProperty["pdfZoom"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserId(value) {
            if (value != undefined) {
                this.userId = value;
                this.hmProperty["userId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 问题类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionsTypeId(value) {
            if (value != undefined) {
                this.questionsTypeId = value;
                this.hmProperty["questionsTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * DiscussCount(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDiscussCount(value) {
            if (value != undefined) {
                this.discussCount = value;
                this.hmProperty["discussCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * GroupDiscussCount(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetGroupDiscussCount(value) {
            if (value != undefined) {
                this.groupDiscussCount = value;
                this.hmProperty["groupDiscussCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * RecommendAnswerCount(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRecommendAnswerCount(value) {
            if (value != undefined) {
                this.recommendAnswerCount = value;
                this.hmProperty["recommendAnswerCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCreateDate(value) {
            if (value != undefined) {
                this.createDate = value;
                this.hmProperty["createDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                case clsqa_QuestionsEN.con_QuestionsId:
                    return this.questionsId;
                case clsqa_QuestionsEN.con_qa_PaperId:
                    return this.qa_PaperId;
                case clsqa_QuestionsEN.con_QuestionsContent:
                    return this.questionsContent;
                case clsqa_QuestionsEN.con_PdfContent:
                    return this.pdfContent;
                case clsqa_QuestionsEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsqa_QuestionsEN.con_IsDelete:
                    return this.isDelete;
                case clsqa_QuestionsEN.con_IsPublic:
                    return this.isPublic;
                case clsqa_QuestionsEN.con_IsEnd:
                    return this.isEnd;
                case clsqa_QuestionsEN.con_VoteCount:
                    return this.voteCount;
                case clsqa_QuestionsEN.con_AnswerCount:
                    return this.answerCount;
                case clsqa_QuestionsEN.con_OrderNum:
                    return this.orderNum;
                case clsqa_QuestionsEN.con_UpdUser:
                    return this.updUser;
                case clsqa_QuestionsEN.con_UpdDate:
                    return this.updDate;
                case clsqa_QuestionsEN.con_Memo:
                    return this.memo;
                case clsqa_QuestionsEN.con_PdfDivLet:
                    return this.pdfDivLet;
                case clsqa_QuestionsEN.con_PdfDivTop:
                    return this.pdfDivTop;
                case clsqa_QuestionsEN.con_PdfPageNumIn:
                    return this.pdfPageNumIn;
                case clsqa_QuestionsEN.con_PdfPageTop:
                    return this.pdfPageTop;
                case clsqa_QuestionsEN.con_PdfZoom:
                    return this.pdfZoom;
                case clsqa_QuestionsEN.con_PaperId:
                    return this.paperId;
                case clsqa_QuestionsEN.con_UserId:
                    return this.userId;
                case clsqa_QuestionsEN.con_QuestionsTypeId:
                    return this.questionsTypeId;
                case clsqa_QuestionsEN.con_DiscussCount:
                    return this.discussCount;
                case clsqa_QuestionsEN.con_GroupDiscussCount:
                    return this.groupDiscussCount;
                case clsqa_QuestionsEN.con_RecommendAnswerCount:
                    return this.recommendAnswerCount;
                case clsqa_QuestionsEN.con_CreateDate:
                    return this.createDate;
                case clsqa_QuestionsEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[qa_Questions]中不存在！`;
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
                case clsqa_QuestionsEN.con_QuestionsId:
                    this.questionsId = strValue;
                    this.hmProperty["questionsId"] = true;
                    break;
                case clsqa_QuestionsEN.con_qa_PaperId:
                    this.qa_PaperId = strValue;
                    this.hmProperty["qa_PaperId"] = true;
                    break;
                case clsqa_QuestionsEN.con_QuestionsContent:
                    this.questionsContent = strValue;
                    this.hmProperty["questionsContent"] = true;
                    break;
                case clsqa_QuestionsEN.con_PdfContent:
                    this.pdfContent = strValue;
                    this.hmProperty["pdfContent"] = true;
                    break;
                case clsqa_QuestionsEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    this.hmProperty["pdfPageNum"] = true;
                    break;
                case clsqa_QuestionsEN.con_IsDelete:
                    this.isDelete = Boolean(strValue);
                    this.hmProperty["isDelete"] = true;
                    break;
                case clsqa_QuestionsEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    this.hmProperty["isPublic"] = true;
                    break;
                case clsqa_QuestionsEN.con_IsEnd:
                    this.isEnd = Boolean(strValue);
                    this.hmProperty["isEnd"] = true;
                    break;
                case clsqa_QuestionsEN.con_VoteCount:
                    this.voteCount = Number(strValue);
                    this.hmProperty["voteCount"] = true;
                    break;
                case clsqa_QuestionsEN.con_AnswerCount:
                    this.answerCount = Number(strValue);
                    this.hmProperty["answerCount"] = true;
                    break;
                case clsqa_QuestionsEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    this.hmProperty["orderNum"] = true;
                    break;
                case clsqa_QuestionsEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsqa_QuestionsEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsqa_QuestionsEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsqa_QuestionsEN.con_PdfDivLet:
                    this.pdfDivLet = strValue;
                    this.hmProperty["pdfDivLet"] = true;
                    break;
                case clsqa_QuestionsEN.con_PdfDivTop:
                    this.pdfDivTop = strValue;
                    this.hmProperty["pdfDivTop"] = true;
                    break;
                case clsqa_QuestionsEN.con_PdfPageNumIn:
                    this.pdfPageNumIn = strValue;
                    this.hmProperty["pdfPageNumIn"] = true;
                    break;
                case clsqa_QuestionsEN.con_PdfPageTop:
                    this.pdfPageTop = Number(strValue);
                    this.hmProperty["pdfPageTop"] = true;
                    break;
                case clsqa_QuestionsEN.con_PdfZoom:
                    this.pdfZoom = strValue;
                    this.hmProperty["pdfZoom"] = true;
                    break;
                case clsqa_QuestionsEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsqa_QuestionsEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case clsqa_QuestionsEN.con_QuestionsTypeId:
                    this.questionsTypeId = strValue;
                    this.hmProperty["questionsTypeId"] = true;
                    break;
                case clsqa_QuestionsEN.con_DiscussCount:
                    this.discussCount = Number(strValue);
                    this.hmProperty["discussCount"] = true;
                    break;
                case clsqa_QuestionsEN.con_GroupDiscussCount:
                    this.groupDiscussCount = Number(strValue);
                    this.hmProperty["groupDiscussCount"] = true;
                    break;
                case clsqa_QuestionsEN.con_RecommendAnswerCount:
                    this.recommendAnswerCount = Number(strValue);
                    this.hmProperty["recommendAnswerCount"] = true;
                    break;
                case clsqa_QuestionsEN.con_CreateDate:
                    this.createDate = strValue;
                    this.hmProperty["createDate"] = true;
                    break;
                case clsqa_QuestionsEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[qa_Questions]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
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
        * 常量:"CreateDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateDate() { return "createDate"; } //建立日期
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
    exports.clsqa_QuestionsEN = clsqa_QuestionsEN;
    clsqa_QuestionsEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsqa_QuestionsEN.CacheModeId = "02"; //客户端缓存
    clsqa_QuestionsEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsqa_QuestionsEN.WhereFormat = ""; //条件格式串
    clsqa_QuestionsEN._CurrTabName = "qa_Questions"; //当前表名,与该类相关的表名
    clsqa_QuestionsEN._KeyFldName = "QuestionsId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsqa_QuestionsEN.mintAttributeCount = 27;
    clsqa_QuestionsEN.AttributeName = ["questionsId", "qa_PaperId", "questionsContent", "pdfContent", "pdfPageNum", "isDelete", "isPublic", "isEnd", "voteCount", "answerCount", "orderNum", "updUser", "updDate", "memo", "pdfDivLet", "pdfDivTop", "pdfPageNumIn", "pdfPageTop", "pdfZoom", "paperId", "userId", "questionsTypeId", "discussCount", "groupDiscussCount", "recommendAnswerCount", "createDate", "id_CurrEduCls"];
});
