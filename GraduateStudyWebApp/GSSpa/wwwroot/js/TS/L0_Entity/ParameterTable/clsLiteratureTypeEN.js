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
    exports.clsLiteratureTypeEN = void 0;
    /**
    * 类名:clsLiteratureTypeEN
    * 表名:LiteratureType(01120557)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:26
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培参数(ParameterTable)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 文献类型(LiteratureType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsLiteratureTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrLiteratureTypeId = ""; //作文类型Id
            this.mstrLiteratureTypeName = ""; //作文类型名
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrUpdDate = ""; //修改日期
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.literatureTypeId = ""; //作文类型Id
            this.literatureTypeName = ""; //作文类型名
            this.updUserId = ""; //修改用户Id
            this.updDate = ""; //修改日期
        }
        /**
         * 作文类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLiteratureTypeId(value) {
            if (value != undefined) {
                this.literatureTypeId = value;
                this.hmProperty["literatureTypeId"] = true;
            }
        }
        /**
         * 作文类型名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLiteratureTypeName(value) {
            if (value != undefined) {
                this.literatureTypeName = value;
                this.hmProperty["literatureTypeName"] = true;
            }
        }
        /**
         * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUserId(value) {
            if (value != undefined) {
                this.updUserId = value;
                this.hmProperty["updUserId"] = true;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdDate(value) {
            if (value != undefined) {
                this.updDate = value;
                this.hmProperty["updDate"] = true;
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
                case clsLiteratureTypeEN.con_LiteratureTypeId:
                    return this.literatureTypeId;
                case clsLiteratureTypeEN.con_LiteratureTypeName:
                    return this.literatureTypeName;
                case clsLiteratureTypeEN.con_UpdUserId:
                    return this.updUserId;
                case clsLiteratureTypeEN.con_UpdDate:
                    return this.updDate;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[LiteratureType]中不存在！`;
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
                case clsLiteratureTypeEN.con_LiteratureTypeId:
                    this.literatureTypeId = strValue;
                    this.hmProperty["literatureTypeId"] = true;
                    break;
                case clsLiteratureTypeEN.con_LiteratureTypeName:
                    this.literatureTypeName = strValue;
                    this.hmProperty["literatureTypeName"] = true;
                    break;
                case clsLiteratureTypeEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clsLiteratureTypeEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[LiteratureType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"LiteratureTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureTypeId() { return "literatureTypeId"; } //作文类型Id
        /**
        * 常量:"LiteratureTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiteratureTypeName() { return "literatureTypeName"; } //作文类型名
        /**
        * 常量:"UpdUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserId() { return "updUserId"; } //修改用户Id
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
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
    exports.clsLiteratureTypeEN = clsLiteratureTypeEN;
    clsLiteratureTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsLiteratureTypeEN.CacheModeId = "03"; //localStorage
    clsLiteratureTypeEN._CurrTabName = "LiteratureType"; //当前表名,与该类相关的表名
    clsLiteratureTypeEN._KeyFldName = "LiteratureTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsLiteratureTypeEN.mintAttributeCount = 4;
    clsLiteratureTypeEN.AttributeName = ["literatureTypeId", "literatureTypeName", "updUserId", "updDate"];
});
