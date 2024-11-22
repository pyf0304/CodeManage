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
    exports.clsvXzUniZoneEN = void 0;
    /**
    * 类名:clsvXzUniZoneEN
    * 表名:vXzUniZone(01120332)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:45:35
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
    * v校区(vXzUniZone)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvXzUniZoneEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.id_UniZone = ""; //校区流水号
            this.uniZoneID = ""; //校区编号
            this.uniZoneDesc = ""; //校区名称
            this.uniZoneDescA = ""; //UniZoneDescA
            this.id_School = ""; //学校流水号
            this.schoolId = ""; //学校编号
            this.schoolName = ""; //学校名称
            this.schoolNameA = ""; //学校简称
            this.id_Uni = ""; //id_Uni
            this.modifyDate = ""; //修改日期
            this.modifyUserID = ""; //修改人
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
                case clsvXzUniZoneEN.con_id_UniZone:
                    return this.id_UniZone;
                case clsvXzUniZoneEN.con_UniZoneID:
                    return this.uniZoneID;
                case clsvXzUniZoneEN.con_UniZoneDesc:
                    return this.uniZoneDesc;
                case clsvXzUniZoneEN.con_UniZoneDescA:
                    return this.uniZoneDescA;
                case clsvXzUniZoneEN.con_id_School:
                    return this.id_School;
                case clsvXzUniZoneEN.con_SchoolId:
                    return this.schoolId;
                case clsvXzUniZoneEN.con_SchoolName:
                    return this.schoolName;
                case clsvXzUniZoneEN.con_SchoolNameA:
                    return this.schoolNameA;
                case clsvXzUniZoneEN.con_id_Uni:
                    return this.id_Uni;
                case clsvXzUniZoneEN.con_ModifyDate:
                    return this.modifyDate;
                case clsvXzUniZoneEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsvXzUniZoneEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vXzUniZone]中不存在！`;
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
                case clsvXzUniZoneEN.con_id_UniZone:
                    this.id_UniZone = strValue;
                    break;
                case clsvXzUniZoneEN.con_UniZoneID:
                    this.uniZoneID = strValue;
                    break;
                case clsvXzUniZoneEN.con_UniZoneDesc:
                    this.uniZoneDesc = strValue;
                    break;
                case clsvXzUniZoneEN.con_UniZoneDescA:
                    this.uniZoneDescA = strValue;
                    break;
                case clsvXzUniZoneEN.con_id_School:
                    this.id_School = strValue;
                    break;
                case clsvXzUniZoneEN.con_SchoolId:
                    this.schoolId = strValue;
                    break;
                case clsvXzUniZoneEN.con_SchoolName:
                    this.schoolName = strValue;
                    break;
                case clsvXzUniZoneEN.con_SchoolNameA:
                    this.schoolNameA = strValue;
                    break;
                case clsvXzUniZoneEN.con_id_Uni:
                    this.id_Uni = strValue;
                    break;
                case clsvXzUniZoneEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    break;
                case clsvXzUniZoneEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    break;
                case clsvXzUniZoneEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vXzUniZone]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_UniZone"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_UniZone() { return "id_UniZone"; } //校区流水号
        /**
        * 常量:"UniZoneID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UniZoneID() { return "uniZoneID"; } //校区编号
        /**
        * 常量:"UniZoneDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UniZoneDesc() { return "uniZoneDesc"; } //校区名称
        /**
        * 常量:"UniZoneDescA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UniZoneDescA() { return "uniZoneDescA"; } //UniZoneDescA
        /**
        * 常量:"id_School"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_School() { return "id_School"; } //学校流水号
        /**
        * 常量:"SchoolId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolId() { return "schoolId"; } //学校编号
        /**
        * 常量:"SchoolName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolName() { return "schoolName"; } //学校名称
        /**
        * 常量:"SchoolNameA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolNameA() { return "schoolNameA"; } //学校简称
        /**
        * 常量:"id_Uni"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Uni() { return "id_Uni"; } //id_Uni
        /**
        * 常量:"ModifyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyDate() { return "modifyDate"; } //修改日期
        /**
        * 常量:"ModifyUserID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyUserID() { return "modifyUserID"; } //修改人
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
    exports.clsvXzUniZoneEN = clsvXzUniZoneEN;
    clsvXzUniZoneEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvXzUniZoneEN.CacheModeId = "05"; //未知
    clsvXzUniZoneEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvXzUniZoneEN.WhereFormat = ""; //条件格式串
    clsvXzUniZoneEN._CurrTabName = "vXzUniZone"; //当前表名,与该类相关的表名
    clsvXzUniZoneEN._KeyFldName = "id_UniZone"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvXzUniZoneEN.mintAttributeCount = 12;
    clsvXzUniZoneEN.AttributeName = ["id_UniZone", "uniZoneID", "uniZoneDesc", "uniZoneDescA", "id_School", "schoolId", "schoolName", "schoolNameA", "id_Uni", "modifyDate", "modifyUserID", "memo"];
});
