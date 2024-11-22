(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/Knowledges/clsgs_KnowledgesLogicEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_KnowledgesLogicENEx = void 0;
    /**
    * 类名:clsgs_KnowledgesLogicENEx
    * 表名:gs_KnowledgesLogic(01120872)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/15 23:43:54
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:知识点相关(Knowledges)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 知识点逻辑(gs_KnowledgesLogic)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsgs_KnowledgesLogicEN_js_1 = require("../../L0_Entity/Knowledges/clsgs_KnowledgesLogicEN.js");
    class clsgs_KnowledgesLogicENEx extends clsgs_KnowledgesLogicEN_js_1.clsgs_KnowledgesLogicEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.knowledgeName = ""; //知识点名称
            this.courseName = ""; //课程名称
            this.knowledgeGraphName = ""; //连连看图名
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
                case clsgs_KnowledgesLogicENEx.con_KnowledgeName:
                    return this.knowledgeName;
                case clsgs_KnowledgesLogicENEx.con_CourseName:
                    return this.courseName;
                case clsgs_KnowledgesLogicENEx.con_KnowledgeGraphName:
                    return this.knowledgeGraphName;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"KnowledgeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeName() { return "knowledgeName"; } //知识点名称
        /**
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
        /**
        * 常量:"KnowledgeGraphName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeGraphName() { return "knowledgeGraphName"; } //连连看图名
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
                case clsgs_KnowledgesLogicENEx.con_KnowledgeName:
                    this.knowledgeName = strValue;
                    this.hmProperty["knowledgeName"] = true;
                    break;
                case clsgs_KnowledgesLogicENEx.con_CourseName:
                    this.courseName = strValue;
                    this.hmProperty["courseName"] = true;
                    break;
                case clsgs_KnowledgesLogicENEx.con_KnowledgeGraphName:
                    this.knowledgeGraphName = strValue;
                    this.hmProperty["knowledgeGraphName"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesLogic]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clsgs_KnowledgesLogicENEx = clsgs_KnowledgesLogicENEx;
});
