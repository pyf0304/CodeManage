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
    exports.enumXzSchool = exports.clsXzSchoolEN = void 0;
    /**
    * 类名:clsXzSchoolEN
    * 表名:XzSchool(01120029)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 18:24:30
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
    * 学校(XzSchool)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsXzSchoolEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrid_School = ""; //学校流水号
            this.mstrSchoolId = ""; //学校编号
            this.mstrSchoolName = ""; //学校名称
            this.mstrSchoolENName = ""; //SchoolENName
            this.mstrSchoolNameA = ""; //学校简称
            this.mstrSchoolTypeId = ""; //学校类型Id
            this.mbolIsCurrentUse = false; //是否当前使用
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_School = ""; //学校流水号
            this.schoolId = ""; //学校编号
            this.schoolName = ""; //学校名称
            this.schoolENName = ""; //SchoolENName
            this.schoolNameA = ""; //学校简称
            this.schoolTypeId = ""; //学校类型Id
            this.isCurrentUse = false; //是否当前使用
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.memo = ""; //备注
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
         * 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolId(value) {
            if (value != undefined) {
                this.schoolId = value;
                this.hmProperty["schoolId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolName(value) {
            if (value != undefined) {
                this.schoolName = value;
                this.hmProperty["schoolName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * SchoolENName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolENName(value) {
            if (value != undefined) {
                this.schoolENName = value;
                this.hmProperty["schoolENName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学校简称(说明:;字段类型:varchar;字段长度:14;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolNameA(value) {
            if (value != undefined) {
                this.schoolNameA = value;
                this.hmProperty["schoolNameA"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学校类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolTypeId(value) {
            if (value != undefined) {
                this.schoolTypeId = value;
                this.hmProperty["schoolTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否当前使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsCurrentUse(value) {
            if (value != undefined) {
                this.isCurrentUse = value;
                this.hmProperty["isCurrentUse"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdDate(value) {
            if (value != undefined) {
                this.updDate = value;
                this.hmProperty["updDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUserId(value) {
            if (value != undefined) {
                this.updUserId = value;
                this.hmProperty["updUserId"] = true;
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
                case clsXzSchoolEN.con_id_School:
                    return this.id_School;
                case clsXzSchoolEN.con_SchoolId:
                    return this.schoolId;
                case clsXzSchoolEN.con_SchoolName:
                    return this.schoolName;
                case clsXzSchoolEN.con_SchoolENName:
                    return this.schoolENName;
                case clsXzSchoolEN.con_SchoolNameA:
                    return this.schoolNameA;
                case clsXzSchoolEN.con_SchoolTypeId:
                    return this.schoolTypeId;
                case clsXzSchoolEN.con_IsCurrentUse:
                    return this.isCurrentUse;
                case clsXzSchoolEN.con_UpdDate:
                    return this.updDate;
                case clsXzSchoolEN.con_UpdUserId:
                    return this.updUserId;
                case clsXzSchoolEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[XzSchool]中不存在！`;
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
                case clsXzSchoolEN.con_id_School:
                    this.id_School = strValue;
                    this.hmProperty["id_School"] = true;
                    break;
                case clsXzSchoolEN.con_SchoolId:
                    this.schoolId = strValue;
                    this.hmProperty["schoolId"] = true;
                    break;
                case clsXzSchoolEN.con_SchoolName:
                    this.schoolName = strValue;
                    this.hmProperty["schoolName"] = true;
                    break;
                case clsXzSchoolEN.con_SchoolENName:
                    this.schoolENName = strValue;
                    this.hmProperty["schoolENName"] = true;
                    break;
                case clsXzSchoolEN.con_SchoolNameA:
                    this.schoolNameA = strValue;
                    this.hmProperty["schoolNameA"] = true;
                    break;
                case clsXzSchoolEN.con_SchoolTypeId:
                    this.schoolTypeId = strValue;
                    this.hmProperty["schoolTypeId"] = true;
                    break;
                case clsXzSchoolEN.con_IsCurrentUse:
                    this.isCurrentUse = Boolean(strValue);
                    this.hmProperty["isCurrentUse"] = true;
                    break;
                case clsXzSchoolEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsXzSchoolEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clsXzSchoolEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[XzSchool]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
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
        * 常量:"SchoolENName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolENName() { return "schoolENName"; } //SchoolENName
        /**
        * 常量:"SchoolNameA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolNameA() { return "schoolNameA"; } //学校简称
        /**
        * 常量:"SchoolTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolTypeId() { return "schoolTypeId"; } //学校类型Id
        /**
        * 常量:"IsCurrentUse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCurrentUse() { return "isCurrentUse"; } //是否当前使用
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
    exports.clsXzSchoolEN = clsXzSchoolEN;
    clsXzSchoolEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsXzSchoolEN.CacheModeId = "04"; //sessionStorage
    clsXzSchoolEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsXzSchoolEN.WhereFormat = ""; //条件格式串
    clsXzSchoolEN._CurrTabName = "XzSchool"; //当前表名,与该类相关的表名
    clsXzSchoolEN._KeyFldName = "id_School"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsXzSchoolEN.mintAttributeCount = 10;
    clsXzSchoolEN.AttributeName = ["id_School", "schoolId", "schoolName", "schoolENName", "schoolNameA", "schoolTypeId", "isCurrentUse", "updDate", "updUserId", "memo"];
    /**
    * 根据表内容设置enum列表
    * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GeneEnumConstList)
    **/
    class enumXzSchool {
    }
    exports.enumXzSchool = enumXzSchool;
    /**
    * 淮阴师范学院
    **/
    enumXzSchool.HYSF_0001 = "0001";
    /**
    * 上海师范大学
    **/
    enumXzSchool.SHNU_0002 = "0002";
    /**
    * 温州大学
    **/
    enumXzSchool.WZU_0003 = "0003";
    /**
    * 宁波大学
    **/
    enumXzSchool.NBU_0004 = "0004";
    /**
    * 淮阴师范测试
    **/
    enumXzSchool.HYSF_TEST_0005 = "0005";
    /**
    * 江苏二师
    **/
    enumXzSchool.JSIE_0006 = "0006";
    /**
    * 上海泰泽
    **/
    enumXzSchool.TZ_0007 = "0007";
    /**
    * 上海师大第二附属中学
    **/
    enumXzSchool.SSDEFZ_0008 = "0008";
    /**
    * 上海市交通局下属单位
    **/
    enumXzSchool.JT_0009 = "0009";
    /**
    * 上海师大智能语音学习平台
    **/
    enumXzSchool.YYXX_0010 = "0010";
});
