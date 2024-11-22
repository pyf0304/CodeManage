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
    exports.clsStudentInfoEN = void 0;
    /**
    * 类名:clsStudentInfoEN
    * 表名:StudentInfo(01120131)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:45:57
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
    * 学生(StudentInfo)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsStudentInfoEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrid_StudentInfo = ""; //学生流水号
            this.mstrStuID = ""; //学号
            this.mstrStuName = ""; //姓名
            this.mstrid_Politics = ""; //政治面貌流水号
            this.mstrid_Sex = ""; //性别流水号
            this.mstrid_Ethnic = ""; //民族流水号
            this.mstrid_UniZone = ""; //校区流水号
            this.mstrid_StuType = ""; //学生类别流水号
            this.mstrid_XzCollege = ""; //学院流水号
            this.mstrid_XzMajor = ""; //专业流水号
            this.mstrid_GradeBase = ""; //年级流水号
            this.mstrid_AdminCls = ""; //行政班流水号
            this.mstrBirthday = ""; //出生日期
            this.mstrNativePlace = ""; //籍贯
            this.mstrDuty = ""; //职位
            this.mstrIDCardNo = ""; //身份证号
            this.mstrStuCardNo = ""; //学生证号
            this.mstrLiveAddress = ""; //居住地址
            this.mstrHomePhone = ""; //住宅电话
            this.mstrId_CardNo = ""; //内卡号
            this.mstrCardNo = ""; //卡号
            this.mbolIsAvconClassUser = false; //IsAvconClassUser
            this.mbolIsAvconUser = false; //IsAvconUser
            this.mbolIsGpUser = false; //是否Gp用户
            this.mbolIsLocalUser = false; //是否本地用户
            this.mbolIsLeaved = false; //IsLeaved
            this.mstrUserId = ""; //用户ID
            this.mstrUserID4Avcon = ""; //UserID4Avcon
            this.mstrEnrollmentDate = ""; //入校日期
            this.mstrPostCode = ""; //邮编
            this.mstrEmail = ""; //电子邮箱
            this.mbolIsMessage = false; //IsMessage
            this.mstrMicroblog = ""; //Microblog
            this.mstrPhoneNumber = ""; //PhoneNumber
            this.mstrHeadphoto = ""; //Headphoto
            this.mstrQQ = ""; //QQ
            this.mstrRegisterPassword = ""; //RegisterPassword
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_StudentInfo = ""; //学生流水号
            this.stuID = ""; //学号
            this.stuName = ""; //姓名
            this.id_Politics = ""; //政治面貌流水号
            this.id_Sex = ""; //性别流水号
            this.id_Ethnic = ""; //民族流水号
            this.id_UniZone = ""; //校区流水号
            this.id_StuType = ""; //学生类别流水号
            this.id_XzCollege = ""; //学院流水号
            this.id_XzMajor = ""; //专业流水号
            this.id_GradeBase = ""; //年级流水号
            this.id_AdminCls = ""; //行政班流水号
            this.birthday = ""; //出生日期
            this.nativePlace = ""; //籍贯
            this.duty = ""; //职位
            this.idCardNo = ""; //身份证号
            this.stuCardNo = ""; //学生证号
            this.liveAddress = ""; //居住地址
            this.homePhone = ""; //住宅电话
            this.id_CardNo = ""; //内卡号
            this.cardNo = ""; //卡号
            this.isAvconClassUser = false; //IsAvconClassUser
            this.isAvconUser = false; //IsAvconUser
            this.isGpUser = false; //是否Gp用户
            this.isLocalUser = false; //是否本地用户
            this.isLeaved = false; //IsLeaved
            this.userId = ""; //用户ID
            this.userID4Avcon = ""; //UserID4Avcon
            this.enrollmentDate = ""; //入校日期
            this.postCode = ""; //邮编
            this.email = ""; //电子邮箱
            this.isMessage = false; //IsMessage
            this.microblog = ""; //Microblog
            this.phoneNumber = ""; //PhoneNumber
            this.headphoto = ""; //Headphoto
            this.qQ = ""; //QQ
            this.registerPassword = ""; //RegisterPassword
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
        }
        /**
         * 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_StudentInfo(value) {
            if (value != undefined) {
                this.id_StudentInfo = value;
                this.hmProperty["id_StudentInfo"] = true;
            }
        }
        /**
         * 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuID(value) {
            if (value != undefined) {
                this.stuID = value;
                this.hmProperty["stuID"] = true;
            }
        }
        /**
         * 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuName(value) {
            if (value != undefined) {
                this.stuName = value;
                this.hmProperty["stuName"] = true;
            }
        }
        /**
         * 政治面貌流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_Politics(value) {
            if (value != undefined) {
                this.id_Politics = value;
                this.hmProperty["id_Politics"] = true;
            }
        }
        /**
         * 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_Sex(value) {
            if (value != undefined) {
                this.id_Sex = value;
                this.hmProperty["id_Sex"] = true;
            }
        }
        /**
         * 民族流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_Ethnic(value) {
            if (value != undefined) {
                this.id_Ethnic = value;
                this.hmProperty["id_Ethnic"] = true;
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
            }
        }
        /**
         * 学生类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_StuType(value) {
            if (value != undefined) {
                this.id_StuType = value;
                this.hmProperty["id_StuType"] = true;
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
            }
        }
        /**
         * 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_AdminCls(value) {
            if (value != undefined) {
                this.id_AdminCls = value;
                this.hmProperty["id_AdminCls"] = true;
            }
        }
        /**
         * 出生日期(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetBirthday(value) {
            if (value != undefined) {
                this.birthday = value;
                this.hmProperty["birthday"] = true;
            }
        }
        /**
         * 籍贯(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetNativePlace(value) {
            if (value != undefined) {
                this.nativePlace = value;
                this.hmProperty["nativePlace"] = true;
            }
        }
        /**
         * 职位(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDuty(value) {
            if (value != undefined) {
                this.duty = value;
                this.hmProperty["duty"] = true;
            }
        }
        /**
         * 身份证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIDCardNo(value) {
            if (value != undefined) {
                this.idCardNo = value;
                this.hmProperty["idCardNo"] = true;
            }
        }
        /**
         * 学生证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuCardNo(value) {
            if (value != undefined) {
                this.stuCardNo = value;
                this.hmProperty["stuCardNo"] = true;
            }
        }
        /**
         * 居住地址(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLiveAddress(value) {
            if (value != undefined) {
                this.liveAddress = value;
                this.hmProperty["liveAddress"] = true;
            }
        }
        /**
         * 住宅电话(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetHomePhone(value) {
            if (value != undefined) {
                this.homePhone = value;
                this.hmProperty["homePhone"] = true;
            }
        }
        /**
         * 内卡号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetId_CardNo(value) {
            if (value != undefined) {
                this.id_CardNo = value;
                this.hmProperty["id_CardNo"] = true;
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
            }
        }
        /**
         * IsAvconClassUser(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsAvconClassUser(value) {
            if (value != undefined) {
                this.isAvconClassUser = value;
                this.hmProperty["isAvconClassUser"] = true;
            }
        }
        /**
         * IsAvconUser(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsAvconUser(value) {
            if (value != undefined) {
                this.isAvconUser = value;
                this.hmProperty["isAvconUser"] = true;
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
            }
        }
        /**
         * 是否本地用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsLocalUser(value) {
            if (value != undefined) {
                this.isLocalUser = value;
                this.hmProperty["isLocalUser"] = true;
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
            }
        }
        /**
         * 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserId(value) {
            if (value != undefined) {
                this.userId = value;
                this.hmProperty["userId"] = true;
            }
        }
        /**
         * UserID4Avcon(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserID4Avcon(value) {
            if (value != undefined) {
                this.userID4Avcon = value;
                this.hmProperty["userID4Avcon"] = true;
            }
        }
        /**
         * 入校日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEnrollmentDate(value) {
            if (value != undefined) {
                this.enrollmentDate = value;
                this.hmProperty["enrollmentDate"] = true;
            }
        }
        /**
         * 邮编(说明:;字段类型:char;字段长度:6;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPostCode(value) {
            if (value != undefined) {
                this.postCode = value;
                this.hmProperty["postCode"] = true;
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
            }
        }
        /**
         * IsMessage(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsMessage(value) {
            if (value != undefined) {
                this.isMessage = value;
                this.hmProperty["isMessage"] = true;
            }
        }
        /**
         * Microblog(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMicroblog(value) {
            if (value != undefined) {
                this.microblog = value;
                this.hmProperty["microblog"] = true;
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
            }
        }
        /**
         * Headphoto(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetHeadphoto(value) {
            if (value != undefined) {
                this.headphoto = value;
                this.hmProperty["headphoto"] = true;
            }
        }
        /**
         * QQ(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQQ(value) {
            if (value != undefined) {
                this.qQ = value;
                this.hmProperty["qQ"] = true;
            }
        }
        /**
         * RegisterPassword(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRegisterPassword(value) {
            if (value != undefined) {
                this.registerPassword = value;
                this.hmProperty["registerPassword"] = true;
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
                case clsStudentInfoEN.con_id_StudentInfo:
                    return this.id_StudentInfo;
                case clsStudentInfoEN.con_StuID:
                    return this.stuID;
                case clsStudentInfoEN.con_StuName:
                    return this.stuName;
                case clsStudentInfoEN.con_id_Politics:
                    return this.id_Politics;
                case clsStudentInfoEN.con_id_Sex:
                    return this.id_Sex;
                case clsStudentInfoEN.con_id_Ethnic:
                    return this.id_Ethnic;
                case clsStudentInfoEN.con_id_UniZone:
                    return this.id_UniZone;
                case clsStudentInfoEN.con_id_StuType:
                    return this.id_StuType;
                case clsStudentInfoEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsStudentInfoEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsStudentInfoEN.con_id_GradeBase:
                    return this.id_GradeBase;
                case clsStudentInfoEN.con_id_AdminCls:
                    return this.id_AdminCls;
                case clsStudentInfoEN.con_Birthday:
                    return this.birthday;
                case clsStudentInfoEN.con_NativePlace:
                    return this.nativePlace;
                case clsStudentInfoEN.con_Duty:
                    return this.duty;
                case clsStudentInfoEN.con_IDCardNo:
                    return this.idCardNo;
                case clsStudentInfoEN.con_StuCardNo:
                    return this.stuCardNo;
                case clsStudentInfoEN.con_LiveAddress:
                    return this.liveAddress;
                case clsStudentInfoEN.con_HomePhone:
                    return this.homePhone;
                case clsStudentInfoEN.con_Id_CardNo:
                    return this.id_CardNo;
                case clsStudentInfoEN.con_CardNo:
                    return this.cardNo;
                case clsStudentInfoEN.con_IsAvconClassUser:
                    return this.isAvconClassUser;
                case clsStudentInfoEN.con_IsAvconUser:
                    return this.isAvconUser;
                case clsStudentInfoEN.con_IsGpUser:
                    return this.isGpUser;
                case clsStudentInfoEN.con_IsLocalUser:
                    return this.isLocalUser;
                case clsStudentInfoEN.con_IsLeaved:
                    return this.isLeaved;
                case clsStudentInfoEN.con_UserId:
                    return this.userId;
                case clsStudentInfoEN.con_UserID4Avcon:
                    return this.userID4Avcon;
                case clsStudentInfoEN.con_EnrollmentDate:
                    return this.enrollmentDate;
                case clsStudentInfoEN.con_PostCode:
                    return this.postCode;
                case clsStudentInfoEN.con_Email:
                    return this.email;
                case clsStudentInfoEN.con_IsMessage:
                    return this.isMessage;
                case clsStudentInfoEN.con_Microblog:
                    return this.microblog;
                case clsStudentInfoEN.con_PhoneNumber:
                    return this.phoneNumber;
                case clsStudentInfoEN.con_Headphoto:
                    return this.headphoto;
                case clsStudentInfoEN.con_QQ:
                    return this.qQ;
                case clsStudentInfoEN.con_RegisterPassword:
                    return this.registerPassword;
                case clsStudentInfoEN.con_UpdDate:
                    return this.updDate;
                case clsStudentInfoEN.con_UpdUser:
                    return this.updUser;
                case clsStudentInfoEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[StudentInfo]中不存在！`;
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
                case clsStudentInfoEN.con_id_StudentInfo:
                    this.id_StudentInfo = strValue;
                    this.hmProperty["id_StudentInfo"] = true;
                    break;
                case clsStudentInfoEN.con_StuID:
                    this.stuID = strValue;
                    this.hmProperty["stuID"] = true;
                    break;
                case clsStudentInfoEN.con_StuName:
                    this.stuName = strValue;
                    this.hmProperty["stuName"] = true;
                    break;
                case clsStudentInfoEN.con_id_Politics:
                    this.id_Politics = strValue;
                    this.hmProperty["id_Politics"] = true;
                    break;
                case clsStudentInfoEN.con_id_Sex:
                    this.id_Sex = strValue;
                    this.hmProperty["id_Sex"] = true;
                    break;
                case clsStudentInfoEN.con_id_Ethnic:
                    this.id_Ethnic = strValue;
                    this.hmProperty["id_Ethnic"] = true;
                    break;
                case clsStudentInfoEN.con_id_UniZone:
                    this.id_UniZone = strValue;
                    this.hmProperty["id_UniZone"] = true;
                    break;
                case clsStudentInfoEN.con_id_StuType:
                    this.id_StuType = strValue;
                    this.hmProperty["id_StuType"] = true;
                    break;
                case clsStudentInfoEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    this.hmProperty["id_XzCollege"] = true;
                    break;
                case clsStudentInfoEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    this.hmProperty["id_XzMajor"] = true;
                    break;
                case clsStudentInfoEN.con_id_GradeBase:
                    this.id_GradeBase = strValue;
                    this.hmProperty["id_GradeBase"] = true;
                    break;
                case clsStudentInfoEN.con_id_AdminCls:
                    this.id_AdminCls = strValue;
                    this.hmProperty["id_AdminCls"] = true;
                    break;
                case clsStudentInfoEN.con_Birthday:
                    this.birthday = strValue;
                    this.hmProperty["birthday"] = true;
                    break;
                case clsStudentInfoEN.con_NativePlace:
                    this.nativePlace = strValue;
                    this.hmProperty["nativePlace"] = true;
                    break;
                case clsStudentInfoEN.con_Duty:
                    this.duty = strValue;
                    this.hmProperty["duty"] = true;
                    break;
                case clsStudentInfoEN.con_IDCardNo:
                    this.idCardNo = strValue;
                    this.hmProperty["idCardNo"] = true;
                    break;
                case clsStudentInfoEN.con_StuCardNo:
                    this.stuCardNo = strValue;
                    this.hmProperty["stuCardNo"] = true;
                    break;
                case clsStudentInfoEN.con_LiveAddress:
                    this.liveAddress = strValue;
                    this.hmProperty["liveAddress"] = true;
                    break;
                case clsStudentInfoEN.con_HomePhone:
                    this.homePhone = strValue;
                    this.hmProperty["homePhone"] = true;
                    break;
                case clsStudentInfoEN.con_Id_CardNo:
                    this.id_CardNo = strValue;
                    this.hmProperty["id_CardNo"] = true;
                    break;
                case clsStudentInfoEN.con_CardNo:
                    this.cardNo = strValue;
                    this.hmProperty["cardNo"] = true;
                    break;
                case clsStudentInfoEN.con_IsAvconClassUser:
                    this.isAvconClassUser = Boolean(strValue);
                    this.hmProperty["isAvconClassUser"] = true;
                    break;
                case clsStudentInfoEN.con_IsAvconUser:
                    this.isAvconUser = Boolean(strValue);
                    this.hmProperty["isAvconUser"] = true;
                    break;
                case clsStudentInfoEN.con_IsGpUser:
                    this.isGpUser = Boolean(strValue);
                    this.hmProperty["isGpUser"] = true;
                    break;
                case clsStudentInfoEN.con_IsLocalUser:
                    this.isLocalUser = Boolean(strValue);
                    this.hmProperty["isLocalUser"] = true;
                    break;
                case clsStudentInfoEN.con_IsLeaved:
                    this.isLeaved = Boolean(strValue);
                    this.hmProperty["isLeaved"] = true;
                    break;
                case clsStudentInfoEN.con_UserId:
                    this.userId = strValue;
                    this.hmProperty["userId"] = true;
                    break;
                case clsStudentInfoEN.con_UserID4Avcon:
                    this.userID4Avcon = strValue;
                    this.hmProperty["userID4Avcon"] = true;
                    break;
                case clsStudentInfoEN.con_EnrollmentDate:
                    this.enrollmentDate = strValue;
                    this.hmProperty["enrollmentDate"] = true;
                    break;
                case clsStudentInfoEN.con_PostCode:
                    this.postCode = strValue;
                    this.hmProperty["postCode"] = true;
                    break;
                case clsStudentInfoEN.con_Email:
                    this.email = strValue;
                    this.hmProperty["email"] = true;
                    break;
                case clsStudentInfoEN.con_IsMessage:
                    this.isMessage = Boolean(strValue);
                    this.hmProperty["isMessage"] = true;
                    break;
                case clsStudentInfoEN.con_Microblog:
                    this.microblog = strValue;
                    this.hmProperty["microblog"] = true;
                    break;
                case clsStudentInfoEN.con_PhoneNumber:
                    this.phoneNumber = strValue;
                    this.hmProperty["phoneNumber"] = true;
                    break;
                case clsStudentInfoEN.con_Headphoto:
                    this.headphoto = strValue;
                    this.hmProperty["headphoto"] = true;
                    break;
                case clsStudentInfoEN.con_QQ:
                    this.qQ = strValue;
                    this.hmProperty["qQ"] = true;
                    break;
                case clsStudentInfoEN.con_RegisterPassword:
                    this.registerPassword = strValue;
                    this.hmProperty["registerPassword"] = true;
                    break;
                case clsStudentInfoEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsStudentInfoEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsStudentInfoEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[StudentInfo]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_StudentInfo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_StudentInfo() { return "id_StudentInfo"; } //学生流水号
        /**
        * 常量:"StuID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuID() { return "stuID"; } //学号
        /**
        * 常量:"StuName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuName() { return "stuName"; } //姓名
        /**
        * 常量:"id_Politics"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Politics() { return "id_Politics"; } //政治面貌流水号
        /**
        * 常量:"id_Sex"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Sex() { return "id_Sex"; } //性别流水号
        /**
        * 常量:"id_Ethnic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Ethnic() { return "id_Ethnic"; } //民族流水号
        /**
        * 常量:"id_UniZone"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_UniZone() { return "id_UniZone"; } //校区流水号
        /**
        * 常量:"id_StuType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_StuType() { return "id_StuType"; } //学生类别流水号
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
        * 常量:"id_GradeBase"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_GradeBase() { return "id_GradeBase"; } //年级流水号
        /**
        * 常量:"id_AdminCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_AdminCls() { return "id_AdminCls"; } //行政班流水号
        /**
        * 常量:"Birthday"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Birthday() { return "birthday"; } //出生日期
        /**
        * 常量:"NativePlace"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_NativePlace() { return "nativePlace"; } //籍贯
        /**
        * 常量:"Duty"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Duty() { return "duty"; } //职位
        /**
        * 常量:"IDCardNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IDCardNo() { return "idCardNo"; } //身份证号
        /**
        * 常量:"StuCardNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuCardNo() { return "stuCardNo"; } //学生证号
        /**
        * 常量:"LiveAddress"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LiveAddress() { return "liveAddress"; } //居住地址
        /**
        * 常量:"HomePhone"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_HomePhone() { return "homePhone"; } //住宅电话
        /**
        * 常量:"Id_CardNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Id_CardNo() { return "id_CardNo"; } //内卡号
        /**
        * 常量:"CardNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CardNo() { return "cardNo"; } //卡号
        /**
        * 常量:"IsAvconClassUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsAvconClassUser() { return "isAvconClassUser"; } //IsAvconClassUser
        /**
        * 常量:"IsAvconUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsAvconUser() { return "isAvconUser"; } //IsAvconUser
        /**
        * 常量:"IsGpUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsGpUser() { return "isGpUser"; } //是否Gp用户
        /**
        * 常量:"IsLocalUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsLocalUser() { return "isLocalUser"; } //是否本地用户
        /**
        * 常量:"IsLeaved"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsLeaved() { return "isLeaved"; } //IsLeaved
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"UserID4Avcon"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserID4Avcon() { return "userID4Avcon"; } //UserID4Avcon
        /**
        * 常量:"EnrollmentDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EnrollmentDate() { return "enrollmentDate"; } //入校日期
        /**
        * 常量:"PostCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PostCode() { return "postCode"; } //邮编
        /**
        * 常量:"Email"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Email() { return "email"; } //电子邮箱
        /**
        * 常量:"IsMessage"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsMessage() { return "isMessage"; } //IsMessage
        /**
        * 常量:"Microblog"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Microblog() { return "microblog"; } //Microblog
        /**
        * 常量:"PhoneNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PhoneNumber() { return "phoneNumber"; } //PhoneNumber
        /**
        * 常量:"Headphoto"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Headphoto() { return "headphoto"; } //Headphoto
        /**
        * 常量:"QQ"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QQ() { return "qQ"; } //QQ
        /**
        * 常量:"RegisterPassword"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RegisterPassword() { return "registerPassword"; } //RegisterPassword
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
    exports.clsStudentInfoEN = clsStudentInfoEN;
    clsStudentInfoEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsStudentInfoEN.CacheModeId = "02"; //客户端缓存
    clsStudentInfoEN._CurrTabName = "StudentInfo"; //当前表名,与该类相关的表名
    clsStudentInfoEN._KeyFldName = "id_StudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsStudentInfoEN.mintAttributeCount = 40;
    clsStudentInfoEN.AttributeName = ["id_StudentInfo", "stuID", "stuName", "id_Politics", "id_Sex", "id_Ethnic", "id_UniZone", "id_StuType", "id_XzCollege", "id_XzMajor", "id_GradeBase", "id_AdminCls", "birthday", "nativePlace", "duty", "idCardNo", "stuCardNo", "liveAddress", "homePhone", "id_CardNo", "cardNo", "isAvconClassUser", "isAvconUser", "isGpUser", "isLocalUser", "isLeaved", "userId", "userID4Avcon", "enrollmentDate", "postCode", "email", "isMessage", "microblog", "phoneNumber", "headphoto", "qQ", "registerPassword", "updDate", "updUser", "memo"];
});
