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
    exports.clscc_KnowledgesExamLibRelaEN = void 0;
    /**
    * 类名:clscc_KnowledgesExamLibRelaEN
    * 表名:cc_KnowledgesExamLibRela(01120140)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 03:26:20
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:知识点相关(Knowledges)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 知识点习题关系(cc_KnowledgesExamLibRela)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clscc_KnowledgesExamLibRelaEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngmId = 0; //mId
            this.mstrQuestionID = ""; //题目ID
            this.mstrCourseId = ""; //课程Id
            this.mdblPositiveCorrelation = 0; //正相关度
            this.mstrCourseKnowledgeId = ""; //知识点Id
            this.mdblNegativeCorrelation = 0; //负相关度
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.mId = 0; //mId
            this.questionID = ""; //题目ID
            this.courseId = ""; //课程Id
            this.positiveCorrelation = 0; //正相关度
            this.courseKnowledgeId = ""; //知识点Id
            this.negativeCorrelation = 0; //负相关度
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.memo = ""; //备注
        }
        /**
         * mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetmId(value) {
            if (value != undefined) {
                this.mId = value;
                this.hmProperty["mId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目ID(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionID(value) {
            if (value != undefined) {
                this.questionID = value;
                this.hmProperty["questionID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseId(value) {
            if (value != undefined) {
                this.courseId = value;
                this.hmProperty["courseId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 正相关度(说明:;字段类型:decimal;字段长度:6;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPositiveCorrelation(value) {
            if (value != undefined) {
                this.positiveCorrelation = value;
                this.hmProperty["positiveCorrelation"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseKnowledgeId(value) {
            if (value != undefined) {
                this.courseKnowledgeId = value;
                this.hmProperty["courseKnowledgeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 负相关度(说明:;字段类型:decimal;字段长度:6;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetNegativeCorrelation(value) {
            if (value != undefined) {
                this.negativeCorrelation = value;
                this.hmProperty["negativeCorrelation"] = true;
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
         * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUserId(value) {
            if (value != undefined) {
                this.updUserId = value;
                this.hmProperty["updUserId"] = true;
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
                case clscc_KnowledgesExamLibRelaEN.con_mId:
                    return this.mId;
                case clscc_KnowledgesExamLibRelaEN.con_QuestionID:
                    return this.questionID;
                case clscc_KnowledgesExamLibRelaEN.con_CourseId:
                    return this.courseId;
                case clscc_KnowledgesExamLibRelaEN.con_PositiveCorrelation:
                    return this.positiveCorrelation;
                case clscc_KnowledgesExamLibRelaEN.con_CourseKnowledgeId:
                    return this.courseKnowledgeId;
                case clscc_KnowledgesExamLibRelaEN.con_NegativeCorrelation:
                    return this.negativeCorrelation;
                case clscc_KnowledgesExamLibRelaEN.con_UpdDate:
                    return this.updDate;
                case clscc_KnowledgesExamLibRelaEN.con_UpdUserId:
                    return this.updUserId;
                case clscc_KnowledgesExamLibRelaEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_KnowledgesExamLibRela]中不存在！`;
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
                case clscc_KnowledgesExamLibRelaEN.con_mId:
                    this.mId = Number(strValue);
                    this.hmProperty["mId"] = true;
                    break;
                case clscc_KnowledgesExamLibRelaEN.con_QuestionID:
                    this.questionID = strValue;
                    this.hmProperty["questionID"] = true;
                    break;
                case clscc_KnowledgesExamLibRelaEN.con_CourseId:
                    this.courseId = strValue;
                    this.hmProperty["courseId"] = true;
                    break;
                case clscc_KnowledgesExamLibRelaEN.con_PositiveCorrelation:
                    this.positiveCorrelation = Number(strValue);
                    this.hmProperty["positiveCorrelation"] = true;
                    break;
                case clscc_KnowledgesExamLibRelaEN.con_CourseKnowledgeId:
                    this.courseKnowledgeId = strValue;
                    this.hmProperty["courseKnowledgeId"] = true;
                    break;
                case clscc_KnowledgesExamLibRelaEN.con_NegativeCorrelation:
                    this.negativeCorrelation = Number(strValue);
                    this.hmProperty["negativeCorrelation"] = true;
                    break;
                case clscc_KnowledgesExamLibRelaEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clscc_KnowledgesExamLibRelaEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clscc_KnowledgesExamLibRelaEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_KnowledgesExamLibRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"mId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_mId() { return "mId"; } //mId
        /**
        * 常量:"QuestionID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionID() { return "questionID"; } //题目ID
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"PositiveCorrelation"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PositiveCorrelation() { return "positiveCorrelation"; } //正相关度
        /**
        * 常量:"CourseKnowledgeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseKnowledgeId() { return "courseKnowledgeId"; } //知识点Id
        /**
        * 常量:"NegativeCorrelation"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_NegativeCorrelation() { return "negativeCorrelation"; } //负相关度
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"UpdUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserId() { return "updUserId"; } //修改用户Id
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
    exports.clscc_KnowledgesExamLibRelaEN = clscc_KnowledgesExamLibRelaEN;
    clscc_KnowledgesExamLibRelaEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clscc_KnowledgesExamLibRelaEN.CacheModeId = "02"; //客户端缓存
    clscc_KnowledgesExamLibRelaEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clscc_KnowledgesExamLibRelaEN.WhereFormat = ""; //条件格式串
    clscc_KnowledgesExamLibRelaEN._CurrTabName = "cc_KnowledgesExamLibRela"; //当前表名,与该类相关的表名
    clscc_KnowledgesExamLibRelaEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clscc_KnowledgesExamLibRelaEN.mintAttributeCount = 9;
    clscc_KnowledgesExamLibRelaEN.AttributeName = ["mId", "questionID", "courseId", "positiveCorrelation", "courseKnowledgeId", "negativeCorrelation", "updDate", "updUserId", "memo"];
});
