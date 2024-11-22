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
    exports.enumgs_PaperType = exports.clsgs_PaperTypeEN = void 0;
    /**
    * 类名:clsgs_PaperTypeEN
    * 表名:gs_PaperType(01120675)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:45:17
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
    * 论文类型表(gs_PaperType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_PaperTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrPaperTypeId = ""; //论文类型Id
            this.mstrPaperTypeName = ""; //论文类型名
            this.mstrMemo = ""; //备注
            this.mstrPaperTypeENName = ""; //论文类型英文名
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.paperTypeId = ""; //论文类型Id
            this.paperTypeName = ""; //论文类型名
            this.memo = ""; //备注
            this.paperTypeENName = ""; //论文类型英文名
        }
        /**
         * 论文类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperTypeId(value) {
            if (value != undefined) {
                this.paperTypeId = value;
                this.hmProperty["paperTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 论文类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperTypeName(value) {
            if (value != undefined) {
                this.paperTypeName = value;
                this.hmProperty["paperTypeName"] = true;
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
         * 论文类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperTypeENName(value) {
            if (value != undefined) {
                this.paperTypeENName = value;
                this.hmProperty["paperTypeENName"] = true;
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
                case clsgs_PaperTypeEN.con_PaperTypeId:
                    return this.paperTypeId;
                case clsgs_PaperTypeEN.con_PaperTypeName:
                    return this.paperTypeName;
                case clsgs_PaperTypeEN.con_Memo:
                    return this.memo;
                case clsgs_PaperTypeEN.con_PaperTypeENName:
                    return this.paperTypeENName;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperType]中不存在！`;
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
                case clsgs_PaperTypeEN.con_PaperTypeId:
                    this.paperTypeId = strValue;
                    this.hmProperty["paperTypeId"] = true;
                    break;
                case clsgs_PaperTypeEN.con_PaperTypeName:
                    this.paperTypeName = strValue;
                    this.hmProperty["paperTypeName"] = true;
                    break;
                case clsgs_PaperTypeEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_PaperTypeEN.con_PaperTypeENName:
                    this.paperTypeENName = strValue;
                    this.hmProperty["paperTypeENName"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"PaperTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTypeId() { return "paperTypeId"; } //论文类型Id
        /**
        * 常量:"PaperTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTypeName() { return "paperTypeName"; } //论文类型名
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"PaperTypeENName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTypeENName() { return "paperTypeENName"; } //论文类型英文名
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
    exports.clsgs_PaperTypeEN = clsgs_PaperTypeEN;
    clsgs_PaperTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_PaperTypeEN.CacheModeId = "04"; //sessionStorage
    clsgs_PaperTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_PaperTypeEN.WhereFormat = ""; //条件格式串
    clsgs_PaperTypeEN._CurrTabName = "gs_PaperType"; //当前表名,与该类相关的表名
    clsgs_PaperTypeEN._KeyFldName = "PaperTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_PaperTypeEN.mintAttributeCount = 4;
    clsgs_PaperTypeEN.AttributeName = ["paperTypeId", "paperTypeName", "memo", "paperTypeENName"];
    /**
    * 根据表内容设置enum列表
    * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GeneEnumConstList)
    **/
    class enumgs_PaperType {
    }
    exports.enumgs_PaperType = enumgs_PaperType;
    /**
    * 引用论文
    **/
    enumgs_PaperType.CitedPapers_01 = "01";
    /**
    * 原创论文
    **/
    enumgs_PaperType.OriginalThesis_02 = "02";
});
