(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/SysPara/clsRsEthnicEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsRsEthnicENEx = void 0;
    /**
    * 类名:clsRsEthnicENEx
    * 表名:RsEthnic(01120105)
    * 生成代码版本:2021.09.17.1
    * 生成日期:2021/09/20 16:16:20
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:系统参数
    * 模块英文名:SysPara
    * 框架-层名:实体扩展层(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 民族(RsEthnic)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsRsEthnicEN_js_1 = require("../../L0_Entity/SysPara/clsRsEthnicEN.js");
    class clsRsEthnicENEx extends clsRsEthnicEN_js_1.clsRsEthnicEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
        }
    }
    exports.clsRsEthnicENEx = clsRsEthnicENEx;
});
