(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduTools/clssys_RequestPushEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clssys_RequestPushENEx = void 0;
    /**
    * 类名:clssys_RequestPushENEx
    * 表名:sys_RequestPush(01120726)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:47:11
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培设置(GraduateEduTools)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 请求推送表(sys_RequestPush)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clssys_RequestPushEN_js_1 = require("../../L0_Entity/GraduateEduTools/clssys_RequestPushEN.js");
    class clssys_RequestPushENEx extends clssys_RequestPushEN_js_1.clssys_RequestPushEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.userName = ""; //用户名
            this.eduClsName = ""; //教学班名
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
                case clssys_RequestPushENEx.con_UserName:
                    return this.userName;
                case clssys_RequestPushENEx.con_EduClsName:
                    return this.eduClsName;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"EduClsName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsName() { return "eduClsName"; } //教学班名
    }
    exports.clssys_RequestPushENEx = clssys_RequestPushENEx;
});
