(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/Other/clsPaperSubViewpointLikeLogEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsPaperSubViewpointLikeLogENEx = void 0;
    /**
    * 类名:clsPaperSubViewpointLikeLogENEx
    * 表名:PaperSubViewpointLikeLog(01120560)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:43:38
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:其他(Other)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 子观点点赞表(PaperSubViewpointLikeLog)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsPaperSubViewpointLikeLogEN_js_1 = require("../../L0_Entity/Other/clsPaperSubViewpointLikeLogEN.js");
    class clsPaperSubViewpointLikeLogENEx extends clsPaperSubViewpointLikeLogEN_js_1.clsPaperSubViewpointLikeLogEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.explainContent = ""; //说明内容
            this.rwTitle = ""; //读写标题
            this.subViewpointContent = ""; //详情内容
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
                case clsPaperSubViewpointLikeLogENEx.con_ExplainContent:
                    return this.explainContent;
                case clsPaperSubViewpointLikeLogENEx.con_RWTitle:
                    return this.rwTitle;
                case clsPaperSubViewpointLikeLogENEx.con_SubViewpointContent:
                    return this.subViewpointContent;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"ExplainContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExplainContent() { return "explainContent"; } //说明内容
        /**
        * 常量:"RWTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RWTitle() { return "rwTitle"; } //读写标题
        /**
        * 常量:"SubViewpointContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SubViewpointContent() { return "subViewpointContent"; } //详情内容
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
                case clsPaperSubViewpointLikeLogENEx.con_ExplainContent:
                    this.explainContent = strValue;
                    this.hmProperty["explainContent"] = true;
                    break;
                case clsPaperSubViewpointLikeLogENEx.con_RWTitle:
                    this.rwTitle = strValue;
                    this.hmProperty["rwTitle"] = true;
                    break;
                case clsPaperSubViewpointLikeLogENEx.con_SubViewpointContent:
                    this.subViewpointContent = strValue;
                    this.hmProperty["subViewpointContent"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[PaperSubViewpointLikeLog]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clsPaperSubViewpointLikeLogENEx = clsPaperSubViewpointLikeLogENEx;
});
