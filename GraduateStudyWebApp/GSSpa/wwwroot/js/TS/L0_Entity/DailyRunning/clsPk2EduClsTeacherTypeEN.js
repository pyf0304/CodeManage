(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTab2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsPk2EduClsTeacherTypeEN_Sim = exports.clsPk2EduClsTeacherTypeEN = void 0;
    /**
    * 类名:clsPk2EduClsTeacherTypeEN
    * 表名:Pk2EduClsTeacherType(01120133)
    * 生成代码版本:2021.09.26.2
    * 生成日期:2021/09/27 18:02:41
    * 生成者:pyf
    * 工程名称:问卷调查
    * 工程ID:0112
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:日常运行
    * 模块英文名:DailyRunning
    * 框架-层名:实体层(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 教学班教师角色表2(Pk2EduClsTeacherType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsPk2EduClsTeacherTypeEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            this.mstrid_Pk2EduClsTeacherType = ""; //教学班老师角色(主讲,辅导)流水号
            this.mstrEduClsTeacherTypeID = ""; //教学班教学类型ID
            this.mstrEduClsTeacherTypeDesc = ""; //教学班教师类型名
        }
        /**
         * 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get id_Pk2EduClsTeacherType() {
            return this.mstrid_Pk2EduClsTeacherType;
        }
        /**
         * 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set id_Pk2EduClsTeacherType(value) {
            if (value != undefined) {
                this.mstrid_Pk2EduClsTeacherType = value;
                this.hmProperty["id_Pk2EduClsTeacherType"] = true;
            }
        }
        /**
         * 教学班教学类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get EduClsTeacherTypeID() {
            return this.mstrEduClsTeacherTypeID;
        }
        /**
         * 教学班教学类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set EduClsTeacherTypeID(value) {
            if (value != undefined) {
                this.mstrEduClsTeacherTypeID = value;
                this.hmProperty["EduClsTeacherTypeID"] = true;
            }
        }
        /**
         * 教学班教师类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        get EduClsTeacherTypeDesc() {
            return this.mstrEduClsTeacherTypeDesc;
        }
        /**
         * 教学班教师类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        set EduClsTeacherTypeDesc(value) {
            if (value != undefined) {
                this.mstrEduClsTeacherTypeDesc = value;
                this.hmProperty["EduClsTeacherTypeDesc"] = true;
            }
        }
        /**
        * 常量:"id_Pk2EduClsTeacherType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Pk2EduClsTeacherType() { return "id_Pk2EduClsTeacherType"; } //教学班老师角色(主讲,辅导)流水号
        /**
        * 常量:"EduClsTeacherTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsTeacherTypeID() { return "EduClsTeacherTypeID"; } //教学班教学类型ID
        /**
        * 常量:"EduClsTeacherTypeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsTeacherTypeDesc() { return "EduClsTeacherTypeDesc"; } //教学班教师类型名
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            this[strFldName] = strFldValue;
            if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        }
    }
    exports.clsPk2EduClsTeacherTypeEN = clsPk2EduClsTeacherTypeEN;
    clsPk2EduClsTeacherTypeEN._CurrTabName = "Pk2EduClsTeacherType"; //当前表名,与该类相关的表名
    clsPk2EduClsTeacherTypeEN._KeyFldName = "id_Pk2EduClsTeacherType"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsPk2EduClsTeacherTypeEN.mintAttributeCount = 3;
    clsPk2EduClsTeacherTypeEN.AttributeName = ["id_Pk2EduClsTeacherType", "EduClsTeacherTypeID", "EduClsTeacherTypeDesc"];
    /**
    * 教学班教师角色表2(Pk2EduClsTeacherType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    class clsPk2EduClsTeacherTypeEN_Sim {
        constructor() {
            //以下是属性变量
            /**
             * 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.id_Pk2EduClsTeacherType = "";
            /**
             * 教学班教学类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.EduClsTeacherTypeID = "";
            /**
             * 教学班教师类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
             * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            */
            this.EduClsTeacherTypeDesc = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsPk2EduClsTeacherTypeEN_Sim = clsPk2EduClsTeacherTypeEN_Sim;
});
