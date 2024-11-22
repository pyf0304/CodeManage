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
    exports.clsQxDepartmentInfoEN = void 0;
    /**
    * 类名:clsQxDepartmentInfoEN
    * 表名:QxDepartmentInfo(01120924)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:52:55
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:用户管理(UserManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 部门(QxDepartmentInfo)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsQxDepartmentInfoEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrDepartmentId = ""; //部门Id
            this.mstrDepartmentName = ""; //部门名称
            this.mstrDepartmentAbbrName = ""; //DepartmentAbbrName
            this.mstrDepartmentTypeId = ""; //DepartmentTypeId
            this.mstrUpDepartmentId = ""; //UpDepartmentId
            this.mintOrderNum = 0; //序号
            this.mbolInUse = false; //是否在用
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.departmentId = ""; //部门Id
            this.departmentName = ""; //部门名称
            this.departmentAbbrName = ""; //DepartmentAbbrName
            this.departmentTypeId = ""; //DepartmentTypeId
            this.upDepartmentId = ""; //UpDepartmentId
            this.orderNum = 0; //序号
            this.inUse = false; //是否在用
            this.memo = ""; //备注
        }
        /**
         * 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDepartmentId(value) {
            if (value != undefined) {
                this.departmentId = value;
                this.hmProperty["departmentId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 部门名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDepartmentName(value) {
            if (value != undefined) {
                this.departmentName = value;
                this.hmProperty["departmentName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * DepartmentAbbrName(说明:;字段类型:varchar;字段长度:12;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDepartmentAbbrName(value) {
            if (value != undefined) {
                this.departmentAbbrName = value;
                this.hmProperty["departmentAbbrName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * DepartmentTypeId(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDepartmentTypeId(value) {
            if (value != undefined) {
                this.departmentTypeId = value;
                this.hmProperty["departmentTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * UpDepartmentId(说明:;字段类型:varchar;字段长度:6;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpDepartmentId(value) {
            if (value != undefined) {
                this.upDepartmentId = value;
                this.hmProperty["upDepartmentId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOrderNum(value) {
            if (value != undefined) {
                this.orderNum = value;
                this.hmProperty["orderNum"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetInUse(value) {
            if (value != undefined) {
                this.inUse = value;
                this.hmProperty["inUse"] = true;
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
                case clsQxDepartmentInfoEN.con_DepartmentId:
                    return this.departmentId;
                case clsQxDepartmentInfoEN.con_DepartmentName:
                    return this.departmentName;
                case clsQxDepartmentInfoEN.con_DepartmentAbbrName:
                    return this.departmentAbbrName;
                case clsQxDepartmentInfoEN.con_DepartmentTypeId:
                    return this.departmentTypeId;
                case clsQxDepartmentInfoEN.con_UpDepartmentId:
                    return this.upDepartmentId;
                case clsQxDepartmentInfoEN.con_OrderNum:
                    return this.orderNum;
                case clsQxDepartmentInfoEN.con_InUse:
                    return this.inUse;
                case clsQxDepartmentInfoEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[QxDepartmentInfo]中不存在！`;
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
                case clsQxDepartmentInfoEN.con_DepartmentId:
                    this.departmentId = strValue;
                    this.hmProperty["departmentId"] = true;
                    break;
                case clsQxDepartmentInfoEN.con_DepartmentName:
                    this.departmentName = strValue;
                    this.hmProperty["departmentName"] = true;
                    break;
                case clsQxDepartmentInfoEN.con_DepartmentAbbrName:
                    this.departmentAbbrName = strValue;
                    this.hmProperty["departmentAbbrName"] = true;
                    break;
                case clsQxDepartmentInfoEN.con_DepartmentTypeId:
                    this.departmentTypeId = strValue;
                    this.hmProperty["departmentTypeId"] = true;
                    break;
                case clsQxDepartmentInfoEN.con_UpDepartmentId:
                    this.upDepartmentId = strValue;
                    this.hmProperty["upDepartmentId"] = true;
                    break;
                case clsQxDepartmentInfoEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    this.hmProperty["orderNum"] = true;
                    break;
                case clsQxDepartmentInfoEN.con_InUse:
                    this.inUse = Boolean(strValue);
                    this.hmProperty["inUse"] = true;
                    break;
                case clsQxDepartmentInfoEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[QxDepartmentInfo]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"DepartmentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DepartmentId() { return "departmentId"; } //部门Id
        /**
        * 常量:"DepartmentName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DepartmentName() { return "departmentName"; } //部门名称
        /**
        * 常量:"DepartmentAbbrName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DepartmentAbbrName() { return "departmentAbbrName"; } //DepartmentAbbrName
        /**
        * 常量:"DepartmentTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DepartmentTypeId() { return "departmentTypeId"; } //DepartmentTypeId
        /**
        * 常量:"UpDepartmentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpDepartmentId() { return "upDepartmentId"; } //UpDepartmentId
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"InUse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_InUse() { return "inUse"; } //是否在用
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
    exports.clsQxDepartmentInfoEN = clsQxDepartmentInfoEN;
    clsQxDepartmentInfoEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsQxDepartmentInfoEN.CacheModeId = "04"; //sessionStorage
    clsQxDepartmentInfoEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsQxDepartmentInfoEN.WhereFormat = ""; //条件格式串
    clsQxDepartmentInfoEN._CurrTabName = "QxDepartmentInfo"; //当前表名,与该类相关的表名
    clsQxDepartmentInfoEN._KeyFldName = "DepartmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsQxDepartmentInfoEN.mintAttributeCount = 8;
    clsQxDepartmentInfoEN.AttributeName = ["departmentId", "departmentName", "departmentAbbrName", "departmentTypeId", "upDepartmentId", "orderNum", "inUse", "memo"];
});
