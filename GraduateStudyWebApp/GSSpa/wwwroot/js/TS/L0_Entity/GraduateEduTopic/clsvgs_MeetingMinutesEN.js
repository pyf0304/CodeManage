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
    exports.clsvgs_MeetingMinutesEN = void 0;
    /**
    * 类名:clsvgs_MeetingMinutesEN
    * 表名:vgs_MeetingMinutes(01120768)
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
    * 会议纪要视图(vgs_MeetingMinutes)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_MeetingMinutesEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.meetingId = ""; //会议Id
            this.topicId = ""; //主题Id
            this.isSubmit = false; //是否提交
            this.topicName = ""; //栏目主题
            this.meetingContent = ""; //会议内容
            this.meetingDate = ""; //会议日期
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.year = ""; //年
            this.month = ""; //月
            this.memo = ""; //备注
            this.versionCount = 0; //版本统计
            this.participants = ""; //参会者
            this.id_CurrEduCls = ""; //教学班流水号
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
                case clsvgs_MeetingMinutesEN.con_MeetingId:
                    return this.meetingId;
                case clsvgs_MeetingMinutesEN.con_TopicId:
                    return this.topicId;
                case clsvgs_MeetingMinutesEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvgs_MeetingMinutesEN.con_TopicName:
                    return this.topicName;
                case clsvgs_MeetingMinutesEN.con_MeetingContent:
                    return this.meetingContent;
                case clsvgs_MeetingMinutesEN.con_MeetingDate:
                    return this.meetingDate;
                case clsvgs_MeetingMinutesEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_MeetingMinutesEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_MeetingMinutesEN.con_Year:
                    return this.year;
                case clsvgs_MeetingMinutesEN.con_Month:
                    return this.month;
                case clsvgs_MeetingMinutesEN.con_Memo:
                    return this.memo;
                case clsvgs_MeetingMinutesEN.con_VersionCount:
                    return this.versionCount;
                case clsvgs_MeetingMinutesEN.con_Participants:
                    return this.participants;
                case clsvgs_MeetingMinutesEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_MeetingMinutes]中不存在！`;
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
                case clsvgs_MeetingMinutesEN.con_MeetingId:
                    this.meetingId = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_TopicId:
                    this.topicId = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvgs_MeetingMinutesEN.con_TopicName:
                    this.topicName = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_MeetingContent:
                    this.meetingContent = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_MeetingDate:
                    this.meetingDate = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_Year:
                    this.year = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_Month:
                    this.month = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvgs_MeetingMinutesEN.con_Participants:
                    this.participants = strValue;
                    break;
                case clsvgs_MeetingMinutesEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_MeetingMinutes]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"MeetingId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MeetingId() { return "meetingId"; } //会议Id
        /**
        * 常量:"TopicId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicId() { return "topicId"; } //主题Id
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"TopicName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicName() { return "topicName"; } //栏目主题
        /**
        * 常量:"MeetingContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MeetingContent() { return "meetingContent"; } //会议内容
        /**
        * 常量:"MeetingDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MeetingDate() { return "meetingDate"; } //会议日期
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
        * 常量:"Year"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Year() { return "year"; } //年
        /**
        * 常量:"Month"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Month() { return "month"; } //月
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"VersionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /**
        * 常量:"Participants"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Participants() { return "participants"; } //参会者
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
    exports.clsvgs_MeetingMinutesEN = clsvgs_MeetingMinutesEN;
    clsvgs_MeetingMinutesEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_MeetingMinutesEN.CacheModeId = "02"; //客户端缓存
    clsvgs_MeetingMinutesEN._CurrTabName = "vgs_MeetingMinutes"; //当前表名,与该类相关的表名
    clsvgs_MeetingMinutesEN._KeyFldName = "MeetingId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_MeetingMinutesEN.mintAttributeCount = 14;
    clsvgs_MeetingMinutesEN.AttributeName = ["meetingId", "topicId", "isSubmit", "topicName", "meetingContent", "meetingDate", "updDate", "updUser", "year", "month", "memo", "versionCount", "participants", "id_CurrEduCls"];
});
