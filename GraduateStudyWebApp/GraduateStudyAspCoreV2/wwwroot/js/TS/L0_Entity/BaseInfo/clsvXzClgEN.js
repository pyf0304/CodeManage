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
    exports.clsvXzClgEN = void 0;
    /**
    * 类名:clsvXzClgEN
    * 表名:vXzClg(01120139)
    * 版本:2023.02.24.1(服务器:WIN-SRV103-116)
    * 日期:2023/02/24 13:48:01
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
    * v学院(vXzClg)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvXzClgEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.id_XzCollege = ""; //学院流水号
            this.collegeID = ""; //学院ID
            this.collegeName = ""; //学院名称
            this.collegeIdInGP = ""; //CollegeIdInGP
            this.clgEnglishName = ""; //ClgEnglishName
            this.collegeNameA = ""; //学院名称简写
            this.phoneNumber = ""; //PhoneNumber
            this.webSite = ""; //个人主页
            this.id_School = ""; //学校流水号
            this.schoolId = ""; //学校编号
            this.schoolName = ""; //学校名称
            this.schoolNameA = ""; //学校简称
            this.id_Uni = ""; //id_Uni
            this.isVisible = false; //是否显示
            this.orderNum = 0; //序号
            this.modifyDate = ""; //修改日期
            this.modifyUserID = ""; //修改人
            this.memo = ""; //备注
            this.majorNum = 0; //MajorNum
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
                case clsvXzClgEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvXzClgEN.con_CollegeID:
                    return this.collegeID;
                case clsvXzClgEN.con_CollegeName:
                    return this.collegeName;
                case clsvXzClgEN.con_CollegeIdInGP:
                    return this.collegeIdInGP;
                case clsvXzClgEN.con_ClgEnglishName:
                    return this.clgEnglishName;
                case clsvXzClgEN.con_CollegeNameA:
                    return this.collegeNameA;
                case clsvXzClgEN.con_PhoneNumber:
                    return this.phoneNumber;
                case clsvXzClgEN.con_WebSite:
                    return this.webSite;
                case clsvXzClgEN.con_id_School:
                    return this.id_School;
                case clsvXzClgEN.con_SchoolId:
                    return this.schoolId;
                case clsvXzClgEN.con_SchoolName:
                    return this.schoolName;
                case clsvXzClgEN.con_SchoolNameA:
                    return this.schoolNameA;
                case clsvXzClgEN.con_id_Uni:
                    return this.id_Uni;
                case clsvXzClgEN.con_IsVisible:
                    return this.isVisible;
                case clsvXzClgEN.con_OrderNum:
                    return this.orderNum;
                case clsvXzClgEN.con_ModifyDate:
                    return this.modifyDate;
                case clsvXzClgEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsvXzClgEN.con_Memo:
                    return this.memo;
                case clsvXzClgEN.con_MajorNum:
                    return this.majorNum;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vXzClg]中不存在！`;
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
                case clsvXzClgEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvXzClgEN.con_CollegeID:
                    this.collegeID = strValue;
                    break;
                case clsvXzClgEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvXzClgEN.con_CollegeIdInGP:
                    this.collegeIdInGP = strValue;
                    break;
                case clsvXzClgEN.con_ClgEnglishName:
                    this.clgEnglishName = strValue;
                    break;
                case clsvXzClgEN.con_CollegeNameA:
                    this.collegeNameA = strValue;
                    break;
                case clsvXzClgEN.con_PhoneNumber:
                    this.phoneNumber = strValue;
                    break;
                case clsvXzClgEN.con_WebSite:
                    this.webSite = strValue;
                    break;
                case clsvXzClgEN.con_id_School:
                    this.id_School = strValue;
                    break;
                case clsvXzClgEN.con_SchoolId:
                    this.schoolId = strValue;
                    break;
                case clsvXzClgEN.con_SchoolName:
                    this.schoolName = strValue;
                    break;
                case clsvXzClgEN.con_SchoolNameA:
                    this.schoolNameA = strValue;
                    break;
                case clsvXzClgEN.con_id_Uni:
                    this.id_Uni = strValue;
                    break;
                case clsvXzClgEN.con_IsVisible:
                    this.isVisible = Boolean(strValue);
                    break;
                case clsvXzClgEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvXzClgEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    break;
                case clsvXzClgEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    break;
                case clsvXzClgEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvXzClgEN.con_MajorNum:
                    this.majorNum = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vXzClg]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"SchoolNameA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolNameA() { return "schoolNameA"; } //学校简称
        /**
        * 常量:"id_Uni"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Uni() { return "id_Uni"; } //id_Uni
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
        * 常量:"MajorNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorNum() { return "majorNum"; } //MajorNum
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
    exports.clsvXzClgEN = clsvXzClgEN;
    clsvXzClgEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvXzClgEN.CacheModeId = "05"; //未知
    clsvXzClgEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvXzClgEN.WhereFormat = ""; //条件格式串
    clsvXzClgEN._CurrTabName = "vXzClg"; //当前表名,与该类相关的表名
    clsvXzClgEN._KeyFldName = "id_XzCollege"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvXzClgEN.mintAttributeCount = 19;
    clsvXzClgEN.AttributeName = ["id_XzCollege", "collegeID", "collegeName", "collegeIdInGP", "clgEnglishName", "collegeNameA", "phoneNumber", "webSite", "id_School", "schoolId", "schoolName", "schoolNameA", "id_Uni", "isVisible", "orderNum", "modifyDate", "modifyUserID", "memo", "majorNum"];
});
