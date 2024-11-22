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
    exports.clsvPaperSubViewpointEN = void 0;
    /**
    * 类名:clsvPaperSubViewpointEN
    * 表名:vPaperSubViewpoint(01120551)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:38
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
    * v子观点表(vPaperSubViewpoint)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvPaperSubViewpointEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.subViewpointId = ""; //子观点Id
            this.paperRWId = ""; //课文阅读
            this.paperId = ""; //论文Id
            this.paperTitle = ""; //论文标题
            this.isSubmit = false; //是否提交
            this.id_CurrEduCls = ""; //教学班流水号
            this.userId = ""; //用户ID
            this.sectionId = ""; //节Id
            this.sectionName = ""; //节名
            this.subViewpointTypeId = ""; //类型Id
            this.subViewpointTypeName = ""; //类型名称
            this.defaTitle = ""; //默认标题
            this.rwTitle = ""; //读写标题
            this.subViewpointContent = ""; //详情内容
            this.explainTypeId = ""; //说明类型Id
            this.explainTypeName = ""; //说明类型名
            this.explainContent = ""; //说明内容
            this.isPublic = false; //是否公开
            this.literatureSourcesId = ""; //文献来源
            this.pageNumber = 0; //页码
            this.orderNum = 0; //序号
            this.paperLineNum = 0; //论文行号
            this.paperPageNum = 0; //论文页码
            this.appraiseCount = 0; //评论数
            this.okCount = 0; //点赞统计
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.topicId = ""; //主题Id
            this.attitudesId = ""; //态度Id
            this.attitudesName = ""; //名称
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.sectionOrderNum = 0; //SectionOrderNum
            this.subViewpointTypeOrderNum = 0; //子观点类型序号
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
                case clsvPaperSubViewpointEN.con_SubViewpointId:
                    return this.subViewpointId;
                case clsvPaperSubViewpointEN.con_PaperRWId:
                    return this.paperRWId;
                case clsvPaperSubViewpointEN.con_PaperId:
                    return this.paperId;
                case clsvPaperSubViewpointEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvPaperSubViewpointEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvPaperSubViewpointEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvPaperSubViewpointEN.con_UserId:
                    return this.userId;
                case clsvPaperSubViewpointEN.con_SectionId:
                    return this.sectionId;
                case clsvPaperSubViewpointEN.con_SectionName:
                    return this.sectionName;
                case clsvPaperSubViewpointEN.con_SubViewpointTypeId:
                    return this.subViewpointTypeId;
                case clsvPaperSubViewpointEN.con_SubViewpointTypeName:
                    return this.subViewpointTypeName;
                case clsvPaperSubViewpointEN.con_DefaTitle:
                    return this.defaTitle;
                case clsvPaperSubViewpointEN.con_RWTitle:
                    return this.rwTitle;
                case clsvPaperSubViewpointEN.con_SubViewpointContent:
                    return this.subViewpointContent;
                case clsvPaperSubViewpointEN.con_ExplainTypeId:
                    return this.explainTypeId;
                case clsvPaperSubViewpointEN.con_ExplainTypeName:
                    return this.explainTypeName;
                case clsvPaperSubViewpointEN.con_ExplainContent:
                    return this.explainContent;
                case clsvPaperSubViewpointEN.con_IsPublic:
                    return this.isPublic;
                case clsvPaperSubViewpointEN.con_LiteratureSourcesId:
                    return this.literatureSourcesId;
                case clsvPaperSubViewpointEN.con_PageNumber:
                    return this.pageNumber;
                case clsvPaperSubViewpointEN.con_OrderNum:
                    return this.orderNum;
                case clsvPaperSubViewpointEN.con_PaperLineNum:
                    return this.paperLineNum;
                case clsvPaperSubViewpointEN.con_PaperPageNum:
                    return this.paperPageNum;
                case clsvPaperSubViewpointEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvPaperSubViewpointEN.con_OkCount:
                    return this.okCount;
                case clsvPaperSubViewpointEN.con_score:
                    return this.score;
                case clsvPaperSubViewpointEN.con_StuScore:
                    return this.stuScore;
                case clsvPaperSubViewpointEN.con_TeaScore:
                    return this.teaScore;
                case clsvPaperSubViewpointEN.con_CreateDate:
                    return this.createDate;
                case clsvPaperSubViewpointEN.con_ShareId:
                    return this.shareId;
                case clsvPaperSubViewpointEN.con_TopicId:
                    return this.topicId;
                case clsvPaperSubViewpointEN.con_AttitudesId:
                    return this.attitudesId;
                case clsvPaperSubViewpointEN.con_AttitudesName:
                    return this.attitudesName;
                case clsvPaperSubViewpointEN.con_UpdDate:
                    return this.updDate;
                case clsvPaperSubViewpointEN.con_UpdUser:
                    return this.updUser;
                case clsvPaperSubViewpointEN.con_Memo:
                    return this.memo;
                case clsvPaperSubViewpointEN.con_SectionOrderNum:
                    return this.sectionOrderNum;
                case clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum:
                    return this.subViewpointTypeOrderNum;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSubViewpoint]中不存在！`;
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
                case clsvPaperSubViewpointEN.con_SubViewpointId:
                    this.subViewpointId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_PaperRWId:
                    this.paperRWId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_SectionId:
                    this.sectionId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_SectionName:
                    this.sectionName = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_SubViewpointTypeId:
                    this.subViewpointTypeId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_SubViewpointTypeName:
                    this.subViewpointTypeName = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_DefaTitle:
                    this.defaTitle = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_RWTitle:
                    this.rwTitle = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_SubViewpointContent:
                    this.subViewpointContent = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_ExplainTypeId:
                    this.explainTypeId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_ExplainTypeName:
                    this.explainTypeName = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_ExplainContent:
                    this.explainContent = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_LiteratureSourcesId:
                    this.literatureSourcesId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_PageNumber:
                    this.pageNumber = Number(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_PaperLineNum:
                    this.paperLineNum = Number(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_PaperPageNum:
                    this.paperPageNum = Number(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_TopicId:
                    this.topicId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_AttitudesId:
                    this.attitudesId = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_AttitudesName:
                    this.attitudesName = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvPaperSubViewpointEN.con_SectionOrderNum:
                    this.sectionOrderNum = Number(strValue);
                    break;
                case clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum:
                    this.subViewpointTypeOrderNum = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSubViewpoint]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"SubViewpointId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubViewpointId() { return "subViewpointId"; } //子观点Id
        /**
        * 常量:"PaperRWId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperRWId() { return "paperRWId"; } //课文阅读
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
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"SectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionId() { return "sectionId"; } //节Id
        /**
        * 常量:"SectionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName() { return "sectionName"; } //节名
        /**
        * 常量:"SubViewpointTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubViewpointTypeId() { return "subViewpointTypeId"; } //类型Id
        /**
        * 常量:"SubViewpointTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubViewpointTypeName() { return "subViewpointTypeName"; } //类型名称
        /**
        * 常量:"DefaTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DefaTitle() { return "defaTitle"; } //默认标题
        /**
        * 常量:"RWTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RWTitle() { return "rwTitle"; } //读写标题
        /**
        * 常量:"SubViewpointContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubViewpointContent() { return "subViewpointContent"; } //详情内容
        /**
        * 常量:"ExplainTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExplainTypeId() { return "explainTypeId"; } //说明类型Id
        /**
        * 常量:"ExplainTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExplainTypeName() { return "explainTypeName"; } //说明类型名
        /**
        * 常量:"ExplainContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExplainContent() { return "explainContent"; } //说明内容
        /**
        * 常量:"IsPublic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsPublic() { return "isPublic"; } //是否公开
        /**
        * 常量:"LiteratureSourcesId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureSourcesId() { return "literatureSourcesId"; } //文献来源
        /**
        * 常量:"PageNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PageNumber() { return "pageNumber"; } //页码
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"PaperLineNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperLineNum() { return "paperLineNum"; } //论文行号
        /**
        * 常量:"PaperPageNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperPageNum() { return "paperPageNum"; } //论文页码
        /**
        * 常量:"AppraiseCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AppraiseCount() { return "appraiseCount"; } //评论数
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
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
        * 常量:"TopicId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicId() { return "topicId"; } //主题Id
        /**
        * 常量:"AttitudesId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AttitudesId() { return "attitudesId"; } //态度Id
        /**
        * 常量:"AttitudesName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AttitudesName() { return "attitudesName"; } //名称
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
        * 常量:"SectionOrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionOrderNum() { return "sectionOrderNum"; } //SectionOrderNum
        /**
        * 常量:"SubViewpointTypeOrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubViewpointTypeOrderNum() { return "subViewpointTypeOrderNum"; } //子观点类型序号
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
    exports.clsvPaperSubViewpointEN = clsvPaperSubViewpointEN;
    clsvPaperSubViewpointEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvPaperSubViewpointEN.CacheModeId = "04"; //sessionStorage
    clsvPaperSubViewpointEN._CurrTabName = "vPaperSubViewpoint"; //当前表名,与该类相关的表名
    clsvPaperSubViewpointEN._KeyFldName = "SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvPaperSubViewpointEN.mintAttributeCount = 38;
    clsvPaperSubViewpointEN.AttributeName = ["subViewpointId", "paperRWId", "paperId", "paperTitle", "isSubmit", "id_CurrEduCls", "userId", "sectionId", "sectionName", "subViewpointTypeId", "subViewpointTypeName", "defaTitle", "rwTitle", "subViewpointContent", "explainTypeId", "explainTypeName", "explainContent", "isPublic", "literatureSourcesId", "pageNumber", "orderNum", "paperLineNum", "paperPageNum", "appraiseCount", "okCount", "score", "stuScore", "teaScore", "createDate", "shareId", "topicId", "attitudesId", "attitudesName", "updDate", "updUser", "memo", "sectionOrderNum", "subViewpointTypeOrderNum"];
});
