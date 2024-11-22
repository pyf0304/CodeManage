(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/SystemSet_Share/clsCacheUseStateEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsCacheUseStateENEx = void 0;
    /**
    * 类名:clsCacheUseStateENEx
    * 表名:CacheUseState(01120689)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:13:08
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:系统设置(SystemSet)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 缓存使用状态(CacheUseState)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsCacheUseStateEN_js_1 = require("../../L0_Entity/SystemSet_Share/clsCacheUseStateEN.js");
    class clsCacheUseStateENEx extends clsCacheUseStateEN_js_1.clsCacheUseStateEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.cacheModeName = ""; //缓存方式名
            this.cacheModeENName = ""; //缓存方式英文名
        }
        /**
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayerEx4TypeScript:Gen_ENEx_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            switch (strFldName) {
                case "CtrlId":
                    return "";
                case clsCacheUseStateENEx.con_CacheModeName:
                    return this.cacheModeName;
                case clsCacheUseStateENEx.con_CacheModeENName:
                    return this.cacheModeENName;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
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
         * 设置对象中某字段名的值.
         * (AutoGCLib.EntityLayerEx4TypeScript:Gen_ENEx_SetFldValue)
         * @param strFldName:字段名
         * @param strValue:字段值
         * @returns 字段值
        */
        SetFldValue(strFldName, strValue) {
            const strThisFuncName = "SetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsCacheUseStateENEx.con_CacheModeName:
                    this.cacheModeName = strValue;
                    this.hmProperty["cacheModeName"] = true;
                    break;
                case clsCacheUseStateENEx.con_CacheModeENName:
                    this.cacheModeENName = strValue;
                    this.hmProperty["cacheModeENName"] = true;
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
    }
    exports.clsCacheUseStateENEx = clsCacheUseStateENEx;
});
