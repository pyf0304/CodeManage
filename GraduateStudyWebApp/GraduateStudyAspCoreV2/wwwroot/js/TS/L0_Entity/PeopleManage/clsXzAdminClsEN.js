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
    exports.clsXzAdminClsEN = void 0;
    /**
    * 类名:clsXzAdminClsEN
    * 表名:XzAdminCls(01120194)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:52:36
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:人员管理(PeopleManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 行政班(XzAdminCls)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsXzAdminClsEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrid_AdminCls = ""; //行政班流水号
            this.mstrAdminClsName = ""; //行政班名称
            this.mstrid_XzMajor = ""; //专业流水号
            this.mstrid_XzCollege = ""; //学院流水号
            this.mstrid_UniZone = ""; //校区流水号
            this.mintCurrentStuQty = 0; //当前学生数
            this.mstrid_GradeBase = ""; //年级流水号
            this.mstrAdminClsId = ""; //行政班代号
            this.mstrid_AdminClsType = ""; //行政班级类型流水号
            this.mintAdminClsIndex = 0; //AdminClsIndex
            this.mstrMemo = ""; //备注
            this.mstrModifyUserID = ""; //修改人
            this.mstrModifyDate = ""; //修改日期
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_AdminCls = ""; //行政班流水号
            this.adminClsName = ""; //行政班名称
            this.id_XzMajor = ""; //专业流水号
            this.id_XzCollege = ""; //学院流水号
            this.id_UniZone = ""; //校区流水号
            this.currentStuQty = 0; //当前学生数
            this.id_GradeBase = ""; //年级流水号
            this.adminClsId = ""; //行政班代号
            this.id_AdminClsType = ""; //行政班级类型流水号
            this.adminClsIndex = 0; //AdminClsIndex
            this.memo = ""; //备注
            this.modifyUserID = ""; //修改人
            this.modifyDate = ""; //修改日期
        }
        /**
         * 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_AdminCls(value) {
            if (value != undefined) {
                this.id_AdminCls = value;
                this.hmProperty["id_AdminCls"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 行政班名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAdminClsName(value) {
            if (value != undefined) {
                this.adminClsName = value;
                this.hmProperty["adminClsName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_XzMajor(value) {
            if (value != undefined) {
                this.id_XzMajor = value;
                this.hmProperty["id_XzMajor"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_XzCollege(value) {
            if (value != undefined) {
                this.id_XzCollege = value;
                this.hmProperty["id_XzCollege"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_UniZone(value) {
            if (value != undefined) {
                this.id_UniZone = value;
                this.hmProperty["id_UniZone"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 当前学生数(说明:;字段类型:int;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCurrentStuQty(value) {
            if (value != undefined) {
                this.currentStuQty = value;
                this.hmProperty["currentStuQty"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_GradeBase(value) {
            if (value != undefined) {
                this.id_GradeBase = value;
                this.hmProperty["id_GradeBase"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 行政班代号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAdminClsId(value) {
            if (value != undefined) {
                this.adminClsId = value;
                this.hmProperty["adminClsId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 行政班级类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_AdminClsType(value) {
            if (value != undefined) {
                this.id_AdminClsType = value;
                this.hmProperty["id_AdminClsType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * AdminClsIndex(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAdminClsIndex(value) {
            if (value != undefined) {
                this.adminClsIndex = value;
                this.hmProperty["adminClsIndex"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsXzAdminClsEN.con_id_AdminCls:
                    return this.id_AdminCls;
                case clsXzAdminClsEN.con_AdminClsName:
                    return this.adminClsName;
                case clsXzAdminClsEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsXzAdminClsEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsXzAdminClsEN.con_id_UniZone:
                    return this.id_UniZone;
                case clsXzAdminClsEN.con_CurrentStuQty:
                    return this.currentStuQty;
                case clsXzAdminClsEN.con_id_GradeBase:
                    return this.id_GradeBase;
                case clsXzAdminClsEN.con_AdminClsId:
                    return this.adminClsId;
                case clsXzAdminClsEN.con_id_AdminClsType:
                    return this.id_AdminClsType;
                case clsXzAdminClsEN.con_AdminClsIndex:
                    return this.adminClsIndex;
                case clsXzAdminClsEN.con_Memo:
                    return this.memo;
                case clsXzAdminClsEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsXzAdminClsEN.con_ModifyDate:
                    return this.modifyDate;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[XzAdminCls]中不存在！`;
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
                case clsXzAdminClsEN.con_id_AdminCls:
                    this.id_AdminCls = strValue;
                    this.hmProperty["id_AdminCls"] = true;
                    break;
                case clsXzAdminClsEN.con_AdminClsName:
                    this.adminClsName = strValue;
                    this.hmProperty["adminClsName"] = true;
                    break;
                case clsXzAdminClsEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    this.hmProperty["id_XzMajor"] = true;
                    break;
                case clsXzAdminClsEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    this.hmProperty["id_XzCollege"] = true;
                    break;
                case clsXzAdminClsEN.con_id_UniZone:
                    this.id_UniZone = strValue;
                    this.hmProperty["id_UniZone"] = true;
                    break;
                case clsXzAdminClsEN.con_CurrentStuQty:
                    this.currentStuQty = Number(strValue);
                    this.hmProperty["currentStuQty"] = true;
                    break;
                case clsXzAdminClsEN.con_id_GradeBase:
                    this.id_GradeBase = strValue;
                    this.hmProperty["id_GradeBase"] = true;
                    break;
                case clsXzAdminClsEN.con_AdminClsId:
                    this.adminClsId = strValue;
                    this.hmProperty["adminClsId"] = true;
                    break;
                case clsXzAdminClsEN.con_id_AdminClsType:
                    this.id_AdminClsType = strValue;
                    this.hmProperty["id_AdminClsType"] = true;
                    break;
                case clsXzAdminClsEN.con_AdminClsIndex:
                    this.adminClsIndex = Number(strValue);
                    this.hmProperty["adminClsIndex"] = true;
                    break;
                case clsXzAdminClsEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsXzAdminClsEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    this.hmProperty["modifyUserID"] = true;
                    break;
                case clsXzAdminClsEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    this.hmProperty["modifyDate"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[XzAdminCls]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_AdminCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_AdminCls() { return "id_AdminCls"; } //行政班流水号
        /**
        * 常量:"AdminClsName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AdminClsName() { return "adminClsName"; } //行政班名称
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
        * 常量:"id_UniZone"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_UniZone() { return "id_UniZone"; } //校区流水号
        /**
        * 常量:"CurrentStuQty"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CurrentStuQty() { return "currentStuQty"; } //当前学生数
        /**
        * 常量:"id_GradeBase"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_GradeBase() { return "id_GradeBase"; } //年级流水号
        /**
        * 常量:"AdminClsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AdminClsId() { return "adminClsId"; } //行政班代号
        /**
        * 常量:"id_AdminClsType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_AdminClsType() { return "id_AdminClsType"; } //行政班级类型流水号
        /**
        * 常量:"AdminClsIndex"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AdminClsIndex() { return "adminClsIndex"; } //AdminClsIndex
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
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
    exports.clsXzAdminClsEN = clsXzAdminClsEN;
    clsXzAdminClsEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsXzAdminClsEN.CacheModeId = "04"; //sessionStorage
    clsXzAdminClsEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsXzAdminClsEN.WhereFormat = ""; //条件格式串
    clsXzAdminClsEN._CurrTabName = "XzAdminCls"; //当前表名,与该类相关的表名
    clsXzAdminClsEN._KeyFldName = "id_AdminCls"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsXzAdminClsEN.mintAttributeCount = 13;
    clsXzAdminClsEN.AttributeName = ["id_AdminCls", "adminClsName", "id_XzMajor", "id_XzCollege", "id_UniZone", "currentStuQty", "id_GradeBase", "adminClsId", "id_AdminClsType", "adminClsIndex", "memo", "modifyUserID", "modifyDate"];
});
