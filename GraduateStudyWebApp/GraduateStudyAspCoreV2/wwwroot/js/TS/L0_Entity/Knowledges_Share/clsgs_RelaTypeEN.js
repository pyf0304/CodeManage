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
    exports.enumgs_RelaType = exports.clsgs_RelaTypeEN = void 0;
    /**
    * 类名:clsgs_RelaTypeEN
    * 表名:gs_RelaType(01120871)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 02:45:39
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:知识点相关(Knowledges)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 知识点关系类型表(gs_RelaType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_RelaTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrRelaTypeId = ""; //关系类型Id
            this.mstrRelaTypeName = ""; //关系类型名
            this.mstrRelaTypeENName = ""; //关系类型英文名
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            this.mstrUpdUser = ""; //修改人
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.relaTypeId = ""; //关系类型Id
            this.relaTypeName = ""; //关系类型名
            this.relaTypeENName = ""; //关系类型英文名
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.updUser = ""; //修改人
        }
        /**
         * 关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRelaTypeId(value) {
            if (value != undefined) {
                this.relaTypeId = value;
                this.hmProperty["relaTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 关系类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRelaTypeName(value) {
            if (value != undefined) {
                this.relaTypeName = value;
                this.hmProperty["relaTypeName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 关系类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRelaTypeENName(value) {
            if (value != undefined) {
                this.relaTypeENName = value;
                this.hmProperty["relaTypeENName"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsgs_RelaTypeEN.con_RelaTypeId:
                    return this.relaTypeId;
                case clsgs_RelaTypeEN.con_RelaTypeName:
                    return this.relaTypeName;
                case clsgs_RelaTypeEN.con_RelaTypeENName:
                    return this.relaTypeENName;
                case clsgs_RelaTypeEN.con_UpdDate:
                    return this.updDate;
                case clsgs_RelaTypeEN.con_Memo:
                    return this.memo;
                case clsgs_RelaTypeEN.con_UpdUser:
                    return this.updUser;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_RelaType]中不存在！`;
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
                case clsgs_RelaTypeEN.con_RelaTypeId:
                    this.relaTypeId = strValue;
                    this.hmProperty["relaTypeId"] = true;
                    break;
                case clsgs_RelaTypeEN.con_RelaTypeName:
                    this.relaTypeName = strValue;
                    this.hmProperty["relaTypeName"] = true;
                    break;
                case clsgs_RelaTypeEN.con_RelaTypeENName:
                    this.relaTypeENName = strValue;
                    this.hmProperty["relaTypeENName"] = true;
                    break;
                case clsgs_RelaTypeEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_RelaTypeEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_RelaTypeEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_RelaType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"RelaTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RelaTypeId() { return "relaTypeId"; } //关系类型Id
        /**
        * 常量:"RelaTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RelaTypeName() { return "relaTypeName"; } //关系类型名
        /**
        * 常量:"RelaTypeENName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RelaTypeENName() { return "relaTypeENName"; } //关系类型英文名
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
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
    exports.clsgs_RelaTypeEN = clsgs_RelaTypeEN;
    clsgs_RelaTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_RelaTypeEN.CacheModeId = "04"; //sessionStorage
    clsgs_RelaTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_RelaTypeEN.WhereFormat = ""; //条件格式串
    clsgs_RelaTypeEN._CurrTabName = "gs_RelaType"; //当前表名,与该类相关的表名
    clsgs_RelaTypeEN._KeyFldName = "RelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_RelaTypeEN.mintAttributeCount = 6;
    clsgs_RelaTypeEN.AttributeName = ["relaTypeId", "relaTypeName", "relaTypeENName", "updDate", "memo", "updUser"];
    /**
    * 根据表内容设置enum列表
    * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GeneEnumConstList)
    **/
    class enumgs_RelaType {
    }
    exports.enumgs_RelaType = enumgs_RelaType;
    /**
    * 相关
    **/
    enumgs_RelaType.Related_01 = "01";
    /**
    * 包含
    **/
    enumgs_RelaType.Include_02 = "02";
});
