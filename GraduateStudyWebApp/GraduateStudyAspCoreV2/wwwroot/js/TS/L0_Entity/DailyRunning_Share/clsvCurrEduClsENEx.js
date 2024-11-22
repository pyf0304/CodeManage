(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvCurrEduClsENEx = void 0;
    /**
    * 类名:clsvCurrEduClsENEx
    * 表名:vCurrEduCls(01120126)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 02:45:32
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:日常运行(DailyRunning)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * v当前教学班(vCurrEduCls)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsvCurrEduClsEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js");
    class clsvCurrEduClsENEx extends clsvCurrEduClsEN_js_1.clsvCurrEduClsEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.userName = ""; //用户名
            this.teachingDate = ""; //教学时期
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
                case clsvCurrEduClsENEx.con_UserName:
                    return this.userName;
                case clsvCurrEduClsENEx.con_TeachingDate:
                    return this.teachingDate;
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
        * 常量:"TeachingDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeachingDate() { return "teachingDate"; } //教学时期
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
                case clsvCurrEduClsENEx.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvCurrEduClsENEx.con_TeachingDate:
                    this.teachingDate = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduCls]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clsvCurrEduClsENEx = clsvCurrEduClsENEx;
});
