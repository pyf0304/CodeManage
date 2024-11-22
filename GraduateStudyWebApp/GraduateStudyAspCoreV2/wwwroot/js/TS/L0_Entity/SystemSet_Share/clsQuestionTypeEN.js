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
    exports.enumQuestionType = exports.clsQuestionTypeEN = void 0;
    /**
    * 类名:clsQuestionTypeEN
    * 表名:QuestionType(01120008)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 18:40:17
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:系统设置(SystemSet)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 题目类型(QuestionType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsQuestionTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrQuestionTypeId = ""; //题目类型Id
            this.mstrQuestionTypeName = ""; //题目类型名
            this.mstrQuestionTypeENName = ""; //题目类型英文名
            this.mstrDefaAnswerModeId = ""; //默认答案模式Id
            this.mstrDefaAnswerTypeId = ""; //默认答案类型Id
            this.mintOrderNum = 0; //序号
            this.mbolIsUse = false; //是否使用
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.questionTypeId = ""; //题目类型Id
            this.questionTypeName = ""; //题目类型名
            this.questionTypeENName = ""; //题目类型英文名
            this.defaAnswerModeId = ""; //默认答案模式Id
            this.defaAnswerTypeId = ""; //默认答案类型Id
            this.orderNum = 0; //序号
            this.isUse = false; //是否使用
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
        }
        /**
         * 题目类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionTypeId(value) {
            if (value != undefined) {
                this.questionTypeId = value;
                this.hmProperty["questionTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionTypeName(value) {
            if (value != undefined) {
                this.questionTypeName = value;
                this.hmProperty["questionTypeName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionTypeENName(value) {
            if (value != undefined) {
                this.questionTypeENName = value;
                this.hmProperty["questionTypeENName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 默认答案模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDefaAnswerModeId(value) {
            if (value != undefined) {
                this.defaAnswerModeId = value;
                this.hmProperty["defaAnswerModeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 默认答案类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDefaAnswerTypeId(value) {
            if (value != undefined) {
                this.defaAnswerTypeId = value;
                this.hmProperty["defaAnswerTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOrderNum(value) {
            if (value != undefined) {
                this.orderNum = value;
                this.hmProperty["orderNum"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsUse(value) {
            if (value != undefined) {
                this.isUse = value;
                this.hmProperty["isUse"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsQuestionTypeEN.con_QuestionTypeId:
                    return this.questionTypeId;
                case clsQuestionTypeEN.con_QuestionTypeName:
                    return this.questionTypeName;
                case clsQuestionTypeEN.con_QuestionTypeENName:
                    return this.questionTypeENName;
                case clsQuestionTypeEN.con_DefaAnswerModeId:
                    return this.defaAnswerModeId;
                case clsQuestionTypeEN.con_DefaAnswerTypeId:
                    return this.defaAnswerTypeId;
                case clsQuestionTypeEN.con_OrderNum:
                    return this.orderNum;
                case clsQuestionTypeEN.con_IsUse:
                    return this.isUse;
                case clsQuestionTypeEN.con_UpdDate:
                    return this.updDate;
                case clsQuestionTypeEN.con_UpdUser:
                    return this.updUser;
                case clsQuestionTypeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[QuestionType]中不存在！`;
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
                case clsQuestionTypeEN.con_QuestionTypeId:
                    this.questionTypeId = strValue;
                    this.hmProperty["questionTypeId"] = true;
                    break;
                case clsQuestionTypeEN.con_QuestionTypeName:
                    this.questionTypeName = strValue;
                    this.hmProperty["questionTypeName"] = true;
                    break;
                case clsQuestionTypeEN.con_QuestionTypeENName:
                    this.questionTypeENName = strValue;
                    this.hmProperty["questionTypeENName"] = true;
                    break;
                case clsQuestionTypeEN.con_DefaAnswerModeId:
                    this.defaAnswerModeId = strValue;
                    this.hmProperty["defaAnswerModeId"] = true;
                    break;
                case clsQuestionTypeEN.con_DefaAnswerTypeId:
                    this.defaAnswerTypeId = strValue;
                    this.hmProperty["defaAnswerTypeId"] = true;
                    break;
                case clsQuestionTypeEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    this.hmProperty["orderNum"] = true;
                    break;
                case clsQuestionTypeEN.con_IsUse:
                    this.isUse = Boolean(strValue);
                    this.hmProperty["isUse"] = true;
                    break;
                case clsQuestionTypeEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsQuestionTypeEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsQuestionTypeEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[QuestionType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"QuestionTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeId() { return "questionTypeId"; } //题目类型Id
        /**
        * 常量:"QuestionTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeName() { return "questionTypeName"; } //题目类型名
        /**
        * 常量:"QuestionTypeENName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeENName() { return "questionTypeENName"; } //题目类型英文名
        /**
        * 常量:"DefaAnswerModeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DefaAnswerModeId() { return "defaAnswerModeId"; } //默认答案模式Id
        /**
        * 常量:"DefaAnswerTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DefaAnswerTypeId() { return "defaAnswerTypeId"; } //默认答案类型Id
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"IsUse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsUse() { return "isUse"; } //是否使用
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
    exports.clsQuestionTypeEN = clsQuestionTypeEN;
    clsQuestionTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsQuestionTypeEN.CacheModeId = "04"; //sessionStorage
    clsQuestionTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsQuestionTypeEN.WhereFormat = ""; //条件格式串
    clsQuestionTypeEN._CurrTabName = "QuestionType"; //当前表名,与该类相关的表名
    clsQuestionTypeEN._KeyFldName = "QuestionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsQuestionTypeEN.mintAttributeCount = 10;
    clsQuestionTypeEN.AttributeName = ["questionTypeId", "questionTypeName", "questionTypeENName", "defaAnswerModeId", "defaAnswerTypeId", "orderNum", "isUse", "updDate", "updUser", "memo"];
    /**
    * 根据表内容设置enum列表
    * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GeneEnumConstList)
    **/
    class enumQuestionType {
    }
    exports.enumQuestionType = enumQuestionType;
    /**
    * 填空题
    **/
    enumQuestionType.FillInBlank_01 = "01";
    /**
    * 单选题
    **/
    enumQuestionType.SingleTopic_02 = "02";
    /**
    * 多选题
    **/
    enumQuestionType.MultipleChoice_03 = "03";
    /**
    * 开放题
    **/
    enumQuestionType.OpenQuestion_04 = "04";
    /**
    * 解答题
    **/
    enumQuestionType.AnswerQuestions_05 = "05";
    /**
    * 标题
    **/
    enumQuestionType.Title_06 = "06";
    /**
    * 说明性内容
    **/
    enumQuestionType.ExplanatoryContent_07 = "07";
    /**
    * 单选题(下拉框)
    **/
    enumQuestionType.SingleTopic_DropDownBox_08 = "08";
    /**
    * 操作题
    **/
    enumQuestionType.OperationQuestions_09 = "09";
    /**
    * 简答题
    **/
    enumQuestionType.ShortAnswer_10 = "10";
    /**
    * 判断题
    **/
    enumQuestionType.TrueorFalse_11 = "11";
    /**
    * 案例分析题
    **/
    enumQuestionType.CaseAnysisMultiChoice_12 = "12";
    /**
    * 录音分析题
    **/
    enumQuestionType.RecorderAndAnysis_13 = "13";
    /**
    * 知识结构图
    **/
    enumQuestionType.KnowledgeStructureDiagram_14 = "14";
    /**
    * 知识逻辑关系图
    **/
    enumQuestionType.KnowledgeLogicDiagram_15 = "15";
    /**
    * 连连看多选题
    **/
    enumQuestionType.LianliankanMultipleChoiceQuestions_17 = "17";
    /**
    * 概念题
    **/
    enumQuestionType.ConceptQuestion_18 = "18";
});
