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
    exports.clscc_CourseExamPaperEN = void 0;
    /**
    * 类名:clscc_CourseExamPaperEN
    * 表名:cc_CourseExamPaper(01120071)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/15 23:43:44
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:知识点相关(Knowledges)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 考卷(cc_CourseExamPaper)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clscc_CourseExamPaperEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrCourseExamPaperId = ""; //考卷流水号
            this.mstrCourseId = ""; //课程Id
            this.mstrExamPaperName = ""; //考卷名称
            this.mintPaperIndex = 0; //试卷序号
            this.mstrExamPaperTypeId = ""; //试卷类型Id
            this.mbolIsShow = false; //是否启用
            this.mdblTotalScore = 0; //总得分
            this.mintViewCount = 0; //浏览量
            this.mintDoneNumber = 0; //已做人数
            this.mintPaperTime = 0; //考试时间（分钟）
            this.mintDownloadNumber = 0; //下载数目
            this.mintCollectionCount = 0; //收藏数量
            this.mlngLikeCount = 0; //资源喜欢数量
            this.mstrid_XzMajor = ""; //专业流水号
            this.mstrPaperDispModeId = ""; //试卷显示模式Id
            this.mstrExamCreateTime = ""; //考卷建立时间
            this.mstrCreateUserID = ""; //建立用户ID
            this.mbolIsOpenToAllStu = false; //全校师生
            this.mbolIsOpenToSchool = false; //全校师生公开
            this.mbolIsOpenToSocial = false; //社会公众
            this.mstrCourseChapterId = ""; //课程章节ID
            this.mbolIsAutoGeneQuestion = false; //是否自动生成题目
            this.mbolIsCanMultiDo = false; //是否可以做多次
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.courseExamPaperId = ""; //考卷流水号
            this.courseId = ""; //课程Id
            this.examPaperName = ""; //考卷名称
            this.paperIndex = 0; //试卷序号
            this.examPaperTypeId = ""; //试卷类型Id
            this.isShow = false; //是否启用
            this.totalScore = 0; //总得分
            this.viewCount = 0; //浏览量
            this.doneNumber = 0; //已做人数
            this.paperTime = 0; //考试时间（分钟）
            this.downloadNumber = 0; //下载数目
            this.collectionCount = 0; //收藏数量
            this.likeCount = 0; //资源喜欢数量
            this.id_XzMajor = ""; //专业流水号
            this.paperDispModeId = ""; //试卷显示模式Id
            this.examCreateTime = ""; //考卷建立时间
            this.createUserID = ""; //建立用户ID
            this.isOpenToAllStu = false; //全校师生
            this.isOpenToSchool = false; //全校师生公开
            this.isOpenToSocial = false; //社会公众
            this.courseChapterId = ""; //课程章节ID
            this.isAutoGeneQuestion = false; //是否自动生成题目
            this.isCanMultiDo = false; //是否可以做多次
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.memo = ""; //备注
        }
        /**
         * 考卷流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCourseExamPaperId(value) {
            if (value != undefined) {
                this.courseExamPaperId = value;
                this.hmProperty["courseExamPaperId"] = true;
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
         * 考卷名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExamPaperName(value) {
            if (value != undefined) {
                this.examPaperName = value;
                this.hmProperty["examPaperName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 试卷序号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperIndex(value) {
            if (value != undefined) {
                this.paperIndex = value;
                this.hmProperty["paperIndex"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 试卷类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExamPaperTypeId(value) {
            if (value != undefined) {
                this.examPaperTypeId = value;
                this.hmProperty["examPaperTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsShow(value) {
            if (value != undefined) {
                this.isShow = value;
                this.hmProperty["isShow"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 总得分(说明:;字段类型:decimal;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTotalScore(value) {
            if (value != undefined) {
                this.totalScore = value;
                this.hmProperty["totalScore"] = true;
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
         * 已做人数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDoneNumber(value) {
            if (value != undefined) {
                this.doneNumber = value;
                this.hmProperty["doneNumber"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 考试时间（分钟）(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperTime(value) {
            if (value != undefined) {
                this.paperTime = value;
                this.hmProperty["paperTime"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 下载数目(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDownloadNumber(value) {
            if (value != undefined) {
                this.downloadNumber = value;
                this.hmProperty["downloadNumber"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 收藏数量(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCollectionCount(value) {
            if (value != undefined) {
                this.collectionCount = value;
                this.hmProperty["collectionCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 资源喜欢数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLikeCount(value) {
            if (value != undefined) {
                this.likeCount = value;
                this.hmProperty["likeCount"] = true;
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
         * 试卷显示模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperDispModeId(value) {
            if (value != undefined) {
                this.paperDispModeId = value;
                this.hmProperty["paperDispModeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 考卷建立时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExamCreateTime(value) {
            if (value != undefined) {
                this.examCreateTime = value;
                this.hmProperty["examCreateTime"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 建立用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCreateUserID(value) {
            if (value != undefined) {
                this.createUserID = value;
                this.hmProperty["createUserID"] = true;
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
         * 是否自动生成题目(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsAutoGeneQuestion(value) {
            if (value != undefined) {
                this.isAutoGeneQuestion = value;
                this.hmProperty["isAutoGeneQuestion"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否可以做多次(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsCanMultiDo(value) {
            if (value != undefined) {
                this.isCanMultiDo = value;
                this.hmProperty["isCanMultiDo"] = true;
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
                case clscc_CourseExamPaperEN.con_CourseExamPaperId:
                    return this.courseExamPaperId;
                case clscc_CourseExamPaperEN.con_CourseId:
                    return this.courseId;
                case clscc_CourseExamPaperEN.con_ExamPaperName:
                    return this.examPaperName;
                case clscc_CourseExamPaperEN.con_PaperIndex:
                    return this.paperIndex;
                case clscc_CourseExamPaperEN.con_ExamPaperTypeId:
                    return this.examPaperTypeId;
                case clscc_CourseExamPaperEN.con_IsShow:
                    return this.isShow;
                case clscc_CourseExamPaperEN.con_TotalScore:
                    return this.totalScore;
                case clscc_CourseExamPaperEN.con_ViewCount:
                    return this.viewCount;
                case clscc_CourseExamPaperEN.con_DoneNumber:
                    return this.doneNumber;
                case clscc_CourseExamPaperEN.con_PaperTime:
                    return this.paperTime;
                case clscc_CourseExamPaperEN.con_DownloadNumber:
                    return this.downloadNumber;
                case clscc_CourseExamPaperEN.con_CollectionCount:
                    return this.collectionCount;
                case clscc_CourseExamPaperEN.con_LikeCount:
                    return this.likeCount;
                case clscc_CourseExamPaperEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clscc_CourseExamPaperEN.con_PaperDispModeId:
                    return this.paperDispModeId;
                case clscc_CourseExamPaperEN.con_ExamCreateTime:
                    return this.examCreateTime;
                case clscc_CourseExamPaperEN.con_CreateUserID:
                    return this.createUserID;
                case clscc_CourseExamPaperEN.con_IsOpenToAllStu:
                    return this.isOpenToAllStu;
                case clscc_CourseExamPaperEN.con_IsOpenToSchool:
                    return this.isOpenToSchool;
                case clscc_CourseExamPaperEN.con_IsOpenToSocial:
                    return this.isOpenToSocial;
                case clscc_CourseExamPaperEN.con_CourseChapterId:
                    return this.courseChapterId;
                case clscc_CourseExamPaperEN.con_IsAutoGeneQuestion:
                    return this.isAutoGeneQuestion;
                case clscc_CourseExamPaperEN.con_IsCanMultiDo:
                    return this.isCanMultiDo;
                case clscc_CourseExamPaperEN.con_UpdDate:
                    return this.updDate;
                case clscc_CourseExamPaperEN.con_UpdUserId:
                    return this.updUserId;
                case clscc_CourseExamPaperEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_CourseExamPaper]中不存在！`;
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
                case clscc_CourseExamPaperEN.con_CourseExamPaperId:
                    this.courseExamPaperId = strValue;
                    this.hmProperty["courseExamPaperId"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_CourseId:
                    this.courseId = strValue;
                    this.hmProperty["courseId"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_ExamPaperName:
                    this.examPaperName = strValue;
                    this.hmProperty["examPaperName"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_PaperIndex:
                    this.paperIndex = Number(strValue);
                    this.hmProperty["paperIndex"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_ExamPaperTypeId:
                    this.examPaperTypeId = strValue;
                    this.hmProperty["examPaperTypeId"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_IsShow:
                    this.isShow = Boolean(strValue);
                    this.hmProperty["isShow"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_TotalScore:
                    this.totalScore = Number(strValue);
                    this.hmProperty["totalScore"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_ViewCount:
                    this.viewCount = Number(strValue);
                    this.hmProperty["viewCount"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_DoneNumber:
                    this.doneNumber = Number(strValue);
                    this.hmProperty["doneNumber"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_PaperTime:
                    this.paperTime = Number(strValue);
                    this.hmProperty["paperTime"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_DownloadNumber:
                    this.downloadNumber = Number(strValue);
                    this.hmProperty["downloadNumber"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_CollectionCount:
                    this.collectionCount = Number(strValue);
                    this.hmProperty["collectionCount"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_LikeCount:
                    this.likeCount = Number(strValue);
                    this.hmProperty["likeCount"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    this.hmProperty["id_XzMajor"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_PaperDispModeId:
                    this.paperDispModeId = strValue;
                    this.hmProperty["paperDispModeId"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_ExamCreateTime:
                    this.examCreateTime = strValue;
                    this.hmProperty["examCreateTime"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_CreateUserID:
                    this.createUserID = strValue;
                    this.hmProperty["createUserID"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_IsOpenToAllStu:
                    this.isOpenToAllStu = Boolean(strValue);
                    this.hmProperty["isOpenToAllStu"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_IsOpenToSchool:
                    this.isOpenToSchool = Boolean(strValue);
                    this.hmProperty["isOpenToSchool"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_IsOpenToSocial:
                    this.isOpenToSocial = Boolean(strValue);
                    this.hmProperty["isOpenToSocial"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_CourseChapterId:
                    this.courseChapterId = strValue;
                    this.hmProperty["courseChapterId"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_IsAutoGeneQuestion:
                    this.isAutoGeneQuestion = Boolean(strValue);
                    this.hmProperty["isAutoGeneQuestion"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_IsCanMultiDo:
                    this.isCanMultiDo = Boolean(strValue);
                    this.hmProperty["isCanMultiDo"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clscc_CourseExamPaperEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_CourseExamPaper]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CourseExamPaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseExamPaperId() { return "courseExamPaperId"; } //考卷流水号
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"ExamPaperName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExamPaperName() { return "examPaperName"; } //考卷名称
        /**
        * 常量:"PaperIndex"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperIndex() { return "paperIndex"; } //试卷序号
        /**
        * 常量:"ExamPaperTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExamPaperTypeId() { return "examPaperTypeId"; } //试卷类型Id
        /**
        * 常量:"IsShow"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsShow() { return "isShow"; } //是否启用
        /**
        * 常量:"TotalScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TotalScore() { return "totalScore"; } //总得分
        /**
        * 常量:"ViewCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewCount() { return "viewCount"; } //浏览量
        /**
        * 常量:"DoneNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DoneNumber() { return "doneNumber"; } //已做人数
        /**
        * 常量:"PaperTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTime() { return "paperTime"; } //考试时间（分钟）
        /**
        * 常量:"DownloadNumber"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DownloadNumber() { return "downloadNumber"; } //下载数目
        /**
        * 常量:"CollectionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CollectionCount() { return "collectionCount"; } //收藏数量
        /**
        * 常量:"LikeCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LikeCount() { return "likeCount"; } //资源喜欢数量
        /**
        * 常量:"id_XzMajor"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_XzMajor() { return "id_XzMajor"; } //专业流水号
        /**
        * 常量:"PaperDispModeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperDispModeId() { return "paperDispModeId"; } //试卷显示模式Id
        /**
        * 常量:"ExamCreateTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExamCreateTime() { return "examCreateTime"; } //考卷建立时间
        /**
        * 常量:"CreateUserID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateUserID() { return "createUserID"; } //建立用户ID
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
        * 常量:"CourseChapterId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterId() { return "courseChapterId"; } //课程章节ID
        /**
        * 常量:"IsAutoGeneQuestion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsAutoGeneQuestion() { return "isAutoGeneQuestion"; } //是否自动生成题目
        /**
        * 常量:"IsCanMultiDo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCanMultiDo() { return "isCanMultiDo"; } //是否可以做多次
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
    exports.clscc_CourseExamPaperEN = clscc_CourseExamPaperEN;
    clscc_CourseExamPaperEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clscc_CourseExamPaperEN.CacheModeId = "02"; //客户端缓存
    clscc_CourseExamPaperEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clscc_CourseExamPaperEN.WhereFormat = ""; //条件格式串
    clscc_CourseExamPaperEN._CurrTabName = "cc_CourseExamPaper"; //当前表名,与该类相关的表名
    clscc_CourseExamPaperEN._KeyFldName = "CourseExamPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clscc_CourseExamPaperEN.mintAttributeCount = 26;
    clscc_CourseExamPaperEN.AttributeName = ["courseExamPaperId", "courseId", "examPaperName", "paperIndex", "examPaperTypeId", "isShow", "totalScore", "viewCount", "doneNumber", "paperTime", "downloadNumber", "collectionCount", "likeCount", "id_XzMajor", "paperDispModeId", "examCreateTime", "createUserID", "isOpenToAllStu", "isOpenToSchool", "isOpenToSocial", "courseChapterId", "isAutoGeneQuestion", "isCanMultiDo", "updDate", "updUserId", "memo"];
});
