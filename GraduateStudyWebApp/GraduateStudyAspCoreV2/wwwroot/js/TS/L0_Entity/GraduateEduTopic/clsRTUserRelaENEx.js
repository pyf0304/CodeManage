(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsRTUserRelaENEx = void 0;
    /**
    * 类名:clsRTUserRelaENEx
    * 表名:RTUserRela(01120582)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/15 23:43:43
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 主题用户关系(RTUserRela)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsRTUserRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js");
    class clsRTUserRelaENEx extends clsRTUserRelaEN_js_1.clsRTUserRelaEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.colorCode = ""; //颜色码
            this.collegeName = ""; //学院名称
            this.userName = ""; //用户名
            this.majorName = ""; //专业名称
            this.topicUserRoleName = ""; //主题用户角色
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
                case clsRTUserRelaENEx.con_ColorCode:
                    return this.colorCode;
                case clsRTUserRelaENEx.con_CollegeName:
                    return this.collegeName;
                case clsRTUserRelaENEx.con_UserName:
                    return this.userName;
                case clsRTUserRelaENEx.con_MajorName:
                    return this.majorName;
                case clsRTUserRelaENEx.con_TopicUserRoleName:
                    return this.topicUserRoleName;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"ColorCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ColorCode() { return "colorCode"; } //颜色码
        /**
        * 常量:"CollegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
        /**
        * 常量:"TopicUserRoleName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicUserRoleName() { return "topicUserRoleName"; } //主题用户角色
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
                case clsRTUserRelaENEx.con_ColorCode:
                    this.colorCode = strValue;
                    this.hmProperty["colorCode"] = true;
                    break;
                case clsRTUserRelaENEx.con_CollegeName:
                    this.collegeName = strValue;
                    this.hmProperty["collegeName"] = true;
                    break;
                case clsRTUserRelaENEx.con_UserName:
                    this.userName = strValue;
                    this.hmProperty["userName"] = true;
                    break;
                case clsRTUserRelaENEx.con_MajorName:
                    this.majorName = strValue;
                    this.hmProperty["majorName"] = true;
                    break;
                case clsRTUserRelaENEx.con_TopicUserRoleName:
                    this.topicUserRoleName = strValue;
                    this.hmProperty["topicUserRoleName"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[RTUserRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clsRTUserRelaENEx = clsRTUserRelaENEx;
});
