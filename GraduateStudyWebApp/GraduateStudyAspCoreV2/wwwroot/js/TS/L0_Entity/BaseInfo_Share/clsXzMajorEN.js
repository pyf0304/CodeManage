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
    exports.clsXzMajorEN = void 0;
    /**
    * 类名:clsXzMajorEN
    * 表名:XzMajor(01120065)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:14:41
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:基本信息维护(BaseInfo)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 专业(XzMajor)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsXzMajorEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrid_XzMajor = ""; //专业流水号
            this.mstrMajorID = ""; //专业ID
            this.mstrMajorName = ""; //专业名称
            this.mstrMajorEnglishName = ""; //专业英文名称
            this.mstrMajorExplain = ""; //专业说明
            this.mstrMajorNationalID = ""; //专业国家代码
            this.mstrid_XzCollege = ""; //学院流水号
            this.mstrid_MajorType = ""; //专业类型(文理工)流水号
            this.mstrid_DegreeType = ""; //学位类型流水号
            this.mbolIsMainMajor = false; //是否重要专业
            this.mstrMajorDirection = ""; //专业方向
            this.mbolIsVisible = false; //是否显示
            this.mbolIsNormal = false; //IsNormal
            this.mstrModifyDate = ""; //修改日期
            this.mstrModifyUserID = ""; //修改人
            this.mstrMemo = ""; //备注
            this.mstrid_XzMajorShoolType = ""; //专业学校类型流水号
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_XzMajor = ""; //专业流水号
            this.majorID = ""; //专业ID
            this.majorName = ""; //专业名称
            this.majorEnglishName = ""; //专业英文名称
            this.majorExplain = ""; //专业说明
            this.majorNationalID = ""; //专业国家代码
            this.id_XzCollege = ""; //学院流水号
            this.id_MajorType = ""; //专业类型(文理工)流水号
            this.id_DegreeType = ""; //学位类型流水号
            this.isMainMajor = false; //是否重要专业
            this.majorDirection = ""; //专业方向
            this.isVisible = false; //是否显示
            this.isNormal = false; //IsNormal
            this.modifyDate = ""; //修改日期
            this.modifyUserID = ""; //修改人
            this.memo = ""; //备注
            this.id_XzMajorShoolType = ""; //专业学校类型流水号
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
         * 专业ID(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMajorID(value) {
            if (value != undefined) {
                this.majorID = value;
                this.hmProperty["majorID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMajorName(value) {
            if (value != undefined) {
                this.majorName = value;
                this.hmProperty["majorName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 专业英文名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMajorEnglishName(value) {
            if (value != undefined) {
                this.majorEnglishName = value;
                this.hmProperty["majorEnglishName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 专业说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMajorExplain(value) {
            if (value != undefined) {
                this.majorExplain = value;
                this.hmProperty["majorExplain"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 专业国家代码(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMajorNationalID(value) {
            if (value != undefined) {
                this.majorNationalID = value;
                this.hmProperty["majorNationalID"] = true;
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
         * 专业类型(文理工)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_MajorType(value) {
            if (value != undefined) {
                this.id_MajorType = value;
                this.hmProperty["id_MajorType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学位类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_DegreeType(value) {
            if (value != undefined) {
                this.id_DegreeType = value;
                this.hmProperty["id_DegreeType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否重要专业(说明:;字段类型:bit;字段长度:1;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsMainMajor(value) {
            if (value != undefined) {
                this.isMainMajor = value;
                this.hmProperty["isMainMajor"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 专业方向(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMajorDirection(value) {
            if (value != undefined) {
                this.majorDirection = value;
                this.hmProperty["majorDirection"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsVisible(value) {
            if (value != undefined) {
                this.isVisible = value;
                this.hmProperty["isVisible"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * IsNormal(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsNormal(value) {
            if (value != undefined) {
                this.isNormal = value;
                this.hmProperty["isNormal"] = true;
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
         * 专业学校类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_XzMajorShoolType(value) {
            if (value != undefined) {
                this.id_XzMajorShoolType = value;
                this.hmProperty["id_XzMajorShoolType"] = true;
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
                case clsXzMajorEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsXzMajorEN.con_MajorID:
                    return this.majorID;
                case clsXzMajorEN.con_MajorName:
                    return this.majorName;
                case clsXzMajorEN.con_MajorEnglishName:
                    return this.majorEnglishName;
                case clsXzMajorEN.con_MajorExplain:
                    return this.majorExplain;
                case clsXzMajorEN.con_MajorNationalID:
                    return this.majorNationalID;
                case clsXzMajorEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsXzMajorEN.con_id_MajorType:
                    return this.id_MajorType;
                case clsXzMajorEN.con_id_DegreeType:
                    return this.id_DegreeType;
                case clsXzMajorEN.con_IsMainMajor:
                    return this.isMainMajor;
                case clsXzMajorEN.con_MajorDirection:
                    return this.majorDirection;
                case clsXzMajorEN.con_IsVisible:
                    return this.isVisible;
                case clsXzMajorEN.con_IsNormal:
                    return this.isNormal;
                case clsXzMajorEN.con_ModifyDate:
                    return this.modifyDate;
                case clsXzMajorEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsXzMajorEN.con_Memo:
                    return this.memo;
                case clsXzMajorEN.con_id_XzMajorShoolType:
                    return this.id_XzMajorShoolType;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[XzMajor]中不存在！`;
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
                case clsXzMajorEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    this.hmProperty["id_XzMajor"] = true;
                    break;
                case clsXzMajorEN.con_MajorID:
                    this.majorID = strValue;
                    this.hmProperty["majorID"] = true;
                    break;
                case clsXzMajorEN.con_MajorName:
                    this.majorName = strValue;
                    this.hmProperty["majorName"] = true;
                    break;
                case clsXzMajorEN.con_MajorEnglishName:
                    this.majorEnglishName = strValue;
                    this.hmProperty["majorEnglishName"] = true;
                    break;
                case clsXzMajorEN.con_MajorExplain:
                    this.majorExplain = strValue;
                    this.hmProperty["majorExplain"] = true;
                    break;
                case clsXzMajorEN.con_MajorNationalID:
                    this.majorNationalID = strValue;
                    this.hmProperty["majorNationalID"] = true;
                    break;
                case clsXzMajorEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    this.hmProperty["id_XzCollege"] = true;
                    break;
                case clsXzMajorEN.con_id_MajorType:
                    this.id_MajorType = strValue;
                    this.hmProperty["id_MajorType"] = true;
                    break;
                case clsXzMajorEN.con_id_DegreeType:
                    this.id_DegreeType = strValue;
                    this.hmProperty["id_DegreeType"] = true;
                    break;
                case clsXzMajorEN.con_IsMainMajor:
                    this.isMainMajor = Boolean(strValue);
                    this.hmProperty["isMainMajor"] = true;
                    break;
                case clsXzMajorEN.con_MajorDirection:
                    this.majorDirection = strValue;
                    this.hmProperty["majorDirection"] = true;
                    break;
                case clsXzMajorEN.con_IsVisible:
                    this.isVisible = Boolean(strValue);
                    this.hmProperty["isVisible"] = true;
                    break;
                case clsXzMajorEN.con_IsNormal:
                    this.isNormal = Boolean(strValue);
                    this.hmProperty["isNormal"] = true;
                    break;
                case clsXzMajorEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    this.hmProperty["modifyDate"] = true;
                    break;
                case clsXzMajorEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    this.hmProperty["modifyUserID"] = true;
                    break;
                case clsXzMajorEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsXzMajorEN.con_id_XzMajorShoolType:
                    this.id_XzMajorShoolType = strValue;
                    this.hmProperty["id_XzMajorShoolType"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[XzMajor]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"MajorID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorID() { return "majorID"; } //专业ID
        /**
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
        /**
        * 常量:"MajorEnglishName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorEnglishName() { return "majorEnglishName"; } //专业英文名称
        /**
        * 常量:"MajorExplain"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorExplain() { return "majorExplain"; } //专业说明
        /**
        * 常量:"MajorNationalID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorNationalID() { return "majorNationalID"; } //专业国家代码
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"id_MajorType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_MajorType() { return "id_MajorType"; } //专业类型(文理工)流水号
        /**
        * 常量:"id_DegreeType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_DegreeType() { return "id_DegreeType"; } //学位类型流水号
        /**
        * 常量:"IsMainMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsMainMajor() { return "isMainMajor"; } //是否重要专业
        /**
        * 常量:"MajorDirection"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorDirection() { return "majorDirection"; } //专业方向
        /**
        * 常量:"IsVisible"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsVisible() { return "isVisible"; } //是否显示
        /**
        * 常量:"IsNormal"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsNormal() { return "isNormal"; } //IsNormal
        /**
        * 常量:"ModifyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyDate() { return "modifyDate"; } //修改日期
        /**
        * 常量:"ModifyUserID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyUserID() { return "modifyUserID"; } //修改人
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"id_XzMajorShoolType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajorShoolType() { return "id_XzMajorShoolType"; } //专业学校类型流水号
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
    exports.clsXzMajorEN = clsXzMajorEN;
    clsXzMajorEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsXzMajorEN.CacheModeId = "04"; //sessionStorage
    clsXzMajorEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsXzMajorEN.WhereFormat = ""; //条件格式串
    clsXzMajorEN._CurrTabName = "XzMajor"; //当前表名,与该类相关的表名
    clsXzMajorEN._KeyFldName = "id_XzMajor"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsXzMajorEN.mintAttributeCount = 17;
    clsXzMajorEN.AttributeName = ["id_XzMajor", "majorID", "majorName", "majorEnglishName", "majorExplain", "majorNationalID", "id_XzCollege", "id_MajorType", "id_DegreeType", "isMainMajor", "majorDirection", "isVisible", "isNormal", "modifyDate", "modifyUserID", "memo", "id_XzMajorShoolType"];
});
