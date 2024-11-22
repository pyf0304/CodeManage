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
    exports.clsvcc_CourseKnowledgesEN = void 0;
    /**
    * 类名:clsvcc_CourseKnowledgesEN
    * 表名:vcc_CourseKnowledges(01120141)
    * 版本:2023.02.24.1(服务器:WIN-SRV103-116)
    * 日期:2023/02/24 13:48:04
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
    * v课程知识点(vcc_CourseKnowledges)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvcc_CourseKnowledgesEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.courseKnowledgeId = ""; //知识点Id
            this.knowledgeName = ""; //知识点名称
            this.knowledgeTitle = ""; //知识点标题
            this.knowledgeContent = ""; //知识点内容
            this.courseId = ""; //课程Id
            this.courseCode = ""; //课程代码
            this.courseName = ""; //课程名称
            this.courseChapterId = ""; //课程章节ID
            this.userId = ""; //用户ID
            this.chapterId = ""; //章Id
            this.uploadDate = ""; //上传时间
            this.sectionId = ""; //节Id
            this.isShow = false; //是否启用
            this.chapterName = ""; //章名
            this.isCast = false; //是否播放
            this.sectionName = ""; //节名
            this.likeCount = 0; //资源喜欢数量
            this.chapterName_Sim = ""; //章名简称
            this.updDate = ""; //修改日期
            this.sectionName_Sim = ""; //节名简称
            this.memo = ""; //备注
            this.questionNum = 0; //题目数
            this.orderNum = 0; //序号
            this.updUser = ""; //修改人
            this.knowledgeTypeId = ""; //知识点类型Id
            this.knowledgeTypeName = ""; //知识点类型名
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
                case clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
                    return this.courseKnowledgeId;
                case clsvcc_CourseKnowledgesEN.con_KnowledgeName:
                    return this.knowledgeName;
                case clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
                    return this.knowledgeTitle;
                case clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
                    return this.knowledgeContent;
                case clsvcc_CourseKnowledgesEN.con_CourseId:
                    return this.courseId;
                case clsvcc_CourseKnowledgesEN.con_CourseCode:
                    return this.courseCode;
                case clsvcc_CourseKnowledgesEN.con_CourseName:
                    return this.courseName;
                case clsvcc_CourseKnowledgesEN.con_CourseChapterId:
                    return this.courseChapterId;
                case clsvcc_CourseKnowledgesEN.con_UserId:
                    return this.userId;
                case clsvcc_CourseKnowledgesEN.con_ChapterId:
                    return this.chapterId;
                case clsvcc_CourseKnowledgesEN.con_UploadDate:
                    return this.uploadDate;
                case clsvcc_CourseKnowledgesEN.con_SectionId:
                    return this.sectionId;
                case clsvcc_CourseKnowledgesEN.con_IsShow:
                    return this.isShow;
                case clsvcc_CourseKnowledgesEN.con_ChapterName:
                    return this.chapterName;
                case clsvcc_CourseKnowledgesEN.con_IsCast:
                    return this.isCast;
                case clsvcc_CourseKnowledgesEN.con_SectionName:
                    return this.sectionName;
                case clsvcc_CourseKnowledgesEN.con_LikeCount:
                    return this.likeCount;
                case clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
                    return this.chapterName_Sim;
                case clsvcc_CourseKnowledgesEN.con_UpdDate:
                    return this.updDate;
                case clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
                    return this.sectionName_Sim;
                case clsvcc_CourseKnowledgesEN.con_Memo:
                    return this.memo;
                case clsvcc_CourseKnowledgesEN.con_QuestionNum:
                    return this.questionNum;
                case clsvcc_CourseKnowledgesEN.con_OrderNum:
                    return this.orderNum;
                case clsvcc_CourseKnowledgesEN.con_UpdUser:
                    return this.updUser;
                case clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
                    return this.knowledgeTypeId;
                case clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
                    return this.knowledgeTypeName;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vcc_CourseKnowledges]中不存在！`;
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
                case clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
                    this.courseKnowledgeId = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_KnowledgeName:
                    this.knowledgeName = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
                    this.knowledgeTitle = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
                    this.knowledgeContent = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_CourseId:
                    this.courseId = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_CourseCode:
                    this.courseCode = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_CourseName:
                    this.courseName = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_CourseChapterId:
                    this.courseChapterId = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_ChapterId:
                    this.chapterId = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_UploadDate:
                    this.uploadDate = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_SectionId:
                    this.sectionId = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_IsShow:
                    this.isShow = Boolean(strValue);
                    break;
                case clsvcc_CourseKnowledgesEN.con_ChapterName:
                    this.chapterName = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_IsCast:
                    this.isCast = Boolean(strValue);
                    break;
                case clsvcc_CourseKnowledgesEN.con_SectionName:
                    this.sectionName = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_LikeCount:
                    this.likeCount = Number(strValue);
                    break;
                case clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
                    this.chapterName_Sim = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
                    this.sectionName_Sim = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_QuestionNum:
                    this.questionNum = Number(strValue);
                    break;
                case clsvcc_CourseKnowledgesEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvcc_CourseKnowledgesEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
                    this.knowledgeTypeId = strValue;
                    break;
                case clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
                    this.knowledgeTypeName = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vcc_CourseKnowledges]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"CourseKnowledgeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseKnowledgeId() { return "courseKnowledgeId"; } //知识点Id
        /**
        * 常量:"KnowledgeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeName() { return "knowledgeName"; } //知识点名称
        /**
        * 常量:"KnowledgeTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeTitle() { return "knowledgeTitle"; } //知识点标题
        /**
        * 常量:"KnowledgeContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeContent() { return "knowledgeContent"; } //知识点内容
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
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
        /**
        * 常量:"CourseChapterId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterId() { return "courseChapterId"; } //课程章节ID
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"ChapterId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterId() { return "chapterId"; } //章Id
        /**
        * 常量:"UploadDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UploadDate() { return "uploadDate"; } //上传时间
        /**
        * 常量:"SectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionId() { return "sectionId"; } //节Id
        /**
        * 常量:"IsShow"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsShow() { return "isShow"; } //是否启用
        /**
        * 常量:"ChapterName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterName() { return "chapterName"; } //章名
        /**
        * 常量:"IsCast"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCast() { return "isCast"; } //是否播放
        /**
        * 常量:"SectionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName() { return "sectionName"; } //节名
        /**
        * 常量:"LikeCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LikeCount() { return "likeCount"; } //资源喜欢数量
        /**
        * 常量:"ChapterName_Sim"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterName_Sim() { return "chapterName_Sim"; } //章名简称
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"SectionName_Sim"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName_Sim() { return "sectionName_Sim"; } //节名简称
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
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"KnowledgeTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeTypeId() { return "knowledgeTypeId"; } //知识点类型Id
        /**
        * 常量:"KnowledgeTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeTypeName() { return "knowledgeTypeName"; } //知识点类型名
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
    exports.clsvcc_CourseKnowledgesEN = clsvcc_CourseKnowledgesEN;
    clsvcc_CourseKnowledgesEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvcc_CourseKnowledgesEN.CacheModeId = "02"; //客户端缓存
    clsvcc_CourseKnowledgesEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvcc_CourseKnowledgesEN.WhereFormat = ""; //条件格式串
    clsvcc_CourseKnowledgesEN._CurrTabName = "vcc_CourseKnowledges"; //当前表名,与该类相关的表名
    clsvcc_CourseKnowledgesEN._KeyFldName = "CourseKnowledgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvcc_CourseKnowledgesEN.mintAttributeCount = 26;
    clsvcc_CourseKnowledgesEN.AttributeName = ["courseKnowledgeId", "knowledgeName", "knowledgeTitle", "knowledgeContent", "courseId", "courseCode", "courseName", "courseChapterId", "userId", "chapterId", "uploadDate", "sectionId", "isShow", "chapterName", "isCast", "sectionName", "likeCount", "chapterName_Sim", "updDate", "sectionName_Sim", "memo", "questionNum", "orderNum", "updUser", "knowledgeTypeId", "knowledgeTypeName"];
});
