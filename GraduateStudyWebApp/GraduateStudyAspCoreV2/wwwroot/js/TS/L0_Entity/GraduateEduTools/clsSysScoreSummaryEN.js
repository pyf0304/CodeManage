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
    exports.clsSysScoreSummaryEN = void 0;
    /**
    * 类名:clsSysScoreSummaryEN
    * 表名:SysScoreSummary(01120628)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:47:41
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
    * 系统分数汇总表(SysScoreSummary)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsSysScoreSummaryEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrUserId = ""; //用户ID
            this.mstrSchoolYear = ""; //学年
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            this.mstrScoreTypeId = ""; //分数类型Id
            this.mstrUpdUser = ""; //修改人
            this.mfltScore = 0.0; //评分
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mbolIsSubmit = false; //是否提交
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.mId = 0; //mId
            this.userId = ""; //用户ID
            this.schoolYear = ""; //学年
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.scoreTypeId = ""; //分数类型Id
            this.updUser = ""; //修改人
            this.score = 0.0; //评分
            this.id_CurrEduCls = ""; //教学班流水号
            this.isSubmit = false; //是否提交
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
         * 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserId(value) {
            if (value != undefined) {
                this.userId = value;
                this.hmProperty["userId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolYear(value) {
            if (value != undefined) {
                this.schoolYear = value;
                this.hmProperty["schoolYear"] = true;
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
         * 分数类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScoreTypeId(value) {
            if (value != undefined) {
                this.scoreTypeId = value;
                this.hmProperty["scoreTypeId"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsSysScoreSummaryEN.con_mId:
                    return this.mId;
                case clsSysScoreSummaryEN.con_UserId:
                    return this.userId;
                case clsSysScoreSummaryEN.con_SchoolYear:
                    return this.schoolYear;
                case clsSysScoreSummaryEN.con_UpdDate:
                    return this.updDate;
                case clsSysScoreSummaryEN.con_Memo:
                    return this.memo;
                case clsSysScoreSummaryEN.con_ScoreTypeId:
                    return this.scoreTypeId;
                case clsSysScoreSummaryEN.con_UpdUser:
                    return this.updUser;
                case clsSysScoreSummaryEN.con_Score:
                    return this.score;
                case clsSysScoreSummaryEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsSysScoreSummaryEN.con_IsSubmit:
                    return this.isSubmit;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SysScoreSummary]中不存在！`;
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
                case clsSysScoreSummaryEN.con_mId:
                    this.mId = Number(strValue);
                    this.hmProperty["mId"] = true;
                    break;
                case clsSysScoreSummaryEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case clsSysScoreSummaryEN.con_SchoolYear:
                    this.schoolYear = strValue;
                    this.hmProperty["schoolYear"] = true;
                    break;
                case clsSysScoreSummaryEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsSysScoreSummaryEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsSysScoreSummaryEN.con_ScoreTypeId:
                    this.scoreTypeId = strValue;
                    this.hmProperty["scoreTypeId"] = true;
                    break;
                case clsSysScoreSummaryEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsSysScoreSummaryEN.con_Score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsSysScoreSummaryEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsSysScoreSummaryEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[SysScoreSummary]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"ScoreTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScoreTypeId() { return "scoreTypeId"; } //分数类型Id
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
    exports.clsSysScoreSummaryEN = clsSysScoreSummaryEN;
    clsSysScoreSummaryEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsSysScoreSummaryEN.CacheModeId = "02"; //客户端缓存
    clsSysScoreSummaryEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsSysScoreSummaryEN.WhereFormat = ""; //条件格式串
    clsSysScoreSummaryEN._CurrTabName = "SysScoreSummary"; //当前表名,与该类相关的表名
    clsSysScoreSummaryEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsSysScoreSummaryEN.mintAttributeCount = 10;
    clsSysScoreSummaryEN.AttributeName = ["mId", "userId", "schoolYear", "updDate", "memo", "scoreTypeId", "updUser", "score", "id_CurrEduCls", "isSubmit"];
});
