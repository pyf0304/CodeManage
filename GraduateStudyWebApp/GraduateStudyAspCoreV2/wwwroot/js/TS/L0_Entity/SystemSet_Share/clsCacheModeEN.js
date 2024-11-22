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
    exports.enumCacheMode = exports.clsCacheModeEN = void 0;
    /**
    * 类名:clsCacheModeEN
    * 表名:CacheMode(01120688)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:13:09
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
    * 缓存方式(CacheMode)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsCacheModeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrCacheModeId = ""; //缓存方式Id
            this.mstrCacheModeName = ""; //缓存方式名
            this.mstrCacheModeENName = ""; //缓存方式英文名
            this.mbolInUse = false; //是否在用
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.cacheModeId = ""; //缓存方式Id
            this.cacheModeName = ""; //缓存方式名
            this.cacheModeENName = ""; //缓存方式英文名
            this.inUse = false; //是否在用
            this.memo = ""; //备注
        }
        /**
         * 缓存方式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCacheModeId(value) {
            if (value != undefined) {
                this.cacheModeId = value;
                this.hmProperty["cacheModeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 缓存方式名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCacheModeName(value) {
            if (value != undefined) {
                this.cacheModeName = value;
                this.hmProperty["cacheModeName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 缓存方式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCacheModeENName(value) {
            if (value != undefined) {
                this.cacheModeENName = value;
                this.hmProperty["cacheModeENName"] = true;
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
                case clsCacheModeEN.con_CacheModeId:
                    return this.cacheModeId;
                case clsCacheModeEN.con_CacheModeName:
                    return this.cacheModeName;
                case clsCacheModeEN.con_CacheModeENName:
                    return this.cacheModeENName;
                case clsCacheModeEN.con_InUse:
                    return this.inUse;
                case clsCacheModeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[CacheMode]中不存在！`;
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
                case clsCacheModeEN.con_CacheModeId:
                    this.cacheModeId = strValue;
                    this.hmProperty["cacheModeId"] = true;
                    break;
                case clsCacheModeEN.con_CacheModeName:
                    this.cacheModeName = strValue;
                    this.hmProperty["cacheModeName"] = true;
                    break;
                case clsCacheModeEN.con_CacheModeENName:
                    this.cacheModeENName = strValue;
                    this.hmProperty["cacheModeENName"] = true;
                    break;
                case clsCacheModeEN.con_InUse:
                    this.inUse = Boolean(strValue);
                    this.hmProperty["inUse"] = true;
                    break;
                case clsCacheModeEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[CacheMode]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CacheModeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CacheModeId() { return "cacheModeId"; } //缓存方式Id
        /**
        * 常量:"CacheModeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CacheModeName() { return "cacheModeName"; } //缓存方式名
        /**
        * 常量:"CacheModeENName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CacheModeENName() { return "cacheModeENName"; } //缓存方式英文名
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
    exports.clsCacheModeEN = clsCacheModeEN;
    clsCacheModeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsCacheModeEN.CacheModeId = "03"; //localStorage
    clsCacheModeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsCacheModeEN.WhereFormat = ""; //条件格式串
    clsCacheModeEN._CurrTabName = "CacheMode"; //当前表名,与该类相关的表名
    clsCacheModeEN._KeyFldName = "CacheModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsCacheModeEN.mintAttributeCount = 5;
    clsCacheModeEN.AttributeName = ["cacheModeId", "cacheModeName", "cacheModeENName", "inUse", "memo"];
    /**
    * 根据表内容设置enum列表
    * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GeneEnumConstList)
    **/
    class enumCacheMode {
    }
    exports.enumCacheMode = enumCacheMode;
    /**
    * Web服务器缓存
    **/
    enumCacheMode.WebServerCache_01 = "01";
    /**
    * 客户端缓存
    **/
    enumCacheMode.ClientCache_02 = "02";
    /**
    * localStorage
    **/
    enumCacheMode.localStorage_03 = "03";
    /**
    * sessionStorage
    **/
    enumCacheMode.sessionStorage_04 = "04";
    /**
    * 未知
    **/
    enumCacheMode.UnKnown_05 = "05";
});
