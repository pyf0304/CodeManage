(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/InteractManage/clsgs_TagsEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_TagsENEx = void 0;
    /**
    * 类名:clsgs_TagsENEx
    * 表名:gs_Tags(01120714)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:14
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:互动管理(InteractManage)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 标注(gs_Tags)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsgs_TagsEN_js_1 = require("../../L0_Entity/InteractManage/clsgs_TagsEN.js");
    class clsgs_TagsENEx extends clsgs_TagsEN_js_1.clsgs_TagsEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.paperTitle = ""; //论文标题
            this.userName = ""; //用户名
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
                case clsgs_TagsENEx.con_PaperTitle:
                    return this.paperTitle;
                case clsgs_TagsENEx.con_UserName:
                    return this.userName;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
    }
    exports.clsgs_TagsENEx = clsgs_TagsENEx;
});
