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
    exports.clsvgs_TotalDataStatisticsEN = void 0;
    /**
    * 类名:clsvgs_TotalDataStatisticsEN
    * 表名:vgs_TotalDataStatistics(01120682)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:48:03
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
    * 总数据统计视图(vgs_TotalDataStatistics)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_TotalDataStatisticsEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.totalDataId = ""; //TotalDataId
            this.id_CurrEduCls = ""; //教学班流水号
            this.eduClsName = ""; //教学班名
            this.schoolYear = ""; //学年
            this.totalDataTypeId = ""; //总数据类型Id
            this.schoolTerm = ""; //学期
            this.tableKey = ""; //表主键
            this.dataUser = ""; //数据用户
            this.dataAddDate = ""; //数据添加日期
            this.dataTable = ""; //数据表
            this.month = 0; //月
            this.dataTableId = ""; //数据表Id
            this.week = 0; //周
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.score = 0.0; //评分
            this.teaScore = 0.0; //教师评分
            this.weekTimeRange = ""; //WeekTimeRange
            this.onlyId = ""; //OnlyId
            this.totalDataTypeName = ""; //总数据类型名称
            this.stuScore = 0.0; //学生平均分
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
                case clsvgs_TotalDataStatisticsEN.con_TotalDataId:
                    return this.totalDataId;
                case clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvgs_TotalDataStatisticsEN.con_EduClsName:
                    return this.eduClsName;
                case clsvgs_TotalDataStatisticsEN.con_SchoolYear:
                    return this.schoolYear;
                case clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId:
                    return this.totalDataTypeId;
                case clsvgs_TotalDataStatisticsEN.con_SchoolTerm:
                    return this.schoolTerm;
                case clsvgs_TotalDataStatisticsEN.con_TableKey:
                    return this.tableKey;
                case clsvgs_TotalDataStatisticsEN.con_DataUser:
                    return this.dataUser;
                case clsvgs_TotalDataStatisticsEN.con_DataAddDate:
                    return this.dataAddDate;
                case clsvgs_TotalDataStatisticsEN.con_DataTable:
                    return this.dataTable;
                case clsvgs_TotalDataStatisticsEN.con_Month:
                    return this.month;
                case clsvgs_TotalDataStatisticsEN.con_DataTableId:
                    return this.dataTableId;
                case clsvgs_TotalDataStatisticsEN.con_Week:
                    return this.week;
                case clsvgs_TotalDataStatisticsEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_TotalDataStatisticsEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_TotalDataStatisticsEN.con_Memo:
                    return this.memo;
                case clsvgs_TotalDataStatisticsEN.con_Score:
                    return this.score;
                case clsvgs_TotalDataStatisticsEN.con_TeaScore:
                    return this.teaScore;
                case clsvgs_TotalDataStatisticsEN.con_WeekTimeRange:
                    return this.weekTimeRange;
                case clsvgs_TotalDataStatisticsEN.con_OnlyId:
                    return this.onlyId;
                case clsvgs_TotalDataStatisticsEN.con_TotalDataTypeName:
                    return this.totalDataTypeName;
                case clsvgs_TotalDataStatisticsEN.con_StuScore:
                    return this.stuScore;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_TotalDataStatistics]中不存在！`;
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
                case clsvgs_TotalDataStatisticsEN.con_TotalDataId:
                    this.totalDataId = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_EduClsName:
                    this.eduClsName = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_SchoolYear:
                    this.schoolYear = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId:
                    this.totalDataTypeId = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_SchoolTerm:
                    this.schoolTerm = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_TableKey:
                    this.tableKey = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_DataUser:
                    this.dataUser = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_DataAddDate:
                    this.dataAddDate = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_DataTable:
                    this.dataTable = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_Month:
                    this.month = Number(strValue);
                    break;
                case clsvgs_TotalDataStatisticsEN.con_DataTableId:
                    this.dataTableId = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_Week:
                    this.week = Number(strValue);
                    break;
                case clsvgs_TotalDataStatisticsEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_Score:
                    this.score = Number(strValue);
                    break;
                case clsvgs_TotalDataStatisticsEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvgs_TotalDataStatisticsEN.con_WeekTimeRange:
                    this.weekTimeRange = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_OnlyId:
                    this.onlyId = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_TotalDataTypeName:
                    this.totalDataTypeName = strValue;
                    break;
                case clsvgs_TotalDataStatisticsEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_TotalDataStatistics]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"TotalDataId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TotalDataId() { return "totalDataId"; } //TotalDataId
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
        * 常量:"SchoolYear"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolYear() { return "schoolYear"; } //学年
        /**
        * 常量:"TotalDataTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TotalDataTypeId() { return "totalDataTypeId"; } //总数据类型Id
        /**
        * 常量:"SchoolTerm"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolTerm() { return "schoolTerm"; } //学期
        /**
        * 常量:"TableKey"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TableKey() { return "tableKey"; } //表主键
        /**
        * 常量:"DataUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DataUser() { return "dataUser"; } //数据用户
        /**
        * 常量:"DataAddDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DataAddDate() { return "dataAddDate"; } //数据添加日期
        /**
        * 常量:"DataTable"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DataTable() { return "dataTable"; } //数据表
        /**
        * 常量:"Month"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Month() { return "month"; } //月
        /**
        * 常量:"DataTableId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DataTableId() { return "dataTableId"; } //数据表Id
        /**
        * 常量:"Week"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Week() { return "week"; } //周
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
        * 常量:"Score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Score() { return "score"; } //评分
        /**
        * 常量:"TeaScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeaScore() { return "teaScore"; } //教师评分
        /**
        * 常量:"WeekTimeRange"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WeekTimeRange() { return "weekTimeRange"; } //WeekTimeRange
        /**
        * 常量:"OnlyId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OnlyId() { return "onlyId"; } //OnlyId
        /**
        * 常量:"TotalDataTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TotalDataTypeName() { return "totalDataTypeName"; } //总数据类型名称
        /**
        * 常量:"StuScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuScore() { return "stuScore"; } //学生平均分
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
    exports.clsvgs_TotalDataStatisticsEN = clsvgs_TotalDataStatisticsEN;
    clsvgs_TotalDataStatisticsEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_TotalDataStatisticsEN.CacheModeId = "02"; //客户端缓存
    clsvgs_TotalDataStatisticsEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvgs_TotalDataStatisticsEN.WhereFormat = ""; //条件格式串
    clsvgs_TotalDataStatisticsEN._CurrTabName = "vgs_TotalDataStatistics"; //当前表名,与该类相关的表名
    clsvgs_TotalDataStatisticsEN._KeyFldName = "TotalDataId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_TotalDataStatisticsEN.mintAttributeCount = 22;
    clsvgs_TotalDataStatisticsEN.AttributeName = ["totalDataId", "id_CurrEduCls", "eduClsName", "schoolYear", "totalDataTypeId", "schoolTerm", "tableKey", "dataUser", "dataAddDate", "dataTable", "month", "dataTableId", "week", "updDate", "updUser", "memo", "score", "teaScore", "weekTimeRange", "onlyId", "totalDataTypeName", "stuScore"];
});
