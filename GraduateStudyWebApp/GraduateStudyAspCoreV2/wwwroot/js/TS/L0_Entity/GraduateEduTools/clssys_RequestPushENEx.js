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
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:48:35
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
            this.courseId = ""; //课程Id
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
                case clssys_RequestPushENEx.con_CourseId:
                    return this.courseId;
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
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
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
                case clssys_RequestPushENEx.con_UserName:
                    this.userName = strValue;
                    this.hmProperty["userName"] = true;
                    break;
                case clssys_RequestPushENEx.con_EduClsName:
                    this.eduClsName = strValue;
                    this.hmProperty["eduClsName"] = true;
                    break;
                case clssys_RequestPushENEx.con_CourseId:
                    this.courseId = strValue;
                    this.hmProperty["courseId"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[sys_RequestPush]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clssys_RequestPushENEx = clssys_RequestPushENEx;
});
