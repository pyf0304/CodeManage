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
    exports.clsvgs_TeachingDateEN = void 0;
    /**
    * 类名:clsvgs_TeachingDateEN
    * 表名:vgs_TeachingDate(01120687)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:47:59
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
    * vgs_TeachingDate(vgs_TeachingDate)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_TeachingDateEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.currEduClsId = ""; //教学班Id
            this.eduClsName = ""; //教学班名
            this.memo = ""; //备注
            this.updDate = ""; //修改日期
            this.endDate = ""; //截止日期
            this.startDate = ""; //开始日期
            this.id_CurrEduCls = ""; //教学班流水号
            this.updUser = ""; //修改人
            this.mId = 0; //mId
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
                case clsvgs_TeachingDateEN.con_CurrEduClsId:
                    return this.currEduClsId;
                case clsvgs_TeachingDateEN.con_EduClsName:
                    return this.eduClsName;
                case clsvgs_TeachingDateEN.con_Memo:
                    return this.memo;
                case clsvgs_TeachingDateEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_TeachingDateEN.con_EndDate:
                    return this.endDate;
                case clsvgs_TeachingDateEN.con_StartDate:
                    return this.startDate;
                case clsvgs_TeachingDateEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvgs_TeachingDateEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_TeachingDateEN.con_mId:
                    return this.mId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_TeachingDate]中不存在！`;
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
                case clsvgs_TeachingDateEN.con_CurrEduClsId:
                    this.currEduClsId = strValue;
                    break;
                case clsvgs_TeachingDateEN.con_EduClsName:
                    this.eduClsName = strValue;
                    break;
                case clsvgs_TeachingDateEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvgs_TeachingDateEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_TeachingDateEN.con_EndDate:
                    this.endDate = strValue;
                    break;
                case clsvgs_TeachingDateEN.con_StartDate:
                    this.startDate = strValue;
                    break;
                case clsvgs_TeachingDateEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvgs_TeachingDateEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_TeachingDateEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_TeachingDate]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
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
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"EndDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EndDate() { return "endDate"; } //截止日期
        /**
        * 常量:"StartDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StartDate() { return "startDate"; } //开始日期
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"mId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_mId() { return "mId"; } //mId
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
    exports.clsvgs_TeachingDateEN = clsvgs_TeachingDateEN;
    clsvgs_TeachingDateEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_TeachingDateEN.CacheModeId = "02"; //客户端缓存
    clsvgs_TeachingDateEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvgs_TeachingDateEN.WhereFormat = ""; //条件格式串
    clsvgs_TeachingDateEN._CurrTabName = "vgs_TeachingDate"; //当前表名,与该类相关的表名
    clsvgs_TeachingDateEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_TeachingDateEN.mintAttributeCount = 9;
    clsvgs_TeachingDateEN.AttributeName = ["currEduClsId", "eduClsName", "memo", "updDate", "endDate", "startDate", "id_CurrEduCls", "updUser", "mId"];
});
