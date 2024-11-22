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
    exports.clsvSysScoreSummaryEN = void 0;
    /**
    * 类名:clsvSysScoreSummaryEN
    * 表名:vSysScoreSummary(01120627)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:46:57
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培设置(GraduateEduTools)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v分数汇总视图(vSysScoreSummary)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvSysScoreSummaryEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.mId = 0; //mId
            this.userId = ""; //用户ID
            this.schoolYear = ""; //学年
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.userName = ""; //用户名
            this.id_XzCollege = ""; //学院流水号
            this.collegeName = ""; //学院名称
            this.id_XzMajor = ""; //专业流水号
            this.majorName = ""; //专业名称
            this.id_GradeBase = ""; //年级流水号
            this.gradeBaseName = ""; //年级名称
            this.onlyId = ""; //OnlyId
            this.scoreTypeId = ""; //分数类型Id
            this.scoreTypeName = ""; //分数类型名称
            this.updUser = ""; //修改人
            this.score = 0.0; //评分
            this.id_CurrEduCls = ""; //教学班流水号
            this.eduClsName = ""; //教学班名
            this.isSubmit = false; //是否提交
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
                case clsvSysScoreSummaryEN.con_mId:
                    return this.mId;
                case clsvSysScoreSummaryEN.con_UserId:
                    return this.userId;
                case clsvSysScoreSummaryEN.con_SchoolYear:
                    return this.schoolYear;
                case clsvSysScoreSummaryEN.con_UpdDate:
                    return this.updDate;
                case clsvSysScoreSummaryEN.con_Memo:
                    return this.memo;
                case clsvSysScoreSummaryEN.con_UserName:
                    return this.userName;
                case clsvSysScoreSummaryEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvSysScoreSummaryEN.con_CollegeName:
                    return this.collegeName;
                case clsvSysScoreSummaryEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvSysScoreSummaryEN.con_MajorName:
                    return this.majorName;
                case clsvSysScoreSummaryEN.con_id_GradeBase:
                    return this.id_GradeBase;
                case clsvSysScoreSummaryEN.con_GradeBaseName:
                    return this.gradeBaseName;
                case clsvSysScoreSummaryEN.con_OnlyId:
                    return this.onlyId;
                case clsvSysScoreSummaryEN.con_ScoreTypeId:
                    return this.scoreTypeId;
                case clsvSysScoreSummaryEN.con_ScoreTypeName:
                    return this.scoreTypeName;
                case clsvSysScoreSummaryEN.con_UpdUser:
                    return this.updUser;
                case clsvSysScoreSummaryEN.con_Score:
                    return this.score;
                case clsvSysScoreSummaryEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvSysScoreSummaryEN.con_EduClsName:
                    return this.eduClsName;
                case clsvSysScoreSummaryEN.con_IsSubmit:
                    return this.isSubmit;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysScoreSummary]中不存在！`;
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
                case clsvSysScoreSummaryEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvSysScoreSummaryEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_SchoolYear:
                    this.schoolYear = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_id_GradeBase:
                    this.id_GradeBase = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_GradeBaseName:
                    this.gradeBaseName = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_OnlyId:
                    this.onlyId = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_ScoreTypeId:
                    this.scoreTypeId = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_ScoreTypeName:
                    this.scoreTypeName = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_Score:
                    this.score = Number(strValue);
                    break;
                case clsvSysScoreSummaryEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_EduClsName:
                    this.eduClsName = strValue;
                    break;
                case clsvSysScoreSummaryEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysScoreSummary]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"SchoolYear"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolYear() { return "schoolYear"; } //学年
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
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"CollegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
        /**
        * 常量:"id_GradeBase"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_GradeBase() { return "id_GradeBase"; } //年级流水号
        /**
        * 常量:"GradeBaseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GradeBaseName() { return "gradeBaseName"; } //年级名称
        /**
        * 常量:"OnlyId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OnlyId() { return "onlyId"; } //OnlyId
        /**
        * 常量:"ScoreTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScoreTypeId() { return "scoreTypeId"; } //分数类型Id
        /**
        * 常量:"ScoreTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScoreTypeName() { return "scoreTypeName"; } //分数类型名称
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"Score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Score() { return "score"; } //评分
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"EduClsName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsName() { return "eduClsName"; } //教学班名
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
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
    exports.clsvSysScoreSummaryEN = clsvSysScoreSummaryEN;
    clsvSysScoreSummaryEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvSysScoreSummaryEN.CacheModeId = "02"; //客户端缓存
    clsvSysScoreSummaryEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvSysScoreSummaryEN.WhereFormat = ""; //条件格式串
    clsvSysScoreSummaryEN._CurrTabName = "vSysScoreSummary"; //当前表名,与该类相关的表名
    clsvSysScoreSummaryEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvSysScoreSummaryEN.mintAttributeCount = 20;
    clsvSysScoreSummaryEN.AttributeName = ["mId", "userId", "schoolYear", "updDate", "memo", "userName", "id_XzCollege", "collegeName", "id_XzMajor", "majorName", "id_GradeBase", "gradeBaseName", "onlyId", "scoreTypeId", "scoreTypeName", "updUser", "score", "id_CurrEduCls", "eduClsName", "isSubmit"];
});
