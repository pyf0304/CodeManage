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
    exports.clsvcc_CourseExamPaperEN = void 0;
    /**
    * 类名:clsvcc_CourseExamPaperEN
    * 表名:vcc_CourseExamPaper(01120098)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:24
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
    * v考卷(vcc_CourseExamPaper)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvcc_CourseExamPaperEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.courseExamPaperId = ""; //考卷流水号
            this.courseId = ""; //课程Id
            this.courseName = ""; //课程名称
            this.examPaperName = ""; //考卷名称
            this.paperIndex = 0; //试卷序号
            this.examPaperTypeId = ""; //试卷类型Id
            this.examPaperTypeName = ""; //试卷类型名称
            this.isShow = false; //是否启用
            this.totalScore = 0; //总得分
            this.viewCount = 0; //浏览量
            this.doneNumber = 0; //已做人数
            this.paperTime = 0; //考试时间（分钟）
            this.downloadNumber = 0; //下载数目
            this.collectionCount = 0; //收藏数量
            this.likeCount = 0; //资源喜欢数量
            this.id_XzMajor = ""; //专业流水号
            this.majorName = ""; //专业名称
            this.paperDispModeId = ""; //试卷显示模式Id
            this.paperDispModeName = ""; //试卷显示模式名称
            this.examCreateTime = ""; //考卷建立时间
            this.createUserID = ""; //建立用户ID
            this.userName = ""; //用户名
            this.isOpenToAllStu = false; //全校师生
            this.isOpenToSchool = false; //全校师生公开
            this.isOpenToSocial = false; //社会公众
            this.courseChapterId = ""; //课程章节ID
            this.courseChapterName = ""; //课程章节名称
            this.chapterId = ""; //章Id
            this.sectionId = ""; //节Id
            this.chapterName = ""; //章名
            this.sectionName = ""; //节名
            this.chapterName_Sim = ""; //章名简称
            this.sectionName_Sim = ""; //节名简称
            this.isAutoGeneQuestion = false; //是否自动生成题目
            this.isCanMultiDo = false; //是否可以做多次
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.memo = ""; //备注
            this.questionNum = 0; //题目数
            this.bigTopicNum = 0; //大标题数
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
                case clsvcc_CourseExamPaperEN.con_CourseExamPaperId:
                    return this.courseExamPaperId;
                case clsvcc_CourseExamPaperEN.con_CourseId:
                    return this.courseId;
                case clsvcc_CourseExamPaperEN.con_CourseName:
                    return this.courseName;
                case clsvcc_CourseExamPaperEN.con_ExamPaperName:
                    return this.examPaperName;
                case clsvcc_CourseExamPaperEN.con_PaperIndex:
                    return this.paperIndex;
                case clsvcc_CourseExamPaperEN.con_ExamPaperTypeId:
                    return this.examPaperTypeId;
                case clsvcc_CourseExamPaperEN.con_ExamPaperTypeName:
                    return this.examPaperTypeName;
                case clsvcc_CourseExamPaperEN.con_IsShow:
                    return this.isShow;
                case clsvcc_CourseExamPaperEN.con_TotalScore:
                    return this.totalScore;
                case clsvcc_CourseExamPaperEN.con_ViewCount:
                    return this.viewCount;
                case clsvcc_CourseExamPaperEN.con_DoneNumber:
                    return this.doneNumber;
                case clsvcc_CourseExamPaperEN.con_PaperTime:
                    return this.paperTime;
                case clsvcc_CourseExamPaperEN.con_DownloadNumber:
                    return this.downloadNumber;
                case clsvcc_CourseExamPaperEN.con_CollectionCount:
                    return this.collectionCount;
                case clsvcc_CourseExamPaperEN.con_LikeCount:
                    return this.likeCount;
                case clsvcc_CourseExamPaperEN.con_id_XzMajor:
                    return this.id_XzMajor;
                case clsvcc_CourseExamPaperEN.con_MajorName:
                    return this.majorName;
                case clsvcc_CourseExamPaperEN.con_PaperDispModeId:
                    return this.paperDispModeId;
                case clsvcc_CourseExamPaperEN.con_PaperDispModeName:
                    return this.paperDispModeName;
                case clsvcc_CourseExamPaperEN.con_ExamCreateTime:
                    return this.examCreateTime;
                case clsvcc_CourseExamPaperEN.con_CreateUserID:
                    return this.createUserID;
                case clsvcc_CourseExamPaperEN.con_UserName:
                    return this.userName;
                case clsvcc_CourseExamPaperEN.con_IsOpenToAllStu:
                    return this.isOpenToAllStu;
                case clsvcc_CourseExamPaperEN.con_IsOpenToSchool:
                    return this.isOpenToSchool;
                case clsvcc_CourseExamPaperEN.con_IsOpenToSocial:
                    return this.isOpenToSocial;
                case clsvcc_CourseExamPaperEN.con_CourseChapterId:
                    return this.courseChapterId;
                case clsvcc_CourseExamPaperEN.con_CourseChapterName:
                    return this.courseChapterName;
                case clsvcc_CourseExamPaperEN.con_ChapterId:
                    return this.chapterId;
                case clsvcc_CourseExamPaperEN.con_SectionId:
                    return this.sectionId;
                case clsvcc_CourseExamPaperEN.con_ChapterName:
                    return this.chapterName;
                case clsvcc_CourseExamPaperEN.con_SectionName:
                    return this.sectionName;
                case clsvcc_CourseExamPaperEN.con_ChapterName_Sim:
                    return this.chapterName_Sim;
                case clsvcc_CourseExamPaperEN.con_SectionName_Sim:
                    return this.sectionName_Sim;
                case clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion:
                    return this.isAutoGeneQuestion;
                case clsvcc_CourseExamPaperEN.con_IsCanMultiDo:
                    return this.isCanMultiDo;
                case clsvcc_CourseExamPaperEN.con_UpdDate:
                    return this.updDate;
                case clsvcc_CourseExamPaperEN.con_UpdUserId:
                    return this.updUserId;
                case clsvcc_CourseExamPaperEN.con_Memo:
                    return this.memo;
                case clsvcc_CourseExamPaperEN.con_QuestionNum:
                    return this.questionNum;
                case clsvcc_CourseExamPaperEN.con_BigTopicNum:
                    return this.bigTopicNum;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vcc_CourseExamPaper]中不存在！`;
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
                case clsvcc_CourseExamPaperEN.con_CourseExamPaperId:
                    this.courseExamPaperId = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_CourseId:
                    this.courseId = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_CourseName:
                    this.courseName = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_ExamPaperName:
                    this.examPaperName = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_PaperIndex:
                    this.paperIndex = Number(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_ExamPaperTypeId:
                    this.examPaperTypeId = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_ExamPaperTypeName:
                    this.examPaperTypeName = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_IsShow:
                    this.isShow = Boolean(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_TotalScore:
                    this.totalScore = Number(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_ViewCount:
                    this.viewCount = Number(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_DoneNumber:
                    this.doneNumber = Number(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_PaperTime:
                    this.paperTime = Number(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_DownloadNumber:
                    this.downloadNumber = Number(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_CollectionCount:
                    this.collectionCount = Number(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_LikeCount:
                    this.likeCount = Number(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_id_XzMajor:
                    this.id_XzMajor = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_MajorName:
                    this.majorName = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_PaperDispModeId:
                    this.paperDispModeId = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_PaperDispModeName:
                    this.paperDispModeName = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_ExamCreateTime:
                    this.examCreateTime = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_CreateUserID:
                    this.createUserID = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_IsOpenToAllStu:
                    this.isOpenToAllStu = Boolean(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_IsOpenToSchool:
                    this.isOpenToSchool = Boolean(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_IsOpenToSocial:
                    this.isOpenToSocial = Boolean(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_CourseChapterId:
                    this.courseChapterId = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_CourseChapterName:
                    this.courseChapterName = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_ChapterId:
                    this.chapterId = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_SectionId:
                    this.sectionId = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_ChapterName:
                    this.chapterName = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_SectionName:
                    this.sectionName = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_ChapterName_Sim:
                    this.chapterName_Sim = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_SectionName_Sim:
                    this.sectionName_Sim = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion:
                    this.isAutoGeneQuestion = Boolean(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_IsCanMultiDo:
                    this.isCanMultiDo = Boolean(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_UpdUserId:
                    this.updUserId = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvcc_CourseExamPaperEN.con_QuestionNum:
                    this.questionNum = Number(strValue);
                    break;
                case clsvcc_CourseExamPaperEN.con_BigTopicNum:
                    this.bigTopicNum = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vcc_CourseExamPaper]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
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
        * 常量:"ExamPaperTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExamPaperTypeName() { return "examPaperTypeName"; } //试卷类型名称
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
        * 常量:"MajorName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MajorName() { return "majorName"; } //专业名称
        /**
        * 常量:"PaperDispModeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperDispModeId() { return "paperDispModeId"; } //试卷显示模式Id
        /**
        * 常量:"PaperDispModeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperDispModeName() { return "paperDispModeName"; } //试卷显示模式名称
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
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
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
        * 常量:"QuestionNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionNum() { return "questionNum"; } //题目数
        /**
        * 常量:"BigTopicNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_BigTopicNum() { return "bigTopicNum"; } //大标题数
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
    exports.clsvcc_CourseExamPaperEN = clsvcc_CourseExamPaperEN;
    clsvcc_CourseExamPaperEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvcc_CourseExamPaperEN.CacheModeId = "02"; //客户端缓存
    clsvcc_CourseExamPaperEN._CurrTabName = "vcc_CourseExamPaper"; //当前表名,与该类相关的表名
    clsvcc_CourseExamPaperEN._KeyFldName = "CourseExamPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvcc_CourseExamPaperEN.mintAttributeCount = 40;
    clsvcc_CourseExamPaperEN.AttributeName = ["courseExamPaperId", "courseId", "courseName", "examPaperName", "paperIndex", "examPaperTypeId", "examPaperTypeName", "isShow", "totalScore", "viewCount", "doneNumber", "paperTime", "downloadNumber", "collectionCount", "likeCount", "id_XzMajor", "majorName", "paperDispModeId", "paperDispModeName", "examCreateTime", "createUserID", "userName", "isOpenToAllStu", "isOpenToSchool", "isOpenToSocial", "courseChapterId", "courseChapterName", "chapterId", "sectionId", "chapterName", "sectionName", "chapterName_Sim", "sectionName_Sim", "isAutoGeneQuestion", "isCanMultiDo", "updDate", "updUserId", "memo", "questionNum", "bigTopicNum"];
});
