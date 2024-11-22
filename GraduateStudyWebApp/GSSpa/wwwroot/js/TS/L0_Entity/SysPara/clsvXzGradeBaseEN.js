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
    exports.clsvXzGradeBaseEN = void 0;
    /**
    * 类名:clsvXzGradeBaseEN
    * 表名:vXzGradeBase(01120130)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:19
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:系统参数(SysPara)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v年级(vXzGradeBase)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvXzGradeBaseEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.id_GradeBase = ""; //年级流水号
            this.gradeBaseID = ""; //年级代号
            this.gradeBaseName = ""; //年级名称
            this.gradeBaseNameA = ""; //年级名称缩写
            this.schoolYear = ""; //学年
            this.schoolTerm = ""; //学期
            this.enterSchoolDate = ""; //进校日期
            this.currentTermSeq = 0; //当前学期
            this.execPlanTermIndex = 0; //生成执行计划学期
            this.setEPTermIndexDate = ""; //设定执行计划学期日期
            this.isOffed = false; //是否毕业
            this.gradeIndex = 0; //年级序号
            this.beginYearMonth = ""; //开始年月
            this.endYearMonth = ""; //结束年月
            this.allowUpBaseInfo = false; //允许修改基本信息
            this.prefix = ""; //前缀
            this.pointCalcVersionId = ""; //绩点计算版本Id
            this.modifyUserID = ""; //修改人
            this.modifyDate = ""; //修改日期
            this.id_StudyLevel = ""; //id_StudyLevel
            this.studyLevelName = ""; //学段名称
            this.isVisible = false; //是否显示
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
                case clsvXzGradeBaseEN.con_id_GradeBase:
                    return this.id_GradeBase;
                case clsvXzGradeBaseEN.con_GradeBaseID:
                    return this.gradeBaseID;
                case clsvXzGradeBaseEN.con_GradeBaseName:
                    return this.gradeBaseName;
                case clsvXzGradeBaseEN.con_GradeBaseNameA:
                    return this.gradeBaseNameA;
                case clsvXzGradeBaseEN.con_SchoolYear:
                    return this.schoolYear;
                case clsvXzGradeBaseEN.con_SchoolTerm:
                    return this.schoolTerm;
                case clsvXzGradeBaseEN.con_EnterSchoolDate:
                    return this.enterSchoolDate;
                case clsvXzGradeBaseEN.con_CurrentTermSeq:
                    return this.currentTermSeq;
                case clsvXzGradeBaseEN.con_ExecPlanTermIndex:
                    return this.execPlanTermIndex;
                case clsvXzGradeBaseEN.con_SetEPTermIndexDate:
                    return this.setEPTermIndexDate;
                case clsvXzGradeBaseEN.con_IsOffed:
                    return this.isOffed;
                case clsvXzGradeBaseEN.con_GradeIndex:
                    return this.gradeIndex;
                case clsvXzGradeBaseEN.con_BeginYearMonth:
                    return this.beginYearMonth;
                case clsvXzGradeBaseEN.con_EndYearMonth:
                    return this.endYearMonth;
                case clsvXzGradeBaseEN.con_AllowUpBaseInfo:
                    return this.allowUpBaseInfo;
                case clsvXzGradeBaseEN.con_Prefix:
                    return this.prefix;
                case clsvXzGradeBaseEN.con_PointCalcVersionId:
                    return this.pointCalcVersionId;
                case clsvXzGradeBaseEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsvXzGradeBaseEN.con_ModifyDate:
                    return this.modifyDate;
                case clsvXzGradeBaseEN.con_id_StudyLevel:
                    return this.id_StudyLevel;
                case clsvXzGradeBaseEN.con_StudyLevelName:
                    return this.studyLevelName;
                case clsvXzGradeBaseEN.con_IsVisible:
                    return this.isVisible;
                case clsvXzGradeBaseEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vXzGradeBase]中不存在！`;
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
                case clsvXzGradeBaseEN.con_id_GradeBase:
                    this.id_GradeBase = strValue;
                    break;
                case clsvXzGradeBaseEN.con_GradeBaseID:
                    this.gradeBaseID = strValue;
                    break;
                case clsvXzGradeBaseEN.con_GradeBaseName:
                    this.gradeBaseName = strValue;
                    break;
                case clsvXzGradeBaseEN.con_GradeBaseNameA:
                    this.gradeBaseNameA = strValue;
                    break;
                case clsvXzGradeBaseEN.con_SchoolYear:
                    this.schoolYear = strValue;
                    break;
                case clsvXzGradeBaseEN.con_SchoolTerm:
                    this.schoolTerm = strValue;
                    break;
                case clsvXzGradeBaseEN.con_EnterSchoolDate:
                    this.enterSchoolDate = strValue;
                    break;
                case clsvXzGradeBaseEN.con_CurrentTermSeq:
                    this.currentTermSeq = Number(strValue);
                    break;
                case clsvXzGradeBaseEN.con_ExecPlanTermIndex:
                    this.execPlanTermIndex = Number(strValue);
                    break;
                case clsvXzGradeBaseEN.con_SetEPTermIndexDate:
                    this.setEPTermIndexDate = strValue;
                    break;
                case clsvXzGradeBaseEN.con_IsOffed:
                    this.isOffed = Boolean(strValue);
                    break;
                case clsvXzGradeBaseEN.con_GradeIndex:
                    this.gradeIndex = Number(strValue);
                    break;
                case clsvXzGradeBaseEN.con_BeginYearMonth:
                    this.beginYearMonth = strValue;
                    break;
                case clsvXzGradeBaseEN.con_EndYearMonth:
                    this.endYearMonth = strValue;
                    break;
                case clsvXzGradeBaseEN.con_AllowUpBaseInfo:
                    this.allowUpBaseInfo = Boolean(strValue);
                    break;
                case clsvXzGradeBaseEN.con_Prefix:
                    this.prefix = strValue;
                    break;
                case clsvXzGradeBaseEN.con_PointCalcVersionId:
                    this.pointCalcVersionId = strValue;
                    break;
                case clsvXzGradeBaseEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    break;
                case clsvXzGradeBaseEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    break;
                case clsvXzGradeBaseEN.con_id_StudyLevel:
                    this.id_StudyLevel = strValue;
                    break;
                case clsvXzGradeBaseEN.con_StudyLevelName:
                    this.studyLevelName = strValue;
                    break;
                case clsvXzGradeBaseEN.con_IsVisible:
                    this.isVisible = Boolean(strValue);
                    break;
                case clsvXzGradeBaseEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vXzGradeBase]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_GradeBase"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_GradeBase() { return "id_GradeBase"; } //年级流水号
        /**
        * 常量:"GradeBaseID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GradeBaseID() { return "gradeBaseID"; } //年级代号
        /**
        * 常量:"GradeBaseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GradeBaseName() { return "gradeBaseName"; } //年级名称
        /**
        * 常量:"GradeBaseNameA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GradeBaseNameA() { return "gradeBaseNameA"; } //年级名称缩写
        /**
        * 常量:"SchoolYear"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolYear() { return "schoolYear"; } //学年
        /**
        * 常量:"SchoolTerm"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolTerm() { return "schoolTerm"; } //学期
        /**
        * 常量:"EnterSchoolDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EnterSchoolDate() { return "enterSchoolDate"; } //进校日期
        /**
        * 常量:"CurrentTermSeq"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CurrentTermSeq() { return "currentTermSeq"; } //当前学期
        /**
        * 常量:"ExecPlanTermIndex"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExecPlanTermIndex() { return "execPlanTermIndex"; } //生成执行计划学期
        /**
        * 常量:"SetEPTermIndexDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SetEPTermIndexDate() { return "setEPTermIndexDate"; } //设定执行计划学期日期
        /**
        * 常量:"IsOffed"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsOffed() { return "isOffed"; } //是否毕业
        /**
        * 常量:"GradeIndex"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GradeIndex() { return "gradeIndex"; } //年级序号
        /**
        * 常量:"BeginYearMonth"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BeginYearMonth() { return "beginYearMonth"; } //开始年月
        /**
        * 常量:"EndYearMonth"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EndYearMonth() { return "endYearMonth"; } //结束年月
        /**
        * 常量:"AllowUpBaseInfo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AllowUpBaseInfo() { return "allowUpBaseInfo"; } //允许修改基本信息
        /**
        * 常量:"Prefix"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Prefix() { return "prefix"; } //前缀
        /**
        * 常量:"PointCalcVersionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PointCalcVersionId() { return "pointCalcVersionId"; } //绩点计算版本Id
        /**
        * 常量:"ModifyUserID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyUserID() { return "modifyUserID"; } //修改人
        /**
        * 常量:"ModifyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyDate() { return "modifyDate"; } //修改日期
        /**
        * 常量:"id_StudyLevel"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_StudyLevel() { return "id_StudyLevel"; } //id_StudyLevel
        /**
        * 常量:"StudyLevelName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StudyLevelName() { return "studyLevelName"; } //学段名称
        /**
        * 常量:"IsVisible"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsVisible() { return "isVisible"; } //是否显示
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
    exports.clsvXzGradeBaseEN = clsvXzGradeBaseEN;
    clsvXzGradeBaseEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvXzGradeBaseEN.CacheModeId = "05"; //未知
    clsvXzGradeBaseEN._CurrTabName = "vXzGradeBase"; //当前表名,与该类相关的表名
    clsvXzGradeBaseEN._KeyFldName = "id_GradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvXzGradeBaseEN.mintAttributeCount = 23;
    clsvXzGradeBaseEN.AttributeName = ["id_GradeBase", "gradeBaseID", "gradeBaseName", "gradeBaseNameA", "schoolYear", "schoolTerm", "enterSchoolDate", "currentTermSeq", "execPlanTermIndex", "setEPTermIndexDate", "isOffed", "gradeIndex", "beginYearMonth", "endYearMonth", "allowUpBaseInfo", "prefix", "pointCalcVersionId", "modifyUserID", "modifyDate", "id_StudyLevel", "studyLevelName", "isVisible", "memo"];
});
