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
    exports.clsvgs_TobeStudiedProblemEN = void 0;
    /**
    * 类名:clsvgs_TobeStudiedProblemEN
    * 表名:vgs_TobeStudiedProblem(01120774)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 15:58:34
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
    * 待研究问题视图(vgs_TobeStudiedProblem)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_TobeStudiedProblemEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.problemId = ""; //问题Id
            this.problemTitle = ""; //问题标题
            this.problemContent = ""; //问题内容
            this.topicId = ""; //主题Id
            this.topicName = ""; //栏目主题
            this.id_CurrEduCls = ""; //教学班流水号
            this.isSubmit = false; //是否提交
            this.problemDate = ""; //问题日期
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.year = ""; //年
            this.month = ""; //月
            this.versionCount = 0; //版本统计
            this.participant = ""; //参与者
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
                case clsvgs_TobeStudiedProblemEN.con_ProblemId:
                    return this.problemId;
                case clsvgs_TobeStudiedProblemEN.con_ProblemTitle:
                    return this.problemTitle;
                case clsvgs_TobeStudiedProblemEN.con_ProblemContent:
                    return this.problemContent;
                case clsvgs_TobeStudiedProblemEN.con_TopicId:
                    return this.topicId;
                case clsvgs_TobeStudiedProblemEN.con_TopicName:
                    return this.topicName;
                case clsvgs_TobeStudiedProblemEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvgs_TobeStudiedProblemEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvgs_TobeStudiedProblemEN.con_ProblemDate:
                    return this.problemDate;
                case clsvgs_TobeStudiedProblemEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_TobeStudiedProblemEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_TobeStudiedProblemEN.con_Year:
                    return this.year;
                case clsvgs_TobeStudiedProblemEN.con_Month:
                    return this.month;
                case clsvgs_TobeStudiedProblemEN.con_VersionCount:
                    return this.versionCount;
                case clsvgs_TobeStudiedProblemEN.con_Participant:
                    return this.participant;
                case clsvgs_TobeStudiedProblemEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_TobeStudiedProblem]中不存在！`;
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
                case clsvgs_TobeStudiedProblemEN.con_ProblemId:
                    this.problemId = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_ProblemTitle:
                    this.problemTitle = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_ProblemContent:
                    this.problemContent = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_TopicId:
                    this.topicId = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_TopicName:
                    this.topicName = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvgs_TobeStudiedProblemEN.con_ProblemDate:
                    this.problemDate = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_Year:
                    this.year = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_Month:
                    this.month = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvgs_TobeStudiedProblemEN.con_Participant:
                    this.participant = strValue;
                    break;
                case clsvgs_TobeStudiedProblemEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_TobeStudiedProblem]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
    exports.clsvgs_TobeStudiedProblemEN = clsvgs_TobeStudiedProblemEN;
    clsvgs_TobeStudiedProblemEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_TobeStudiedProblemEN.CacheModeId = "02"; //客户端缓存
    clsvgs_TobeStudiedProblemEN._CurrTabName = "vgs_TobeStudiedProblem"; //当前表名,与该类相关的表名
    clsvgs_TobeStudiedProblemEN._KeyFldName = "ProblemId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_TobeStudiedProblemEN.mintAttributeCount = 15;
    clsvgs_TobeStudiedProblemEN.AttributeName = ["problemId", "problemTitle", "problemContent", "topicId", "topicName", "id_CurrEduCls", "isSubmit", "problemDate", "updDate", "updUser", "year", "month", "versionCount", "participant", "memo"];
});
