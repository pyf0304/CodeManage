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
    exports.clsgs_TotalDataTypeEN = void 0;
    /**
    * 类名:clsgs_TotalDataTypeEN
    * 表名:gs_TotalDataType(01120685)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:47:14
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
    * 总数据类型表(gs_TotalDataType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_TotalDataTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrTotalDataTypeId = ""; //总数据类型Id
            this.mstrTotalDataTypeName = ""; //总数据类型名称
            this.mstrDataTable = ""; //数据表
            this.mstrDataTableId = ""; //数据表Id
            this.mstrMemo = ""; //备注
            this.mstrOnlyId = ""; //OnlyId
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.totalDataTypeId = ""; //总数据类型Id
            this.totalDataTypeName = ""; //总数据类型名称
            this.dataTable = ""; //数据表
            this.dataTableId = ""; //数据表Id
            this.memo = ""; //备注
            this.onlyId = ""; //OnlyId
        }
        /**
         * 总数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTotalDataTypeId(value) {
            if (value != undefined) {
                this.totalDataTypeId = value;
                this.hmProperty["totalDataTypeId"] = true;
            }
        }
        /**
         * 总数据类型名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTotalDataTypeName(value) {
            if (value != undefined) {
                this.totalDataTypeName = value;
                this.hmProperty["totalDataTypeName"] = true;
            }
        }
        /**
         * 数据表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDataTable(value) {
            if (value != undefined) {
                this.dataTable = value;
                this.hmProperty["dataTable"] = true;
            }
        }
        /**
         * 数据表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDataTableId(value) {
            if (value != undefined) {
                this.dataTableId = value;
                this.hmProperty["dataTableId"] = true;
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
         * OnlyId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOnlyId(value) {
            if (value != undefined) {
                this.onlyId = value;
                this.hmProperty["onlyId"] = true;
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
                case clsgs_TotalDataTypeEN.con_TotalDataTypeId:
                    return this.totalDataTypeId;
                case clsgs_TotalDataTypeEN.con_TotalDataTypeName:
                    return this.totalDataTypeName;
                case clsgs_TotalDataTypeEN.con_DataTable:
                    return this.dataTable;
                case clsgs_TotalDataTypeEN.con_DataTableId:
                    return this.dataTableId;
                case clsgs_TotalDataTypeEN.con_Memo:
                    return this.memo;
                case clsgs_TotalDataTypeEN.con_OnlyId:
                    return this.onlyId;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TotalDataType]中不存在！`;
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
                case clsgs_TotalDataTypeEN.con_TotalDataTypeId:
                    this.totalDataTypeId = strValue;
                    this.hmProperty["totalDataTypeId"] = true;
                    break;
                case clsgs_TotalDataTypeEN.con_TotalDataTypeName:
                    this.totalDataTypeName = strValue;
                    this.hmProperty["totalDataTypeName"] = true;
                    break;
                case clsgs_TotalDataTypeEN.con_DataTable:
                    this.dataTable = strValue;
                    this.hmProperty["dataTable"] = true;
                    break;
                case clsgs_TotalDataTypeEN.con_DataTableId:
                    this.dataTableId = strValue;
                    this.hmProperty["dataTableId"] = true;
                    break;
                case clsgs_TotalDataTypeEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_TotalDataTypeEN.con_OnlyId:
                    this.onlyId = strValue;
                    this.hmProperty["onlyId"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TotalDataType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"TotalDataTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TotalDataTypeId() { return "totalDataTypeId"; } //总数据类型Id
        /**
        * 常量:"TotalDataTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TotalDataTypeName() { return "totalDataTypeName"; } //总数据类型名称
        /**
        * 常量:"DataTable"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DataTable() { return "dataTable"; } //数据表
        /**
        * 常量:"DataTableId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DataTableId() { return "dataTableId"; } //数据表Id
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"OnlyId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OnlyId() { return "onlyId"; } //OnlyId
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
    exports.clsgs_TotalDataTypeEN = clsgs_TotalDataTypeEN;
    clsgs_TotalDataTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_TotalDataTypeEN.CacheModeId = "03"; //localStorage
    clsgs_TotalDataTypeEN._CurrTabName = "gs_TotalDataType"; //当前表名,与该类相关的表名
    clsgs_TotalDataTypeEN._KeyFldName = "TotalDataTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_TotalDataTypeEN.mintAttributeCount = 6;
    clsgs_TotalDataTypeEN.AttributeName = ["totalDataTypeId", "totalDataTypeName", "dataTable", "dataTableId", "memo", "onlyId"];
});
