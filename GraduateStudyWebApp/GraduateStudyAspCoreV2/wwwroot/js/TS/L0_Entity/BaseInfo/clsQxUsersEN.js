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
    exports.clsQxUsersEN = void 0;
    /**
    * 类名:clsQxUsersEN
    * 表名:QxUsers(01120258)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:52:32
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
    * Qx用户(QxUsers)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsQxUsersEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrid_XzCollege = ""; //学院流水号
            this.mstrUserStateId = ""; //用户状态Id
            this.mstrid_GradeBase = ""; //年级流水号
            this.mstrCard_State = ""; //Card_State
            this.mbolIsLeaved = false; //IsLeaved
            this.mstrCardNo = ""; //卡号
            this.mstrBeginYearMonth = ""; //开始年月
            this.mstrEndYearMonth = ""; //结束年月
            this.mstrOptUser = ""; //OptUser
            this.mstrOptDate = ""; //OptDate
            this.mstrMemo = ""; //备注
            this.mstrPassword = ""; //Password
            this.mbolIsGpUser = false; //是否Gp用户
            this.mstrSchoolID1 = ""; //学校编号
            this.mstrAvatarsPicture = ""; //AvatarsPicture
            this.mstrEmail = ""; //电子邮箱
            this.mstrPhoneNumber = ""; //PhoneNumber
            this.mstrEffectiveDate = ""; //EffectiveDate
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrEffitiveBeginDate = ""; //EffitiveBeginDate
            this.mstrEffitiveEndDate = ""; //EffitiveEndDate
            this.mstrid_College = ""; //学院流水号
            this.mstrStuTeacherID = ""; //学工号
            this.mstrIdentityID = ""; //身份编号
            this.mbolIsArchive = false; //IsArchive
            this.mstrHeadimgUrl = ""; //微信头像
            this.mstrOpenId = ""; //微信OpenId
            this.mstrNickName = ""; //昵称
            this.mbolIsSynch = false; //是否同步
            this.mstrSynchDate = ""; //同步日期
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.userId = ""; //用户ID
            this.userName = ""; //用户名
            this.departmentId = ""; //部门Id
            this.id_XzCollege = ""; //学院流水号
            this.userStateId = ""; //用户状态Id
            this.id_GradeBase = ""; //年级流水号
            this.card_State = ""; //Card_State
            this.isLeaved = false; //IsLeaved
            this.cardNo = ""; //卡号
            this.beginYearMonth = ""; //开始年月
            this.endYearMonth = ""; //结束年月
            this.optUser = ""; //OptUser
            this.optDate = ""; //OptDate
            this.memo = ""; //备注
            this.password = ""; //Password
            this.isGpUser = false; //是否Gp用户
            this.schoolID1 = ""; //学校编号
            this.avatarsPicture = ""; //AvatarsPicture
            this.email = ""; //电子邮箱
            this.phoneNumber = ""; //PhoneNumber
            this.effectiveDate = ""; //EffectiveDate
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.effitiveBeginDate = ""; //EffitiveBeginDate
            this.effitiveEndDate = ""; //EffitiveEndDate
            this.id_College = ""; //学院流水号
            this.stuTeacherID = ""; //学工号
            this.identityID = ""; //身份编号
            this.isArchive = false; //IsArchive
            this.headimgUrl = ""; //微信头像
            this.openId = ""; //微信OpenId
            this.nickName = ""; //昵称
            this.isSynch = false; //是否同步
            this.synchDate = ""; //同步日期
        }
        /**
         * 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
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
         * 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
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
         * Card_State(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCard_State(value) {
            if (value != undefined) {
                this.card_State = value;
                this.hmProperty["card_State"] = true;
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
         * 卡号(说明:;字段类型:varchar;字段长度:18;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCardNo(value) {
            if (value != undefined) {
                this.cardNo = value;
                this.hmProperty["cardNo"] = true;
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
         * OptUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOptUser(value) {
            if (value != undefined) {
                this.optUser = value;
                this.hmProperty["optUser"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * OptDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOptDate(value) {
            if (value != undefined) {
                this.optDate = value;
                this.hmProperty["optDate"] = true;
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
         * EffectiveDate(说明:;字段类型:varchar;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEffectiveDate(value) {
            if (value != undefined) {
                this.effectiveDate = value;
                this.hmProperty["effectiveDate"] = true;
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
         * EffitiveBeginDate(说明:;字段类型:varchar;字段长度:14;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEffitiveBeginDate(value) {
            if (value != undefined) {
                this.effitiveBeginDate = value;
                this.hmProperty["effitiveBeginDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * EffitiveEndDate(说明:;字段类型:varchar;字段长度:14;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEffitiveEndDate(value) {
            if (value != undefined) {
                this.effitiveEndDate = value;
                this.hmProperty["effitiveEndDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_College(value) {
            if (value != undefined) {
                this.id_College = value;
                this.hmProperty["id_College"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuTeacherID(value) {
            if (value != undefined) {
                this.stuTeacherID = value;
                this.hmProperty["stuTeacherID"] = true;
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
         * IsArchive(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsArchive(value) {
            if (value != undefined) {
                this.isArchive = value;
                this.hmProperty["isArchive"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 微信头像(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetHeadimgUrl(value) {
            if (value != undefined) {
                this.headimgUrl = value;
                this.hmProperty["headimgUrl"] = true;
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
         * 昵称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetNickName(value) {
            if (value != undefined) {
                this.nickName = value;
                this.hmProperty["nickName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否同步(说明:;字段类型:bit;字段长度:1;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSynch(value) {
            if (value != undefined) {
                this.isSynch = value;
                this.hmProperty["isSynch"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 同步日期(说明:;字段类型:varchar;字段长度:30;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSynchDate(value) {
            if (value != undefined) {
                this.synchDate = value;
                this.hmProperty["synchDate"] = true;
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
                case clsQxUsersEN.con_UserId:
                    return this.userId;
                case clsQxUsersEN.con_UserName:
                    return this.userName;
                case clsQxUsersEN.con_DepartmentId:
                    return this.departmentId;
                case clsQxUsersEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsQxUsersEN.con_UserStateId:
                    return this.userStateId;
                case clsQxUsersEN.con_id_GradeBase:
                    return this.id_GradeBase;
                case clsQxUsersEN.con_Card_State:
                    return this.card_State;
                case clsQxUsersEN.con_IsLeaved:
                    return this.isLeaved;
                case clsQxUsersEN.con_CardNo:
                    return this.cardNo;
                case clsQxUsersEN.con_BeginYearMonth:
                    return this.beginYearMonth;
                case clsQxUsersEN.con_EndYearMonth:
                    return this.endYearMonth;
                case clsQxUsersEN.con_OptUser:
                    return this.optUser;
                case clsQxUsersEN.con_OptDate:
                    return this.optDate;
                case clsQxUsersEN.con_Memo:
                    return this.memo;
                case clsQxUsersEN.con_Password:
                    return this.password;
                case clsQxUsersEN.con_IsGpUser:
                    return this.isGpUser;
                case clsQxUsersEN.con_SchoolID1:
                    return this.schoolID1;
                case clsQxUsersEN.con_AvatarsPicture:
                    return this.avatarsPicture;
                case clsQxUsersEN.con_Email:
                    return this.email;
                case clsQxUsersEN.con_PhoneNumber:
                    return this.phoneNumber;
                case clsQxUsersEN.con_EffectiveDate:
                    return this.effectiveDate;
                case clsQxUsersEN.con_UpdDate:
                    return this.updDate;
                case clsQxUsersEN.con_UpdUser:
                    return this.updUser;
                case clsQxUsersEN.con_EffitiveBeginDate:
                    return this.effitiveBeginDate;
                case clsQxUsersEN.con_EffitiveEndDate:
                    return this.effitiveEndDate;
                case clsQxUsersEN.con_id_College:
                    return this.id_College;
                case clsQxUsersEN.con_StuTeacherID:
                    return this.stuTeacherID;
                case clsQxUsersEN.con_IdentityID:
                    return this.identityID;
                case clsQxUsersEN.con_IsArchive:
                    return this.isArchive;
                case clsQxUsersEN.con_HeadimgUrl:
                    return this.headimgUrl;
                case clsQxUsersEN.con_OpenId:
                    return this.openId;
                case clsQxUsersEN.con_NickName:
                    return this.nickName;
                case clsQxUsersEN.con_IsSynch:
                    return this.isSynch;
                case clsQxUsersEN.con_SynchDate:
                    return this.synchDate;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[QxUsers]中不存在！`;
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
                case clsQxUsersEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case clsQxUsersEN.con_UserName:
                    this.userName = strValue;
                    this.hmProperty["userName"] = true;
                    break;
                case clsQxUsersEN.con_DepartmentId:
                    this.departmentId = strValue;
                    this.hmProperty["departmentId"] = true;
                    break;
                case clsQxUsersEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    this.hmProperty["id_XzCollege"] = true;
                    break;
                case clsQxUsersEN.con_UserStateId:
                    this.userStateId = strValue;
                    this.hmProperty["userStateId"] = true;
                    break;
                case clsQxUsersEN.con_id_GradeBase:
                    this.id_GradeBase = strValue;
                    this.hmProperty["id_GradeBase"] = true;
                    break;
                case clsQxUsersEN.con_Card_State:
                    this.card_State = strValue;
                    this.hmProperty["card_State"] = true;
                    break;
                case clsQxUsersEN.con_IsLeaved:
                    this.isLeaved = Boolean(strValue);
                    this.hmProperty["isLeaved"] = true;
                    break;
                case clsQxUsersEN.con_CardNo:
                    this.cardNo = strValue;
                    this.hmProperty["cardNo"] = true;
                    break;
                case clsQxUsersEN.con_BeginYearMonth:
                    this.beginYearMonth = strValue;
                    this.hmProperty["beginYearMonth"] = true;
                    break;
                case clsQxUsersEN.con_EndYearMonth:
                    this.endYearMonth = strValue;
                    this.hmProperty["endYearMonth"] = true;
                    break;
                case clsQxUsersEN.con_OptUser:
                    this.optUser = strValue;
                    this.hmProperty["optUser"] = true;
                    break;
                case clsQxUsersEN.con_OptDate:
                    this.optDate = strValue;
                    this.hmProperty["optDate"] = true;
                    break;
                case clsQxUsersEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsQxUsersEN.con_Password:
                    this.password = strValue;
                    this.hmProperty["password"] = true;
                    break;
                case clsQxUsersEN.con_IsGpUser:
                    this.isGpUser = Boolean(strValue);
                    this.hmProperty["isGpUser"] = true;
                    break;
                case clsQxUsersEN.con_SchoolID1:
                    this.schoolID1 = strValue;
                    this.hmProperty["schoolID1"] = true;
                    break;
                case clsQxUsersEN.con_AvatarsPicture:
                    this.avatarsPicture = strValue;
                    this.hmProperty["avatarsPicture"] = true;
                    break;
                case clsQxUsersEN.con_Email:
                    this.email = strValue;
                    this.hmProperty["email"] = true;
                    break;
                case clsQxUsersEN.con_PhoneNumber:
                    this.phoneNumber = strValue;
                    this.hmProperty["phoneNumber"] = true;
                    break;
                case clsQxUsersEN.con_EffectiveDate:
                    this.effectiveDate = strValue;
                    this.hmProperty["effectiveDate"] = true;
                    break;
                case clsQxUsersEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsQxUsersEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsQxUsersEN.con_EffitiveBeginDate:
                    this.effitiveBeginDate = strValue;
                    this.hmProperty["effitiveBeginDate"] = true;
                    break;
                case clsQxUsersEN.con_EffitiveEndDate:
                    this.effitiveEndDate = strValue;
                    this.hmProperty["effitiveEndDate"] = true;
                    break;
                case clsQxUsersEN.con_id_College:
                    this.id_College = strValue;
                    this.hmProperty["id_College"] = true;
                    break;
                case clsQxUsersEN.con_StuTeacherID:
                    this.stuTeacherID = strValue;
                    this.hmProperty["stuTeacherID"] = true;
                    break;
                case clsQxUsersEN.con_IdentityID:
                    this.identityID = strValue;
                    this.hmProperty["identityID"] = true;
                    break;
                case clsQxUsersEN.con_IsArchive:
                    this.isArchive = Boolean(strValue);
                    this.hmProperty["isArchive"] = true;
                    break;
                case clsQxUsersEN.con_HeadimgUrl:
                    this.headimgUrl = strValue;
                    this.hmProperty["headimgUrl"] = true;
                    break;
                case clsQxUsersEN.con_OpenId:
                    this.openId = strValue;
                    this.hmProperty["openId"] = true;
                    break;
                case clsQxUsersEN.con_NickName:
                    this.nickName = strValue;
                    this.hmProperty["nickName"] = true;
                    break;
                case clsQxUsersEN.con_IsSynch:
                    this.isSynch = Boolean(strValue);
                    this.hmProperty["isSynch"] = true;
                    break;
                case clsQxUsersEN.con_SynchDate:
                    this.synchDate = strValue;
                    this.hmProperty["synchDate"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[QxUsers]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
        /**
        * 常量:"UserStateId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserStateId() { return "userStateId"; } //用户状态Id
        /**
        * 常量:"id_GradeBase"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_GradeBase() { return "id_GradeBase"; } //年级流水号
        /**
        * 常量:"Card_State"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Card_State() { return "card_State"; } //Card_State
        /**
        * 常量:"IsLeaved"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsLeaved() { return "isLeaved"; } //IsLeaved
        /**
        * 常量:"CardNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CardNo() { return "cardNo"; } //卡号
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
        * 常量:"OptUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OptUser() { return "optUser"; } //OptUser
        /**
        * 常量:"OptDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OptDate() { return "optDate"; } //OptDate
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
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
        * 常量:"EffectiveDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EffectiveDate() { return "effectiveDate"; } //EffectiveDate
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
        * 常量:"EffitiveBeginDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EffitiveBeginDate() { return "effitiveBeginDate"; } //EffitiveBeginDate
        /**
        * 常量:"EffitiveEndDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EffitiveEndDate() { return "effitiveEndDate"; } //EffitiveEndDate
        /**
        * 常量:"id_College"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_College() { return "id_College"; } //学院流水号
        /**
        * 常量:"StuTeacherID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuTeacherID() { return "stuTeacherID"; } //学工号
        /**
        * 常量:"IdentityID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IdentityID() { return "identityID"; } //身份编号
        /**
        * 常量:"IsArchive"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsArchive() { return "isArchive"; } //IsArchive
        /**
        * 常量:"HeadimgUrl"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_HeadimgUrl() { return "headimgUrl"; } //微信头像
        /**
        * 常量:"OpenId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OpenId() { return "openId"; } //微信OpenId
        /**
        * 常量:"NickName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_NickName() { return "nickName"; } //昵称
        /**
        * 常量:"IsSynch"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSynch() { return "isSynch"; } //是否同步
        /**
        * 常量:"SynchDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SynchDate() { return "synchDate"; } //同步日期
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
    exports.clsQxUsersEN = clsQxUsersEN;
    clsQxUsersEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsQxUsersEN.CacheModeId = "02"; //客户端缓存
    clsQxUsersEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsQxUsersEN.WhereFormat = ""; //条件格式串
    clsQxUsersEN._CurrTabName = "QxUsers"; //当前表名,与该类相关的表名
    clsQxUsersEN._KeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsQxUsersEN.mintAttributeCount = 34;
    clsQxUsersEN.AttributeName = ["userId", "userName", "departmentId", "id_XzCollege", "userStateId", "id_GradeBase", "card_State", "isLeaved", "cardNo", "beginYearMonth", "endYearMonth", "optUser", "optDate", "memo", "password", "isGpUser", "schoolID1", "avatarsPicture", "email", "phoneNumber", "effectiveDate", "updDate", "updUser", "effitiveBeginDate", "effitiveEndDate", "id_College", "stuTeacherID", "identityID", "isArchive", "headimgUrl", "openId", "nickName", "isSynch", "synchDate"];
});
