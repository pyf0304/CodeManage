(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTab.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsCourseLearningCaseTypeEN = void 0;
    /**
    * 类名:clsCourseLearningCaseTypeEN
    * 表名:CourseLearningCaseType(01120275)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/12 17:06:00
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:课程学习(CourseLearning)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 课程学习案例类型(CourseLearningCaseType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsCourseLearningCaseTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            /**
             * 设置对象中私有属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPrivateVar)
            */
            this.mstrid_CourseLearningCaseType = ""; //课程学习案例类型流水号
            this.mstrCourseLearningCaseTypeId = ""; //课程学习案例类型Id
            this.mstrCourseLearningCaseTypeName = ""; //课程学习案例类型名称
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_CourseLearningCaseType = ""; //课程学习案例类型流水号
            this.courseLearningCaseTypeId = ""; //课程学习案例类型Id
            this.courseLearningCaseTypeName = ""; //课程学习案例类型名称
            this.memo = ""; //备注
        }
        /**
         * 课程学习案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CourseLearningCaseType(value) {
            if (value != undefined) {
                this.id_CourseLearningCaseType = value;
                this.hmProperty["id_CourseLearningCaseType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程学习案例类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseLearningCaseTypeId(value) {
            if (value != undefined) {
                this.courseLearningCaseTypeId = value;
                this.hmProperty["courseLearningCaseTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程学习案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseLearningCaseTypeName(value) {
            if (value != undefined) {
                this.courseLearningCaseTypeName = value;
                this.hmProperty["courseLearningCaseTypeName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMemo(value) {
            if (value != undefined) {
                this.memo = value;
                this.hmProperty["memo"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
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
                case clsCourseLearningCaseTypeEN.con_id_CourseLearningCaseType:
                    return this.id_CourseLearningCaseType;
                case clsCourseLearningCaseTypeEN.con_CourseLearningCaseTypeId:
                    return this.courseLearningCaseTypeId;
                case clsCourseLearningCaseTypeEN.con_CourseLearningCaseTypeName:
                    return this.courseLearningCaseTypeName;
                case clsCourseLearningCaseTypeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[CourseLearningCaseType]中不存在！`;
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
                case clsCourseLearningCaseTypeEN.con_id_CourseLearningCaseType:
                    this.id_CourseLearningCaseType = strValue;
                    this.hmProperty["id_CourseLearningCaseType"] = true;
                    break;
                case clsCourseLearningCaseTypeEN.con_CourseLearningCaseTypeId:
                    this.courseLearningCaseTypeId = strValue;
                    this.hmProperty["courseLearningCaseTypeId"] = true;
                    break;
                case clsCourseLearningCaseTypeEN.con_CourseLearningCaseTypeName:
                    this.courseLearningCaseTypeName = strValue;
                    this.hmProperty["courseLearningCaseTypeName"] = true;
                    break;
                case clsCourseLearningCaseTypeEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[CourseLearningCaseType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_CourseLearningCaseType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CourseLearningCaseType() { return "id_CourseLearningCaseType"; } //课程学习案例类型流水号
        /**
        * 常量:"CourseLearningCaseTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseLearningCaseTypeId() { return "courseLearningCaseTypeId"; } //课程学习案例类型Id
        /**
        * 常量:"CourseLearningCaseTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseLearningCaseTypeName() { return "courseLearningCaseTypeName"; } //课程学习案例类型名称
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
    exports.clsCourseLearningCaseTypeEN = clsCourseLearningCaseTypeEN;
    clsCourseLearningCaseTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsCourseLearningCaseTypeEN.CacheModeId = "02"; //客户端缓存
    clsCourseLearningCaseTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsCourseLearningCaseTypeEN.WhereFormat = ""; //条件格式串
    clsCourseLearningCaseTypeEN._CurrTabName = "CourseLearningCaseType"; //当前表名,与该类相关的表名
    clsCourseLearningCaseTypeEN._KeyFldName = "id_CourseLearningCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsCourseLearningCaseTypeEN.mintAttributeCount = 4;
    clsCourseLearningCaseTypeEN.AttributeName = ["id_CourseLearningCaseType", "courseLearningCaseTypeId", "courseLearningCaseTypeName", "memo"];
});