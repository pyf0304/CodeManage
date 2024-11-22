(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTabV.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvCacheUseStateEN = void 0;
    /**
    * 类名:clsvCacheUseStateEN
    * 表名:vCacheUseState(01120690)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:13:02
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
    * vCacheUseState(vCacheUseState)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvCacheUseStateEN extends clsGeneralTabV_js_1.clsGeneralTabV {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.mId = 0; //mId
            this.userId = ""; //用户ID
            this.cacheModeId = ""; //缓存方式Id
            this.cacheModeName = ""; //缓存方式名
            this.cacheModeENName = ""; //缓存方式英文名
            this.cacheKey = ""; //缓存关键字
            this.cacheSize = 0; //缓存大小
            this.memo = ""; //备注
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
                case clsvCacheUseStateEN.con_mId:
                    return this.mId;
                case clsvCacheUseStateEN.con_UserId:
                    return this.userId;
                case clsvCacheUseStateEN.con_CacheModeId:
                    return this.cacheModeId;
                case clsvCacheUseStateEN.con_CacheModeName:
                    return this.cacheModeName;
                case clsvCacheUseStateEN.con_CacheModeENName:
                    return this.cacheModeENName;
                case clsvCacheUseStateEN.con_CacheKey:
                    return this.cacheKey;
                case clsvCacheUseStateEN.con_CacheSize:
                    return this.cacheSize;
                case clsvCacheUseStateEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vCacheUseState]中不存在！`;
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
                case clsvCacheUseStateEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvCacheUseStateEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvCacheUseStateEN.con_CacheModeId:
                    this.cacheModeId = strValue;
                    break;
                case clsvCacheUseStateEN.con_CacheModeName:
                    this.cacheModeName = strValue;
                    break;
                case clsvCacheUseStateEN.con_CacheModeENName:
                    this.cacheModeENName = strValue;
                    break;
                case clsvCacheUseStateEN.con_CacheKey:
                    this.cacheKey = strValue;
                    break;
                case clsvCacheUseStateEN.con_CacheSize:
                    this.cacheSize = Number(strValue);
                    break;
                case clsvCacheUseStateEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vCacheUseState]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
    exports.clsvCacheUseStateEN = clsvCacheUseStateEN;
    clsvCacheUseStateEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvCacheUseStateEN.CacheModeId = "04"; //sessionStorage
    clsvCacheUseStateEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvCacheUseStateEN.WhereFormat = ""; //条件格式串
    clsvCacheUseStateEN._CurrTabName = "vCacheUseState"; //当前表名,与该类相关的表名
    clsvCacheUseStateEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvCacheUseStateEN.mintAttributeCount = 8;
    clsvCacheUseStateEN.AttributeName = ["mId", "userId", "cacheModeId", "cacheModeName", "cacheModeENName", "cacheKey", "cacheSize", "memo"];
});
