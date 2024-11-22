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
    exports.clsvgs_ResearchResultEN = void 0;
    /**
    * 类名:clsvgs_ResearchResultEN
    * 表名:vgs_ResearchResult(01120778)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 15:53:08
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
    * 研究成果视图(vgs_ResearchResult)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_ResearchResultEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.resultId = ""; //成果Id
            this.topicId = ""; //主题Id
            this.topicName = ""; //栏目主题
            this.paperId = ""; //论文Id
            this.id_CurrEduCls = ""; //教学班流水号
            this.resultTypeId = ""; //成果类型Id
            this.resultName = ""; //成果名称
            this.resultContent = ""; //成果内容
            this.author = ""; //作者
            this.division = ""; //分工
            this.versionCount = 0; //版本统计
            this.okCount = 0; //点赞统计
            this.appraiseCount = 0; //评论数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
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
                case clsvgs_ResearchResultEN.con_ResultId:
                    return this.resultId;
                case clsvgs_ResearchResultEN.con_TopicId:
                    return this.topicId;
                case clsvgs_ResearchResultEN.con_TopicName:
                    return this.topicName;
                case clsvgs_ResearchResultEN.con_PaperId:
                    return this.paperId;
                case clsvgs_ResearchResultEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvgs_ResearchResultEN.con_ResultTypeId:
                    return this.resultTypeId;
                case clsvgs_ResearchResultEN.con_ResultName:
                    return this.resultName;
                case clsvgs_ResearchResultEN.con_ResultContent:
                    return this.resultContent;
                case clsvgs_ResearchResultEN.con_Author:
                    return this.author;
                case clsvgs_ResearchResultEN.con_Division:
                    return this.division;
                case clsvgs_ResearchResultEN.con_VersionCount:
                    return this.versionCount;
                case clsvgs_ResearchResultEN.con_OkCount:
                    return this.okCount;
                case clsvgs_ResearchResultEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvgs_ResearchResultEN.con_score:
                    return this.score;
                case clsvgs_ResearchResultEN.con_StuScore:
                    return this.stuScore;
                case clsvgs_ResearchResultEN.con_TeaScore:
                    return this.teaScore;
                case clsvgs_ResearchResultEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_ResearchResultEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_ResearchResultEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_ResearchResult]中不存在！`;
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
                case clsvgs_ResearchResultEN.con_ResultId:
                    this.resultId = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_TopicId:
                    this.topicId = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_TopicName:
                    this.topicName = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_ResultTypeId:
                    this.resultTypeId = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_ResultName:
                    this.resultName = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_ResultContent:
                    this.resultContent = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_Division:
                    this.division = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvgs_ResearchResultEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvgs_ResearchResultEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvgs_ResearchResultEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvgs_ResearchResultEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvgs_ResearchResultEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvgs_ResearchResultEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_ResearchResultEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_ResearchResult]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ResultId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResultId() { return "resultId"; } //成果Id
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
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"ResultTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResultTypeId() { return "resultTypeId"; } //成果类型Id
        /**
        * 常量:"ResultName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResultName() { return "resultName"; } //成果名称
        /**
        * 常量:"ResultContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResultContent() { return "resultContent"; } //成果内容
        /**
        * 常量:"Author"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Author() { return "author"; } //作者
        /**
        * 常量:"Division"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Division() { return "division"; } //分工
        /**
        * 常量:"VersionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
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
    exports.clsvgs_ResearchResultEN = clsvgs_ResearchResultEN;
    clsvgs_ResearchResultEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_ResearchResultEN.CacheModeId = "02"; //客户端缓存
    clsvgs_ResearchResultEN._CurrTabName = "vgs_ResearchResult"; //当前表名,与该类相关的表名
    clsvgs_ResearchResultEN._KeyFldName = "ResultId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_ResearchResultEN.mintAttributeCount = 19;
    clsvgs_ResearchResultEN.AttributeName = ["resultId", "topicId", "topicName", "paperId", "id_CurrEduCls", "resultTypeId", "resultName", "resultContent", "author", "division", "versionCount", "okCount", "appraiseCount", "score", "stuScore", "teaScore", "updDate", "updUser", "memo"];
});
