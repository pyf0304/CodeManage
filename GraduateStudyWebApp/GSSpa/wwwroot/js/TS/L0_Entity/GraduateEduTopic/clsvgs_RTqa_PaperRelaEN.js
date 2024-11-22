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
    exports.clsvgs_RTqa_PaperRelaEN = void 0;
    /**
    * 类名:clsvgs_RTqa_PaperRelaEN
    * 表名:vgs_RTqa_PaperRela(01120695)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:56
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
    * 主题答疑关系视图(vgs_RTqa_PaperRela)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_RTqa_PaperRelaEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.mId = 0; //mId
            this.topicId = ""; //主题Id
            this.topicName = ""; //栏目主题
            this.id_CurrEduCls = ""; //教学班流水号
            this.qa_PaperId = ""; //论文答疑Id
            this.paperId = ""; //论文Id
            this.questionsCount = 0; //提问计数
            this.isPublic = false; //是否公开
            this.isSubmit = false; //是否提交
            this.paperTitle = ""; //论文标题
            this.attachmentCount = 0; //附件计数
            this.answerCount = 0; //回答计数
            this.shareId = ""; //分享Id
            this.tagsCount = 0; //论文标注数
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.qaUser = ""; //qaUser
            this.qaDate = ""; //qaDate
            this.qaUserName = ""; //qaUserName
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
                case clsvgs_RTqa_PaperRelaEN.con_mId:
                    return this.mId;
                case clsvgs_RTqa_PaperRelaEN.con_TopicId:
                    return this.topicId;
                case clsvgs_RTqa_PaperRelaEN.con_TopicName:
                    return this.topicName;
                case clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvgs_RTqa_PaperRelaEN.con_qa_PaperId:
                    return this.qa_PaperId;
                case clsvgs_RTqa_PaperRelaEN.con_PaperId:
                    return this.paperId;
                case clsvgs_RTqa_PaperRelaEN.con_QuestionsCount:
                    return this.questionsCount;
                case clsvgs_RTqa_PaperRelaEN.con_IsPublic:
                    return this.isPublic;
                case clsvgs_RTqa_PaperRelaEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvgs_RTqa_PaperRelaEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvgs_RTqa_PaperRelaEN.con_AttachmentCount:
                    return this.attachmentCount;
                case clsvgs_RTqa_PaperRelaEN.con_AnswerCount:
                    return this.answerCount;
                case clsvgs_RTqa_PaperRelaEN.con_ShareId:
                    return this.shareId;
                case clsvgs_RTqa_PaperRelaEN.con_TagsCount:
                    return this.tagsCount;
                case clsvgs_RTqa_PaperRelaEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_RTqa_PaperRelaEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_RTqa_PaperRelaEN.con_Memo:
                    return this.memo;
                case clsvgs_RTqa_PaperRelaEN.con_qaUser:
                    return this.qaUser;
                case clsvgs_RTqa_PaperRelaEN.con_qaDate:
                    return this.qaDate;
                case clsvgs_RTqa_PaperRelaEN.con_qaUserName:
                    return this.qaUserName;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_RTqa_PaperRela]中不存在！`;
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
                case clsvgs_RTqa_PaperRelaEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_TopicId:
                    this.topicId = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_TopicName:
                    this.topicName = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_qa_PaperId:
                    this.qa_PaperId = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_QuestionsCount:
                    this.questionsCount = Number(strValue);
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_AttachmentCount:
                    this.attachmentCount = Number(strValue);
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_AnswerCount:
                    this.answerCount = Number(strValue);
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_TagsCount:
                    this.tagsCount = Number(strValue);
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_qaUser:
                    this.qaUser = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_qaDate:
                    this.qaDate = strValue;
                    break;
                case clsvgs_RTqa_PaperRelaEN.con_qaUserName:
                    this.qaUserName = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_RTqa_PaperRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"mId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_mId() { return "mId"; } //mId
        /**
        * 常量:"TopicId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicId() { return "topicId"; } //主题Id
        /**
        * 常量:"TopicName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicName() { return "topicName"; } //栏目主题
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"qa_PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_qa_PaperId() { return "qa_PaperId"; } //论文答疑Id
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"QuestionsCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsCount() { return "questionsCount"; } //提问计数
        /**
        * 常量:"IsPublic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsPublic() { return "isPublic"; } //是否公开
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"AttachmentCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AttachmentCount() { return "attachmentCount"; } //附件计数
        /**
        * 常量:"AnswerCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerCount() { return "answerCount"; } //回答计数
        /**
        * 常量:"ShareId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ShareId() { return "shareId"; } //分享Id
        /**
        * 常量:"TagsCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TagsCount() { return "tagsCount"; } //论文标注数
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
        * 常量:"qaUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_qaUser() { return "qaUser"; } //qaUser
        /**
        * 常量:"qaDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_qaDate() { return "qaDate"; } //qaDate
        /**
        * 常量:"qaUserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_qaUserName() { return "qaUserName"; } //qaUserName
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
    exports.clsvgs_RTqa_PaperRelaEN = clsvgs_RTqa_PaperRelaEN;
    clsvgs_RTqa_PaperRelaEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_RTqa_PaperRelaEN.CacheModeId = "02"; //客户端缓存
    clsvgs_RTqa_PaperRelaEN._CurrTabName = "vgs_RTqa_PaperRela"; //当前表名,与该类相关的表名
    clsvgs_RTqa_PaperRelaEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_RTqa_PaperRelaEN.mintAttributeCount = 20;
    clsvgs_RTqa_PaperRelaEN.AttributeName = ["mId", "topicId", "topicName", "id_CurrEduCls", "qa_PaperId", "paperId", "questionsCount", "isPublic", "isSubmit", "paperTitle", "attachmentCount", "answerCount", "shareId", "tagsCount", "updDate", "updUser", "memo", "qaUser", "qaDate", "qaUserName"];
});
