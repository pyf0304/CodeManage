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
    exports.clsClsRmTypeEN = void 0;
    /**
    * 类名:clsClsRmTypeEN
    * 表名:ClsRmType(01120576)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 18:26:50
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:系统设置(SystemSet)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 教室类型(ClsRmType)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsClsRmTypeEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrid_ClassRoomType = ""; //教室类型流水号
            this.mstrClassRoomTypeID = ""; //教室类型代号
            this.mstrClassRoomTypeDesc = ""; //教室类型描述
            this.mstrClassRoomTypeDescA = ""; //教室类型简称
            this.mstrModifyUserID = ""; //修改人
            this.mstrModifyDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_ClassRoomType = ""; //教室类型流水号
            this.classRoomTypeID = ""; //教室类型代号
            this.classRoomTypeDesc = ""; //教室类型描述
            this.classRoomTypeDescA = ""; //教室类型简称
            this.modifyUserID = ""; //修改人
            this.modifyDate = ""; //修改日期
            this.memo = ""; //备注
        }
        /**
         * 教室类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_ClassRoomType(value) {
            if (value != undefined) {
                this.id_ClassRoomType = value;
                this.hmProperty["id_ClassRoomType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教室类型代号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetClassRoomTypeID(value) {
            if (value != undefined) {
                this.classRoomTypeID = value;
                this.hmProperty["classRoomTypeID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教室类型描述(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetClassRoomTypeDesc(value) {
            if (value != undefined) {
                this.classRoomTypeDesc = value;
                this.hmProperty["classRoomTypeDesc"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教室类型简称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetClassRoomTypeDescA(value) {
            if (value != undefined) {
                this.classRoomTypeDescA = value;
                this.hmProperty["classRoomTypeDescA"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetModifyUserID(value) {
            if (value != undefined) {
                this.modifyUserID = value;
                this.hmProperty["modifyUserID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetModifyDate(value) {
            if (value != undefined) {
                this.modifyDate = value;
                this.hmProperty["modifyDate"] = true;
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
                case clsClsRmTypeEN.con_id_ClassRoomType:
                    return this.id_ClassRoomType;
                case clsClsRmTypeEN.con_ClassRoomTypeID:
                    return this.classRoomTypeID;
                case clsClsRmTypeEN.con_ClassRoomTypeDesc:
                    return this.classRoomTypeDesc;
                case clsClsRmTypeEN.con_ClassRoomTypeDescA:
                    return this.classRoomTypeDescA;
                case clsClsRmTypeEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsClsRmTypeEN.con_ModifyDate:
                    return this.modifyDate;
                case clsClsRmTypeEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[ClsRmType]中不存在！`;
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
                case clsClsRmTypeEN.con_id_ClassRoomType:
                    this.id_ClassRoomType = strValue;
                    this.hmProperty["id_ClassRoomType"] = true;
                    break;
                case clsClsRmTypeEN.con_ClassRoomTypeID:
                    this.classRoomTypeID = strValue;
                    this.hmProperty["classRoomTypeID"] = true;
                    break;
                case clsClsRmTypeEN.con_ClassRoomTypeDesc:
                    this.classRoomTypeDesc = strValue;
                    this.hmProperty["classRoomTypeDesc"] = true;
                    break;
                case clsClsRmTypeEN.con_ClassRoomTypeDescA:
                    this.classRoomTypeDescA = strValue;
                    this.hmProperty["classRoomTypeDescA"] = true;
                    break;
                case clsClsRmTypeEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    this.hmProperty["modifyUserID"] = true;
                    break;
                case clsClsRmTypeEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    this.hmProperty["modifyDate"] = true;
                    break;
                case clsClsRmTypeEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[ClsRmType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_ClassRoomType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_ClassRoomType() { return "id_ClassRoomType"; } //教室类型流水号
        /**
        * 常量:"ClassRoomTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ClassRoomTypeID() { return "classRoomTypeID"; } //教室类型代号
        /**
        * 常量:"ClassRoomTypeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ClassRoomTypeDesc() { return "classRoomTypeDesc"; } //教室类型描述
        /**
        * 常量:"ClassRoomTypeDescA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ClassRoomTypeDescA() { return "classRoomTypeDescA"; } //教室类型简称
        /**
        * 常量:"ModifyUserID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyUserID() { return "modifyUserID"; } //修改人
        /**
        * 常量:"ModifyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyDate() { return "modifyDate"; } //修改日期
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
    exports.clsClsRmTypeEN = clsClsRmTypeEN;
    clsClsRmTypeEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsClsRmTypeEN.CacheModeId = "04"; //sessionStorage
    clsClsRmTypeEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsClsRmTypeEN.WhereFormat = ""; //条件格式串
    clsClsRmTypeEN._CurrTabName = "ClsRmType"; //当前表名,与该类相关的表名
    clsClsRmTypeEN._KeyFldName = "id_ClassRoomType"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsClsRmTypeEN.mintAttributeCount = 7;
    clsClsRmTypeEN.AttributeName = ["id_ClassRoomType", "classRoomTypeID", "classRoomTypeDesc", "classRoomTypeDescA", "modifyUserID", "modifyDate", "memo"];
});
