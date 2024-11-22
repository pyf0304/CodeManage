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
    exports.clsRsStuTypeEN = void 0;
    /**
    * 类名:clsRsStuTypeEN
    * 表名:RsStuType(01120162)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:50:34
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:成长档案(EPortfolio)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 学生类别(RsStuType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsRsStuTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrid_StuType = ""; //学生类别流水号
            this.mstrStuTypeID = ""; //学生类别ID
            this.mstrStuTypeDesc = ""; //学生类别名称
            this.mstrModifyDate = ""; //修改日期
            this.mstrModifyUserID = ""; //修改人
            this.mstrSpecUniLenDesc = ""; //SpecUniLenDesc
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_StuType = ""; //学生类别流水号
            this.stuTypeID = ""; //学生类别ID
            this.stuTypeDesc = ""; //学生类别名称
            this.modifyDate = ""; //修改日期
            this.modifyUserID = ""; //修改人
            this.specUniLenDesc = ""; //SpecUniLenDesc
            this.memo = ""; //备注
        }
        /**
         * 学生类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_StuType(value) {
            if (value != undefined) {
                this.id_StuType = value;
                this.hmProperty["id_StuType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学生类别ID(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuTypeID(value) {
            if (value != undefined) {
                this.stuTypeID = value;
                this.hmProperty["stuTypeID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学生类别名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuTypeDesc(value) {
            if (value != undefined) {
                this.stuTypeDesc = value;
                this.hmProperty["stuTypeDesc"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetModifyDate(value) {
            if (value != undefined) {
                this.modifyDate = value;
                this.hmProperty["modifyDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetModifyUserID(value) {
            if (value != undefined) {
                this.modifyUserID = value;
                this.hmProperty["modifyUserID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * SpecUniLenDesc(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSpecUniLenDesc(value) {
            if (value != undefined) {
                this.specUniLenDesc = value;
                this.hmProperty["specUniLenDesc"] = true;
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
                case clsRsStuTypeEN.con_id_StuType:
                    return this.id_StuType;
                case clsRsStuTypeEN.con_StuTypeID:
                    return this.stuTypeID;
                case clsRsStuTypeEN.con_StuTypeDesc:
                    return this.stuTypeDesc;
                case clsRsStuTypeEN.con_ModifyDate:
                    return this.modifyDate;
                case clsRsStuTypeEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsRsStuTypeEN.con_SpecUniLenDesc:
                    return this.specUniLenDesc;
                case clsRsStuTypeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[RsStuType]中不存在！`;
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
                case clsRsStuTypeEN.con_id_StuType:
                    this.id_StuType = strValue;
                    this.hmProperty["id_StuType"] = true;
                    break;
                case clsRsStuTypeEN.con_StuTypeID:
                    this.stuTypeID = strValue;
                    this.hmProperty["stuTypeID"] = true;
                    break;
                case clsRsStuTypeEN.con_StuTypeDesc:
                    this.stuTypeDesc = strValue;
                    this.hmProperty["stuTypeDesc"] = true;
                    break;
                case clsRsStuTypeEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    this.hmProperty["modifyDate"] = true;
                    break;
                case clsRsStuTypeEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    this.hmProperty["modifyUserID"] = true;
                    break;
                case clsRsStuTypeEN.con_SpecUniLenDesc:
                    this.specUniLenDesc = strValue;
                    this.hmProperty["specUniLenDesc"] = true;
                    break;
                case clsRsStuTypeEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[RsStuType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_StuType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_StuType() { return "id_StuType"; } //学生类别流水号
        /**
        * 常量:"StuTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuTypeID() { return "stuTypeID"; } //学生类别ID
        /**
        * 常量:"StuTypeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuTypeDesc() { return "stuTypeDesc"; } //学生类别名称
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
        * 常量:"SpecUniLenDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SpecUniLenDesc() { return "specUniLenDesc"; } //SpecUniLenDesc
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
    exports.clsRsStuTypeEN = clsRsStuTypeEN;
    clsRsStuTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsRsStuTypeEN.CacheModeId = "04"; //sessionStorage
    clsRsStuTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsRsStuTypeEN.WhereFormat = ""; //条件格式串
    clsRsStuTypeEN._CurrTabName = "RsStuType"; //当前表名,与该类相关的表名
    clsRsStuTypeEN._KeyFldName = "id_StuType"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsRsStuTypeEN.mintAttributeCount = 7;
    clsRsStuTypeEN.AttributeName = ["id_StuType", "stuTypeID", "stuTypeDesc", "modifyDate", "modifyUserID", "specUniLenDesc", "memo"];
});
