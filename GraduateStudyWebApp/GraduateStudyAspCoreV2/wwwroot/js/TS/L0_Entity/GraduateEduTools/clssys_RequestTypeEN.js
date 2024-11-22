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
    exports.clssys_RequestTypeEN = void 0;
    /**
    * 类名:clssys_RequestTypeEN
    * 表名:sys_RequestType(01120727)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:48:36
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
    * 请求类型表(sys_RequestType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clssys_RequestTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrRequestTypeId = ""; //RequestTypeId
            this.mstrRequestTypeName = ""; //RequestTypeName
            this.mstrRequestTable = ""; //RequestTable
            this.mstrRequestTableId = ""; //RequestTableId
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.requestTypeId = ""; //RequestTypeId
            this.requestTypeName = ""; //RequestTypeName
            this.requestTable = ""; //RequestTable
            this.requestTableId = ""; //RequestTableId
            this.memo = ""; //备注
        }
        /**
         * RequestTypeId(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRequestTypeId(value) {
            if (value != undefined) {
                this.requestTypeId = value;
                this.hmProperty["requestTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * RequestTypeName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRequestTypeName(value) {
            if (value != undefined) {
                this.requestTypeName = value;
                this.hmProperty["requestTypeName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * RequestTable(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRequestTable(value) {
            if (value != undefined) {
                this.requestTable = value;
                this.hmProperty["requestTable"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * RequestTableId(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRequestTableId(value) {
            if (value != undefined) {
                this.requestTableId = value;
                this.hmProperty["requestTableId"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clssys_RequestTypeEN.con_RequestTypeId:
                    return this.requestTypeId;
                case clssys_RequestTypeEN.con_RequestTypeName:
                    return this.requestTypeName;
                case clssys_RequestTypeEN.con_RequestTable:
                    return this.requestTable;
                case clssys_RequestTypeEN.con_RequestTableId:
                    return this.requestTableId;
                case clssys_RequestTypeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[sys_RequestType]中不存在！`;
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
                case clssys_RequestTypeEN.con_RequestTypeId:
                    this.requestTypeId = strValue;
                    this.hmProperty["requestTypeId"] = true;
                    break;
                case clssys_RequestTypeEN.con_RequestTypeName:
                    this.requestTypeName = strValue;
                    this.hmProperty["requestTypeName"] = true;
                    break;
                case clssys_RequestTypeEN.con_RequestTable:
                    this.requestTable = strValue;
                    this.hmProperty["requestTable"] = true;
                    break;
                case clssys_RequestTypeEN.con_RequestTableId:
                    this.requestTableId = strValue;
                    this.hmProperty["requestTableId"] = true;
                    break;
                case clssys_RequestTypeEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[sys_RequestType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"RequestTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestTypeId() { return "requestTypeId"; } //RequestTypeId
        /**
        * 常量:"RequestTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestTypeName() { return "requestTypeName"; } //RequestTypeName
        /**
        * 常量:"RequestTable"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestTable() { return "requestTable"; } //RequestTable
        /**
        * 常量:"RequestTableId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RequestTableId() { return "requestTableId"; } //RequestTableId
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
    exports.clssys_RequestTypeEN = clssys_RequestTypeEN;
    clssys_RequestTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clssys_RequestTypeEN.CacheModeId = "03"; //localStorage
    clssys_RequestTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clssys_RequestTypeEN.WhereFormat = ""; //条件格式串
    clssys_RequestTypeEN._CurrTabName = "sys_RequestType"; //当前表名,与该类相关的表名
    clssys_RequestTypeEN._KeyFldName = "RequestTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clssys_RequestTypeEN.mintAttributeCount = 5;
    clssys_RequestTypeEN.AttributeName = ["requestTypeId", "requestTypeName", "requestTable", "requestTableId", "memo"];
});
