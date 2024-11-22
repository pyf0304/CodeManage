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
    exports.clsUsersEN = void 0;
    /**
    * 类名:clsUsersEN
    * 表名:Users(01120034)
    * 版本:2023.02.24.1(服务器:WIN-SRV103-116)
    * 日期:2023/02/24 13:39:14
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
    * 用户(Users)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsUsersEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrUserId = ""; //用户ID
            this.mstrUserName = ""; //用户名
            this.mstrDepartmentId = ""; //部门Id
            this.mstrUserStateId = ""; //用户状态Id
            this.mstrPassword = ""; //Password
            this.mbolIsGpUser = false; //是否Gp用户
            this.mstrSchoolID1 = ""; //学校编号
            this.mstrBeginYearMonth = ""; //开始年月
            this.mstrEndYearMonth = ""; //结束年月
            this.mstrid_GradeBase = ""; //年级流水号
            this.mstrid_XzCollege = ""; //学院流水号
            this.mstrid_XzMajor = ""; //专业流水号
            this.mbolIsLeaved = false; //IsLeaved
            this.mstrStuIdTeacherId = ""; //学工号
            this.mstrEmail = ""; //电子邮箱
            this.mstrPhoneNumber = ""; //PhoneNumber
            this.mstrAvatarsPicture = ""; //AvatarsPicture
            this.mstrIdentityID = ""; //身份编号
            this.mstrAuditDate = ""; //AuditDate
            this.mstrAuditUser = ""; //AuditUser
            this.mbolIsAudit = false; //是否审核
            this.mbolIsRegister = false; //IsRegister
            this.mstrRegisterDate = ""; //RegisterDate
            this.mstrMobilePhone = ""; //手机
            this.mstrOpenId = ""; //微信OpenId
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            this.mstrHeadPic = ""; //头像
            this.mbolIsGSuser = false; //是否GS用户
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.userId = ""; //用户ID
            this.userName = ""; //用户名
            this.departmentId = ""; //部门Id
            this.userStateId = ""; //用户状态Id
            this.password = ""; //Password
            this.isGpUser = false; //是否Gp用户
            this.schoolID1 = ""; //学校编号
            this.beginYearMonth = ""; //开始年月
            this.endYearMonth = ""; //结束年月
            this.id_GradeBase = ""; //年级流水号
            this.id_XzCollege = ""; //学院流水号
            this.id_XzMajor = ""; //专业流水号
            this.isLeaved = false; //IsLeaved
            this.stuIdTeacherId = ""; //学工号
            this.email = ""; //电子邮箱
            this.phoneNumber = ""; //PhoneNumber
            this.avatarsPicture = ""; //AvatarsPicture
            this.identityID = ""; //身份编号
            this.auditDate = ""; //AuditDate
            this.auditUser = ""; //AuditUser
            this.isAudit = false; //是否审核
            this.isRegister = false; //IsRegister
            this.registerDate = ""; //RegisterDate
            this.mobilePhone = ""; //手机
            this.openId = ""; //微信OpenId
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.headPic = ""; //头像
            this.isGSuser = false; //是否GS用户
        }
        /**
         * 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserId(value) {
            if (value != undefined) {
                this.userId = value;
                this.hmProperty["userId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 用户名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserName(value) {
            if (value != undefined) {
                this.userName = value;
                this.hmProperty["userName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDepartmentId(value) {
            if (value != undefined) {
                this.departmentId = value;
                this.hmProperty["departmentId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserStateId(value) {
            if (value != undefined) {
                this.userStateId = value;
                this.hmProperty["userStateId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * Password(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPassword(value) {
            if (value != undefined) {
                this.password = value;
                this.hmProperty["password"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否Gp用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsGpUser(value) {
            if (value != undefined) {
                this.isGpUser = value;
                this.hmProperty["isGpUser"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学校编号(说明:;字段类型:varchar;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolID1(value) {
            if (value != undefined) {
                this.schoolID1 = value;
                this.hmProperty["schoolID1"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 开始年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetBeginYearMonth(value) {
            if (value != undefined) {
                this.beginYearMonth = value;
                this.hmProperty["beginYearMonth"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 结束年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEndYearMonth(value) {
            if (value != undefined) {
                this.endYearMonth = value;
                this.hmProperty["endYearMonth"] = true;
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
         * IsLeaved(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsLeaved(value) {
            if (value != undefined) {
                this.isLeaved = value;
                this.hmProperty["isLeaved"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuIdTeacherId(value) {
            if (value != undefined) {
                this.stuIdTeacherId = value;
                this.hmProperty["stuIdTeacherId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 电子邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEmail(value) {
            if (value != undefined) {
                this.email = value;
                this.hmProperty["email"] = true;
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
         * AvatarsPicture(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAvatarsPicture(value) {
            if (value != undefined) {
                this.avatarsPicture = value;
                this.hmProperty["avatarsPicture"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIdentityID(value) {
            if (value != undefined) {
                this.identityID = value;
                this.hmProperty["identityID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * AuditDate(说明:;字段类型:varchar;字段长度:14;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAuditDate(value) {
            if (value != undefined) {
                this.auditDate = value;
                this.hmProperty["auditDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * AuditUser(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAuditUser(value) {
            if (value != undefined) {
                this.auditUser = value;
                this.hmProperty["auditUser"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否审核(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsAudit(value) {
            if (value != undefined) {
                this.isAudit = value;
                this.hmProperty["isAudit"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * IsRegister(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsRegister(value) {
            if (value != undefined) {
                this.isRegister = value;
                this.hmProperty["isRegister"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * RegisterDate(说明:;字段类型:varchar;字段长度:14;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRegisterDate(value) {
            if (value != undefined) {
                this.registerDate = value;
                this.hmProperty["registerDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 手机(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMobilePhone(value) {
            if (value != undefined) {
                this.mobilePhone = value;
                this.hmProperty["mobilePhone"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 微信OpenId(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOpenId(value) {
            if (value != undefined) {
                this.openId = value;
                this.hmProperty["openId"] = true;
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
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUser(value) {
            if (value != undefined) {
                this.updUser = value;
                this.hmProperty["updUser"] = true;
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
         * 头像(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetHeadPic(value) {
            if (value != undefined) {
                this.headPic = value;
                this.hmProperty["headPic"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否GS用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsGSuser(value) {
            if (value != undefined) {
                this.isGSuser = value;
                this.hmProperty["isGSuser"] = true;
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
                case clsUsersEN.con_UserId:
                    return this.userId;
                case clsUsersEN.con_UserName:
                    return this.userName;
                case clsUsersEN.con_DepartmentId:
                    return this.departmentId;
                case clsUsersEN.con_UserStateId:
                    return this.userStateId;
                case clsUsersEN.con_Password:
                    return this.password;
                case clsUsersEN.con_IsGpUser:
                    return this.isGpUser;
                case clsUsersEN.con_SchoolID1:
                    return this.schoolID1;
                case clsUsersEN.con_BeginYearMonth:
                    return this.beginYearMonth;
                case clsUsersEN.con_EndYearMonth:
                    return this.endYearMonth;
                case clsUsersEN.con_id_GradeBase:
                    return this.id_GradeBase;
                case clsUsersEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsUsersEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsUsersEN.con_IsLeaved:
                    return this.isLeaved;
                case clsUsersEN.con_StuIdTeacherId:
                    return this.stuIdTeacherId;
                case clsUsersEN.con_Email:
                    return this.email;
                case clsUsersEN.con_PhoneNumber:
                    return this.phoneNumber;
                case clsUsersEN.con_AvatarsPicture:
                    return this.avatarsPicture;
                case clsUsersEN.con_IdentityID:
                    return this.identityID;
                case clsUsersEN.con_AuditDate:
                    return this.auditDate;
                case clsUsersEN.con_AuditUser:
                    return this.auditUser;
                case clsUsersEN.con_IsAudit:
                    return this.isAudit;
                case clsUsersEN.con_IsRegister:
                    return this.isRegister;
                case clsUsersEN.con_RegisterDate:
                    return this.registerDate;
                case clsUsersEN.con_MobilePhone:
                    return this.mobilePhone;
                case clsUsersEN.con_OpenId:
                    return this.openId;
                case clsUsersEN.con_UpdDate:
                    return this.updDate;
                case clsUsersEN.con_UpdUser:
                    return this.updUser;
                case clsUsersEN.con_Memo:
                    return this.memo;
                case clsUsersEN.con_HeadPic:
                    return this.headPic;
                case clsUsersEN.con_IsGSuser:
                    return this.isGSuser;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[Users]中不存在！`;
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
                case clsUsersEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case clsUsersEN.con_UserName:
                    this.userName = strValue;
                    this.hmProperty["userName"] = true;
                    break;
                case clsUsersEN.con_DepartmentId:
                    this.departmentId = strValue;
                    this.hmProperty["departmentId"] = true;
                    break;
                case clsUsersEN.con_UserStateId:
                    this.userStateId = strValue;
                    this.hmProperty["userStateId"] = true;
                    break;
                case clsUsersEN.con_Password:
                    this.password = strValue;
                    this.hmProperty["password"] = true;
                    break;
                case clsUsersEN.con_IsGpUser:
                    this.isGpUser = Boolean(strValue);
                    this.hmProperty["isGpUser"] = true;
                    break;
                case clsUsersEN.con_SchoolID1:
                    this.schoolID1 = strValue;
                    this.hmProperty["schoolID1"] = true;
                    break;
                case clsUsersEN.con_BeginYearMonth:
                    this.beginYearMonth = strValue;
                    this.hmProperty["beginYearMonth"] = true;
                    break;
                case clsUsersEN.con_EndYearMonth:
                    this.endYearMonth = strValue;
                    this.hmProperty["endYearMonth"] = true;
                    break;
                case clsUsersEN.con_id_GradeBase:
                    this.id_GradeBase = strValue;
                    this.hmProperty["id_GradeBase"] = true;
                    break;
                case clsUsersEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    this.hmProperty["id_XzCollege"] = true;
                    break;
                case clsUsersEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    this.hmProperty["id_XzMajor"] = true;
                    break;
                case clsUsersEN.con_IsLeaved:
                    this.isLeaved = Boolean(strValue);
                    this.hmProperty["isLeaved"] = true;
                    break;
                case clsUsersEN.con_StuIdTeacherId:
                    this.stuIdTeacherId = strValue;
                    this.hmProperty["stuIdTeacherId"] = true;
                    break;
                case clsUsersEN.con_Email:
                    this.email = strValue;
                    this.hmProperty["email"] = true;
                    break;
                case clsUsersEN.con_PhoneNumber:
                    this.phoneNumber = strValue;
                    this.hmProperty["phoneNumber"] = true;
                    break;
                case clsUsersEN.con_AvatarsPicture:
                    this.avatarsPicture = strValue;
                    this.hmProperty["avatarsPicture"] = true;
                    break;
                case clsUsersEN.con_IdentityID:
                    this.identityID = strValue;
                    this.hmProperty["identityID"] = true;
                    break;
                case clsUsersEN.con_AuditDate:
                    this.auditDate = strValue;
                    this.hmProperty["auditDate"] = true;
                    break;
                case clsUsersEN.con_AuditUser:
                    this.auditUser = strValue;
                    this.hmProperty["auditUser"] = true;
                    break;
                case clsUsersEN.con_IsAudit:
                    this.isAudit = Boolean(strValue);
                    this.hmProperty["isAudit"] = true;
                    break;
                case clsUsersEN.con_IsRegister:
                    this.isRegister = Boolean(strValue);
                    this.hmProperty["isRegister"] = true;
                    break;
                case clsUsersEN.con_RegisterDate:
                    this.registerDate = strValue;
                    this.hmProperty["registerDate"] = true;
                    break;
                case clsUsersEN.con_MobilePhone:
                    this.mobilePhone = strValue;
                    this.hmProperty["mobilePhone"] = true;
                    break;
                case clsUsersEN.con_OpenId:
                    this.openId = strValue;
                    this.hmProperty["openId"] = true;
                    break;
                case clsUsersEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsUsersEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsUsersEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsUsersEN.con_HeadPic:
                    this.headPic = strValue;
                    this.hmProperty["headPic"] = true;
                    break;
                case clsUsersEN.con_IsGSuser:
                    this.isGSuser = Boolean(strValue);
                    this.hmProperty["isGSuser"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[Users]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"DepartmentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DepartmentId() { return "departmentId"; } //部门Id
        /**
        * 常量:"UserStateId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserStateId() { return "userStateId"; } //用户状态Id
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
        * 常量:"SchoolID1"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolID1() { return "schoolID1"; } //学校编号
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
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
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
        * 常量:"AvatarsPicture"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AvatarsPicture() { return "avatarsPicture"; } //AvatarsPicture
        /**
        * 常量:"IdentityID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IdentityID() { return "identityID"; } //身份编号
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
        * 常量:"OpenId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OpenId() { return "openId"; } //微信OpenId
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
    exports.clsUsersEN = clsUsersEN;
    clsUsersEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsUsersEN.CacheModeId = "02"; //客户端缓存
    clsUsersEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsUsersEN.WhereFormat = ""; //条件格式串
    clsUsersEN._CurrTabName = "Users"; //当前表名,与该类相关的表名
    clsUsersEN._KeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsUsersEN.mintAttributeCount = 30;
    clsUsersEN.AttributeName = ["userId", "userName", "departmentId", "userStateId", "password", "isGpUser", "schoolID1", "beginYearMonth", "endYearMonth", "id_GradeBase", "id_XzCollege", "id_XzMajor", "isLeaved", "stuIdTeacherId", "email", "phoneNumber", "avatarsPicture", "identityID", "auditDate", "auditUser", "isAudit", "isRegister", "registerDate", "mobilePhone", "openId", "updDate", "updUser", "memo", "headPic", "isGSuser"];
});
