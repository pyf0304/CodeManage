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
    exports.clsvqa_PaperEN = void 0;
    /**
    * 类名:clsvqa_PaperEN
    * 表名:vqa_Paper(01120637)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:53:32
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
    * v论文答疑(vqa_Paper)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvqa_PaperEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.qa_PaperId = ""; //论文答疑Id
            this.paperId = ""; //论文Id
            this.questionsCount = 0; //提问计数
            this.isDelete = false; //是否删除
            this.isPublic = false; //是否公开
            this.isSubmit = false; //是否提交
            this.updUser = ""; //修改人
            this.userName = ""; //用户名
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.paperTitle = ""; //论文标题
            this.attachmentCount = 0; //附件计数
            this.paperContent = ""; //主题内容
            this.periodical = ""; //期刊
            this.author = ""; //作者
            this.researchQuestion = ""; //研究问题
            this.literatureSources = ""; //文献来源
            this.uploadfileUrl = ""; //文件地址
            this.id_XzMajor = ""; //专业流水号
            this.majorName = ""; //专业名称
            this.id_CurrEduCls = ""; //教学班流水号
            this.answerCount = 0; //回答计数
            this.shareId = ""; //分享Id
            this.tagsCount = 0; //论文标注数
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
                case clsvqa_PaperEN.con_qa_PaperId:
                    return this.qa_PaperId;
                case clsvqa_PaperEN.con_PaperId:
                    return this.paperId;
                case clsvqa_PaperEN.con_QuestionsCount:
                    return this.questionsCount;
                case clsvqa_PaperEN.con_IsDelete:
                    return this.isDelete;
                case clsvqa_PaperEN.con_IsPublic:
                    return this.isPublic;
                case clsvqa_PaperEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvqa_PaperEN.con_UpdUser:
                    return this.updUser;
                case clsvqa_PaperEN.con_UserName:
                    return this.userName;
                case clsvqa_PaperEN.con_UpdDate:
                    return this.updDate;
                case clsvqa_PaperEN.con_Memo:
                    return this.memo;
                case clsvqa_PaperEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvqa_PaperEN.con_AttachmentCount:
                    return this.attachmentCount;
                case clsvqa_PaperEN.con_PaperContent:
                    return this.paperContent;
                case clsvqa_PaperEN.con_Periodical:
                    return this.periodical;
                case clsvqa_PaperEN.con_Author:
                    return this.author;
                case clsvqa_PaperEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsvqa_PaperEN.con_LiteratureSources:
                    return this.literatureSources;
                case clsvqa_PaperEN.con_UploadfileUrl:
                    return this.uploadfileUrl;
                case clsvqa_PaperEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvqa_PaperEN.con_MajorName:
                    return this.majorName;
                case clsvqa_PaperEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvqa_PaperEN.con_AnswerCount:
                    return this.answerCount;
                case clsvqa_PaperEN.con_ShareId:
                    return this.shareId;
                case clsvqa_PaperEN.con_TagsCount:
                    return this.tagsCount;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vqa_Paper]中不存在！`;
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
                case clsvqa_PaperEN.con_qa_PaperId:
                    this.qa_PaperId = strValue;
                    break;
                case clsvqa_PaperEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvqa_PaperEN.con_QuestionsCount:
                    this.questionsCount = Number(strValue);
                    break;
                case clsvqa_PaperEN.con_IsDelete:
                    this.isDelete = Boolean(strValue);
                    break;
                case clsvqa_PaperEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    break;
                case clsvqa_PaperEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvqa_PaperEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvqa_PaperEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvqa_PaperEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvqa_PaperEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvqa_PaperEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvqa_PaperEN.con_AttachmentCount:
                    this.attachmentCount = Number(strValue);
                    break;
                case clsvqa_PaperEN.con_PaperContent:
                    this.paperContent = strValue;
                    break;
                case clsvqa_PaperEN.con_Periodical:
                    this.periodical = strValue;
                    break;
                case clsvqa_PaperEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvqa_PaperEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    break;
                case clsvqa_PaperEN.con_LiteratureSources:
                    this.literatureSources = strValue;
                    break;
                case clsvqa_PaperEN.con_UploadfileUrl:
                    this.uploadfileUrl = strValue;
                    break;
                case clsvqa_PaperEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvqa_PaperEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvqa_PaperEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvqa_PaperEN.con_AnswerCount:
                    this.answerCount = Number(strValue);
                    break;
                case clsvqa_PaperEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvqa_PaperEN.con_TagsCount:
                    this.tagsCount = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vqa_Paper]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
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
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
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
        * 常量:"LiteratureSources"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureSources() { return "literatureSources"; } //文献来源
        /**
        * 常量:"UploadfileUrl"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UploadfileUrl() { return "uploadfileUrl"; } //文件地址
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
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
    exports.clsvqa_PaperEN = clsvqa_PaperEN;
    clsvqa_PaperEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvqa_PaperEN.CacheModeId = "04"; //sessionStorage
    clsvqa_PaperEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvqa_PaperEN.WhereFormat = ""; //条件格式串
    clsvqa_PaperEN._CurrTabName = "vqa_Paper"; //当前表名,与该类相关的表名
    clsvqa_PaperEN._KeyFldName = "qa_PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvqa_PaperEN.mintAttributeCount = 24;
    clsvqa_PaperEN.AttributeName = ["qa_PaperId", "paperId", "questionsCount", "isDelete", "isPublic", "isSubmit", "updUser", "userName", "updDate", "memo", "paperTitle", "attachmentCount", "paperContent", "periodical", "author", "researchQuestion", "literatureSources", "uploadfileUrl", "id_XzMajor", "majorName", "id_CurrEduCls", "answerCount", "shareId", "tagsCount"];
});
