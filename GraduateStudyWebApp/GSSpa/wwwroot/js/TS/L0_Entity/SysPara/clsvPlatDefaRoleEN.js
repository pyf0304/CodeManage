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
    exports.clsvPlatDefaRoleEN = void 0;
    /**
    * 类名:clsvPlatDefaRoleEN
    * 表名:vPlatDefaRole(01120232)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:20
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
    * v平台默认角色(vPlatDefaRole)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvPlatDefaRoleEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.id_School = ""; //学校流水号
            this.schoolId = ""; //学校编号
            this.isCurrentUse = false; //是否当前使用
            this.schoolName = ""; //学校名称
            this.personType = ""; //人员类别
            this.prjId = ""; //PrjId
            this.roleId = ""; //角色Id
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
                case clsvPlatDefaRoleEN.con_mId:
                    return this.mId;
                case clsvPlatDefaRoleEN.con_id_School:
                    return this.id_School;
                case clsvPlatDefaRoleEN.con_SchoolId:
                    return this.schoolId;
                case clsvPlatDefaRoleEN.con_IsCurrentUse:
                    return this.isCurrentUse;
                case clsvPlatDefaRoleEN.con_SchoolName:
                    return this.schoolName;
                case clsvPlatDefaRoleEN.con_PersonType:
                    return this.personType;
                case clsvPlatDefaRoleEN.con_PrjId:
                    return this.prjId;
                case clsvPlatDefaRoleEN.con_RoleId:
                    return this.roleId;
                case clsvPlatDefaRoleEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPlatDefaRole]中不存在！`;
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
                case clsvPlatDefaRoleEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvPlatDefaRoleEN.con_id_School:
                    this.id_School = strValue;
                    break;
                case clsvPlatDefaRoleEN.con_SchoolId:
                    this.schoolId = strValue;
                    break;
                case clsvPlatDefaRoleEN.con_IsCurrentUse:
                    this.isCurrentUse = Boolean(strValue);
                    break;
                case clsvPlatDefaRoleEN.con_SchoolName:
                    this.schoolName = strValue;
                    break;
                case clsvPlatDefaRoleEN.con_PersonType:
                    this.personType = strValue;
                    break;
                case clsvPlatDefaRoleEN.con_PrjId:
                    this.prjId = strValue;
                    break;
                case clsvPlatDefaRoleEN.con_RoleId:
                    this.roleId = strValue;
                    break;
                case clsvPlatDefaRoleEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPlatDefaRole]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"IsCurrentUse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCurrentUse() { return "isCurrentUse"; } //是否当前使用
        /**
        * 常量:"SchoolName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolName() { return "schoolName"; } //学校名称
        /**
        * 常量:"PersonType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PersonType() { return "personType"; } //人员类别
        /**
        * 常量:"PrjId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PrjId() { return "prjId"; } //PrjId
        /**
        * 常量:"RoleId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RoleId() { return "roleId"; } //角色Id
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
    exports.clsvPlatDefaRoleEN = clsvPlatDefaRoleEN;
    clsvPlatDefaRoleEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvPlatDefaRoleEN.CacheModeId = "05"; //未知
    clsvPlatDefaRoleEN._CurrTabName = "vPlatDefaRole"; //当前表名,与该类相关的表名
    clsvPlatDefaRoleEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvPlatDefaRoleEN.mintAttributeCount = 9;
    clsvPlatDefaRoleEN.AttributeName = ["mId", "id_School", "schoolId", "isCurrentUse", "schoolName", "personType", "prjId", "roleId", "memo"];
});
