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
    exports.enumge_DifficultyLevel = exports.clsge_DifficultyLevelEN = void 0;
    /**
    * 类名:clsge_DifficultyLevelEN
    * 表名:ge_DifficultyLevel(01120905)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 18:42:02
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:系统设置(SystemSet)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 难度等级表(ge_DifficultyLevel)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsge_DifficultyLevelEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrDifficultyLevelId = ""; //难度等级Id
            this.mstrDifficultyLevelName = ""; //难度等级名称
            this.mstrDifficultyLevelENName = ""; //难度等级英文名
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.difficultyLevelId = ""; //难度等级Id
            this.difficultyLevelName = ""; //难度等级名称
            this.difficultyLevelENName = ""; //难度等级英文名
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
        }
        /**
         * 难度等级Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDifficultyLevelId(value) {
            if (value != undefined) {
                this.difficultyLevelId = value;
                this.hmProperty["difficultyLevelId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 难度等级名称(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDifficultyLevelName(value) {
            if (value != undefined) {
                this.difficultyLevelName = value;
                this.hmProperty["difficultyLevelName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 难度等级英文名(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDifficultyLevelENName(value) {
            if (value != undefined) {
                this.difficultyLevelENName = value;
                this.hmProperty["difficultyLevelENName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUser(value) {
            if (value != undefined) {
                this.updUser = value;
                this.hmProperty["updUser"] = true;
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
                case clsge_DifficultyLevelEN.con_DifficultyLevelId:
                    return this.difficultyLevelId;
                case clsge_DifficultyLevelEN.con_DifficultyLevelName:
                    return this.difficultyLevelName;
                case clsge_DifficultyLevelEN.con_DifficultyLevelENName:
                    return this.difficultyLevelENName;
                case clsge_DifficultyLevelEN.con_UpdDate:
                    return this.updDate;
                case clsge_DifficultyLevelEN.con_UpdUser:
                    return this.updUser;
                case clsge_DifficultyLevelEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ge_DifficultyLevel]中不存在！`;
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
                case clsge_DifficultyLevelEN.con_DifficultyLevelId:
                    this.difficultyLevelId = strValue;
                    this.hmProperty["difficultyLevelId"] = true;
                    break;
                case clsge_DifficultyLevelEN.con_DifficultyLevelName:
                    this.difficultyLevelName = strValue;
                    this.hmProperty["difficultyLevelName"] = true;
                    break;
                case clsge_DifficultyLevelEN.con_DifficultyLevelENName:
                    this.difficultyLevelENName = strValue;
                    this.hmProperty["difficultyLevelENName"] = true;
                    break;
                case clsge_DifficultyLevelEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsge_DifficultyLevelEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsge_DifficultyLevelEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[ge_DifficultyLevel]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"DifficultyLevelId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DifficultyLevelId() { return "difficultyLevelId"; } //难度等级Id
        /**
        * 常量:"DifficultyLevelName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DifficultyLevelName() { return "difficultyLevelName"; } //难度等级名称
        /**
        * 常量:"DifficultyLevelENName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DifficultyLevelENName() { return "difficultyLevelENName"; } //难度等级英文名
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
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
    exports.clsge_DifficultyLevelEN = clsge_DifficultyLevelEN;
    clsge_DifficultyLevelEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsge_DifficultyLevelEN.CacheModeId = "04"; //sessionStorage
    clsge_DifficultyLevelEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsge_DifficultyLevelEN.WhereFormat = ""; //条件格式串
    clsge_DifficultyLevelEN._CurrTabName = "ge_DifficultyLevel"; //当前表名,与该类相关的表名
    clsge_DifficultyLevelEN._KeyFldName = "DifficultyLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsge_DifficultyLevelEN.mintAttributeCount = 6;
    clsge_DifficultyLevelEN.AttributeName = ["difficultyLevelId", "difficultyLevelName", "difficultyLevelENName", "updDate", "updUser", "memo"];
    /**
    * 根据表内容设置enum列表
    * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GeneEnumConstList)
    **/
    class enumge_DifficultyLevel {
    }
    exports.enumge_DifficultyLevel = enumge_DifficultyLevel;
    /**
    * 简单
    **/
    enumge_DifficultyLevel.Easy_01 = "01";
    /**
    * 中等
    **/
    enumge_DifficultyLevel.Middle_02 = "02";
    /**
    * 困难
    **/
    enumge_DifficultyLevel.Difficulty_03 = "03";
});
