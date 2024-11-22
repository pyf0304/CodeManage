(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsMajorDirectionPaperRelaENEx = void 0;
    /**
    * 类名:clsMajorDirectionPaperRelaENEx
    * 表名:MajorDirectionPaperRela(01120554)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:55:08
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
    * 专业方向论文关系(MajorDirectionPaperRela)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsMajorDirectionPaperRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js");
    class clsMajorDirectionPaperRelaENEx extends clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.id_XzMajor = ""; //专业流水号
            this.majorName = ""; //专业名称
            this.majorDirectionName = ""; //研究方向名
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
                case clsMajorDirectionPaperRelaENEx.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsMajorDirectionPaperRelaENEx.con_MajorName:
                    return this.majorName;
                case clsMajorDirectionPaperRelaENEx.con_MajorDirectionName:
                    return this.majorDirectionName;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
        /**
        * 常量:"MajorDirectionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirectionName() { return "majorDirectionName"; } //研究方向名
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
                case clsMajorDirectionPaperRelaENEx.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    this.hmProperty["id_XzMajor"] = true;
                    break;
                case clsMajorDirectionPaperRelaENEx.con_MajorName:
                    this.majorName = strValue;
                    this.hmProperty["majorName"] = true;
                    break;
                case clsMajorDirectionPaperRelaENEx.con_MajorDirectionName:
                    this.majorDirectionName = strValue;
                    this.hmProperty["majorDirectionName"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[MajorDirectionPaperRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clsMajorDirectionPaperRelaENEx = clsMajorDirectionPaperRelaENEx;
});
