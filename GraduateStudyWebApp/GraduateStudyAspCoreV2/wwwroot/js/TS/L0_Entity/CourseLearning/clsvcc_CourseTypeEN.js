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
    exports.clsvcc_CourseTypeEN = void 0;
    /**
    * 类名:clsvcc_CourseTypeEN
    * 表名:vcc_CourseType(01120059)
    * 版本:2023.02.24.1(服务器:WIN-SRV103-116)
    * 日期:2023/02/24 13:49:06
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:课程学习(CourseLearning)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v课程类型(vcc_CourseType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvcc_CourseTypeEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.courseTypeID = ""; //课程类型ID
            this.courseTypeName = ""; //课程类型名称
            this.id_School = ""; //学校流水号
            this.schoolId = ""; //学校编号
            this.schoolName = ""; //学校名称
            this.isUse = false; //是否使用
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.memo = ""; //备注
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
                case clsvcc_CourseTypeEN.con_CourseTypeID:
                    return this.courseTypeID;
                case clsvcc_CourseTypeEN.con_CourseTypeName:
                    return this.courseTypeName;
                case clsvcc_CourseTypeEN.con_id_School:
                    return this.id_School;
                case clsvcc_CourseTypeEN.con_SchoolId:
                    return this.schoolId;
                case clsvcc_CourseTypeEN.con_SchoolName:
                    return this.schoolName;
                case clsvcc_CourseTypeEN.con_IsUse:
                    return this.isUse;
                case clsvcc_CourseTypeEN.con_UpdDate:
                    return this.updDate;
                case clsvcc_CourseTypeEN.con_UpdUserId:
                    return this.updUserId;
                case clsvcc_CourseTypeEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vcc_CourseType]中不存在！`;
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
                case clsvcc_CourseTypeEN.con_CourseTypeID:
                    this.courseTypeID = strValue;
                    break;
                case clsvcc_CourseTypeEN.con_CourseTypeName:
                    this.courseTypeName = strValue;
                    break;
                case clsvcc_CourseTypeEN.con_id_School:
                    this.id_School = strValue;
                    break;
                case clsvcc_CourseTypeEN.con_SchoolId:
                    this.schoolId = strValue;
                    break;
                case clsvcc_CourseTypeEN.con_SchoolName:
                    this.schoolName = strValue;
                    break;
                case clsvcc_CourseTypeEN.con_IsUse:
                    this.isUse = Boolean(strValue);
                    break;
                case clsvcc_CourseTypeEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvcc_CourseTypeEN.con_UpdUserId:
                    this.updUserId = strValue;
                    break;
                case clsvcc_CourseTypeEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vcc_CourseType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CourseTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseTypeID() { return "courseTypeID"; } //课程类型ID
        /**
        * 常量:"CourseTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseTypeName() { return "courseTypeName"; } //课程类型名称
        /**
        * 常量:"id_School"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_School() { return "id_School"; } //学校流水号
        /**
        * 常量:"SchoolId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolId() { return "schoolId"; } //学校编号
        /**
        * 常量:"SchoolName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolName() { return "schoolName"; } //学校名称
        /**
        * 常量:"IsUse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsUse() { return "isUse"; } //是否使用
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"UpdUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUserId() { return "updUserId"; } //修改用户Id
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
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
    exports.clsvcc_CourseTypeEN = clsvcc_CourseTypeEN;
    clsvcc_CourseTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvcc_CourseTypeEN.CacheModeId = "05"; //未知
    clsvcc_CourseTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvcc_CourseTypeEN.WhereFormat = ""; //条件格式串
    clsvcc_CourseTypeEN._CurrTabName = "vcc_CourseType"; //当前表名,与该类相关的表名
    clsvcc_CourseTypeEN._KeyFldName = "CourseTypeID"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvcc_CourseTypeEN.mintAttributeCount = 9;
    clsvcc_CourseTypeEN.AttributeName = ["courseTypeID", "courseTypeName", "id_School", "schoolId", "schoolName", "isUse", "updDate", "updUserId", "memo"];
});
