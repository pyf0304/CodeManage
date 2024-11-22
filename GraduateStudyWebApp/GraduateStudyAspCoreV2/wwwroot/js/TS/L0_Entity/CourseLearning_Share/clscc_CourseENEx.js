(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/CourseLearning_Share/clscc_CourseEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clscc_CourseENEx = void 0;
    /**
    * 类名:clscc_CourseENEx
    * 表名:cc_Course(01120056)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:13:21
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:课程学习(CourseLearning)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 课程(cc_Course)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clscc_CourseEN_js_1 = require("../../L0_Entity/CourseLearning_Share/clscc_CourseEN.js");
    class clscc_CourseENEx extends clscc_CourseEN_js_1.clscc_CourseEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.schoolName = ""; //学校名称
            this.majorName = ""; //专业名称
            this.collegeName = ""; //学院名称
            this.excellentTypeName = ""; //精品课程类型名称
            this.courseTypeName = ""; //课程类型名称
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
                case clscc_CourseENEx.con_SchoolName:
                    return this.schoolName;
                case clscc_CourseENEx.con_MajorName:
                    return this.majorName;
                case clscc_CourseENEx.con_CollegeName:
                    return this.collegeName;
                case clscc_CourseENEx.con_ExcellentTypeName:
                    return this.excellentTypeName;
                case clscc_CourseENEx.con_CourseTypeName:
                    return this.courseTypeName;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"SchoolName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolName() { return "schoolName"; } //学校名称
        /**
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
        /**
        * 常量:"CollegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
        /**
        * 常量:"ExcellentTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExcellentTypeName() { return "excellentTypeName"; } //精品课程类型名称
        /**
        * 常量:"CourseTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseTypeName() { return "courseTypeName"; } //课程类型名称
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
                case clscc_CourseENEx.con_SchoolName:
                    this.schoolName = strValue;
                    this.hmProperty["schoolName"] = true;
                    break;
                case clscc_CourseENEx.con_MajorName:
                    this.majorName = strValue;
                    this.hmProperty["majorName"] = true;
                    break;
                case clscc_CourseENEx.con_CollegeName:
                    this.collegeName = strValue;
                    this.hmProperty["collegeName"] = true;
                    break;
                case clscc_CourseENEx.con_ExcellentTypeName:
                    this.excellentTypeName = strValue;
                    this.hmProperty["excellentTypeName"] = true;
                    break;
                case clscc_CourseENEx.con_CourseTypeName:
                    this.courseTypeName = strValue;
                    this.hmProperty["courseTypeName"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_Course]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clscc_CourseENEx = clscc_CourseENEx;
});
