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
    exports.clsgs_ColorEN = void 0;
    /**
    * 类名:clsgs_ColorEN
    * 表名:gs_Color(01120751)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:54:54
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
    * 颜色表(gs_Color)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_ColorEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrColorId = ""; //颜色Id
            this.mintUserNo = 0; //用户号
            this.mstrColorCode = ""; //颜色码
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.colorId = ""; //颜色Id
            this.userNo = 0; //用户号
            this.colorCode = ""; //颜色码
        }
        /**
         * 颜色Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetColorId(value) {
            if (value != undefined) {
                this.colorId = value;
                this.hmProperty["colorId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 用户号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserNo(value) {
            if (value != undefined) {
                this.userNo = value;
                this.hmProperty["userNo"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 颜色码(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetColorCode(value) {
            if (value != undefined) {
                this.colorCode = value;
                this.hmProperty["colorCode"] = true;
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
                case clsgs_ColorEN.con_ColorId:
                    return this.colorId;
                case clsgs_ColorEN.con_UserNo:
                    return this.userNo;
                case clsgs_ColorEN.con_ColorCode:
                    return this.colorCode;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_Color]中不存在！`;
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
                case clsgs_ColorEN.con_ColorId:
                    this.colorId = strValue;
                    this.hmProperty["colorId"] = true;
                    break;
                case clsgs_ColorEN.con_UserNo:
                    this.userNo = Number(strValue);
                    this.hmProperty["userNo"] = true;
                    break;
                case clsgs_ColorEN.con_ColorCode:
                    this.colorCode = strValue;
                    this.hmProperty["colorCode"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_Color]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ColorId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ColorId() { return "colorId"; } //颜色Id
        /**
        * 常量:"UserNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserNo() { return "userNo"; } //用户号
        /**
        * 常量:"ColorCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ColorCode() { return "colorCode"; } //颜色码
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
    exports.clsgs_ColorEN = clsgs_ColorEN;
    clsgs_ColorEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_ColorEN.CacheModeId = "04"; //sessionStorage
    clsgs_ColorEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_ColorEN.WhereFormat = ""; //条件格式串
    clsgs_ColorEN._CurrTabName = "gs_Color"; //当前表名,与该类相关的表名
    clsgs_ColorEN._KeyFldName = "ColorId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_ColorEN.mintAttributeCount = 3;
    clsgs_ColorEN.AttributeName = ["colorId", "userNo", "colorCode"];
});
