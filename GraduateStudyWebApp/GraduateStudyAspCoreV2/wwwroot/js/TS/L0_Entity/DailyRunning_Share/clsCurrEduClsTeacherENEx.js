(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsTeacherEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsCurrEduClsTeacherENEx = void 0;
    /**
    * 类名:clsCurrEduClsTeacherENEx
    * 表名:CurrEduClsTeacher(01120124)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 02:45:28
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
    * 当前教学班教师(CurrEduClsTeacher)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsCurrEduClsTeacherEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsTeacherEN.js");
    class clsCurrEduClsTeacherENEx extends clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.collegeName = ""; //学院名称
            this.teacherID = ""; //教师工号
            this.teacherName = ""; //教师姓名
            this.eduClsName = ""; //教学班名
            this.courseName = ""; //课程名称
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
                case clsCurrEduClsTeacherENEx.con_CollegeName:
                    return this.collegeName;
                case clsCurrEduClsTeacherENEx.con_TeacherID:
                    return this.teacherID;
                case clsCurrEduClsTeacherENEx.con_TeacherName:
                    return this.teacherName;
                case clsCurrEduClsTeacherENEx.con_EduClsName:
                    return this.eduClsName;
                case clsCurrEduClsTeacherENEx.con_CourseName:
                    return this.courseName;
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
        * 常量:"TeacherID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeacherID() { return "teacherID"; } //教师工号
        /**
        * 常量:"TeacherName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeacherName() { return "teacherName"; } //教师姓名
        /**
        * 常量:"EduClsName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsName() { return "eduClsName"; } //教学班名
        /**
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
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
                case clsCurrEduClsTeacherENEx.con_CollegeName:
                    this.collegeName = strValue;
                    this.hmProperty["collegeName"] = true;
                    break;
                case clsCurrEduClsTeacherENEx.con_TeacherID:
                    this.teacherID = strValue;
                    this.hmProperty["teacherID"] = true;
                    break;
                case clsCurrEduClsTeacherENEx.con_TeacherName:
                    this.teacherName = strValue;
                    this.hmProperty["teacherName"] = true;
                    break;
                case clsCurrEduClsTeacherENEx.con_EduClsName:
                    this.eduClsName = strValue;
                    this.hmProperty["eduClsName"] = true;
                    break;
                case clsCurrEduClsTeacherENEx.con_CourseName:
                    this.courseName = strValue;
                    this.hmProperty["courseName"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[CurrEduClsTeacher]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clsCurrEduClsTeacherENEx = clsCurrEduClsTeacherENEx;
});
