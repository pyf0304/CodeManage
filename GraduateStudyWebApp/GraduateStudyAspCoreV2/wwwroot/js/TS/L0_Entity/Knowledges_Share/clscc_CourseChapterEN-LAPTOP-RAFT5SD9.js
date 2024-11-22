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
    exports.clscc_CourseChapterEN = void 0;
    /**
    * 类名:clscc_CourseChapterEN
    * 表名:cc_CourseChapter(01120060)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/12 11:56:41
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:知识点相关(Knowledges)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 课程章节(cc_CourseChapter)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clscc_CourseChapterEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrCourseChapterId = ""; //课程章节ID
            this.mstrCourseChapterName = ""; //课程章节名称
            this.mstrChapterId = ""; //章Id
            this.mstrSectionId = ""; //节Id
            this.mstrChapterName = ""; //章名
            this.mstrSectionName = ""; //节名
            this.mstrChapterName_Sim = ""; //章名简称
            this.mstrSectionName_Sim = ""; //节名简称
            this.mstrChapterContent = ""; //章节内容
            this.mstrCourseId = ""; //课程Id
            this.mstrParentNodeID = ""; //父节点编号
            this.mbolIsOpenToAllStu = false; //全校师生
            this.mbolIsOpenToSchool = false; //全校师生公开
            this.mbolIsOpenToSocial = false; //社会公众
            this.mbolIsMustMenu = false; //是否必建栏目
            this.mstrThemeName = ""; //主题名
            this.mbolIsFile = false; //项目或文件夹
            this.mbolIsUse = false; //是否使用
            this.mintViewCount = 0; //浏览量
            this.mstrCourseChapterReferred = ""; //节简称
            this.mintOrderNum = 0; //序号
            this.mstrCreateDate = ""; //建立日期
            this.mstrEditPeople = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.courseChapterId = ""; //课程章节ID
            this.courseChapterName = ""; //课程章节名称
            this.chapterId = ""; //章Id
            this.sectionId = ""; //节Id
            this.chapterName = ""; //章名
            this.sectionName = ""; //节名
            this.chapterName_Sim = ""; //章名简称
            this.sectionName_Sim = ""; //节名简称
            this.chapterContent = ""; //章节内容
            this.courseId = ""; //课程Id
            this.parentNodeID = ""; //父节点编号
            this.isOpenToAllStu = false; //全校师生
            this.isOpenToSchool = false; //全校师生公开
            this.isOpenToSocial = false; //社会公众
            this.isMustMenu = false; //是否必建栏目
            this.themeName = ""; //主题名
            this.isFile = false; //项目或文件夹
            this.isUse = false; //是否使用
            this.viewCount = 0; //浏览量
            this.courseChapterReferred = ""; //节简称
            this.orderNum = 0; //序号
            this.createDate = ""; //建立日期
            this.editPeople = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
        }
        /**
         * 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseChapterId(value) {
            if (value != undefined) {
                this.courseChapterId = value;
                this.hmProperty["courseChapterId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 课程章节名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseChapterName(value) {
            if (value != undefined) {
                this.courseChapterName = value;
                this.hmProperty["courseChapterName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 章Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetChapterId(value) {
            if (value != undefined) {
                this.chapterId = value;
                this.hmProperty["chapterId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSectionId(value) {
            if (value != undefined) {
                this.sectionId = value;
                this.hmProperty["sectionId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 章名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetChapterName(value) {
            if (value != undefined) {
                this.chapterName = value;
                this.hmProperty["chapterName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSectionName(value) {
            if (value != undefined) {
                this.sectionName = value;
                this.hmProperty["sectionName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 章名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetChapterName_Sim(value) {
            if (value != undefined) {
                this.chapterName_Sim = value;
                this.hmProperty["chapterName_Sim"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 节名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSectionName_Sim(value) {
            if (value != undefined) {
                this.sectionName_Sim = value;
                this.hmProperty["sectionName_Sim"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 章节内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetChapterContent(value) {
            if (value != undefined) {
                this.chapterContent = value;
                this.hmProperty["chapterContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
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
         * 父节点编号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParentNodeID(value) {
            if (value != undefined) {
                this.parentNodeID = value;
                this.hmProperty["parentNodeID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 全校师生(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsOpenToAllStu(value) {
            if (value != undefined) {
                this.isOpenToAllStu = value;
                this.hmProperty["isOpenToAllStu"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 全校师生公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsOpenToSchool(value) {
            if (value != undefined) {
                this.isOpenToSchool = value;
                this.hmProperty["isOpenToSchool"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 社会公众(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsOpenToSocial(value) {
            if (value != undefined) {
                this.isOpenToSocial = value;
                this.hmProperty["isOpenToSocial"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否必建栏目(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsMustMenu(value) {
            if (value != undefined) {
                this.isMustMenu = value;
                this.hmProperty["isMustMenu"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 主题名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetThemeName(value) {
            if (value != undefined) {
                this.themeName = value;
                this.hmProperty["themeName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 项目或文件夹(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsFile(value) {
            if (value != undefined) {
                this.isFile = value;
                this.hmProperty["isFile"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsUse(value) {
            if (value != undefined) {
                this.isUse = value;
                this.hmProperty["isUse"] = true;
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
         * 节简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseChapterReferred(value) {
            if (value != undefined) {
                this.courseChapterReferred = value;
                this.hmProperty["courseChapterReferred"] = true;
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
         * 修改人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetEditPeople(value) {
            if (value != undefined) {
                this.editPeople = value;
                this.hmProperty["editPeople"] = true;
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
                case clscc_CourseChapterEN.con_CourseChapterId:
                    return this.courseChapterId;
                case clscc_CourseChapterEN.con_CourseChapterName:
                    return this.courseChapterName;
                case clscc_CourseChapterEN.con_ChapterId:
                    return this.chapterId;
                case clscc_CourseChapterEN.con_SectionId:
                    return this.sectionId;
                case clscc_CourseChapterEN.con_ChapterName:
                    return this.chapterName;
                case clscc_CourseChapterEN.con_SectionName:
                    return this.sectionName;
                case clscc_CourseChapterEN.con_ChapterName_Sim:
                    return this.chapterName_Sim;
                case clscc_CourseChapterEN.con_SectionName_Sim:
                    return this.sectionName_Sim;
                case clscc_CourseChapterEN.con_ChapterContent:
                    return this.chapterContent;
                case clscc_CourseChapterEN.con_CourseId:
                    return this.courseId;
                case clscc_CourseChapterEN.con_ParentNodeID:
                    return this.parentNodeID;
                case clscc_CourseChapterEN.con_IsOpenToAllStu:
                    return this.isOpenToAllStu;
                case clscc_CourseChapterEN.con_IsOpenToSchool:
                    return this.isOpenToSchool;
                case clscc_CourseChapterEN.con_IsOpenToSocial:
                    return this.isOpenToSocial;
                case clscc_CourseChapterEN.con_IsMustMenu:
                    return this.isMustMenu;
                case clscc_CourseChapterEN.con_ThemeName:
                    return this.themeName;
                case clscc_CourseChapterEN.con_IsFile:
                    return this.isFile;
                case clscc_CourseChapterEN.con_IsUse:
                    return this.isUse;
                case clscc_CourseChapterEN.con_ViewCount:
                    return this.viewCount;
                case clscc_CourseChapterEN.con_CourseChapterReferred:
                    return this.courseChapterReferred;
                case clscc_CourseChapterEN.con_OrderNum:
                    return this.orderNum;
                case clscc_CourseChapterEN.con_CreateDate:
                    return this.createDate;
                case clscc_CourseChapterEN.con_EditPeople:
                    return this.editPeople;
                case clscc_CourseChapterEN.con_UpdDate:
                    return this.updDate;
                case clscc_CourseChapterEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_CourseChapter]中不存在！`;
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
                case clscc_CourseChapterEN.con_CourseChapterId:
                    this.courseChapterId = strValue;
                    this.hmProperty["courseChapterId"] = true;
                    break;
                case clscc_CourseChapterEN.con_CourseChapterName:
                    this.courseChapterName = strValue;
                    this.hmProperty["courseChapterName"] = true;
                    break;
                case clscc_CourseChapterEN.con_ChapterId:
                    this.chapterId = strValue;
                    this.hmProperty["chapterId"] = true;
                    break;
                case clscc_CourseChapterEN.con_SectionId:
                    this.sectionId = strValue;
                    this.hmProperty["sectionId"] = true;
                    break;
                case clscc_CourseChapterEN.con_ChapterName:
                    this.chapterName = strValue;
                    this.hmProperty["chapterName"] = true;
                    break;
                case clscc_CourseChapterEN.con_SectionName:
                    this.sectionName = strValue;
                    this.hmProperty["sectionName"] = true;
                    break;
                case clscc_CourseChapterEN.con_ChapterName_Sim:
                    this.chapterName_Sim = strValue;
                    this.hmProperty["chapterName_Sim"] = true;
                    break;
                case clscc_CourseChapterEN.con_SectionName_Sim:
                    this.sectionName_Sim = strValue;
                    this.hmProperty["sectionName_Sim"] = true;
                    break;
                case clscc_CourseChapterEN.con_ChapterContent:
                    this.chapterContent = strValue;
                    this.hmProperty["chapterContent"] = true;
                    break;
                case clscc_CourseChapterEN.con_CourseId:
                    this.courseId = strValue;
                    this.hmProperty["courseId"] = true;
                    break;
                case clscc_CourseChapterEN.con_ParentNodeID:
                    this.parentNodeID = strValue;
                    this.hmProperty["parentNodeID"] = true;
                    break;
                case clscc_CourseChapterEN.con_IsOpenToAllStu:
                    this.isOpenToAllStu = Boolean(strValue);
                    this.hmProperty["isOpenToAllStu"] = true;
                    break;
                case clscc_CourseChapterEN.con_IsOpenToSchool:
                    this.isOpenToSchool = Boolean(strValue);
                    this.hmProperty["isOpenToSchool"] = true;
                    break;
                case clscc_CourseChapterEN.con_IsOpenToSocial:
                    this.isOpenToSocial = Boolean(strValue);
                    this.hmProperty["isOpenToSocial"] = true;
                    break;
                case clscc_CourseChapterEN.con_IsMustMenu:
                    this.isMustMenu = Boolean(strValue);
                    this.hmProperty["isMustMenu"] = true;
                    break;
                case clscc_CourseChapterEN.con_ThemeName:
                    this.themeName = strValue;
                    this.hmProperty["themeName"] = true;
                    break;
                case clscc_CourseChapterEN.con_IsFile:
                    this.isFile = Boolean(strValue);
                    this.hmProperty["isFile"] = true;
                    break;
                case clscc_CourseChapterEN.con_IsUse:
                    this.isUse = Boolean(strValue);
                    this.hmProperty["isUse"] = true;
                    break;
                case clscc_CourseChapterEN.con_ViewCount:
                    this.viewCount = Number(strValue);
                    this.hmProperty["viewCount"] = true;
                    break;
                case clscc_CourseChapterEN.con_CourseChapterReferred:
                    this.courseChapterReferred = strValue;
                    this.hmProperty["courseChapterReferred"] = true;
                    break;
                case clscc_CourseChapterEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    this.hmProperty["orderNum"] = true;
                    break;
                case clscc_CourseChapterEN.con_CreateDate:
                    this.createDate = strValue;
                    this.hmProperty["createDate"] = true;
                    break;
                case clscc_CourseChapterEN.con_EditPeople:
                    this.editPeople = strValue;
                    this.hmProperty["editPeople"] = true;
                    break;
                case clscc_CourseChapterEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clscc_CourseChapterEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_CourseChapter]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CourseChapterId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterId() { return "courseChapterId"; } //课程章节ID
        /**
        * 常量:"CourseChapterName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterName() { return "courseChapterName"; } //课程章节名称
        /**
        * 常量:"ChapterId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterId() { return "chapterId"; } //章Id
        /**
        * 常量:"SectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionId() { return "sectionId"; } //节Id
        /**
        * 常量:"ChapterName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterName() { return "chapterName"; } //章名
        /**
        * 常量:"SectionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName() { return "sectionName"; } //节名
        /**
        * 常量:"ChapterName_Sim"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterName_Sim() { return "chapterName_Sim"; } //章名简称
        /**
        * 常量:"SectionName_Sim"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName_Sim() { return "sectionName_Sim"; } //节名简称
        /**
        * 常量:"ChapterContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterContent() { return "chapterContent"; } //章节内容
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"ParentNodeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentNodeID() { return "parentNodeID"; } //父节点编号
        /**
        * 常量:"IsOpenToAllStu"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsOpenToAllStu() { return "isOpenToAllStu"; } //全校师生
        /**
        * 常量:"IsOpenToSchool"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsOpenToSchool() { return "isOpenToSchool"; } //全校师生公开
        /**
        * 常量:"IsOpenToSocial"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsOpenToSocial() { return "isOpenToSocial"; } //社会公众
        /**
        * 常量:"IsMustMenu"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsMustMenu() { return "isMustMenu"; } //是否必建栏目
        /**
        * 常量:"ThemeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ThemeName() { return "themeName"; } //主题名
        /**
        * 常量:"IsFile"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsFile() { return "isFile"; } //项目或文件夹
        /**
        * 常量:"IsUse"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsUse() { return "isUse"; } //是否使用
        /**
        * 常量:"ViewCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewCount() { return "viewCount"; } //浏览量
        /**
        * 常量:"CourseChapterReferred"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterReferred() { return "courseChapterReferred"; } //节简称
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"CreateDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateDate() { return "createDate"; } //建立日期
        /**
        * 常量:"EditPeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_EditPeople() { return "editPeople"; } //修改人
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
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
    exports.clscc_CourseChapterEN = clscc_CourseChapterEN;
    clscc_CourseChapterEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clscc_CourseChapterEN.CacheModeId = "04"; //sessionStorage
    clscc_CourseChapterEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clscc_CourseChapterEN.WhereFormat = ""; //条件格式串
    clscc_CourseChapterEN._CurrTabName = "cc_CourseChapter"; //当前表名,与该类相关的表名
    clscc_CourseChapterEN._KeyFldName = "CourseChapterId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clscc_CourseChapterEN.mintAttributeCount = 25;
    clscc_CourseChapterEN.AttributeName = ["courseChapterId", "courseChapterName", "chapterId", "sectionId", "chapterName", "sectionName", "chapterName_Sim", "sectionName_Sim", "chapterContent", "courseId", "parentNodeID", "isOpenToAllStu", "isOpenToSchool", "isOpenToSocial", "isMustMenu", "themeName", "isFile", "isUse", "viewCount", "courseChapterReferred", "orderNum", "createDate", "editPeople", "updDate", "memo"];
});
