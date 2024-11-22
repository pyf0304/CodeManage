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
    exports.clsgs_TDRelaTypeEN = void 0;
    /**
    * 类名:clsgs_TDRelaTypeEN
    * 表名:gs_TDRelaType(01120703)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:47:09
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
    * 总数据关系类型表(gs_TDRelaType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_TDRelaTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrTDRelaTypeId = ""; //总数据关系类型Id
            this.mstrTDRelaTypeName = ""; //总数据类型名称
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.tdRelaTypeId = ""; //总数据关系类型Id
            this.tdRelaTypeName = ""; //总数据类型名称
            this.memo = ""; //备注
        }
        /**
         * 总数据关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTDRelaTypeId(value) {
            if (value != undefined) {
                this.tdRelaTypeId = value;
                this.hmProperty["tdRelaTypeId"] = true;
            }
        }
        /**
         * 总数据类型名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTDRelaTypeName(value) {
            if (value != undefined) {
                this.tdRelaTypeName = value;
                this.hmProperty["tdRelaTypeName"] = true;
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
                case clsgs_TDRelaTypeEN.con_TDRelaTypeId:
                    return this.tdRelaTypeId;
                case clsgs_TDRelaTypeEN.con_TDRelaTypeName:
                    return this.tdRelaTypeName;
                case clsgs_TDRelaTypeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TDRelaType]中不存在！`;
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
                case clsgs_TDRelaTypeEN.con_TDRelaTypeId:
                    this.tdRelaTypeId = strValue;
                    this.hmProperty["tdRelaTypeId"] = true;
                    break;
                case clsgs_TDRelaTypeEN.con_TDRelaTypeName:
                    this.tdRelaTypeName = strValue;
                    this.hmProperty["tdRelaTypeName"] = true;
                    break;
                case clsgs_TDRelaTypeEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_TDRelaType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"TDRelaTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TDRelaTypeId() { return "tdRelaTypeId"; } //总数据关系类型Id
        /**
        * 常量:"TDRelaTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TDRelaTypeName() { return "tdRelaTypeName"; } //总数据类型名称
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
    exports.clsgs_TDRelaTypeEN = clsgs_TDRelaTypeEN;
    clsgs_TDRelaTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_TDRelaTypeEN.CacheModeId = "03"; //localStorage
    clsgs_TDRelaTypeEN._CurrTabName = "gs_TDRelaType"; //当前表名,与该类相关的表名
    clsgs_TDRelaTypeEN._KeyFldName = "TDRelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_TDRelaTypeEN.mintAttributeCount = 3;
    clsgs_TDRelaTypeEN.AttributeName = ["tdRelaTypeId", "tdRelaTypeName", "memo"];
});
