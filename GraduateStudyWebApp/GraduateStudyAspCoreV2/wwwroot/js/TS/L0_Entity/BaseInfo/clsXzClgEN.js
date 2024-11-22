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
    exports.clsXzClgEN = void 0;
    /**
    * 类名:clsXzClgEN
    * 表名:XzClg(01120064)
    * 版本:2023.02.24.1(服务器:WIN-SRV103-116)
    * 日期:2023/02/24 13:39:34
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
    * 学院(XzClg)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsXzClgEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrid_XzCollege = ""; //学院流水号
            this.mstrCollegeID = ""; //学院ID
            this.mstrCollegeName = ""; //学院名称
            this.mstrCollegeIdInGP = ""; //CollegeIdInGP
            this.mstrClgEnglishName = ""; //ClgEnglishName
            this.mstrCollegeNameA = ""; //学院名称简写
            this.mstrPhoneNumber = ""; //PhoneNumber
            this.mstrWebSite = ""; //个人主页
            this.mstrid_School = ""; //学校流水号
            this.mstrid_Uni = ""; //id_Uni
            this.mbolIsVisible4Tea = false; //IsVisible4Tea
            this.mbolIsVisible = false; //是否显示
            this.mintOrderNum = 0; //序号
            this.mstrModifyDate = ""; //修改日期
            this.mstrModifyUserID = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_XzCollege = ""; //学院流水号
            this.collegeID = ""; //学院ID
            this.collegeName = ""; //学院名称
            this.collegeIdInGP = ""; //CollegeIdInGP
            this.clgEnglishName = ""; //ClgEnglishName
            this.collegeNameA = ""; //学院名称简写
            this.phoneNumber = ""; //PhoneNumber
            this.webSite = ""; //个人主页
            this.id_School = ""; //学校流水号
            this.id_Uni = ""; //id_Uni
            this.isVisible4Tea = false; //IsVisible4Tea
            this.isVisible = false; //是否显示
            this.orderNum = 0; //序号
            this.modifyDate = ""; //修改日期
            this.modifyUserID = ""; //修改人
            this.memo = ""; //备注
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
         * 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCollegeID(value) {
            if (value != undefined) {
                this.collegeID = value;
                this.hmProperty["collegeID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCollegeName(value) {
            if (value != undefined) {
                this.collegeName = value;
                this.hmProperty["collegeName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * CollegeIdInGP(说明:;字段类型:varchar;字段长度:6;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCollegeIdInGP(value) {
            if (value != undefined) {
                this.collegeIdInGP = value;
                this.hmProperty["collegeIdInGP"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * ClgEnglishName(说明:;字段类型:varchar;字段长度:60;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetClgEnglishName(value) {
            if (value != undefined) {
                this.clgEnglishName = value;
                this.hmProperty["clgEnglishName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCollegeNameA(value) {
            if (value != undefined) {
                this.collegeNameA = value;
                this.hmProperty["collegeNameA"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * PhoneNumber(说明:;字段类型:varchar;字段长度:15;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPhoneNumber(value) {
            if (value != undefined) {
                this.phoneNumber = value;
                this.hmProperty["phoneNumber"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 个人主页(说明:;字段类型:varchar;字段长度:60;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetWebSite(value) {
            if (value != undefined) {
                this.webSite = value;
                this.hmProperty["webSite"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_School(value) {
            if (value != undefined) {
                this.id_School = value;
                this.hmProperty["id_School"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_Uni(value) {
            if (value != undefined) {
                this.id_Uni = value;
                this.hmProperty["id_Uni"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * IsVisible4Tea(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsVisible4Tea(value) {
            if (value != undefined) {
                this.isVisible4Tea = value;
                this.hmProperty["isVisible4Tea"] = true;
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
         * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOrderNum(value) {
            if (value != undefined) {
                this.orderNum = value;
                this.hmProperty["orderNum"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsXzClgEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsXzClgEN.con_CollegeID:
                    return this.collegeID;
                case clsXzClgEN.con_CollegeName:
                    return this.collegeName;
                case clsXzClgEN.con_CollegeIdInGP:
                    return this.collegeIdInGP;
                case clsXzClgEN.con_ClgEnglishName:
                    return this.clgEnglishName;
                case clsXzClgEN.con_CollegeNameA:
                    return this.collegeNameA;
                case clsXzClgEN.con_PhoneNumber:
                    return this.phoneNumber;
                case clsXzClgEN.con_WebSite:
                    return this.webSite;
                case clsXzClgEN.con_id_School:
                    return this.id_School;
                case clsXzClgEN.con_id_Uni:
                    return this.id_Uni;
                case clsXzClgEN.con_IsVisible4Tea:
                    return this.isVisible4Tea;
                case clsXzClgEN.con_IsVisible:
                    return this.isVisible;
                case clsXzClgEN.con_OrderNum:
                    return this.orderNum;
                case clsXzClgEN.con_ModifyDate:
                    return this.modifyDate;
                case clsXzClgEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsXzClgEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[XzClg]中不存在！`;
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
                case clsXzClgEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    this.hmProperty["id_XzCollege"] = true;
                    break;
                case clsXzClgEN.con_CollegeID:
                    this.collegeID = strValue;
                    this.hmProperty["collegeID"] = true;
                    break;
                case clsXzClgEN.con_CollegeName:
                    this.collegeName = strValue;
                    this.hmProperty["collegeName"] = true;
                    break;
                case clsXzClgEN.con_CollegeIdInGP:
                    this.collegeIdInGP = strValue;
                    this.hmProperty["collegeIdInGP"] = true;
                    break;
                case clsXzClgEN.con_ClgEnglishName:
                    this.clgEnglishName = strValue;
                    this.hmProperty["clgEnglishName"] = true;
                    break;
                case clsXzClgEN.con_CollegeNameA:
                    this.collegeNameA = strValue;
                    this.hmProperty["collegeNameA"] = true;
                    break;
                case clsXzClgEN.con_PhoneNumber:
                    this.phoneNumber = strValue;
                    this.hmProperty["phoneNumber"] = true;
                    break;
                case clsXzClgEN.con_WebSite:
                    this.webSite = strValue;
                    this.hmProperty["webSite"] = true;
                    break;
                case clsXzClgEN.con_id_School:
                    this.id_School = strValue;
                    this.hmProperty["id_School"] = true;
                    break;
                case clsXzClgEN.con_id_Uni:
                    this.id_Uni = strValue;
                    this.hmProperty["id_Uni"] = true;
                    break;
                case clsXzClgEN.con_IsVisible4Tea:
                    this.isVisible4Tea = Boolean(strValue);
                    this.hmProperty["isVisible4Tea"] = true;
                    break;
                case clsXzClgEN.con_IsVisible:
                    this.isVisible = Boolean(strValue);
                    this.hmProperty["isVisible"] = true;
                    break;
                case clsXzClgEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    this.hmProperty["orderNum"] = true;
                    break;
                case clsXzClgEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    this.hmProperty["modifyDate"] = true;
                    break;
                case clsXzClgEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    this.hmProperty["modifyUserID"] = true;
                    break;
                case clsXzClgEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[XzClg]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"CollegeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeID() { return "collegeID"; } //学院ID
        /**
        * 常量:"CollegeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeName() { return "collegeName"; } //学院名称
        /**
        * 常量:"CollegeIdInGP"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeIdInGP() { return "collegeIdInGP"; } //CollegeIdInGP
        /**
        * 常量:"ClgEnglishName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ClgEnglishName() { return "clgEnglishName"; } //ClgEnglishName
        /**
        * 常量:"CollegeNameA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeNameA() { return "collegeNameA"; } //学院名称简写
        /**
        * 常量:"PhoneNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PhoneNumber() { return "phoneNumber"; } //PhoneNumber
        /**
        * 常量:"WebSite"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WebSite() { return "webSite"; } //个人主页
        /**
        * 常量:"id_School"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_School() { return "id_School"; } //学校流水号
        /**
        * 常量:"id_Uni"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Uni() { return "id_Uni"; } //id_Uni
        /**
        * 常量:"IsVisible4Tea"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsVisible4Tea() { return "isVisible4Tea"; } //IsVisible4Tea
        /**
        * 常量:"IsVisible"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsVisible() { return "isVisible"; } //是否显示
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
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
    exports.clsXzClgEN = clsXzClgEN;
    clsXzClgEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsXzClgEN.CacheModeId = "04"; //sessionStorage
    clsXzClgEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsXzClgEN.WhereFormat = ""; //条件格式串
    clsXzClgEN._CurrTabName = "XzClg"; //当前表名,与该类相关的表名
    clsXzClgEN._KeyFldName = "id_XzCollege"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsXzClgEN.mintAttributeCount = 16;
    clsXzClgEN.AttributeName = ["id_XzCollege", "collegeID", "collegeName", "collegeIdInGP", "clgEnglishName", "collegeNameA", "phoneNumber", "webSite", "id_School", "id_Uni", "isVisible4Tea", "isVisible", "orderNum", "modifyDate", "modifyUserID", "memo"];
});
