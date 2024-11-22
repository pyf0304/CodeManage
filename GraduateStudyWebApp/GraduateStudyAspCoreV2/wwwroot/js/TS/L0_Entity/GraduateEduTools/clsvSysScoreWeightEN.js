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
    exports.clsvSysScoreWeightEN = void 0;
    /**
    * 类名:clsvSysScoreWeightEN
    * 表名:vSysScoreWeight(01120630)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:47:49
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
    * v系统分数权重表(vSysScoreWeight)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvSysScoreWeightEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.scoreWeightId = ""; //分数权重Id
            this.scoreWeightValue = ""; //分数权重值
            this.isPublic = false; //是否公开
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.scoreTypeId = ""; //分数类型Id
            this.scoreTypeName = ""; //分数类型名称
            this.onlyId = ""; //OnlyId
            this.id_CurrEduCls = ""; //教学班流水号
            this.currEduClsId = ""; //教学班Id
            this.eduClsName = ""; //教学班名
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
                case clsvSysScoreWeightEN.con_ScoreWeightId:
                    return this.scoreWeightId;
                case clsvSysScoreWeightEN.con_ScoreWeightValue:
                    return this.scoreWeightValue;
                case clsvSysScoreWeightEN.con_IsPublic:
                    return this.isPublic;
                case clsvSysScoreWeightEN.con_UpdDate:
                    return this.updDate;
                case clsvSysScoreWeightEN.con_UpdUser:
                    return this.updUser;
                case clsvSysScoreWeightEN.con_Memo:
                    return this.memo;
                case clsvSysScoreWeightEN.con_ScoreTypeId:
                    return this.scoreTypeId;
                case clsvSysScoreWeightEN.con_ScoreTypeName:
                    return this.scoreTypeName;
                case clsvSysScoreWeightEN.con_OnlyId:
                    return this.onlyId;
                case clsvSysScoreWeightEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvSysScoreWeightEN.con_CurrEduClsId:
                    return this.currEduClsId;
                case clsvSysScoreWeightEN.con_EduClsName:
                    return this.eduClsName;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysScoreWeight]中不存在！`;
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
                case clsvSysScoreWeightEN.con_ScoreWeightId:
                    this.scoreWeightId = strValue;
                    break;
                case clsvSysScoreWeightEN.con_ScoreWeightValue:
                    this.scoreWeightValue = strValue;
                    break;
                case clsvSysScoreWeightEN.con_IsPublic:
                    this.isPublic = Boolean(strValue);
                    break;
                case clsvSysScoreWeightEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvSysScoreWeightEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvSysScoreWeightEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvSysScoreWeightEN.con_ScoreTypeId:
                    this.scoreTypeId = strValue;
                    break;
                case clsvSysScoreWeightEN.con_ScoreTypeName:
                    this.scoreTypeName = strValue;
                    break;
                case clsvSysScoreWeightEN.con_OnlyId:
                    this.onlyId = strValue;
                    break;
                case clsvSysScoreWeightEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvSysScoreWeightEN.con_CurrEduClsId:
                    this.currEduClsId = strValue;
                    break;
                case clsvSysScoreWeightEN.con_EduClsName:
                    this.eduClsName = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysScoreWeight]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ScoreWeightId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScoreWeightId() { return "scoreWeightId"; } //分数权重Id
        /**
        * 常量:"ScoreWeightValue"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScoreWeightValue() { return "scoreWeightValue"; } //分数权重值
        /**
        * 常量:"IsPublic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsPublic() { return "isPublic"; } //是否公开
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
        * 常量:"OnlyId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OnlyId() { return "onlyId"; } //OnlyId
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"CurrEduClsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CurrEduClsId() { return "currEduClsId"; } //教学班Id
        /**
        * 常量:"EduClsName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsName() { return "eduClsName"; } //教学班名
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
    exports.clsvSysScoreWeightEN = clsvSysScoreWeightEN;
    clsvSysScoreWeightEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvSysScoreWeightEN.CacheModeId = "02"; //客户端缓存
    clsvSysScoreWeightEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvSysScoreWeightEN.WhereFormat = ""; //条件格式串
    clsvSysScoreWeightEN._CurrTabName = "vSysScoreWeight"; //当前表名,与该类相关的表名
    clsvSysScoreWeightEN._KeyFldName = "ScoreWeightId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvSysScoreWeightEN.mintAttributeCount = 12;
    clsvSysScoreWeightEN.AttributeName = ["scoreWeightId", "scoreWeightValue", "isPublic", "updDate", "updUser", "memo", "scoreTypeId", "scoreTypeName", "onlyId", "id_CurrEduCls", "currEduClsId", "eduClsName"];
});
