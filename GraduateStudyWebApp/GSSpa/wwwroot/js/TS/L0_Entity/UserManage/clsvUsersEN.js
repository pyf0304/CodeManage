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
    exports.clsvUsersEN = void 0;
    /**
    * 类名:clsvUsersEN
    * 表名:vUsers(01120027)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:21
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:用户管理(UserManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v用户(vUsers)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvUsersEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.userId = ""; //用户ID
            this.userName = ""; //用户名
            this.userStateId = ""; //用户状态Id
            this.userStateName = ""; //用户状态名
            this.password = ""; //Password
            this.isGpUser = false; //是否Gp用户
            this.beginYearMonth = ""; //开始年月
            this.endYearMonth = ""; //结束年月
            this.id_GradeBase = ""; //年级流水号
            this.gradeBaseName = ""; //年级名称
            this.id_XzCollege = ""; //学院流水号
            this.collegeID = ""; //学院ID
            this.collegeName = ""; //学院名称
            this.collegeNameA = ""; //学院名称简写
            this.id_XzMajor = ""; //专业流水号
            this.majorName = ""; //专业名称
            this.isLeaved = false; //IsLeaved
            this.stuIdTeacherId = ""; //学工号
            this.identityID = ""; //身份编号
            this.identityDesc = ""; //身份描述
            this.auditDate = ""; //AuditDate
            this.auditUser = ""; //AuditUser
            this.isAudit = false; //是否审核
            this.isRegister = false; //IsRegister
            this.registerDate = ""; //RegisterDate
            this.mobilePhone = ""; //手机
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.userNameWithUserId = ""; //UserNameWithUserId
            this.openId = ""; //微信OpenId
            this.avatarsPicture = ""; //AvatarsPicture
            this.email = ""; //电子邮箱
            this.phoneNumber = ""; //PhoneNumber
            this.headPic = ""; //头像
            this.isGSuser = false; //是否GS用户
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
                case clsvUsersEN.con_UserId:
                    return this.userId;
                case clsvUsersEN.con_UserName:
                    return this.userName;
                case clsvUsersEN.con_UserStateId:
                    return this.userStateId;
                case clsvUsersEN.con_UserStateName:
                    return this.userStateName;
                case clsvUsersEN.con_Password:
                    return this.password;
                case clsvUsersEN.con_IsGpUser:
                    return this.isGpUser;
                case clsvUsersEN.con_BeginYearMonth:
                    return this.beginYearMonth;
                case clsvUsersEN.con_EndYearMonth:
                    return this.endYearMonth;
                case clsvUsersEN.con_id_GradeBase:
                    return this.id_GradeBase;
                case clsvUsersEN.con_GradeBaseName:
                    return this.gradeBaseName;
                case clsvUsersEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvUsersEN.con_CollegeID:
                    return this.collegeID;
                case clsvUsersEN.con_CollegeName:
                    return this.collegeName;
                case clsvUsersEN.con_CollegeNameA:
                    return this.collegeNameA;
                case clsvUsersEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvUsersEN.con_MajorName:
                    return this.majorName;
                case clsvUsersEN.con_IsLeaved:
                    return this.isLeaved;
                case clsvUsersEN.con_StuIdTeacherId:
                    return this.stuIdTeacherId;
                case clsvUsersEN.con_IdentityID:
                    return this.identityID;
                case clsvUsersEN.con_IdentityDesc:
                    return this.identityDesc;
                case clsvUsersEN.con_AuditDate:
                    return this.auditDate;
                case clsvUsersEN.con_AuditUser:
                    return this.auditUser;
                case clsvUsersEN.con_IsAudit:
                    return this.isAudit;
                case clsvUsersEN.con_IsRegister:
                    return this.isRegister;
                case clsvUsersEN.con_RegisterDate:
                    return this.registerDate;
                case clsvUsersEN.con_MobilePhone:
                    return this.mobilePhone;
                case clsvUsersEN.con_UpdDate:
                    return this.updDate;
                case clsvUsersEN.con_UpdUser:
                    return this.updUser;
                case clsvUsersEN.con_Memo:
                    return this.memo;
                case clsvUsersEN.con_UserNameWithUserId:
                    return this.userNameWithUserId;
                case clsvUsersEN.con_OpenId:
                    return this.openId;
                case clsvUsersEN.con_AvatarsPicture:
                    return this.avatarsPicture;
                case clsvUsersEN.con_Email:
                    return this.email;
                case clsvUsersEN.con_PhoneNumber:
                    return this.phoneNumber;
                case clsvUsersEN.con_HeadPic:
                    return this.headPic;
                case clsvUsersEN.con_IsGSuser:
                    return this.isGSuser;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vUsers]中不存在！`;
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
                case clsvUsersEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvUsersEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvUsersEN.con_UserStateId:
                    this.userStateId = strValue;
                    break;
                case clsvUsersEN.con_UserStateName:
                    this.userStateName = strValue;
                    break;
                case clsvUsersEN.con_Password:
                    this.password = strValue;
                    break;
                case clsvUsersEN.con_IsGpUser:
                    this.isGpUser = Boolean(strValue);
                    break;
                case clsvUsersEN.con_BeginYearMonth:
                    this.beginYearMonth = strValue;
                    break;
                case clsvUsersEN.con_EndYearMonth:
                    this.endYearMonth = strValue;
                    break;
                case clsvUsersEN.con_id_GradeBase:
                    this.id_GradeBase = strValue;
                    break;
                case clsvUsersEN.con_GradeBaseName:
                    this.gradeBaseName = strValue;
                    break;
                case clsvUsersEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvUsersEN.con_CollegeID:
                    this.collegeID = strValue;
                    break;
                case clsvUsersEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvUsersEN.con_CollegeNameA:
                    this.collegeNameA = strValue;
                    break;
                case clsvUsersEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvUsersEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvUsersEN.con_IsLeaved:
                    this.isLeaved = Boolean(strValue);
                    break;
                case clsvUsersEN.con_StuIdTeacherId:
                    this.stuIdTeacherId = strValue;
                    break;
                case clsvUsersEN.con_IdentityID:
                    this.identityID = strValue;
                    break;
                case clsvUsersEN.con_IdentityDesc:
                    this.identityDesc = strValue;
                    break;
                case clsvUsersEN.con_AuditDate:
                    this.auditDate = strValue;
                    break;
                case clsvUsersEN.con_AuditUser:
                    this.auditUser = strValue;
                    break;
                case clsvUsersEN.con_IsAudit:
                    this.isAudit = Boolean(strValue);
                    break;
                case clsvUsersEN.con_IsRegister:
                    this.isRegister = Boolean(strValue);
                    break;
                case clsvUsersEN.con_RegisterDate:
                    this.registerDate = strValue;
                    break;
                case clsvUsersEN.con_MobilePhone:
                    this.mobilePhone = strValue;
                    break;
                case clsvUsersEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvUsersEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvUsersEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvUsersEN.con_UserNameWithUserId:
                    this.userNameWithUserId = strValue;
                    break;
                case clsvUsersEN.con_OpenId:
                    this.openId = strValue;
                    break;
                case clsvUsersEN.con_AvatarsPicture:
                    this.avatarsPicture = strValue;
                    break;
                case clsvUsersEN.con_Email:
                    this.email = strValue;
                    break;
                case clsvUsersEN.con_PhoneNumber:
                    this.phoneNumber = strValue;
                    break;
                case clsvUsersEN.con_HeadPic:
                    this.headPic = strValue;
                    break;
                case clsvUsersEN.con_IsGSuser:
                    this.isGSuser = Boolean(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vUsers]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"UserStateId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserStateId() { return "userStateId"; } //用户状态Id
        /**
        * 常量:"UserStateName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserStateName() { return "userStateName"; } //用户状态名
        /**
        * 常量:"Password"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Password() { return "password"; } //Password
        /**
        * 常量:"IsGpUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsGpUser() { return "isGpUser"; } //是否Gp用户
        /**
        * 常量:"BeginYearMonth"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BeginYearMonth() { return "beginYearMonth"; } //开始年月
        /**
        * 常量:"EndYearMonth"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EndYearMonth() { return "endYearMonth"; } //结束年月
        /**
        * 常量:"id_GradeBase"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_GradeBase() { return "id_GradeBase"; } //年级流水号
        /**
        * 常量:"GradeBaseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GradeBaseName() { return "gradeBaseName"; } //年级名称
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
        * 常量:"CollegeNameA"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollegeNameA() { return "collegeNameA"; } //学院名称简写
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
        /**
        * 常量:"IsLeaved"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsLeaved() { return "isLeaved"; } //IsLeaved
        /**
        * 常量:"StuIdTeacherId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuIdTeacherId() { return "stuIdTeacherId"; } //学工号
        /**
        * 常量:"IdentityID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IdentityID() { return "identityID"; } //身份编号
        /**
        * 常量:"IdentityDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IdentityDesc() { return "identityDesc"; } //身份描述
        /**
        * 常量:"AuditDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AuditDate() { return "auditDate"; } //AuditDate
        /**
        * 常量:"AuditUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AuditUser() { return "auditUser"; } //AuditUser
        /**
        * 常量:"IsAudit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsAudit() { return "isAudit"; } //是否审核
        /**
        * 常量:"IsRegister"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRegister() { return "isRegister"; } //IsRegister
        /**
        * 常量:"RegisterDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RegisterDate() { return "registerDate"; } //RegisterDate
        /**
        * 常量:"MobilePhone"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MobilePhone() { return "mobilePhone"; } //手机
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"UserNameWithUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserNameWithUserId() { return "userNameWithUserId"; } //UserNameWithUserId
        /**
        * 常量:"OpenId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OpenId() { return "openId"; } //微信OpenId
        /**
        * 常量:"AvatarsPicture"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AvatarsPicture() { return "avatarsPicture"; } //AvatarsPicture
        /**
        * 常量:"Email"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Email() { return "email"; } //电子邮箱
        /**
        * 常量:"PhoneNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PhoneNumber() { return "phoneNumber"; } //PhoneNumber
        /**
        * 常量:"HeadPic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_HeadPic() { return "headPic"; } //头像
        /**
        * 常量:"IsGSuser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsGSuser() { return "isGSuser"; } //是否GS用户
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
    exports.clsvUsersEN = clsvUsersEN;
    clsvUsersEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvUsersEN.CacheModeId = "04"; //sessionStorage
    clsvUsersEN._CurrTabName = "vUsers"; //当前表名,与该类相关的表名
    clsvUsersEN._KeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvUsersEN.mintAttributeCount = 36;
    clsvUsersEN.AttributeName = ["userId", "userName", "userStateId", "userStateName", "password", "isGpUser", "beginYearMonth", "endYearMonth", "id_GradeBase", "gradeBaseName", "id_XzCollege", "collegeID", "collegeName", "collegeNameA", "id_XzMajor", "majorName", "isLeaved", "stuIdTeacherId", "identityID", "identityDesc", "auditDate", "auditUser", "isAudit", "isRegister", "registerDate", "mobilePhone", "updDate", "updUser", "memo", "userNameWithUserId", "openId", "avatarsPicture", "email", "phoneNumber", "headPic", "isGSuser"];
});
