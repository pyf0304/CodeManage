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
    exports.clscc_CourseEN = void 0;
    /**
    * 类名:clscc_CourseEN
    * 表名:cc_Course(01120056)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:13:18
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:课程学习(CourseLearning)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 课程(cc_Course)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clscc_CourseEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrCourseId = ""; //课程Id
            this.mstrCourseCode = ""; //课程代码
            this.mstrCourseDescription = ""; //课程描述
            this.mstrCourseName = ""; //课程名称
            this.mstrCourseTypeID = ""; //课程类型ID
            this.mstrCreateDate = ""; //建立日期
            this.mstrExcellentTypeId = ""; //精品课程类型Id
            this.mintExcellentYear = 0; //课程年份
            this.mbolIsBuildingCourse = false; //是否已建设课程
            this.mbolIsDoubleLanguageCourse = false; //是否双语课程
            this.mbolIsOpen = false; //是否公开
            this.mbolIsRecommendedCourse = false; //是否推荐课程
            this.mbolIsSelfPropelledCourse = false; //是否自荐课程
            this.mstrOperationDate = ""; //操作时间
            this.mintOrderNum = 0; //序号
            this.mstrOuterLink = ""; //外链地址
            this.mintViewCount = 0; //浏览量
            this.mstrThemeId = ""; //主题Id
            this.mstrid_School = ""; //学校流水号
            this.mstrid_XzMajor = ""; //专业流水号
            this.mstrid_XzCollege = ""; //学院流水号
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.courseId = ""; //课程Id
            this.courseCode = ""; //课程代码
            this.courseDescription = ""; //课程描述
            this.courseName = ""; //课程名称
            this.courseTypeID = ""; //课程类型ID
            this.createDate = ""; //建立日期
            this.excellentTypeId = ""; //精品课程类型Id
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
            this.id_School = ""; //学校流水号
            this.id_XzMajor = ""; //专业流水号
            this.id_XzCollege = ""; //学院流水号
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.memo = ""; //备注
        }
        /**
         * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseId(value) {
            if (value != undefined) {
                this.courseId = value;
                this.hmProperty["courseId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseCode(value) {
            if (value != undefined) {
                this.courseCode = value;
                this.hmProperty["courseCode"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程描述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseDescription(value) {
            if (value != undefined) {
                this.courseDescription = value;
                this.hmProperty["courseDescription"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseName(value) {
            if (value != undefined) {
                this.courseName = value;
                this.hmProperty["courseName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseTypeID(value) {
            if (value != undefined) {
                this.courseTypeID = value;
                this.hmProperty["courseTypeID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCreateDate(value) {
            if (value != undefined) {
                this.createDate = value;
                this.hmProperty["createDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 精品课程类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExcellentTypeId(value) {
            if (value != undefined) {
                this.excellentTypeId = value;
                this.hmProperty["excellentTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程年份(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExcellentYear(value) {
            if (value != undefined) {
                this.excellentYear = value;
                this.hmProperty["excellentYear"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否已建设课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsBuildingCourse(value) {
            if (value != undefined) {
                this.isBuildingCourse = value;
                this.hmProperty["isBuildingCourse"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否双语课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsDoubleLanguageCourse(value) {
            if (value != undefined) {
                this.isDoubleLanguageCourse = value;
                this.hmProperty["isDoubleLanguageCourse"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsOpen(value) {
            if (value != undefined) {
                this.isOpen = value;
                this.hmProperty["isOpen"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否推荐课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsRecommendedCourse(value) {
            if (value != undefined) {
                this.isRecommendedCourse = value;
                this.hmProperty["isRecommendedCourse"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否自荐课程(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSelfPropelledCourse(value) {
            if (value != undefined) {
                this.isSelfPropelledCourse = value;
                this.hmProperty["isSelfPropelledCourse"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 操作时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOperationDate(value) {
            if (value != undefined) {
                this.operationDate = value;
                this.hmProperty["operationDate"] = true;
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
         * 外链地址(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOuterLink(value) {
            if (value != undefined) {
                this.outerLink = value;
                this.hmProperty["outerLink"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetViewCount(value) {
            if (value != undefined) {
                this.viewCount = value;
                this.hmProperty["viewCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetThemeId(value) {
            if (value != undefined) {
                this.themeId = value;
                this.hmProperty["themeId"] = true;
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
                case clscc_CourseEN.con_CourseId:
                    return this.courseId;
                case clscc_CourseEN.con_CourseCode:
                    return this.courseCode;
                case clscc_CourseEN.con_CourseDescription:
                    return this.courseDescription;
                case clscc_CourseEN.con_CourseName:
                    return this.courseName;
                case clscc_CourseEN.con_CourseTypeID:
                    return this.courseTypeID;
                case clscc_CourseEN.con_CreateDate:
                    return this.createDate;
                case clscc_CourseEN.con_ExcellentTypeId:
                    return this.excellentTypeId;
                case clscc_CourseEN.con_ExcellentYear:
                    return this.excellentYear;
                case clscc_CourseEN.con_IsBuildingCourse:
                    return this.isBuildingCourse;
                case clscc_CourseEN.con_IsDoubleLanguageCourse:
                    return this.isDoubleLanguageCourse;
                case clscc_CourseEN.con_IsOpen:
                    return this.isOpen;
                case clscc_CourseEN.con_IsRecommendedCourse:
                    return this.isRecommendedCourse;
                case clscc_CourseEN.con_IsSelfPropelledCourse:
                    return this.isSelfPropelledCourse;
                case clscc_CourseEN.con_OperationDate:
                    return this.operationDate;
                case clscc_CourseEN.con_OrderNum:
                    return this.orderNum;
                case clscc_CourseEN.con_OuterLink:
                    return this.outerLink;
                case clscc_CourseEN.con_ViewCount:
                    return this.viewCount;
                case clscc_CourseEN.con_ThemeId:
                    return this.themeId;
                case clscc_CourseEN.con_id_School:
                    return this.id_School;
                case clscc_CourseEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clscc_CourseEN.con_id_XzCollege:
                    return this.id_XzCollege;
                case clscc_CourseEN.con_UpdDate:
                    return this.updDate;
                case clscc_CourseEN.con_UpdUserId:
                    return this.updUserId;
                case clscc_CourseEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_Course]中不存在！`;
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
                case clscc_CourseEN.con_CourseId:
                    this.courseId = strValue;
                    this.hmProperty["courseId"] = true;
                    break;
                case clscc_CourseEN.con_CourseCode:
                    this.courseCode = strValue;
                    this.hmProperty["courseCode"] = true;
                    break;
                case clscc_CourseEN.con_CourseDescription:
                    this.courseDescription = strValue;
                    this.hmProperty["courseDescription"] = true;
                    break;
                case clscc_CourseEN.con_CourseName:
                    this.courseName = strValue;
                    this.hmProperty["courseName"] = true;
                    break;
                case clscc_CourseEN.con_CourseTypeID:
                    this.courseTypeID = strValue;
                    this.hmProperty["courseTypeID"] = true;
                    break;
                case clscc_CourseEN.con_CreateDate:
                    this.createDate = strValue;
                    this.hmProperty["createDate"] = true;
                    break;
                case clscc_CourseEN.con_ExcellentTypeId:
                    this.excellentTypeId = strValue;
                    this.hmProperty["excellentTypeId"] = true;
                    break;
                case clscc_CourseEN.con_ExcellentYear:
                    this.excellentYear = Number(strValue);
                    this.hmProperty["excellentYear"] = true;
                    break;
                case clscc_CourseEN.con_IsBuildingCourse:
                    this.isBuildingCourse = Boolean(strValue);
                    this.hmProperty["isBuildingCourse"] = true;
                    break;
                case clscc_CourseEN.con_IsDoubleLanguageCourse:
                    this.isDoubleLanguageCourse = Boolean(strValue);
                    this.hmProperty["isDoubleLanguageCourse"] = true;
                    break;
                case clscc_CourseEN.con_IsOpen:
                    this.isOpen = Boolean(strValue);
                    this.hmProperty["isOpen"] = true;
                    break;
                case clscc_CourseEN.con_IsRecommendedCourse:
                    this.isRecommendedCourse = Boolean(strValue);
                    this.hmProperty["isRecommendedCourse"] = true;
                    break;
                case clscc_CourseEN.con_IsSelfPropelledCourse:
                    this.isSelfPropelledCourse = Boolean(strValue);
                    this.hmProperty["isSelfPropelledCourse"] = true;
                    break;
                case clscc_CourseEN.con_OperationDate:
                    this.operationDate = strValue;
                    this.hmProperty["operationDate"] = true;
                    break;
                case clscc_CourseEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    this.hmProperty["orderNum"] = true;
                    break;
                case clscc_CourseEN.con_OuterLink:
                    this.outerLink = strValue;
                    this.hmProperty["outerLink"] = true;
                    break;
                case clscc_CourseEN.con_ViewCount:
                    this.viewCount = Number(strValue);
                    this.hmProperty["viewCount"] = true;
                    break;
                case clscc_CourseEN.con_ThemeId:
                    this.themeId = strValue;
                    this.hmProperty["themeId"] = true;
                    break;
                case clscc_CourseEN.con_id_School:
                    this.id_School = strValue;
                    this.hmProperty["id_School"] = true;
                    break;
                case clscc_CourseEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    this.hmProperty["id_XzMajor"] = true;
                    break;
                case clscc_CourseEN.con_id_XzCollege:
                    this.id_XzCollege = strValue;
                    this.hmProperty["id_XzCollege"] = true;
                    break;
                case clscc_CourseEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clscc_CourseEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clscc_CourseEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_Course]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"id_School"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_School() { return "id_School"; } //学校流水号
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"id_XzCollege"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzCollege() { return "id_XzCollege"; } //学院流水号
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
    exports.clscc_CourseEN = clscc_CourseEN;
    clscc_CourseEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clscc_CourseEN.CacheModeId = "04"; //sessionStorage
    clscc_CourseEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clscc_CourseEN.WhereFormat = ""; //条件格式串
    clscc_CourseEN._CurrTabName = "cc_Course"; //当前表名,与该类相关的表名
    clscc_CourseEN._KeyFldName = "CourseId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clscc_CourseEN.mintAttributeCount = 24;
    clscc_CourseEN.AttributeName = ["courseId", "courseCode", "courseDescription", "courseName", "courseTypeID", "createDate", "excellentTypeId", "excellentYear", "isBuildingCourse", "isDoubleLanguageCourse", "isOpen", "isRecommendedCourse", "isSelfPropelledCourse", "operationDate", "orderNum", "outerLink", "viewCount", "themeId", "id_School", "id_XzMajor", "id_XzCollege", "updDate", "updUserId", "memo"];
});
