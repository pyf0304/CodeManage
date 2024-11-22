(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/BaseInfo_Share/clsvQuestionnaire_SimEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvQuestionnaire_SimENEx = void 0;
    /**
    * 类名:clsvQuestionnaire_SimENEx
    * 表名:vQuestionnaire_Sim(01120949)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 18:31:55
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:基本信息(BaseInfo)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * vQuestionnaire_Sim(vQuestionnaire_Sim)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsvQuestionnaire_SimEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsvQuestionnaire_SimEN.js");
    class clsvQuestionnaire_SimENEx extends clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
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
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
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
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vQuestionnaire_Sim]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clsvQuestionnaire_SimENEx = clsvQuestionnaire_SimENEx;
});