(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTabV.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvcc_Course_SimEN = void 0;
    /**
    * 类名:clsvcc_Course_SimEN
    * 表名:vcc_Course_Sim(01120950)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 00:07:59
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:课程管理(CourseManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * vcc_Course_Sim(vcc_Course_Sim)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvcc_Course_SimEN extends clsGeneralTabV_js_1.clsGeneralTabV {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.courseId = ""; //课程Id
            this.courseCode = ""; //课程代码
            this.courseName = ""; //课程名称
            this.orderNum = 0; //序号
            this.courseTypeID = ""; //课程类型ID
            this.id_XzMajor = ""; //专业流水号
            this.id_XzCollege = ""; //学院流水号
            this.excellentTypeId = ""; //精品课程类型Id
        }
        /**
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsvcc_Course_SimEN.con_CourseId:
                    return this.courseId;
                case clsvcc_Course_SimEN.con_CourseCode:
                    return this.courseCode;
                case clsvcc_Course_SimEN.con_CourseName:
                    return this.courseName;
                case clsvcc_Course_SimEN.con_OrderNum:
                    return this.orderNum;
                case clsvcc_Course_SimEN.con_CourseTypeID:
                    return this.courseTypeID;
                case clsvcc_Course_SimEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvcc_Course_SimEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvcc_Course_SimEN.con_ExcellentTypeId:
                    return this.excellentTypeId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vcc_Course_Sim]中不存在！`;
                    console.error(strMsg);
                    return "";
            }
        }
        /**
         * 设置对象中某字段名的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetFldValue)
         * @param strFldName:字段名
         * @param strValue:字段值
         * @returns 字段值
        */
        SetFldValue(strFldName, strValue) {
            const strThisFuncName = "SetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsvcc_Course_SimEN.con_CourseId:
                    this.courseId = strValue;
                    break;
                case clsvcc_Course_SimEN.con_CourseCode:
                    this.courseCode = strValue;
                    break;
                case clsvcc_Course_SimEN.con_CourseName:
                    this.courseName = strValue;
                    break;
                case clsvcc_Course_SimEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvcc_Course_SimEN.con_CourseTypeID:
                    this.courseTypeID = strValue;
                    break;
                case clsvcc_Course_SimEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvcc_Course_SimEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvcc_Course_SimEN.con_ExcellentTypeId:
                    this.excellentTypeId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vcc_Course_Sim]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"CourseCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseCode() { return "courseCode"; } //课程代码
        /**
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"CourseTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseTypeID() { return "courseTypeID"; } //课程类型ID
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"ExcellentTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExcellentTypeId() { return "excellentTypeId"; } //精品课程类型Id
        /**
        * 设置条件字段值.
        * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetCondFldValue)
        * @param strFldName:字段名
        * @param strFldValue:字段值
        * @param strComparisonOp:比较操作条符
        * @returns 根据关键字获取的名称
        **/
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            const strThisFuncName = this.SetCondFldValue.name;
            this.SetFldValue(strFldName, strFldValue);
            if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        }
    }
    exports.clsvcc_Course_SimEN = clsvcc_Course_SimEN;
    clsvcc_Course_SimEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvcc_Course_SimEN.CacheModeId = "03"; //localStorage
    clsvcc_Course_SimEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvcc_Course_SimEN.WhereFormat = ""; //条件格式串
    clsvcc_Course_SimEN._CurrTabName = "vcc_Course_Sim"; //当前表名,与该类相关的表名
    clsvcc_Course_SimEN._KeyFldName = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvcc_Course_SimEN.mintAttributeCount = 8;
    clsvcc_Course_SimEN.AttributeName = ["courseId", "courseCode", "courseName", "orderNum", "courseTypeID", "id_XzMajor", "id_XzCollege", "excellentTypeId"];
});
