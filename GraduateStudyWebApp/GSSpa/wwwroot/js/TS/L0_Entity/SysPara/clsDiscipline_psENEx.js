(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/SysPara/clsDiscipline_psEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsDiscipline_psENEx = void 0;
    /**
    * 类名:clsDiscipline_psENEx
    * 表名:Discipline_ps(01120100)
    * 生成代码版本:2021.09.17.1
    * 生成日期:2021/09/20 16:16:15
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
    * 学科_ps(Discipline_ps)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsDiscipline_psEN_js_1 = require("../../L0_Entity/SysPara/clsDiscipline_psEN.js");
    class clsDiscipline_psENEx extends clsDiscipline_psEN_js_1.clsDiscipline_psEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
        }
    }
    exports.clsDiscipline_psENEx = clsDiscipline_psENEx;
});
