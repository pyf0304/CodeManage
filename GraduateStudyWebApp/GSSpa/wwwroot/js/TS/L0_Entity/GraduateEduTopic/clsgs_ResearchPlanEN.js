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
    exports.clsgs_ResearchPlanEN = void 0;
    /**
    * 类名:clsgs_ResearchPlanEN
    * 表名:gs_ResearchPlan(01120663)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:57
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
    * 主题研究计划(gs_ResearchPlan)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_ResearchPlanEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrPlanId = ""; //计划Id
            this.mstrTopicId = ""; //主题Id
            this.mstrStatusId = ""; //状态Id
            this.mstrPlanContent = ""; //计划内容
            this.mstrResponsibleUser = ""; //负责人/小组
            this.mstrStartDate = ""; //开始日期
            this.mstrEndDate = ""; //截止日期
            this.mstrActualFinishingDate = ""; //实际完成日期
            this.mstrAcceptanceUser = ""; //验收用户
            this.mbolIsSubmit = false; //是否提交
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            this.mstrPlanTypeId = ""; //计划类型
            this.mstrid_CurrEduCls = ""; //教学班流水号
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.planId = ""; //计划Id
            this.topicId = ""; //主题Id
            this.statusId = ""; //状态Id
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
            this.id_CurrEduCls = ""; //教学班流水号
        }
        /**
         * 计划Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPlanId(value) {
            if (value != undefined) {
                this.planId = value;
                this.hmProperty["planId"] = true;
            }
        }
        /**
         * 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicId(value) {
            if (value != undefined) {
                this.topicId = value;
                this.hmProperty["topicId"] = true;
            }
        }
        /**
         * 状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStatusId(value) {
            if (value != undefined) {
                this.statusId = value;
                this.hmProperty["statusId"] = true;
            }
        }
        /**
         * 计划内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPlanContent(value) {
            if (value != undefined) {
                this.planContent = value;
                this.hmProperty["planContent"] = true;
            }
        }
        /**
         * 负责人/小组(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResponsibleUser(value) {
            if (value != undefined) {
                this.responsibleUser = value;
                this.hmProperty["responsibleUser"] = true;
            }
        }
        /**
         * 开始日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStartDate(value) {
            if (value != undefined) {
                this.startDate = value;
                this.hmProperty["startDate"] = true;
            }
        }
        /**
         * 截止日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEndDate(value) {
            if (value != undefined) {
                this.endDate = value;
                this.hmProperty["endDate"] = true;
            }
        }
        /**
         * 实际完成日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetActualFinishingDate(value) {
            if (value != undefined) {
                this.actualFinishingDate = value;
                this.hmProperty["actualFinishingDate"] = true;
            }
        }
        /**
         * 验收用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAcceptanceUser(value) {
            if (value != undefined) {
                this.acceptanceUser = value;
                this.hmProperty["acceptanceUser"] = true;
            }
        }
        /**
         * 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSubmit(value) {
            if (value != undefined) {
                this.isSubmit = value;
                this.hmProperty["isSubmit"] = true;
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
            }
        }
        /**
         * 计划类型(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPlanTypeId(value) {
            if (value != undefined) {
                this.planTypeId = value;
                this.hmProperty["planTypeId"] = true;
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
                case clsgs_ResearchPlanEN.con_PlanId:
                    return this.planId;
                case clsgs_ResearchPlanEN.con_TopicId:
                    return this.topicId;
                case clsgs_ResearchPlanEN.con_StatusId:
                    return this.statusId;
                case clsgs_ResearchPlanEN.con_PlanContent:
                    return this.planContent;
                case clsgs_ResearchPlanEN.con_ResponsibleUser:
                    return this.responsibleUser;
                case clsgs_ResearchPlanEN.con_StartDate:
                    return this.startDate;
                case clsgs_ResearchPlanEN.con_EndDate:
                    return this.endDate;
                case clsgs_ResearchPlanEN.con_ActualFinishingDate:
                    return this.actualFinishingDate;
                case clsgs_ResearchPlanEN.con_AcceptanceUser:
                    return this.acceptanceUser;
                case clsgs_ResearchPlanEN.con_IsSubmit:
                    return this.isSubmit;
                case clsgs_ResearchPlanEN.con_UpdUser:
                    return this.updUser;
                case clsgs_ResearchPlanEN.con_UpdDate:
                    return this.updDate;
                case clsgs_ResearchPlanEN.con_Memo:
                    return this.memo;
                case clsgs_ResearchPlanEN.con_PlanTypeId:
                    return this.planTypeId;
                case clsgs_ResearchPlanEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_ResearchPlan]中不存在！`;
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
                case clsgs_ResearchPlanEN.con_PlanId:
                    this.planId = strValue;
                    this.hmProperty["planId"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_StatusId:
                    this.statusId = strValue;
                    this.hmProperty["statusId"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_PlanContent:
                    this.planContent = strValue;
                    this.hmProperty["planContent"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_ResponsibleUser:
                    this.responsibleUser = strValue;
                    this.hmProperty["responsibleUser"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_StartDate:
                    this.startDate = strValue;
                    this.hmProperty["startDate"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_EndDate:
                    this.endDate = strValue;
                    this.hmProperty["endDate"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_ActualFinishingDate:
                    this.actualFinishingDate = strValue;
                    this.hmProperty["actualFinishingDate"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_AcceptanceUser:
                    this.acceptanceUser = strValue;
                    this.hmProperty["acceptanceUser"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_PlanTypeId:
                    this.planTypeId = strValue;
                    this.hmProperty["planTypeId"] = true;
                    break;
                case clsgs_ResearchPlanEN.con_id_CurrEduCls:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_ResearchPlan]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"StatusId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StatusId() { return "statusId"; } //状态Id
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
    exports.clsgs_ResearchPlanEN = clsgs_ResearchPlanEN;
    clsgs_ResearchPlanEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_ResearchPlanEN.CacheModeId = "02"; //客户端缓存
    clsgs_ResearchPlanEN._CurrTabName = "gs_ResearchPlan"; //当前表名,与该类相关的表名
    clsgs_ResearchPlanEN._KeyFldName = "PlanId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_ResearchPlanEN.mintAttributeCount = 15;
    clsgs_ResearchPlanEN.AttributeName = ["planId", "topicId", "statusId", "planContent", "responsibleUser", "startDate", "endDate", "actualFinishingDate", "acceptanceUser", "isSubmit", "updUser", "updDate", "memo", "planTypeId", "id_CurrEduCls"];
});
