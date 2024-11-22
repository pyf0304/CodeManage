(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsCurrEduClsENEx = void 0;
    /**
    * 类名:clsCurrEduClsENEx
    * 表名:CurrEduCls(01120123)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 02:45:25
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
    * 当前教学班(CurrEduCls)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsCurrEduClsEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js");
    class clsCurrEduClsENEx extends clsCurrEduClsEN_js_1.clsCurrEduClsEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.collegeName = ""; //学院名称
            this.gradeBaseName = ""; //年级名称
            this.courseName = ""; //课程名称
            this.courseCode = ""; //课程代码
            this.classRoomTypeDesc = ""; //教室类型描述
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
                case clsCurrEduClsENEx.con_CollegeName:
                    return this.collegeName;
                case clsCurrEduClsENEx.con_GradeBaseName:
                    return this.gradeBaseName;
                case clsCurrEduClsENEx.con_CourseName:
                    return this.courseName;
                case clsCurrEduClsENEx.con_CourseCode:
                    return this.courseCode;
                case clsCurrEduClsENEx.con_ClassRoomTypeDesc:
                    return this.classRoomTypeDesc;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"CollegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
        /**
        * 常量:"GradeBaseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GradeBaseName() { return "gradeBaseName"; } //年级名称
        /**
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
        /**
        * 常量:"CourseCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseCode() { return "courseCode"; } //课程代码
        /**
        * 常量:"ClassRoomTypeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ClassRoomTypeDesc() { return "classRoomTypeDesc"; } //教室类型描述
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
                case clsCurrEduClsENEx.con_CollegeName:
                    this.collegeName = strValue;
                    this.hmProperty["collegeName"] = true;
                    break;
                case clsCurrEduClsENEx.con_GradeBaseName:
                    this.gradeBaseName = strValue;
                    this.hmProperty["gradeBaseName"] = true;
                    break;
                case clsCurrEduClsENEx.con_CourseName:
                    this.courseName = strValue;
                    this.hmProperty["courseName"] = true;
                    break;
                case clsCurrEduClsENEx.con_CourseCode:
                    this.courseCode = strValue;
                    this.hmProperty["courseCode"] = true;
                    break;
                case clsCurrEduClsENEx.con_ClassRoomTypeDesc:
                    this.classRoomTypeDesc = strValue;
                    this.hmProperty["classRoomTypeDesc"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[CurrEduCls]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clsCurrEduClsENEx = clsCurrEduClsENEx;
});
