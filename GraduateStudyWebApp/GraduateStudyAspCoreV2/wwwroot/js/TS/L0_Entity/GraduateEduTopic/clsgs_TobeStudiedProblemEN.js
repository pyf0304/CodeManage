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
    exports.clsgs_TobeStudiedProblemEN = void 0;
    /**
    * 类名:clsgs_TobeStudiedProblemEN
    * 表名:gs_TobeStudiedProblem(01120776)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:48:25
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
    * 待研究问题(gs_TobeStudiedProblem)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_TobeStudiedProblemEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrProblemId = ""; //问题Id
            this.mstrProblemTitle = ""; //问题标题
            this.mstrProblemContent = ""; //问题内容
            this.mstrTopicId = ""; //主题Id
            this.mbolIsSubmit = false; //是否提交
            this.mstrProblemDate = ""; //问题日期
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrYear = ""; //年
            this.mstrMonth = ""; //月
            this.mintVersionCount = 0; //版本统计
            this.mstrParticipant = ""; //参与者
            this.mstrMemo = ""; //备注
            this.mstrid_CurrEduCls = ""; //教学班流水号
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.problemId = ""; //问题Id
            this.problemTitle = ""; //问题标题
            this.problemContent = ""; //问题内容
            this.topicId = ""; //主题Id
            this.isSubmit = false; //是否提交
            this.problemDate = ""; //问题日期
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.year = ""; //年
            this.month = ""; //月
            this.versionCount = 0; //版本统计
            this.participant = ""; //参与者
            this.memo = ""; //备注
            this.id_CurrEduCls = ""; //教学班流水号
        }
        /**
         * 问题Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetProblemId(value) {
            if (value != undefined) {
                this.problemId = value;
                this.hmProperty["problemId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 问题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetProblemContent(value) {
            if (value != undefined) {
                this.problemContent = value;
                this.hmProperty["problemContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
         * 年(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetYear(value) {
            if (value != undefined) {
                this.year = value;
                this.hmProperty["year"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVersionCount(value) {
            if (value != undefined) {
                this.versionCount = value;
                this.hmProperty["versionCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                case clsgs_TobeStudiedProblemEN.con_ProblemId:
                    return this.problemId;
                case clsgs_TobeStudiedProblemEN.con_ProblemTitle:
                    return this.problemTitle;
                case clsgs_TobeStudiedProblemEN.con_ProblemContent:
                    return this.problemContent;
                case clsgs_TobeStudiedProblemEN.con_TopicId:
                    return this.topicId;
                case clsgs_TobeStudiedProblemEN.con_IsSubmit:
                    return this.isSubmit;
                case clsgs_TobeStudiedProblemEN.con_ProblemDate:
                    return this.problemDate;
                case clsgs_TobeStudiedProblemEN.con_UpdDate:
                    return this.updDate;
                case clsgs_TobeStudiedProblemEN.con_UpdUser:
                    return this.updUser;
                case clsgs_TobeStudiedProblemEN.con_Year:
                    return this.year;
                case clsgs_TobeStudiedProblemEN.con_Month:
                    return this.month;
                case clsgs_TobeStudiedProblemEN.con_VersionCount:
                    return this.versionCount;
                case clsgs_TobeStudiedProblemEN.con_Participant:
                    return this.participant;
                case clsgs_TobeStudiedProblemEN.con_Memo:
                    return this.memo;
                case clsgs_TobeStudiedProblemEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TobeStudiedProblem]中不存在！`;
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
                case clsgs_TobeStudiedProblemEN.con_ProblemId:
                    this.problemId = strValue;
                    this.hmProperty["problemId"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_ProblemTitle:
                    this.problemTitle = strValue;
                    this.hmProperty["problemTitle"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_ProblemContent:
                    this.problemContent = strValue;
                    this.hmProperty["problemContent"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_ProblemDate:
                    this.problemDate = strValue;
                    this.hmProperty["problemDate"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_Year:
                    this.year = strValue;
                    this.hmProperty["year"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_Month:
                    this.month = strValue;
                    this.hmProperty["month"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    this.hmProperty["versionCount"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_Participant:
                    this.participant = strValue;
                    this.hmProperty["participant"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_TobeStudiedProblemEN.con_id_CurrEduCls:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TobeStudiedProblem]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ProblemId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProblemId() { return "problemId"; } //问题Id
        /**
        * 常量:"ProblemTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProblemTitle() { return "problemTitle"; } //问题标题
        /**
        * 常量:"ProblemContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProblemContent() { return "problemContent"; } //问题内容
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
        * 常量:"ProblemDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProblemDate() { return "problemDate"; } //问题日期
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
        * 常量:"VersionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /**
        * 常量:"Participant"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Participant() { return "participant"; } //参与者
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
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
    exports.clsgs_TobeStudiedProblemEN = clsgs_TobeStudiedProblemEN;
    clsgs_TobeStudiedProblemEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_TobeStudiedProblemEN.CacheModeId = ""; //
    clsgs_TobeStudiedProblemEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_TobeStudiedProblemEN.WhereFormat = ""; //条件格式串
    clsgs_TobeStudiedProblemEN._CurrTabName = "gs_TobeStudiedProblem"; //当前表名,与该类相关的表名
    clsgs_TobeStudiedProblemEN._KeyFldName = "ProblemId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_TobeStudiedProblemEN.mintAttributeCount = 14;
    clsgs_TobeStudiedProblemEN.AttributeName = ["problemId", "problemTitle", "problemContent", "topicId", "isSubmit", "problemDate", "updDate", "updUser", "year", "month", "versionCount", "participant", "memo", "id_CurrEduCls"];
});
