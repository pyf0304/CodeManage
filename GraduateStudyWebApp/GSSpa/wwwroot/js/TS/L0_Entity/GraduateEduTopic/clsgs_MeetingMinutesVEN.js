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
    exports.clsgs_MeetingMinutesVEN = void 0;
    /**
    * 类名:clsgs_MeetingMinutesVEN
    * 表名:gs_MeetingMinutesV(01120769)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:47:04
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
    * 会议纪要历史版(gs_MeetingMinutesV)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_MeetingMinutesVEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngMeetingVId = 0; //MeetingVId
            this.mstrMeetingId = ""; //会议Id
            this.mstrTopicId = ""; //主题Id
            this.mbolIsSubmit = false; //是否提交
            this.mstrMeetingContent = ""; //会议内容
            this.mstrMeetingDate = ""; //会议日期
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrYear = ""; //年
            this.mstrMonth = ""; //月
            this.mstrMemo = ""; //备注
            this.mstrParticipants = ""; //参会者
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.meetingVId = 0; //MeetingVId
            this.meetingId = ""; //会议Id
            this.topicId = ""; //主题Id
            this.isSubmit = false; //是否提交
            this.meetingContent = ""; //会议内容
            this.meetingDate = ""; //会议日期
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.year = ""; //年
            this.month = ""; //月
            this.memo = ""; //备注
            this.participants = ""; //参会者
        }
        /**
         * MeetingVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMeetingVId(value) {
            if (value != undefined) {
                this.meetingVId = value;
                this.hmProperty["meetingVId"] = true;
            }
        }
        /**
         * 会议Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMeetingId(value) {
            if (value != undefined) {
                this.meetingId = value;
                this.hmProperty["meetingId"] = true;
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
         * 会议内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMeetingContent(value) {
            if (value != undefined) {
                this.meetingContent = value;
                this.hmProperty["meetingContent"] = true;
            }
        }
        /**
         * 会议日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMeetingDate(value) {
            if (value != undefined) {
                this.meetingDate = value;
                this.hmProperty["meetingDate"] = true;
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
         * 年(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetYear(value) {
            if (value != undefined) {
                this.year = value;
                this.hmProperty["year"] = true;
            }
        }
        /**
         * 月(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMonth(value) {
            if (value != undefined) {
                this.month = value;
                this.hmProperty["month"] = true;
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
         * 参会者(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParticipants(value) {
            if (value != undefined) {
                this.participants = value;
                this.hmProperty["participants"] = true;
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
                case clsgs_MeetingMinutesVEN.con_MeetingVId:
                    return this.meetingVId;
                case clsgs_MeetingMinutesVEN.con_MeetingId:
                    return this.meetingId;
                case clsgs_MeetingMinutesVEN.con_TopicId:
                    return this.topicId;
                case clsgs_MeetingMinutesVEN.con_IsSubmit:
                    return this.isSubmit;
                case clsgs_MeetingMinutesVEN.con_MeetingContent:
                    return this.meetingContent;
                case clsgs_MeetingMinutesVEN.con_MeetingDate:
                    return this.meetingDate;
                case clsgs_MeetingMinutesVEN.con_UpdDate:
                    return this.updDate;
                case clsgs_MeetingMinutesVEN.con_UpdUser:
                    return this.updUser;
                case clsgs_MeetingMinutesVEN.con_Year:
                    return this.year;
                case clsgs_MeetingMinutesVEN.con_Month:
                    return this.month;
                case clsgs_MeetingMinutesVEN.con_Memo:
                    return this.memo;
                case clsgs_MeetingMinutesVEN.con_Participants:
                    return this.participants;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_MeetingMinutesV]中不存在！`;
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
                case clsgs_MeetingMinutesVEN.con_MeetingVId:
                    this.meetingVId = Number(strValue);
                    this.hmProperty["meetingVId"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_MeetingId:
                    this.meetingId = strValue;
                    this.hmProperty["meetingId"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_MeetingContent:
                    this.meetingContent = strValue;
                    this.hmProperty["meetingContent"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_MeetingDate:
                    this.meetingDate = strValue;
                    this.hmProperty["meetingDate"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_Year:
                    this.year = strValue;
                    this.hmProperty["year"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_Month:
                    this.month = strValue;
                    this.hmProperty["month"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_MeetingMinutesVEN.con_Participants:
                    this.participants = strValue;
                    this.hmProperty["participants"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_MeetingMinutesV]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"MeetingVId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MeetingVId() { return "meetingVId"; } //MeetingVId
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
        * 常量:"Participants"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Participants() { return "participants"; } //参会者
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
    exports.clsgs_MeetingMinutesVEN = clsgs_MeetingMinutesVEN;
    clsgs_MeetingMinutesVEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_MeetingMinutesVEN.CacheModeId = ""; //
    clsgs_MeetingMinutesVEN._CurrTabName = "gs_MeetingMinutesV"; //当前表名,与该类相关的表名
    clsgs_MeetingMinutesVEN._KeyFldName = "MeetingVId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_MeetingMinutesVEN.mintAttributeCount = 12;
    clsgs_MeetingMinutesVEN.AttributeName = ["meetingVId", "meetingId", "topicId", "isSubmit", "meetingContent", "meetingDate", "updDate", "updUser", "year", "month", "memo", "participants"];
});
