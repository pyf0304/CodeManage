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
    exports.clsgs_TotalDataStatisticsEN = void 0;
    /**
    * 类名:clsgs_TotalDataStatisticsEN
    * 表名:gs_TotalDataStatistics(01120683)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:47:32
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
    * 总数据统计(gs_TotalDataStatistics)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_TotalDataStatisticsEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrTotalDataId = ""; //TotalDataId
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrTotalDataTypeId = ""; //总数据类型Id
            this.mstrTableKey = ""; //表主键
            this.mstrDataUser = ""; //数据用户
            this.mstrDataAddDate = ""; //数据添加日期
            this.mintMonth = 0; //月
            this.mintWeek = 0; //周
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            this.mfltScore = 0.0; //评分
            this.mfltTeaScore = 0.0; //教师评分
            this.mstrWeekTimeRange = ""; //WeekTimeRange
            this.mfltStuScore = 0.0; //学生平均分
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.totalDataId = ""; //TotalDataId
            this.id_CurrEduCls = ""; //教学班流水号
            this.totalDataTypeId = ""; //总数据类型Id
            this.tableKey = ""; //表主键
            this.dataUser = ""; //数据用户
            this.dataAddDate = ""; //数据添加日期
            this.month = 0; //月
            this.week = 0; //周
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.score = 0.0; //评分
            this.teaScore = 0.0; //教师评分
            this.weekTimeRange = ""; //WeekTimeRange
            this.stuScore = 0.0; //学生平均分
        }
        /**
         * TotalDataId(说明:;字段类型:char;字段长度:12;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTotalDataId(value) {
            if (value != undefined) {
                this.totalDataId = value;
                this.hmProperty["totalDataId"] = true;
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
         * 总数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTotalDataTypeId(value) {
            if (value != undefined) {
                this.totalDataTypeId = value;
                this.hmProperty["totalDataTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTableKey(value) {
            if (value != undefined) {
                this.tableKey = value;
                this.hmProperty["tableKey"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 数据用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDataUser(value) {
            if (value != undefined) {
                this.dataUser = value;
                this.hmProperty["dataUser"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 数据添加日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDataAddDate(value) {
            if (value != undefined) {
                this.dataAddDate = value;
                this.hmProperty["dataAddDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 月(说明:;字段类型:int;字段长度:4;是否可空:True)
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
         * 周(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetWeek(value) {
            if (value != undefined) {
                this.week = value;
                this.hmProperty["week"] = true;
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
         * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScore(value) {
            if (value != undefined) {
                this.score = value;
                this.hmProperty["score"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTeaScore(value) {
            if (value != undefined) {
                this.teaScore = value;
                this.hmProperty["teaScore"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * WeekTimeRange(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetWeekTimeRange(value) {
            if (value != undefined) {
                this.weekTimeRange = value;
                this.hmProperty["weekTimeRange"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuScore(value) {
            if (value != undefined) {
                this.stuScore = value;
                this.hmProperty["stuScore"] = true;
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
                case clsgs_TotalDataStatisticsEN.con_TotalDataId:
                    return this.totalDataId;
                case clsgs_TotalDataStatisticsEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsgs_TotalDataStatisticsEN.con_TotalDataTypeId:
                    return this.totalDataTypeId;
                case clsgs_TotalDataStatisticsEN.con_TableKey:
                    return this.tableKey;
                case clsgs_TotalDataStatisticsEN.con_DataUser:
                    return this.dataUser;
                case clsgs_TotalDataStatisticsEN.con_DataAddDate:
                    return this.dataAddDate;
                case clsgs_TotalDataStatisticsEN.con_Month:
                    return this.month;
                case clsgs_TotalDataStatisticsEN.con_Week:
                    return this.week;
                case clsgs_TotalDataStatisticsEN.con_UpdDate:
                    return this.updDate;
                case clsgs_TotalDataStatisticsEN.con_UpdUser:
                    return this.updUser;
                case clsgs_TotalDataStatisticsEN.con_Memo:
                    return this.memo;
                case clsgs_TotalDataStatisticsEN.con_Score:
                    return this.score;
                case clsgs_TotalDataStatisticsEN.con_TeaScore:
                    return this.teaScore;
                case clsgs_TotalDataStatisticsEN.con_WeekTimeRange:
                    return this.weekTimeRange;
                case clsgs_TotalDataStatisticsEN.con_StuScore:
                    return this.stuScore;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TotalDataStatistics]中不存在！`;
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
                case clsgs_TotalDataStatisticsEN.con_TotalDataId:
                    this.totalDataId = strValue;
                    this.hmProperty["totalDataId"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_TotalDataTypeId:
                    this.totalDataTypeId = strValue;
                    this.hmProperty["totalDataTypeId"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_TableKey:
                    this.tableKey = strValue;
                    this.hmProperty["tableKey"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_DataUser:
                    this.dataUser = strValue;
                    this.hmProperty["dataUser"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_DataAddDate:
                    this.dataAddDate = strValue;
                    this.hmProperty["dataAddDate"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_Month:
                    this.month = Number(strValue);
                    this.hmProperty["month"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_Week:
                    this.week = Number(strValue);
                    this.hmProperty["week"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_Score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    this.hmProperty["teaScore"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_WeekTimeRange:
                    this.weekTimeRange = strValue;
                    this.hmProperty["weekTimeRange"] = true;
                    break;
                case clsgs_TotalDataStatisticsEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    this.hmProperty["stuScore"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TotalDataStatistics]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"TotalDataTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TotalDataTypeId() { return "totalDataTypeId"; } //总数据类型Id
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
        * 常量:"Month"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Month() { return "month"; } //月
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
    exports.clsgs_TotalDataStatisticsEN = clsgs_TotalDataStatisticsEN;
    clsgs_TotalDataStatisticsEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_TotalDataStatisticsEN.CacheModeId = "02"; //客户端缓存
    clsgs_TotalDataStatisticsEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_TotalDataStatisticsEN.WhereFormat = ""; //条件格式串
    clsgs_TotalDataStatisticsEN._CurrTabName = "gs_TotalDataStatistics"; //当前表名,与该类相关的表名
    clsgs_TotalDataStatisticsEN._KeyFldName = "TotalDataId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_TotalDataStatisticsEN.mintAttributeCount = 15;
    clsgs_TotalDataStatisticsEN.AttributeName = ["totalDataId", "id_CurrEduCls", "totalDataTypeId", "tableKey", "dataUser", "dataAddDate", "month", "week", "updDate", "updUser", "memo", "score", "teaScore", "weekTimeRange", "stuScore"];
});
