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
    exports.clsvgs_UserConfigEN = void 0;
    /**
    * 类名:clsvgs_UserConfigEN
    * 表名:vgs_UserConfig(01120691)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:03:01
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
    * 用户配置视图(vgs_UserConfig)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_UserConfigEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.configId = 0; //配置Id
            this.configTypeId = ""; //配置类型Id
            this.configTypeName = ""; //配置类型名称
            this.shareId = ""; //分享Id
            this.dataTable = ""; //数据表
            this.updUser = ""; //修改人
            this.dataTableId = ""; //数据表Id
            this.updDate = ""; //修改日期
            this.shareName = ""; //分享名称
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
                case clsvgs_UserConfigEN.con_ConfigId:
                    return this.configId;
                case clsvgs_UserConfigEN.con_ConfigTypeId:
                    return this.configTypeId;
                case clsvgs_UserConfigEN.con_ConfigTypeName:
                    return this.configTypeName;
                case clsvgs_UserConfigEN.con_ShareId:
                    return this.shareId;
                case clsvgs_UserConfigEN.con_DataTable:
                    return this.dataTable;
                case clsvgs_UserConfigEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_UserConfigEN.con_DataTableId:
                    return this.dataTableId;
                case clsvgs_UserConfigEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_UserConfigEN.con_ShareName:
                    return this.shareName;
                case clsvgs_UserConfigEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_UserConfig]中不存在！`;
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
                case clsvgs_UserConfigEN.con_ConfigId:
                    this.configId = Number(strValue);
                    break;
                case clsvgs_UserConfigEN.con_ConfigTypeId:
                    this.configTypeId = strValue;
                    break;
                case clsvgs_UserConfigEN.con_ConfigTypeName:
                    this.configTypeName = strValue;
                    break;
                case clsvgs_UserConfigEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvgs_UserConfigEN.con_DataTable:
                    this.dataTable = strValue;
                    break;
                case clsvgs_UserConfigEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_UserConfigEN.con_DataTableId:
                    this.dataTableId = strValue;
                    break;
                case clsvgs_UserConfigEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_UserConfigEN.con_ShareName:
                    this.shareName = strValue;
                    break;
                case clsvgs_UserConfigEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_UserConfig]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ConfigId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConfigId() { return "configId"; } //配置Id
        /**
        * 常量:"ConfigTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConfigTypeId() { return "configTypeId"; } //配置类型Id
        /**
        * 常量:"ConfigTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConfigTypeName() { return "configTypeName"; } //配置类型名称
        /**
        * 常量:"ShareId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ShareId() { return "shareId"; } //分享Id
        /**
        * 常量:"DataTable"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DataTable() { return "dataTable"; } //数据表
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"DataTableId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DataTableId() { return "dataTableId"; } //数据表Id
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"ShareName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ShareName() { return "shareName"; } //分享名称
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
    exports.clsvgs_UserConfigEN = clsvgs_UserConfigEN;
    clsvgs_UserConfigEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_UserConfigEN.CacheModeId = "02"; //客户端缓存
    clsvgs_UserConfigEN._CurrTabName = "vgs_UserConfig"; //当前表名,与该类相关的表名
    clsvgs_UserConfigEN._KeyFldName = "ConfigId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_UserConfigEN.mintAttributeCount = 10;
    clsvgs_UserConfigEN.AttributeName = ["configId", "configTypeId", "configTypeName", "shareId", "dataTable", "updUser", "dataTableId", "updDate", "shareName", "memo"];
});
