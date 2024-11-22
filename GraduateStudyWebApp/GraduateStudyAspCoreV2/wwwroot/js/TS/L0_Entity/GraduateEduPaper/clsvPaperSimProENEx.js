(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsvPaperSimProEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvPaperSimProENEx = void 0;
    /**
    * 类名:clsvPaperSimProENEx
    * 表名:vPaperSimPro(01120944)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:44:32
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * vPaperSimPro(vPaperSimPro)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsvPaperSimProEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperSimProEN.js");
    class clsvPaperSimProENEx extends clsvPaperSimProEN_js_1.clsvPaperSimProEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.id_CurrEduCls = ""; //教学班流水号
            this.paperTitle_Author = ""; //论文标题作者
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
                case clsvPaperSimProENEx.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvPaperSimProENEx.con_PaperTitle_Author:
                    return this.paperTitle_Author;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"PaperTitle_Author"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle_Author() { return "paperTitle_Author"; } //论文标题作者
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
                case clsvPaperSimProENEx.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvPaperSimProENEx.con_PaperTitle_Author:
                    this.paperTitle_Author = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vPaperSimPro]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clsvPaperSimProENEx = clsvPaperSimProENEx;
});
