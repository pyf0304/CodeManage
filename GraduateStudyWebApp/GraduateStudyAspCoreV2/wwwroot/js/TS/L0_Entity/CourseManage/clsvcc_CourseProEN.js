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
    exports.clsvcc_CourseProEN = void 0;
    /**
    * 类名:clsvcc_CourseProEN
    * 表名:vcc_CoursePro(01120213)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:46:47
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:课程管理(CourseManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v课程Pro(vcc_CoursePro)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvcc_CourseProEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.courseId = ""; //课程Id
            this.likeCount = 0; //LikeCount
            this.courseCode = ""; //课程代码
            this.courseDescription = ""; //课程描述
            this.courseName = ""; //课程名称
            this.courseTypeID = ""; //课程类型ID
            this.courseTypeName = ""; //课程类型名称
            this.createDate = ""; //建立日期
            this.excellentTypeId = ""; //精品课程类型Id
            this.excellentTypeName = ""; //精品课程类型名称
            this.excellentYear = 0; //课程年份
            this.isBuildingCourse = false; //是否已建设课程
            this.isDoubleLanguageCourse = false; //是否双语课程
            this.isOpen = false; //是否公开
            this.isRecommendedCourse = false; //是否推荐课程
            this.isSelfPropelledCourse = false; //是否自荐课程
            this.operationDate = ""; //操作时间
            this.orderNum = 0; //序号
            this.outerLink = ""; //外链地址
            this.viewCount = 0; //浏览量
            this.themeId = ""; //主题Id
            this.themeName = ""; //主题名
            this.exampleImgPath = ""; //示例图路径
            this.id_XzMajor = ""; //专业流水号
            this.majorID = ""; //专业ID
            this.majorName = ""; //专业名称
            this.id_XzCollege = ""; //学院流水号
            this.collegeID = ""; //学院ID
            this.collegeName = ""; //学院名称
            this.collegeNameA = ""; //学院名称简写
            this.memo = ""; //备注
            this.questionNum = 0; //题目数
            this.knowledgesNum = 0; //知识点数
            this.teacherNum = 0; //教师数
            this.chapterNum = 0; //章节数
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
                case clsvcc_CourseProEN.con_CourseId:
                    return this.courseId;
                case clsvcc_CourseProEN.con_LikeCount:
                    return this.likeCount;
                case clsvcc_CourseProEN.con_CourseCode:
                    return this.courseCode;
                case clsvcc_CourseProEN.con_CourseDescription:
                    return this.courseDescription;
                case clsvcc_CourseProEN.con_CourseName:
                    return this.courseName;
                case clsvcc_CourseProEN.con_CourseTypeID:
                    return this.courseTypeID;
                case clsvcc_CourseProEN.con_CourseTypeName:
                    return this.courseTypeName;
                case clsvcc_CourseProEN.con_CreateDate:
                    return this.createDate;
                case clsvcc_CourseProEN.con_ExcellentTypeId:
                    return this.excellentTypeId;
                case clsvcc_CourseProEN.con_ExcellentTypeName:
                    return this.excellentTypeName;
                case clsvcc_CourseProEN.con_ExcellentYear:
                    return this.excellentYear;
                case clsvcc_CourseProEN.con_IsBuildingCourse:
                    return this.isBuildingCourse;
                case clsvcc_CourseProEN.con_IsDoubleLanguageCourse:
                    return this.isDoubleLanguageCourse;
                case clsvcc_CourseProEN.con_IsOpen:
                    return this.isOpen;
                case clsvcc_CourseProEN.con_IsRecommendedCourse:
                    return this.isRecommendedCourse;
                case clsvcc_CourseProEN.con_IsSelfPropelledCourse:
                    return this.isSelfPropelledCourse;
                case clsvcc_CourseProEN.con_OperationDate:
                    return this.operationDate;
                case clsvcc_CourseProEN.con_OrderNum:
                    return this.orderNum;
                case clsvcc_CourseProEN.con_OuterLink:
                    return this.outerLink;
                case clsvcc_CourseProEN.con_ViewCount:
                    return this.viewCount;
                case clsvcc_CourseProEN.con_ThemeId:
                    return this.themeId;
                case clsvcc_CourseProEN.con_ThemeName:
                    return this.themeName;
                case clsvcc_CourseProEN.con_ExampleImgPath:
                    return this.exampleImgPath;
                case clsvcc_CourseProEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvcc_CourseProEN.con_MajorID:
                    return this.majorID;
                case clsvcc_CourseProEN.con_MajorName:
                    return this.majorName;
                case clsvcc_CourseProEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clsvcc_CourseProEN.con_CollegeID:
                    return this.collegeID;
                case clsvcc_CourseProEN.con_CollegeName:
                    return this.collegeName;
                case clsvcc_CourseProEN.con_CollegeNameA:
                    return this.collegeNameA;
                case clsvcc_CourseProEN.con_Memo:
                    return this.memo;
                case clsvcc_CourseProEN.con_QuestionNum:
                    return this.questionNum;
                case clsvcc_CourseProEN.con_KnowledgesNum:
                    return this.knowledgesNum;
                case clsvcc_CourseProEN.con_TeacherNum:
                    return this.teacherNum;
                case clsvcc_CourseProEN.con_ChapterNum:
                    return this.chapterNum;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vcc_CoursePro]中不存在！`;
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
                case clsvcc_CourseProEN.con_CourseId:
                    this.courseId = strValue;
                    break;
                case clsvcc_CourseProEN.con_LikeCount:
                    this.likeCount = Number(strValue);
                    break;
                case clsvcc_CourseProEN.con_CourseCode:
                    this.courseCode = strValue;
                    break;
                case clsvcc_CourseProEN.con_CourseDescription:
                    this.courseDescription = strValue;
                    break;
                case clsvcc_CourseProEN.con_CourseName:
                    this.courseName = strValue;
                    break;
                case clsvcc_CourseProEN.con_CourseTypeID:
                    this.courseTypeID = strValue;
                    break;
                case clsvcc_CourseProEN.con_CourseTypeName:
                    this.courseTypeName = strValue;
                    break;
                case clsvcc_CourseProEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvcc_CourseProEN.con_ExcellentTypeId:
                    this.excellentTypeId = strValue;
                    break;
                case clsvcc_CourseProEN.con_ExcellentTypeName:
                    this.excellentTypeName = strValue;
                    break;
                case clsvcc_CourseProEN.con_ExcellentYear:
                    this.excellentYear = Number(strValue);
                    break;
                case clsvcc_CourseProEN.con_IsBuildingCourse:
                    this.isBuildingCourse = Boolean(strValue);
                    break;
                case clsvcc_CourseProEN.con_IsDoubleLanguageCourse:
                    this.isDoubleLanguageCourse = Boolean(strValue);
                    break;
                case clsvcc_CourseProEN.con_IsOpen:
                    this.isOpen = Boolean(strValue);
                    break;
                case clsvcc_CourseProEN.con_IsRecommendedCourse:
                    this.isRecommendedCourse = Boolean(strValue);
                    break;
                case clsvcc_CourseProEN.con_IsSelfPropelledCourse:
                    this.isSelfPropelledCourse = Boolean(strValue);
                    break;
                case clsvcc_CourseProEN.con_OperationDate:
                    this.operationDate = strValue;
                    break;
                case clsvcc_CourseProEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvcc_CourseProEN.con_OuterLink:
                    this.outerLink = strValue;
                    break;
                case clsvcc_CourseProEN.con_ViewCount:
                    this.viewCount = Number(strValue);
                    break;
                case clsvcc_CourseProEN.con_ThemeId:
                    this.themeId = strValue;
                    break;
                case clsvcc_CourseProEN.con_ThemeName:
                    this.themeName = strValue;
                    break;
                case clsvcc_CourseProEN.con_ExampleImgPath:
                    this.exampleImgPath = strValue;
                    break;
                case clsvcc_CourseProEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvcc_CourseProEN.con_MajorID:
                    this.majorID = strValue;
                    break;
                case clsvcc_CourseProEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvcc_CourseProEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    break;
                case clsvcc_CourseProEN.con_CollegeID:
                    this.collegeID = strValue;
                    break;
                case clsvcc_CourseProEN.con_CollegeName:
                    this.collegeName = strValue;
                    break;
                case clsvcc_CourseProEN.con_CollegeNameA:
                    this.collegeNameA = strValue;
                    break;
                case clsvcc_CourseProEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvcc_CourseProEN.con_QuestionNum:
                    this.questionNum = Number(strValue);
                    break;
                case clsvcc_CourseProEN.con_KnowledgesNum:
                    this.knowledgesNum = Number(strValue);
                    break;
                case clsvcc_CourseProEN.con_TeacherNum:
                    this.teacherNum = Number(strValue);
                    break;
                case clsvcc_CourseProEN.con_ChapterNum:
                    this.chapterNum = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vcc_CoursePro]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"LikeCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LikeCount() { return "likeCount"; } //LikeCount
        /**
        * 常量:"CourseCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseCode() { return "courseCode"; } //课程代码
        /**
        * 常量:"CourseDescription"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseDescription() { return "courseDescription"; } //课程描述
        /**
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
        /**
        * 常量:"CourseTypeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseTypeID() { return "courseTypeID"; } //课程类型ID
        /**
        * 常量:"CourseTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseTypeName() { return "courseTypeName"; } //课程类型名称
        /**
        * 常量:"CreateDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateDate() { return "createDate"; } //建立日期
        /**
        * 常量:"ExcellentTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExcellentTypeId() { return "excellentTypeId"; } //精品课程类型Id
        /**
        * 常量:"ExcellentTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExcellentTypeName() { return "excellentTypeName"; } //精品课程类型名称
        /**
        * 常量:"ExcellentYear"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExcellentYear() { return "excellentYear"; } //课程年份
        /**
        * 常量:"IsBuildingCourse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsBuildingCourse() { return "isBuildingCourse"; } //是否已建设课程
        /**
        * 常量:"IsDoubleLanguageCourse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsDoubleLanguageCourse() { return "isDoubleLanguageCourse"; } //是否双语课程
        /**
        * 常量:"IsOpen"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsOpen() { return "isOpen"; } //是否公开
        /**
        * 常量:"IsRecommendedCourse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRecommendedCourse() { return "isRecommendedCourse"; } //是否推荐课程
        /**
        * 常量:"IsSelfPropelledCourse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSelfPropelledCourse() { return "isSelfPropelledCourse"; } //是否自荐课程
        /**
        * 常量:"OperationDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OperationDate() { return "operationDate"; } //操作时间
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"OuterLink"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OuterLink() { return "outerLink"; } //外链地址
        /**
        * 常量:"ViewCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewCount() { return "viewCount"; } //浏览量
        /**
        * 常量:"ThemeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ThemeId() { return "themeId"; } //主题Id
        /**
        * 常量:"ThemeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ThemeName() { return "themeName"; } //主题名
        /**
        * 常量:"ExampleImgPath"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExampleImgPath() { return "exampleImgPath"; } //示例图路径
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
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"QuestionNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionNum() { return "questionNum"; } //题目数
        /**
        * 常量:"KnowledgesNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgesNum() { return "knowledgesNum"; } //知识点数
        /**
        * 常量:"TeacherNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeacherNum() { return "teacherNum"; } //教师数
        /**
        * 常量:"ChapterNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterNum() { return "chapterNum"; } //章节数
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
    exports.clsvcc_CourseProEN = clsvcc_CourseProEN;
    clsvcc_CourseProEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvcc_CourseProEN.CacheModeId = ""; //
    clsvcc_CourseProEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvcc_CourseProEN.WhereFormat = ""; //条件格式串
    clsvcc_CourseProEN._CurrTabName = "vcc_CoursePro"; //当前表名,与该类相关的表名
    clsvcc_CourseProEN._KeyFldName = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvcc_CourseProEN.mintAttributeCount = 35;
    clsvcc_CourseProEN.AttributeName = ["courseId", "likeCount", "courseCode", "courseDescription", "courseName", "courseTypeID", "courseTypeName", "createDate", "excellentTypeId", "excellentTypeName", "excellentYear", "isBuildingCourse", "isDoubleLanguageCourse", "isOpen", "isRecommendedCourse", "isSelfPropelledCourse", "operationDate", "orderNum", "outerLink", "viewCount", "themeId", "themeName", "exampleImgPath", "id_XzMajor", "majorID", "majorName", "id_XzCollege", "collegeID", "collegeName", "collegeNameA", "memo", "questionNum", "knowledgesNum", "teacherNum", "chapterNum"];
});
