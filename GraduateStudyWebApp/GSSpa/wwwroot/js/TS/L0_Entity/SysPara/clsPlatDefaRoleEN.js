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
    exports.clsPlatDefaRoleEN = void 0;
    /**
    * 类名:clsPlatDefaRoleEN
    * 表名:PlatDefaRole(01120231)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:45:53
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
    * 平台默认角色(PlatDefaRole)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsPlatDefaRoleEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrid_School = ""; //学校流水号
            this.mstrPersonType = ""; //人员类别
            this.mstrPrjId = ""; //PrjId
            this.mstrRoleId = ""; //角色Id
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.mId = 0; //mId
            this.id_School = ""; //学校流水号
            this.personType = ""; //人员类别
            this.prjId = ""; //PrjId
            this.roleId = ""; //角色Id
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
            }
        }
        /**
         * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_School(value) {
            if (value != undefined) {
                this.id_School = value;
                this.hmProperty["id_School"] = true;
            }
        }
        /**
         * 人员类别(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPersonType(value) {
            if (value != undefined) {
                this.personType = value;
                this.hmProperty["personType"] = true;
            }
        }
        /**
         * PrjId(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPrjId(value) {
            if (value != undefined) {
                this.prjId = value;
                this.hmProperty["prjId"] = true;
            }
        }
        /**
         * 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRoleId(value) {
            if (value != undefined) {
                this.roleId = value;
                this.hmProperty["roleId"] = true;
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
                case clsPlatDefaRoleEN.con_mId:
                    return this.mId;
                case clsPlatDefaRoleEN.con_id_School:
                    return this.id_School;
                case clsPlatDefaRoleEN.con_PersonType:
                    return this.personType;
                case clsPlatDefaRoleEN.con_PrjId:
                    return this.prjId;
                case clsPlatDefaRoleEN.con_RoleId:
                    return this.roleId;
                case clsPlatDefaRoleEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[PlatDefaRole]中不存在！`;
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
                case clsPlatDefaRoleEN.con_mId:
                    this.mId = Number(strValue);
                    this.hmProperty["mId"] = true;
                    break;
                case clsPlatDefaRoleEN.con_id_School:
                    this.id_School = strValue;
                    this.hmProperty["id_School"] = true;
                    break;
                case clsPlatDefaRoleEN.con_PersonType:
                    this.personType = strValue;
                    this.hmProperty["personType"] = true;
                    break;
                case clsPlatDefaRoleEN.con_PrjId:
                    this.prjId = strValue;
                    this.hmProperty["prjId"] = true;
                    break;
                case clsPlatDefaRoleEN.con_RoleId:
                    this.roleId = strValue;
                    this.hmProperty["roleId"] = true;
                    break;
                case clsPlatDefaRoleEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[PlatDefaRole]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
    exports.clsPlatDefaRoleEN = clsPlatDefaRoleEN;
    clsPlatDefaRoleEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsPlatDefaRoleEN.CacheModeId = "05"; //未知
    clsPlatDefaRoleEN._CurrTabName = "PlatDefaRole"; //当前表名,与该类相关的表名
    clsPlatDefaRoleEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsPlatDefaRoleEN.mintAttributeCount = 6;
    clsPlatDefaRoleEN.AttributeName = ["mId", "id_School", "personType", "prjId", "roleId", "memo"];
});
