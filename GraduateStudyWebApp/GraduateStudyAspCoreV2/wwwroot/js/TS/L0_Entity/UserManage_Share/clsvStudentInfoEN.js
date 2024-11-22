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
    exports.clsvStudentInfoEN = void 0;
    /**
    * 类名:clsvStudentInfoEN
    * 表名:vStudentInfo(01120132)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:14:06
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
    * v学生(vStudentInfo)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvStudentInfoEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.id_StudentInfo = ""; //学生流水号
            this.stuID = ""; //学号
            this.stuName = ""; //姓名
            this.id_Politics = ""; //政治面貌流水号
            this.politicsID = ""; //政治面貌ID
            this.politicsName = ""; //政治面貌
            this.id_Sex = ""; //性别流水号
            this.sexDesc = ""; //性别名称
            this.id_Ethnic = ""; //民族流水号
            this.ethnicID = ""; //民族ID
            this.ethnicName = ""; //民族名称
            this.id_UniZone = ""; //校区流水号
            this.uniZoneDesc = ""; //校区名称
            this.id_StuType = ""; //学生类别流水号
            this.stuTypeID = ""; //学生类别ID
            this.stuTypeDesc = ""; //学生类别名称
            this.id_XzCollege = ""; //学院流水号
            this.collegeID = ""; //学院ID
            this.collegeName = ""; //学院名称
            this.collegeIdInGP = ""; //CollegeIdInGP
            this.collegeNameA = ""; //学院名称简写
            this.id_XzMajor = ""; //专业流水号
            this.majorID = ""; //专业ID
            this.majorName = ""; //专业名称
            this.isNormal = false; //IsNormal
            this.id_GradeBase = ""; //年级流水号
            this.gradeBaseName = ""; //年级名称
            this.id_AdminCls = ""; //行政班流水号
            this.adminClsName = ""; //行政班名称
            this.adminClsId = ""; //行政班代号
            this.id_AdminClsType = ""; //行政班级类型流水号
            this.adminClsTypeName = ""; //行政班级类型名称
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
            this.qQ = ""; //QQ
            this.registerPassword = ""; //RegisterPassword
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
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
                case clsvStudentInfoEN.con_id_StudentInfo:
                    return this.id_StudentInfo;
                case clsvStudentInfoEN.con_StuID:
                    return this.stuID;
                case clsvStudentInfoEN.con_StuName:
                    return this.stuName;
                case clsvStudentInfoEN.con_id_Politics:
                    return this.id_Politics;
                case clsvStudentInfoEN.con_PoliticsID:
                    return this.politicsID;
                case clsvStudentInfoEN.con_PoliticsName:
                    return this.politicsName;
                case clsvStudentInfoEN.con_id_Sex:
                    return this.id_Sex;
                case clsvStudentInfoEN.con_SexDesc:
                    return this.sexDesc;
                case clsvStudentInfoEN.con_id_Ethnic:
                    return this.id_Ethnic;
                case clsvStudentInfoEN.con_EthnicID:
                    return this.ethnicID;
                case clsvStudentInfoEN.con_EthnicName:
                    return this.ethnicName;
                case clsvStudentInfoEN.con_id_UniZone:
                    return this.id_UniZone;
                case clsvStudentInfoEN.con_UniZoneDesc:
                    return this.uniZoneDesc;
                case clsvStudentInfoEN.con_id_StuType:
                    return this.id_StuType;
                case clsvStudentInfoEN.con_StuTypeID:
                    return this.stuTypeID;
                case clsvStudentInfoEN.con_StuTypeDesc:
                    return this.stuTypeDesc;
                case clsvStudentInfoEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvStudentInfoEN.con_CollegeID:
                    return this.collegeID;
                case clsvStudentInfoEN.con_CollegeName:
                    return this.collegeName;
                case clsvStudentInfoEN.con_CollegeIdInGP:
                    return this.collegeIdInGP;
                case clsvStudentInfoEN.con_CollegeNameA:
                    return this.collegeNameA;
                case clsvStudentInfoEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvStudentInfoEN.con_MajorID:
                    return this.majorID;
                case clsvStudentInfoEN.con_MajorName:
                    return this.majorName;
                case clsvStudentInfoEN.con_IsNormal:
                    return this.isNormal;
                case clsvStudentInfoEN.con_id_GradeBase:
                    return this.id_GradeBase;
                case clsvStudentInfoEN.con_GradeBaseName:
                    return this.gradeBaseName;
                case clsvStudentInfoEN.con_id_AdminCls:
                    return this.id_AdminCls;
                case clsvStudentInfoEN.con_AdminClsName:
                    return this.adminClsName;
                case clsvStudentInfoEN.con_AdminClsId:
                    return this.adminClsId;
                case clsvStudentInfoEN.con_id_AdminClsType:
                    return this.id_AdminClsType;
                case clsvStudentInfoEN.con_AdminClsTypeName:
                    return this.adminClsTypeName;
                case clsvStudentInfoEN.con_Birthday:
                    return this.birthday;
                case clsvStudentInfoEN.con_NativePlace:
                    return this.nativePlace;
                case clsvStudentInfoEN.con_Duty:
                    return this.duty;
                case clsvStudentInfoEN.con_IDCardNo:
                    return this.idCardNo;
                case clsvStudentInfoEN.con_StuCardNo:
                    return this.stuCardNo;
                case clsvStudentInfoEN.con_LiveAddress:
                    return this.liveAddress;
                case clsvStudentInfoEN.con_HomePhone:
                    return this.homePhone;
                case clsvStudentInfoEN.con_Id_CardNo:
                    return this.id_CardNo;
                case clsvStudentInfoEN.con_CardNo:
                    return this.cardNo;
                case clsvStudentInfoEN.con_IsAvconClassUser:
                    return this.isAvconClassUser;
                case clsvStudentInfoEN.con_IsAvconUser:
                    return this.isAvconUser;
                case clsvStudentInfoEN.con_IsGpUser:
                    return this.isGpUser;
                case clsvStudentInfoEN.con_IsLocalUser:
                    return this.isLocalUser;
                case clsvStudentInfoEN.con_IsLeaved:
                    return this.isLeaved;
                case clsvStudentInfoEN.con_UserId:
                    return this.userId;
                case clsvStudentInfoEN.con_UserID4Avcon:
                    return this.userID4Avcon;
                case clsvStudentInfoEN.con_EnrollmentDate:
                    return this.enrollmentDate;
                case clsvStudentInfoEN.con_PostCode:
                    return this.postCode;
                case clsvStudentInfoEN.con_Email:
                    return this.email;
                case clsvStudentInfoEN.con_IsMessage:
                    return this.isMessage;
                case clsvStudentInfoEN.con_Microblog:
                    return this.microblog;
                case clsvStudentInfoEN.con_PhoneNumber:
                    return this.phoneNumber;
                case clsvStudentInfoEN.con_QQ:
                    return this.qQ;
                case clsvStudentInfoEN.con_RegisterPassword:
                    return this.registerPassword;
                case clsvStudentInfoEN.con_UpdDate:
                    return this.updDate;
                case clsvStudentInfoEN.con_UpdUser:
                    return this.updUser;
                case clsvStudentInfoEN.con_Memo:
                    return this.memo;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vStudentInfo]中不存在！`;
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
                case clsvStudentInfoEN.con_id_StudentInfo:
                    this.id_StudentInfo = strValue;
                    break;
                case clsvStudentInfoEN.con_StuID:
                    this.stuID = strValue;
                    break;
                case clsvStudentInfoEN.con_StuName:
                    this.stuName = strValue;
                    break;
                case clsvStudentInfoEN.con_id_Politics:
                    this.id_Politics = strValue;
                    break;
                case clsvStudentInfoEN.con_PoliticsID:
                    this.politicsID = strValue;
                    break;
                case clsvStudentInfoEN.con_PoliticsName:
                    this.politicsName = strValue;
                    break;
                case clsvStudentInfoEN.con_id_Sex:
                    this.id_Sex = strValue;
                    break;
                case clsvStudentInfoEN.con_SexDesc:
                    this.sexDesc = strValue;
                    break;
                case clsvStudentInfoEN.con_id_Ethnic:
                    this.id_Ethnic = strValue;
                    break;
                case clsvStudentInfoEN.con_EthnicID:
                    this.ethnicID = strValue;
                    break;
                case clsvStudentInfoEN.con_EthnicName:
                    this.ethnicName = strValue;
                    break;
                case clsvStudentInfoEN.con_id_UniZone:
                    this.id_UniZone = strValue;
                    break;
                case clsvStudentInfoEN.con_UniZoneDesc:
                    this.uniZoneDesc = strValue;
                    break;
                case clsvStudentInfoEN.con_id_StuType:
                    this.id_StuType = strValue;
                    break;
                case clsvStudentInfoEN.con_StuTypeID:
                    this.stuTypeID = strValue;
                    break;
                case clsvStudentInfoEN.con_StuTypeDesc:
                    this.stuTypeDesc = strValue;
                    break;
                case clsvStudentInfoEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvStudentInfoEN.con_CollegeID:
                    this.collegeID = strValue;
                    break;
                case clsvStudentInfoEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvStudentInfoEN.con_CollegeIdInGP:
                    this.collegeIdInGP = strValue;
                    break;
                case clsvStudentInfoEN.con_CollegeNameA:
                    this.collegeNameA = strValue;
                    break;
                case clsvStudentInfoEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvStudentInfoEN.con_MajorID:
                    this.majorID = strValue;
                    break;
                case clsvStudentInfoEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvStudentInfoEN.con_IsNormal:
                    this.isNormal = Boolean(strValue);
                    break;
                case clsvStudentInfoEN.con_id_GradeBase:
                    this.id_GradeBase = strValue;
                    break;
                case clsvStudentInfoEN.con_GradeBaseName:
                    this.gradeBaseName = strValue;
                    break;
                case clsvStudentInfoEN.con_id_AdminCls:
                    this.id_AdminCls = strValue;
                    break;
                case clsvStudentInfoEN.con_AdminClsName:
                    this.adminClsName = strValue;
                    break;
                case clsvStudentInfoEN.con_AdminClsId:
                    this.adminClsId = strValue;
                    break;
                case clsvStudentInfoEN.con_id_AdminClsType:
                    this.id_AdminClsType = strValue;
                    break;
                case clsvStudentInfoEN.con_AdminClsTypeName:
                    this.adminClsTypeName = strValue;
                    break;
                case clsvStudentInfoEN.con_Birthday:
                    this.birthday = strValue;
                    break;
                case clsvStudentInfoEN.con_NativePlace:
                    this.nativePlace = strValue;
                    break;
                case clsvStudentInfoEN.con_Duty:
                    this.duty = strValue;
                    break;
                case clsvStudentInfoEN.con_IDCardNo:
                    this.idCardNo = strValue;
                    break;
                case clsvStudentInfoEN.con_StuCardNo:
                    this.stuCardNo = strValue;
                    break;
                case clsvStudentInfoEN.con_LiveAddress:
                    this.liveAddress = strValue;
                    break;
                case clsvStudentInfoEN.con_HomePhone:
                    this.homePhone = strValue;
                    break;
                case clsvStudentInfoEN.con_Id_CardNo:
                    this.id_CardNo = strValue;
                    break;
                case clsvStudentInfoEN.con_CardNo:
                    this.cardNo = strValue;
                    break;
                case clsvStudentInfoEN.con_IsAvconClassUser:
                    this.isAvconClassUser = Boolean(strValue);
                    break;
                case clsvStudentInfoEN.con_IsAvconUser:
                    this.isAvconUser = Boolean(strValue);
                    break;
                case clsvStudentInfoEN.con_IsGpUser:
                    this.isGpUser = Boolean(strValue);
                    break;
                case clsvStudentInfoEN.con_IsLocalUser:
                    this.isLocalUser = Boolean(strValue);
                    break;
                case clsvStudentInfoEN.con_IsLeaved:
                    this.isLeaved = Boolean(strValue);
                    break;
                case clsvStudentInfoEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvStudentInfoEN.con_UserID4Avcon:
                    this.userID4Avcon = strValue;
                    break;
                case clsvStudentInfoEN.con_EnrollmentDate:
                    this.enrollmentDate = strValue;
                    break;
                case clsvStudentInfoEN.con_PostCode:
                    this.postCode = strValue;
                    break;
                case clsvStudentInfoEN.con_Email:
                    this.email = strValue;
                    break;
                case clsvStudentInfoEN.con_IsMessage:
                    this.isMessage = Boolean(strValue);
                    break;
                case clsvStudentInfoEN.con_Microblog:
                    this.microblog = strValue;
                    break;
                case clsvStudentInfoEN.con_PhoneNumber:
                    this.phoneNumber = strValue;
                    break;
                case clsvStudentInfoEN.con_QQ:
                    this.qQ = strValue;
                    break;
                case clsvStudentInfoEN.con_RegisterPassword:
                    this.registerPassword = strValue;
                    break;
                case clsvStudentInfoEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvStudentInfoEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvStudentInfoEN.con_Memo:
                    this.memo = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vStudentInfo]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"PoliticsID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PoliticsID() { return "politicsID"; } //政治面貌ID
        /**
        * 常量:"PoliticsName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PoliticsName() { return "politicsName"; } //政治面貌
        /**
        * 常量:"id_Sex"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Sex() { return "id_Sex"; } //性别流水号
        /**
        * 常量:"SexDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SexDesc() { return "sexDesc"; } //性别名称
        /**
        * 常量:"id_Ethnic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Ethnic() { return "id_Ethnic"; } //民族流水号
        /**
        * 常量:"EthnicID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EthnicID() { return "ethnicID"; } //民族ID
        /**
        * 常量:"EthnicName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EthnicName() { return "ethnicName"; } //民族名称
        /**
        * 常量:"id_UniZone"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_UniZone() { return "id_UniZone"; } //校区流水号
        /**
        * 常量:"UniZoneDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UniZoneDesc() { return "uniZoneDesc"; } //校区名称
        /**
        * 常量:"id_StuType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_StuType() { return "id_StuType"; } //学生类别流水号
        /**
        * 常量:"StuTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuTypeID() { return "stuTypeID"; } //学生类别ID
        /**
        * 常量:"StuTypeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuTypeDesc() { return "stuTypeDesc"; } //学生类别名称
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
        * 常量:"IsNormal"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsNormal() { return "isNormal"; } //IsNormal
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
        * 常量:"AdminClsTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AdminClsTypeName() { return "adminClsTypeName"; } //行政班级类型名称
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
    exports.clsvStudentInfoEN = clsvStudentInfoEN;
    clsvStudentInfoEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvStudentInfoEN.CacheModeId = "04"; //sessionStorage
    clsvStudentInfoEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvStudentInfoEN.WhereFormat = ""; //条件格式串
    clsvStudentInfoEN._CurrTabName = "vStudentInfo"; //当前表名,与该类相关的表名
    clsvStudentInfoEN._KeyFldName = "id_StudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvStudentInfoEN.mintAttributeCount = 59;
    clsvStudentInfoEN.AttributeName = ["id_StudentInfo", "stuID", "stuName", "id_Politics", "politicsID", "politicsName", "id_Sex", "sexDesc", "id_Ethnic", "ethnicID", "ethnicName", "id_UniZone", "uniZoneDesc", "id_StuType", "stuTypeID", "stuTypeDesc", "id_XzCollege", "collegeID", "collegeName", "collegeIdInGP", "collegeNameA", "id_XzMajor", "majorID", "majorName", "isNormal", "id_GradeBase", "gradeBaseName", "id_AdminCls", "adminClsName", "adminClsId", "id_AdminClsType", "adminClsTypeName", "birthday", "nativePlace", "duty", "idCardNo", "stuCardNo", "liveAddress", "homePhone", "id_CardNo", "cardNo", "isAvconClassUser", "isAvconUser", "isGpUser", "isLocalUser", "isLeaved", "userId", "userID4Avcon", "enrollmentDate", "postCode", "email", "isMessage", "microblog", "phoneNumber", "qQ", "registerPassword", "updDate", "updUser", "memo"];
});