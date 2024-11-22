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
    exports.clsvCurrEduCls_SimEN = void 0;
    /**
    * 类名:clsvCurrEduCls_SimEN
    * 表名:vCurrEduCls_Sim(01120951)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 02:45:46
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:日常运行(DailyRunning)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * vCurrEduCls_Sim(vCurrEduCls_Sim)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvCurrEduCls_SimEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.id_CurrEduCls = ""; //教学班流水号
            this.currEduClsId = ""; //教学班Id
            this.eduClsName = ""; //教学班名
            this.eduClsTypeId = ""; //教学班类型Id
            this.courseId = ""; //课程Id
            this.id_XzCollege = ""; //学院流水号
            this.id_XzMajor = ""; //专业流水号
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
                case clsvCurrEduCls_SimEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvCurrEduCls_SimEN.con_CurrEduClsId:
                    return this.currEduClsId;
                case clsvCurrEduCls_SimEN.con_EduClsName:
                    return this.eduClsName;
                case clsvCurrEduCls_SimEN.con_EduClsTypeId:
                    return this.eduClsTypeId;
                case clsvCurrEduCls_SimEN.con_CourseId:
                    return this.courseId;
                case clsvCurrEduCls_SimEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvCurrEduCls_SimEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduCls_Sim]中不存在！`;
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
                case clsvCurrEduCls_SimEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvCurrEduCls_SimEN.con_CurrEduClsId:
                    this.currEduClsId = strValue;
                    break;
                case clsvCurrEduCls_SimEN.con_EduClsName:
                    this.eduClsName = strValue;
                    break;
                case clsvCurrEduCls_SimEN.con_EduClsTypeId:
                    this.eduClsTypeId = strValue;
                    break;
                case clsvCurrEduCls_SimEN.con_CourseId:
                    this.courseId = strValue;
                    break;
                case clsvCurrEduCls_SimEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvCurrEduCls_SimEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduCls_Sim]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"CurrEduClsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CurrEduClsId() { return "currEduClsId"; } //教学班Id
        /**
        * 常量:"EduClsName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsName() { return "eduClsName"; } //教学班名
        /**
        * 常量:"EduClsTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsTypeId() { return "eduClsTypeId"; } //教学班类型Id
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
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
    exports.clsvCurrEduCls_SimEN = clsvCurrEduCls_SimEN;
    clsvCurrEduCls_SimEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvCurrEduCls_SimEN.CacheModeId = "03"; //localStorage
    clsvCurrEduCls_SimEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvCurrEduCls_SimEN.WhereFormat = ""; //条件格式串
    clsvCurrEduCls_SimEN._CurrTabName = "vCurrEduCls_Sim"; //当前表名,与该类相关的表名
    clsvCurrEduCls_SimEN._KeyFldName = "id_CurrEduCls,EduClsTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvCurrEduCls_SimEN.mintAttributeCount = 7;
    clsvCurrEduCls_SimEN.AttributeName = ["id_CurrEduCls", "currEduClsId", "eduClsName", "eduClsTypeId", "courseId", "id_XzCollege", "id_XzMajor"];
});
