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
    exports.clsvTeacherInfoEN = void 0;
    /**
    * 类名:clsvTeacherInfoEN
    * 表名:vTeacherInfo(01120094)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:14:01
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
    * v教师(vTeacherInfo)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvTeacherInfoEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.id_Teacher = ""; //教师流水号
            this.teacherID = ""; //教师工号
            this.teacherName = ""; //教师姓名
            this.id_Sex = ""; //性别流水号
            this.sexDesc = ""; //性别名称
            this.id_School_Ps = ""; //学校流水号
            this.schoolId = ""; //学校编号
            this.schoolName = ""; //学校名称
            this.id_Discipline_Ps = ""; //学科流水号
            this.id_UniZone = ""; //校区流水号
            this.uniZoneDesc = ""; //校区名称
            this.id_Ethnic = ""; //民族流水号
            this.ethnicName = ""; //民族名称
            this.id_Politics = ""; //政治面貌流水号
            this.politicsName = ""; //政治面貌
            this.id_AdminGrade = ""; //行政职务流水号
            this.adminGradeDesc = ""; //行政职务描述
            this.id_ProfGrade = ""; //专业职称流水号
            this.profenssionalGradeName = ""; //专业职称
            this.id_Qualif = ""; //学历流水号
            this.qualifDesc = ""; //QualifDesc
            this.id_Degree = ""; //学位流水号
            this.degreeName = ""; //学位名称
            this.id_StaffType = ""; //职工类型流水号
            this.staffTypeName = ""; //职工类型名称
            this.id_Province = ""; //省份流水号
            this.provinceName = ""; //ProvinceName
            this.citizenID = ""; //身份证号
            this.cardNo = ""; //卡号
            this.birthday = ""; //出生日期
            this.graduationMajor = ""; //毕业专业
            this.telNo = ""; //电话
            this.email = ""; //电子邮箱
            this.webSite = ""; //个人主页
            this.personBlog = ""; //个人博客
            this.entryDate = ""; //进校日期
            this.offed = false; //是否离校
            this.id_CardNo = ""; //内卡号
            this.isAvconUser = false; //IsAvconUser
            this.isGpUser = false; //是否Gp用户
            this.isLocalUser = false; //是否本地用户
            this.fromUnit = ""; //来自单位
            this.memo = ""; //备注
            this.id_XzCollege = ""; //学院流水号
            this.collegeID = ""; //学院ID
            this.collegeName = ""; //学院名称
            this.collegeNameA = ""; //学院名称简写
            this.id_XzMajor = ""; //专业流水号
            this.entryDay = ""; //EntryDay
            this.id_Photo = ""; //id_Photo
            this.id_Religion = ""; //id_Religion
            this.religionName = ""; //ReligionName
            this.isMessage = false; //IsMessage
            this.microblog = ""; //Microblog
            this.modifyUserID = ""; //修改人
            this.offedBak = false; //OffedBak
            this.phoneNumber = ""; //PhoneNumber
            this.qQ = ""; //QQ
            this.teach_id_College = ""; //Teach_id_College
            this.teach_id_Major = ""; //Teach_id_Major
            this.tel = ""; //Tel
            this.modifyDate = ""; //修改日期
            this.registerPassword = ""; //RegisterPassword
            this.entryYear = ""; //EntryYear
            this.disciplineName_ps = ""; //学科
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
                case clsvTeacherInfoEN.con_id_Teacher:
                    return this.id_Teacher;
                case clsvTeacherInfoEN.con_TeacherID:
                    return this.teacherID;
                case clsvTeacherInfoEN.con_TeacherName:
                    return this.teacherName;
                case clsvTeacherInfoEN.con_id_Sex:
                    return this.id_Sex;
                case clsvTeacherInfoEN.con_SexDesc:
                    return this.sexDesc;
                case clsvTeacherInfoEN.con_id_School_Ps:
                    return this.id_School_Ps;
                case clsvTeacherInfoEN.con_SchoolId:
                    return this.schoolId;
                case clsvTeacherInfoEN.con_SchoolName:
                    return this.schoolName;
                case clsvTeacherInfoEN.con_id_Discipline_Ps:
                    return this.id_Discipline_Ps;
                case clsvTeacherInfoEN.con_id_UniZone:
                    return this.id_UniZone;
                case clsvTeacherInfoEN.con_UniZoneDesc:
                    return this.uniZoneDesc;
                case clsvTeacherInfoEN.con_id_Ethnic:
                    return this.id_Ethnic;
                case clsvTeacherInfoEN.con_EthnicName:
                    return this.ethnicName;
                case clsvTeacherInfoEN.con_id_Politics:
                    return this.id_Politics;
                case clsvTeacherInfoEN.con_PoliticsName:
                    return this.politicsName;
                case clsvTeacherInfoEN.con_id_AdminGrade:
                    return this.id_AdminGrade;
                case clsvTeacherInfoEN.con_AdminGradeDesc:
                    return this.adminGradeDesc;
                case clsvTeacherInfoEN.con_id_ProfGrade:
                    return this.id_ProfGrade;
                case clsvTeacherInfoEN.con_ProfenssionalGradeName:
                    return this.profenssionalGradeName;
                case clsvTeacherInfoEN.con_id_Qualif:
                    return this.id_Qualif;
                case clsvTeacherInfoEN.con_QualifDesc:
                    return this.qualifDesc;
                case clsvTeacherInfoEN.con_id_Degree:
                    return this.id_Degree;
                case clsvTeacherInfoEN.con_DegreeName:
                    return this.degreeName;
                case clsvTeacherInfoEN.con_id_StaffType:
                    return this.id_StaffType;
                case clsvTeacherInfoEN.con_StaffTypeName:
                    return this.staffTypeName;
                case clsvTeacherInfoEN.con_id_Province:
                    return this.id_Province;
                case clsvTeacherInfoEN.con_ProvinceName:
                    return this.provinceName;
                case clsvTeacherInfoEN.con_CitizenID:
                    return this.citizenID;
                case clsvTeacherInfoEN.con_CardNo:
                    return this.cardNo;
                case clsvTeacherInfoEN.con_Birthday:
                    return this.birthday;
                case clsvTeacherInfoEN.con_GraduationMajor:
                    return this.graduationMajor;
                case clsvTeacherInfoEN.con_TelNo:
                    return this.telNo;
                case clsvTeacherInfoEN.con_Email:
                    return this.email;
                case clsvTeacherInfoEN.con_WebSite:
                    return this.webSite;
                case clsvTeacherInfoEN.con_PersonBlog:
                    return this.personBlog;
                case clsvTeacherInfoEN.con_EntryDate:
                    return this.entryDate;
                case clsvTeacherInfoEN.con_Offed:
                    return this.offed;
                case clsvTeacherInfoEN.con_Id_CardNo:
                    return this.id_CardNo;
                case clsvTeacherInfoEN.con_IsAvconUser:
                    return this.isAvconUser;
                case clsvTeacherInfoEN.con_IsGpUser:
                    return this.isGpUser;
                case clsvTeacherInfoEN.con_IsLocalUser:
                    return this.isLocalUser;
                case clsvTeacherInfoEN.con_FromUnit:
                    return this.fromUnit;
                case clsvTeacherInfoEN.con_Memo:
                    return this.memo;
                case clsvTeacherInfoEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvTeacherInfoEN.con_CollegeID:
                    return this.collegeID;
                case clsvTeacherInfoEN.con_CollegeName:
                    return this.collegeName;
                case clsvTeacherInfoEN.con_CollegeNameA:
                    return this.collegeNameA;
                case clsvTeacherInfoEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvTeacherInfoEN.con_EntryDay:
                    return this.entryDay;
                case clsvTeacherInfoEN.con_id_Photo:
                    return this.id_Photo;
                case clsvTeacherInfoEN.con_id_Religion:
                    return this.id_Religion;
                case clsvTeacherInfoEN.con_ReligionName:
                    return this.religionName;
                case clsvTeacherInfoEN.con_IsMessage:
                    return this.isMessage;
                case clsvTeacherInfoEN.con_Microblog:
                    return this.microblog;
                case clsvTeacherInfoEN.con_ModifyUserID:
                    return this.modifyUserID;
                case clsvTeacherInfoEN.con_OffedBak:
                    return this.offedBak;
                case clsvTeacherInfoEN.con_PhoneNumber:
                    return this.phoneNumber;
                case clsvTeacherInfoEN.con_QQ:
                    return this.qQ;
                case clsvTeacherInfoEN.con_Teach_id_College:
                    return this.teach_id_College;
                case clsvTeacherInfoEN.con_Teach_id_Major:
                    return this.teach_id_Major;
                case clsvTeacherInfoEN.con_Tel:
                    return this.tel;
                case clsvTeacherInfoEN.con_ModifyDate:
                    return this.modifyDate;
                case clsvTeacherInfoEN.con_RegisterPassword:
                    return this.registerPassword;
                case clsvTeacherInfoEN.con_EntryYear:
                    return this.entryYear;
                case clsvTeacherInfoEN.con_DisciplineName_ps:
                    return this.disciplineName_ps;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vTeacherInfo]中不存在！`;
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
                case clsvTeacherInfoEN.con_id_Teacher:
                    this.id_Teacher = strValue;
                    break;
                case clsvTeacherInfoEN.con_TeacherID:
                    this.teacherID = strValue;
                    break;
                case clsvTeacherInfoEN.con_TeacherName:
                    this.teacherName = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_Sex:
                    this.id_Sex = strValue;
                    break;
                case clsvTeacherInfoEN.con_SexDesc:
                    this.sexDesc = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_School_Ps:
                    this.id_School_Ps = strValue;
                    break;
                case clsvTeacherInfoEN.con_SchoolId:
                    this.schoolId = strValue;
                    break;
                case clsvTeacherInfoEN.con_SchoolName:
                    this.schoolName = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_Discipline_Ps:
                    this.id_Discipline_Ps = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_UniZone:
                    this.id_UniZone = strValue;
                    break;
                case clsvTeacherInfoEN.con_UniZoneDesc:
                    this.uniZoneDesc = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_Ethnic:
                    this.id_Ethnic = strValue;
                    break;
                case clsvTeacherInfoEN.con_EthnicName:
                    this.ethnicName = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_Politics:
                    this.id_Politics = strValue;
                    break;
                case clsvTeacherInfoEN.con_PoliticsName:
                    this.politicsName = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_AdminGrade:
                    this.id_AdminGrade = strValue;
                    break;
                case clsvTeacherInfoEN.con_AdminGradeDesc:
                    this.adminGradeDesc = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_ProfGrade:
                    this.id_ProfGrade = strValue;
                    break;
                case clsvTeacherInfoEN.con_ProfenssionalGradeName:
                    this.profenssionalGradeName = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_Qualif:
                    this.id_Qualif = strValue;
                    break;
                case clsvTeacherInfoEN.con_QualifDesc:
                    this.qualifDesc = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_Degree:
                    this.id_Degree = strValue;
                    break;
                case clsvTeacherInfoEN.con_DegreeName:
                    this.degreeName = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_StaffType:
                    this.id_StaffType = strValue;
                    break;
                case clsvTeacherInfoEN.con_StaffTypeName:
                    this.staffTypeName = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_Province:
                    this.id_Province = strValue;
                    break;
                case clsvTeacherInfoEN.con_ProvinceName:
                    this.provinceName = strValue;
                    break;
                case clsvTeacherInfoEN.con_CitizenID:
                    this.citizenID = strValue;
                    break;
                case clsvTeacherInfoEN.con_CardNo:
                    this.cardNo = strValue;
                    break;
                case clsvTeacherInfoEN.con_Birthday:
                    this.birthday = strValue;
                    break;
                case clsvTeacherInfoEN.con_GraduationMajor:
                    this.graduationMajor = strValue;
                    break;
                case clsvTeacherInfoEN.con_TelNo:
                    this.telNo = strValue;
                    break;
                case clsvTeacherInfoEN.con_Email:
                    this.email = strValue;
                    break;
                case clsvTeacherInfoEN.con_WebSite:
                    this.webSite = strValue;
                    break;
                case clsvTeacherInfoEN.con_PersonBlog:
                    this.personBlog = strValue;
                    break;
                case clsvTeacherInfoEN.con_EntryDate:
                    this.entryDate = strValue;
                    break;
                case clsvTeacherInfoEN.con_Offed:
                    this.offed = Boolean(strValue);
                    break;
                case clsvTeacherInfoEN.con_Id_CardNo:
                    this.id_CardNo = strValue;
                    break;
                case clsvTeacherInfoEN.con_IsAvconUser:
                    this.isAvconUser = Boolean(strValue);
                    break;
                case clsvTeacherInfoEN.con_IsGpUser:
                    this.isGpUser = Boolean(strValue);
                    break;
                case clsvTeacherInfoEN.con_IsLocalUser:
                    this.isLocalUser = Boolean(strValue);
                    break;
                case clsvTeacherInfoEN.con_FromUnit:
                    this.fromUnit = strValue;
                    break;
                case clsvTeacherInfoEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvTeacherInfoEN.con_CollegeID:
                    this.collegeID = strValue;
                    break;
                case clsvTeacherInfoEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvTeacherInfoEN.con_CollegeNameA:
                    this.collegeNameA = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvTeacherInfoEN.con_EntryDay:
                    this.entryDay = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_Photo:
                    this.id_Photo = strValue;
                    break;
                case clsvTeacherInfoEN.con_id_Religion:
                    this.id_Religion = strValue;
                    break;
                case clsvTeacherInfoEN.con_ReligionName:
                    this.religionName = strValue;
                    break;
                case clsvTeacherInfoEN.con_IsMessage:
                    this.isMessage = Boolean(strValue);
                    break;
                case clsvTeacherInfoEN.con_Microblog:
                    this.microblog = strValue;
                    break;
                case clsvTeacherInfoEN.con_ModifyUserID:
                    this.modifyUserID = strValue;
                    break;
                case clsvTeacherInfoEN.con_OffedBak:
                    this.offedBak = Boolean(strValue);
                    break;
                case clsvTeacherInfoEN.con_PhoneNumber:
                    this.phoneNumber = strValue;
                    break;
                case clsvTeacherInfoEN.con_QQ:
                    this.qQ = strValue;
                    break;
                case clsvTeacherInfoEN.con_Teach_id_College:
                    this.teach_id_College = strValue;
                    break;
                case clsvTeacherInfoEN.con_Teach_id_Major:
                    this.teach_id_Major = strValue;
                    break;
                case clsvTeacherInfoEN.con_Tel:
                    this.tel = strValue;
                    break;
                case clsvTeacherInfoEN.con_ModifyDate:
                    this.modifyDate = strValue;
                    break;
                case clsvTeacherInfoEN.con_RegisterPassword:
                    this.registerPassword = strValue;
                    break;
                case clsvTeacherInfoEN.con_EntryYear:
                    this.entryYear = strValue;
                    break;
                case clsvTeacherInfoEN.con_DisciplineName_ps:
                    this.disciplineName_ps = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vTeacherInfo]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"id_Teacher"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Teacher() { return "id_Teacher"; } //教师流水号
        /**
        * 常量:"TeacherID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeacherID() { return "teacherID"; } //教师工号
        /**
        * 常量:"TeacherName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeacherName() { return "teacherName"; } //教师姓名
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
        * 常量:"id_School_Ps"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_School_Ps() { return "id_School_Ps"; } //学校流水号
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
        * 常量:"id_Discipline_Ps"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Discipline_Ps() { return "id_Discipline_Ps"; } //学科流水号
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
        * 常量:"id_Ethnic"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Ethnic() { return "id_Ethnic"; } //民族流水号
        /**
        * 常量:"EthnicName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EthnicName() { return "ethnicName"; } //民族名称
        /**
        * 常量:"id_Politics"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Politics() { return "id_Politics"; } //政治面貌流水号
        /**
        * 常量:"PoliticsName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PoliticsName() { return "politicsName"; } //政治面貌
        /**
        * 常量:"id_AdminGrade"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_AdminGrade() { return "id_AdminGrade"; } //行政职务流水号
        /**
        * 常量:"AdminGradeDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AdminGradeDesc() { return "adminGradeDesc"; } //行政职务描述
        /**
        * 常量:"id_ProfGrade"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_ProfGrade() { return "id_ProfGrade"; } //专业职称流水号
        /**
        * 常量:"ProfenssionalGradeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProfenssionalGradeName() { return "profenssionalGradeName"; } //专业职称
        /**
        * 常量:"id_Qualif"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Qualif() { return "id_Qualif"; } //学历流水号
        /**
        * 常量:"QualifDesc"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QualifDesc() { return "qualifDesc"; } //QualifDesc
        /**
        * 常量:"id_Degree"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Degree() { return "id_Degree"; } //学位流水号
        /**
        * 常量:"DegreeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DegreeName() { return "degreeName"; } //学位名称
        /**
        * 常量:"id_StaffType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_StaffType() { return "id_StaffType"; } //职工类型流水号
        /**
        * 常量:"StaffTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StaffTypeName() { return "staffTypeName"; } //职工类型名称
        /**
        * 常量:"id_Province"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Province() { return "id_Province"; } //省份流水号
        /**
        * 常量:"ProvinceName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProvinceName() { return "provinceName"; } //ProvinceName
        /**
        * 常量:"CitizenID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitizenID() { return "citizenID"; } //身份证号
        /**
        * 常量:"CardNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CardNo() { return "cardNo"; } //卡号
        /**
        * 常量:"Birthday"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Birthday() { return "birthday"; } //出生日期
        /**
        * 常量:"GraduationMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GraduationMajor() { return "graduationMajor"; } //毕业专业
        /**
        * 常量:"TelNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TelNo() { return "telNo"; } //电话
        /**
        * 常量:"Email"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Email() { return "email"; } //电子邮箱
        /**
        * 常量:"WebSite"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WebSite() { return "webSite"; } //个人主页
        /**
        * 常量:"PersonBlog"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PersonBlog() { return "personBlog"; } //个人博客
        /**
        * 常量:"EntryDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EntryDate() { return "entryDate"; } //进校日期
        /**
        * 常量:"Offed"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Offed() { return "offed"; } //是否离校
        /**
        * 常量:"Id_CardNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Id_CardNo() { return "id_CardNo"; } //内卡号
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
        * 常量:"FromUnit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FromUnit() { return "fromUnit"; } //来自单位
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
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
        * 常量:"EntryDay"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EntryDay() { return "entryDay"; } //EntryDay
        /**
        * 常量:"id_Photo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Photo() { return "id_Photo"; } //id_Photo
        /**
        * 常量:"id_Religion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_Religion() { return "id_Religion"; } //id_Religion
        /**
        * 常量:"ReligionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReligionName() { return "religionName"; } //ReligionName
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
        * 常量:"ModifyUserID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyUserID() { return "modifyUserID"; } //修改人
        /**
        * 常量:"OffedBak"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OffedBak() { return "offedBak"; } //OffedBak
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
        * 常量:"Teach_id_College"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Teach_id_College() { return "teach_id_College"; } //Teach_id_College
        /**
        * 常量:"Teach_id_Major"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Teach_id_Major() { return "teach_id_Major"; } //Teach_id_Major
        /**
        * 常量:"Tel"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Tel() { return "tel"; } //Tel
        /**
        * 常量:"ModifyDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ModifyDate() { return "modifyDate"; } //修改日期
        /**
        * 常量:"RegisterPassword"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RegisterPassword() { return "registerPassword"; } //RegisterPassword
        /**
        * 常量:"EntryYear"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EntryYear() { return "entryYear"; } //EntryYear
        /**
        * 常量:"DisciplineName_ps"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DisciplineName_ps() { return "disciplineName_ps"; } //学科
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
    exports.clsvTeacherInfoEN = clsvTeacherInfoEN;
    clsvTeacherInfoEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvTeacherInfoEN.CacheModeId = "02"; //客户端缓存
    clsvTeacherInfoEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvTeacherInfoEN.WhereFormat = ""; //条件格式串
    clsvTeacherInfoEN._CurrTabName = "vTeacherInfo"; //当前表名,与该类相关的表名
    clsvTeacherInfoEN._KeyFldName = "id_Teacher"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvTeacherInfoEN.mintAttributeCount = 65;
    clsvTeacherInfoEN.AttributeName = ["id_Teacher", "teacherID", "teacherName", "id_Sex", "sexDesc", "id_School_Ps", "schoolId", "schoolName", "id_Discipline_Ps", "id_UniZone", "uniZoneDesc", "id_Ethnic", "ethnicName", "id_Politics", "politicsName", "id_AdminGrade", "adminGradeDesc", "id_ProfGrade", "profenssionalGradeName", "id_Qualif", "qualifDesc", "id_Degree", "degreeName", "id_StaffType", "staffTypeName", "id_Province", "provinceName", "citizenID", "cardNo", "birthday", "graduationMajor", "telNo", "email", "webSite", "personBlog", "entryDate", "offed", "id_CardNo", "isAvconUser", "isGpUser", "isLocalUser", "fromUnit", "memo", "id_XzCollege", "collegeID", "collegeName", "collegeNameA", "id_XzMajor", "entryDay", "id_Photo", "id_Religion", "religionName", "isMessage", "microblog", "modifyUserID", "offedBak", "phoneNumber", "qQ", "teach_id_College", "teach_id_Major", "tel", "modifyDate", "registerPassword", "entryYear", "disciplineName_ps"];
});
