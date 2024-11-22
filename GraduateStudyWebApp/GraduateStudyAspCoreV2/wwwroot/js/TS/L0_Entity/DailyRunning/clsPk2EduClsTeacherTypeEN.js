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
    exports.clsPk2EduClsTeacherTypeEN = void 0;
    /**
    * 类名:clsPk2EduClsTeacherTypeEN
    * 表名:Pk2EduClsTeacherType(01120133)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:51:38
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:日常运行(DailyRunning)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 教学班教师角色表2(Pk2EduClsTeacherType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsPk2EduClsTeacherTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrid_Pk2EduClsTeacherType = ""; //教学班老师角色(主讲,辅导)流水号
            this.mstrEduClsTeacherTypeID = ""; //教学班教学类型ID
            this.mstrEduClsTeacherTypeDesc = ""; //教学班教师类型名
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_Pk2EduClsTeacherType = ""; //教学班老师角色(主讲,辅导)流水号
            this.eduClsTeacherTypeID = ""; //教学班教学类型ID
            this.eduClsTeacherTypeDesc = ""; //教学班教师类型名
        }
        /**
         * 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_Pk2EduClsTeacherType(value) {
            if (value != undefined) {
                this.id_Pk2EduClsTeacherType = value;
                this.hmProperty["id_Pk2EduClsTeacherType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教学班教学类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEduClsTeacherTypeID(value) {
            if (value != undefined) {
                this.eduClsTeacherTypeID = value;
                this.hmProperty["eduClsTeacherTypeID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教学班教师类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEduClsTeacherTypeDesc(value) {
            if (value != undefined) {
                this.eduClsTeacherTypeDesc = value;
                this.hmProperty["eduClsTeacherTypeDesc"] = true;
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
                case clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType:
                    return this.id_Pk2EduClsTeacherType;
                case clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID:
                    return this.eduClsTeacherTypeID;
                case clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc:
                    return this.eduClsTeacherTypeDesc;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[Pk2EduClsTeacherType]中不存在！`;
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
                case clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType:
                    this.id_Pk2EduClsTeacherType = strValue;
                    this.hmProperty["id_Pk2EduClsTeacherType"] = true;
                    break;
                case clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID:
                    this.eduClsTeacherTypeID = strValue;
                    this.hmProperty["eduClsTeacherTypeID"] = true;
                    break;
                case clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc:
                    this.eduClsTeacherTypeDesc = strValue;
                    this.hmProperty["eduClsTeacherTypeDesc"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[Pk2EduClsTeacherType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
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
        static get con_EduClsTeacherTypeID() { return "eduClsTeacherTypeID"; } //教学班教学类型ID
        /**
        * 常量:"EduClsTeacherTypeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EduClsTeacherTypeDesc() { return "eduClsTeacherTypeDesc"; } //教学班教师类型名
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
    exports.clsPk2EduClsTeacherTypeEN = clsPk2EduClsTeacherTypeEN;
    clsPk2EduClsTeacherTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsPk2EduClsTeacherTypeEN.CacheModeId = "03"; //localStorage
    clsPk2EduClsTeacherTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsPk2EduClsTeacherTypeEN.WhereFormat = ""; //条件格式串
    clsPk2EduClsTeacherTypeEN._CurrTabName = "Pk2EduClsTeacherType"; //当前表名,与该类相关的表名
    clsPk2EduClsTeacherTypeEN._KeyFldName = "id_Pk2EduClsTeacherType"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsPk2EduClsTeacherTypeEN.mintAttributeCount = 3;
    clsPk2EduClsTeacherTypeEN.AttributeName = ["id_Pk2EduClsTeacherType", "eduClsTeacherTypeID", "eduClsTeacherTypeDesc"];
});
