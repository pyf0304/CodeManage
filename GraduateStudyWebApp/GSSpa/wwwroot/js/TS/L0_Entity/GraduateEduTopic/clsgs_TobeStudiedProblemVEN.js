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
    exports.clsgs_TobeStudiedProblemVEN = void 0;
    /**
    * 类名:clsgs_TobeStudiedProblemVEN
    * 表名:gs_TobeStudiedProblemV(01120775)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:47:12
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
    * 待研究问题历史版本表(gs_TobeStudiedProblemV)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_TobeStudiedProblemVEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngProblemVId = 0; //ProblemVId
            this.mstrProblemId = ""; //问题Id
            this.mstrTopicId = ""; //主题Id
            this.mbolIsSubmit = false; //是否提交
            this.mstrProblemContent = ""; //问题内容
            this.mstrProblemDate = ""; //问题日期
            this.mstrParticipant = ""; //参与者
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrYear = ""; //年
            this.mstrMonth = ""; //月
            this.mstrMemo = ""; //备注
            this.mstrProblemTitle = ""; //问题标题
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.problemVId = 0; //ProblemVId
            this.problemId = ""; //问题Id
            this.topicId = ""; //主题Id
            this.isSubmit = false; //是否提交
            this.problemContent = ""; //问题内容
            this.problemDate = ""; //问题日期
            this.participant = ""; //参与者
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.year = ""; //年
            this.month = ""; //月
            this.memo = ""; //备注
            this.problemTitle = ""; //问题标题
        }
        /**
         * ProblemVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetProblemVId(value) {
            if (value != undefined) {
                this.problemVId = value;
                this.hmProperty["problemVId"] = true;
            }
        }
        /**
         * 问题Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetProblemId(value) {
            if (value != undefined) {
                this.problemId = value;
                this.hmProperty["problemId"] = true;
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
         * 问题内容(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetProblemContent(value) {
            if (value != undefined) {
                this.problemContent = value;
                this.hmProperty["problemContent"] = true;
            }
        }
        /**
         * 问题日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetProblemDate(value) {
            if (value != undefined) {
                this.problemDate = value;
                this.hmProperty["problemDate"] = true;
            }
        }
        /**
         * 参与者(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParticipant(value) {
            if (value != undefined) {
                this.participant = value;
                this.hmProperty["participant"] = true;
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
         * 问题标题(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetProblemTitle(value) {
            if (value != undefined) {
                this.problemTitle = value;
                this.hmProperty["problemTitle"] = true;
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
                case clsgs_TobeStudiedProblemVEN.con_ProblemVId:
                    return this.problemVId;
                case clsgs_TobeStudiedProblemVEN.con_ProblemId:
                    return this.problemId;
                case clsgs_TobeStudiedProblemVEN.con_TopicId:
                    return this.topicId;
                case clsgs_TobeStudiedProblemVEN.con_IsSubmit:
                    return this.isSubmit;
                case clsgs_TobeStudiedProblemVEN.con_ProblemContent:
                    return this.problemContent;
                case clsgs_TobeStudiedProblemVEN.con_ProblemDate:
                    return this.problemDate;
                case clsgs_TobeStudiedProblemVEN.con_Participant:
                    return this.participant;
                case clsgs_TobeStudiedProblemVEN.con_UpdDate:
                    return this.updDate;
                case clsgs_TobeStudiedProblemVEN.con_UpdUser:
                    return this.updUser;
                case clsgs_TobeStudiedProblemVEN.con_Year:
                    return this.year;
                case clsgs_TobeStudiedProblemVEN.con_Month:
                    return this.month;
                case clsgs_TobeStudiedProblemVEN.con_Memo:
                    return this.memo;
                case clsgs_TobeStudiedProblemVEN.con_ProblemTitle:
                    return this.problemTitle;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TobeStudiedProblemV]中不存在！`;
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
                case clsgs_TobeStudiedProblemVEN.con_ProblemVId:
                    this.problemVId = Number(strValue);
                    this.hmProperty["problemVId"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_ProblemId:
                    this.problemId = strValue;
                    this.hmProperty["problemId"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_ProblemContent:
                    this.problemContent = strValue;
                    this.hmProperty["problemContent"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_ProblemDate:
                    this.problemDate = strValue;
                    this.hmProperty["problemDate"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_Participant:
                    this.participant = strValue;
                    this.hmProperty["participant"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_Year:
                    this.year = strValue;
                    this.hmProperty["year"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_Month:
                    this.month = strValue;
                    this.hmProperty["month"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_TobeStudiedProblemVEN.con_ProblemTitle:
                    this.problemTitle = strValue;
                    this.hmProperty["problemTitle"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TobeStudiedProblemV]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ProblemVId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProblemVId() { return "problemVId"; } //ProblemVId
        /**
        * 常量:"ProblemId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProblemId() { return "problemId"; } //问题Id
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
        * 常量:"ProblemContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProblemContent() { return "problemContent"; } //问题内容
        /**
        * 常量:"ProblemDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProblemDate() { return "problemDate"; } //问题日期
        /**
        * 常量:"Participant"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Participant() { return "participant"; } //参与者
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
        * 常量:"ProblemTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProblemTitle() { return "problemTitle"; } //问题标题
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
    exports.clsgs_TobeStudiedProblemVEN = clsgs_TobeStudiedProblemVEN;
    clsgs_TobeStudiedProblemVEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_TobeStudiedProblemVEN.CacheModeId = ""; //
    clsgs_TobeStudiedProblemVEN._CurrTabName = "gs_TobeStudiedProblemV"; //当前表名,与该类相关的表名
    clsgs_TobeStudiedProblemVEN._KeyFldName = "ProblemVId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_TobeStudiedProblemVEN.mintAttributeCount = 13;
    clsgs_TobeStudiedProblemVEN.AttributeName = ["problemVId", "problemId", "topicId", "isSubmit", "problemContent", "problemDate", "participant", "updDate", "updUser", "year", "month", "memo", "problemTitle"];
});