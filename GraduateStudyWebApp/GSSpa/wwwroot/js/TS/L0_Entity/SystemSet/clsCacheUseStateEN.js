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
    exports.clsCacheUseStateEN = void 0;
    /**
    * 类名:clsCacheUseStateEN
    * 表名:CacheUseState(01120689)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:45:56
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
    * 缓存使用状态(CacheUseState)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsCacheUseStateEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngmId = 0; //mId
            this.mstrUserId = ""; //用户ID
            this.mstrCacheModeId = ""; //缓存方式Id
            this.mstrCacheKey = ""; //缓存关键字
            this.mintCacheSize = 0; //缓存大小
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.mId = 0; //mId
            this.userId = ""; //用户ID
            this.cacheModeId = ""; //缓存方式Id
            this.cacheKey = ""; //缓存关键字
            this.cacheSize = 0; //缓存大小
            this.memo = ""; //备注
        }
        /**
         * mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetmId(value) {
            if (value != undefined) {
                this.mId = value;
                this.hmProperty["mId"] = true;
            }
        }
        /**
         * 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserId(value) {
            if (value != undefined) {
                this.userId = value;
                this.hmProperty["userId"] = true;
            }
        }
        /**
         * 缓存方式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCacheModeId(value) {
            if (value != undefined) {
                this.cacheModeId = value;
                this.hmProperty["cacheModeId"] = true;
            }
        }
        /**
         * 缓存关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCacheKey(value) {
            if (value != undefined) {
                this.cacheKey = value;
                this.hmProperty["cacheKey"] = true;
            }
        }
        /**
         * 缓存大小(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCacheSize(value) {
            if (value != undefined) {
                this.cacheSize = value;
                this.hmProperty["cacheSize"] = true;
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
                case clsCacheUseStateEN.con_mId:
                    return this.mId;
                case clsCacheUseStateEN.con_UserId:
                    return this.userId;
                case clsCacheUseStateEN.con_CacheModeId:
                    return this.cacheModeId;
                case clsCacheUseStateEN.con_CacheKey:
                    return this.cacheKey;
                case clsCacheUseStateEN.con_CacheSize:
                    return this.cacheSize;
                case clsCacheUseStateEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[CacheUseState]中不存在！`;
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
                case clsCacheUseStateEN.con_mId:
                    this.mId = Number(strValue);
                    this.hmProperty["mId"] = true;
                    break;
                case clsCacheUseStateEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case clsCacheUseStateEN.con_CacheModeId:
                    this.cacheModeId = strValue;
                    this.hmProperty["cacheModeId"] = true;
                    break;
                case clsCacheUseStateEN.con_CacheKey:
                    this.cacheKey = strValue;
                    this.hmProperty["cacheKey"] = true;
                    break;
                case clsCacheUseStateEN.con_CacheSize:
                    this.cacheSize = Number(strValue);
                    this.hmProperty["cacheSize"] = true;
                    break;
                case clsCacheUseStateEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[CacheUseState]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"mId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_mId() { return "mId"; } //mId
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"CacheModeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CacheModeId() { return "cacheModeId"; } //缓存方式Id
        /**
        * 常量:"CacheKey"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CacheKey() { return "cacheKey"; } //缓存关键字
        /**
        * 常量:"CacheSize"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CacheSize() { return "cacheSize"; } //缓存大小
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
    exports.clsCacheUseStateEN = clsCacheUseStateEN;
    clsCacheUseStateEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsCacheUseStateEN.CacheModeId = "04"; //sessionStorage
    clsCacheUseStateEN._CurrTabName = "CacheUseState"; //当前表名,与该类相关的表名
    clsCacheUseStateEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsCacheUseStateEN.mintAttributeCount = 6;
    clsCacheUseStateEN.AttributeName = ["mId", "userId", "cacheModeId", "cacheKey", "cacheSize", "memo"];
});
