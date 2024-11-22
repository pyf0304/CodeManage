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
    exports.clsvgs_ResearchPlanEN = void 0;
    /**
    * 类名:clsvgs_ResearchPlanEN
    * 表名:vgs_ResearchPlan(01120662)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:55
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
    * 主题研究计划视图(vgs_ResearchPlan)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_ResearchPlanEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.planId = ""; //计划Id
            this.topicId = ""; //主题Id
            this.topicName = ""; //栏目主题
            this.id_CurrEduCls = ""; //教学班流水号
            this.statusId = ""; //状态Id
            this.statusName = ""; //状态名称
            this.planContent = ""; //计划内容
            this.responsibleUser = ""; //负责人/小组
            this.startDate = ""; //开始日期
            this.endDate = ""; //截止日期
            this.actualFinishingDate = ""; //实际完成日期
            this.acceptanceUser = ""; //验收用户
            this.isSubmit = false; //是否提交
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.planTypeId = ""; //计划类型
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
                case clsvgs_ResearchPlanEN.con_PlanId:
                    return this.planId;
                case clsvgs_ResearchPlanEN.con_TopicId:
                    return this.topicId;
                case clsvgs_ResearchPlanEN.con_TopicName:
                    return this.topicName;
                case clsvgs_ResearchPlanEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvgs_ResearchPlanEN.con_StatusId:
                    return this.statusId;
                case clsvgs_ResearchPlanEN.con_StatusName:
                    return this.statusName;
                case clsvgs_ResearchPlanEN.con_PlanContent:
                    return this.planContent;
                case clsvgs_ResearchPlanEN.con_ResponsibleUser:
                    return this.responsibleUser;
                case clsvgs_ResearchPlanEN.con_StartDate:
                    return this.startDate;
                case clsvgs_ResearchPlanEN.con_EndDate:
                    return this.endDate;
                case clsvgs_ResearchPlanEN.con_ActualFinishingDate:
                    return this.actualFinishingDate;
                case clsvgs_ResearchPlanEN.con_AcceptanceUser:
                    return this.acceptanceUser;
                case clsvgs_ResearchPlanEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvgs_ResearchPlanEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_ResearchPlanEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_ResearchPlanEN.con_Memo:
                    return this.memo;
                case clsvgs_ResearchPlanEN.con_PlanTypeId:
                    return this.planTypeId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_ResearchPlan]中不存在！`;
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
                case clsvgs_ResearchPlanEN.con_PlanId:
                    this.planId = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_TopicId:
                    this.topicId = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_TopicName:
                    this.topicName = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_StatusId:
                    this.statusId = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_StatusName:
                    this.statusName = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_PlanContent:
                    this.planContent = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_ResponsibleUser:
                    this.responsibleUser = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_StartDate:
                    this.startDate = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_EndDate:
                    this.endDate = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_ActualFinishingDate:
                    this.actualFinishingDate = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_AcceptanceUser:
                    this.acceptanceUser = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvgs_ResearchPlanEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvgs_ResearchPlanEN.con_PlanTypeId:
                    this.planTypeId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_ResearchPlan]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PlanId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PlanId() { return "planId"; } //计划Id
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
        * 常量:"StatusId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StatusId() { return "statusId"; } //状态Id
        /**
        * 常量:"StatusName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StatusName() { return "statusName"; } //状态名称
        /**
        * 常量:"PlanContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PlanContent() { return "planContent"; } //计划内容
        /**
        * 常量:"ResponsibleUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResponsibleUser() { return "responsibleUser"; } //负责人/小组
        /**
        * 常量:"StartDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StartDate() { return "startDate"; } //开始日期
        /**
        * 常量:"EndDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EndDate() { return "endDate"; } //截止日期
        /**
        * 常量:"ActualFinishingDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ActualFinishingDate() { return "actualFinishingDate"; } //实际完成日期
        /**
        * 常量:"AcceptanceUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AcceptanceUser() { return "acceptanceUser"; } //验收用户
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
        * 常量:"PlanTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PlanTypeId() { return "planTypeId"; } //计划类型
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
    exports.clsvgs_ResearchPlanEN = clsvgs_ResearchPlanEN;
    clsvgs_ResearchPlanEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_ResearchPlanEN.CacheModeId = "02"; //客户端缓存
    clsvgs_ResearchPlanEN._CurrTabName = "vgs_ResearchPlan"; //当前表名,与该类相关的表名
    clsvgs_ResearchPlanEN._KeyFldName = "PlanId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_ResearchPlanEN.mintAttributeCount = 17;
    clsvgs_ResearchPlanEN.AttributeName = ["planId", "topicId", "topicName", "id_CurrEduCls", "statusId", "statusName", "planContent", "responsibleUser", "startDate", "endDate", "actualFinishingDate", "acceptanceUser", "isSubmit", "updUser", "updDate", "memo", "planTypeId"];
});
