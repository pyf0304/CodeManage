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
    exports.clsQuestionnaireEN = void 0;
    /**
    * 类名:clsQuestionnaireEN
    * 表名:Questionnaire(01120001)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 18:31:32
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:基本信息(BaseInfo)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 题目(Questionnaire)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsQuestionnaireEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrQuestionID = ""; //题目ID
            this.mintQuestionIndex = 0; //题目序号
            this.mstrQuestionName = ""; //题目名称
            this.mstrQuestionContent = ""; //题目内容
            this.mstrQuestionMemo = ""; //题目说明
            this.mstrQuestionNo = ""; //题目编号
            this.mstrParentQuestionId = ""; //父题目Id
            this.mstrExamAnswer = ""; //题目答案
            this.mstrCourseId = ""; //课程Id
            this.mintLevelNo = 0; //学习关号2
            this.mstrCourseChapterId = ""; //课程章节ID
            this.mstrQuestionTypeId = ""; //题目类型Id
            this.mstrQuestionTypeId4Course = ""; //题目类型Id4课程
            this.mstrAnswerTypeId = ""; //答案类型ID
            this.mstrGridTitle = ""; //表格标题
            this.mstrAnswerModeId = ""; //答案模式Id
            this.mbolIsHaveAdditionalMemo = false; //是否有附加说明
            this.mfltQuestionScore = 0.0; //题目得分
            this.mstrDefaultValue = ""; //缺省值
            this.mstrDefaultSelectItem = ""; //默认选项
            this.mbolIsShow = false; //是否启用
            this.mbolIsCast = false; //是否播放
            this.mlngLikeCount = 0; //资源喜欢数量
            this.mlngAnswerAttLimitSize = 0; //回答附件限制大小
            this.mstrLimitedResourceType = ""; //限制资源类型
            this.mbolIsEffective = false; //是否有效
            this.mbolIsCanInPaper = false; //是否可在Paper
            this.mstrExamGradeId = ""; //题库等级ID
            this.mstrTextDirectId = ""; //文本方向ID
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            this.mstrQuestionCode = ""; //html代码
            this.mstrDifficultyLevelId = ""; //难度等级Id
            this.mstrSectionTypeId = ""; //节点类型Id
            this.mstrKnowledgeGraphId = ""; //知识点图Id
            this.mbolFirstIndent = false; //首行缩进
            this.mstrQuestionName_Add = ""; //题目补充
            this.mstrCodeTab = ""; //代码表
            this.mstrCodeTab_Code = ""; //CodeTab_Code
            this.mstrCodeTab_Condition = ""; //代码表_条件
            this.mstrCodeTab_Name = ""; //CodeTab_Name
            this.mintFillInTextHeight = 0; //填空框高度
            this.mintFillInTextWidth = 0; //填空框宽度
            this.mbolIsMulti4FillInText = false; //是否填空框多行
            this.mintCheckBoxLimitCount = 0; //复选框限制数
            this.mbolIsJs = false; //是否是JS
            this.mintMemoTextWidth = 0; //备注框宽度
            this.mstrRelaEvent = ""; //相关事件
            this.mbolIsTest = false; //是否测试
            this.mstrLevelModeTypeId = ""; //模式Id
            this.mbolIsRandom = false; //是否随机
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.questionID = ""; //题目ID
            this.questionIndex = 0; //题目序号
            this.questionName = ""; //题目名称
            this.questionContent = ""; //题目内容
            this.questionMemo = ""; //题目说明
            this.questionNo = ""; //题目编号
            this.parentQuestionId = ""; //父题目Id
            this.examAnswer = ""; //题目答案
            this.courseId = ""; //课程Id
            this.levelNo = 0; //学习关号2
            this.courseChapterId = ""; //课程章节ID
            this.questionTypeId = ""; //题目类型Id
            this.questionTypeId4Course = ""; //题目类型Id4课程
            this.answerTypeId = ""; //答案类型ID
            this.gridTitle = ""; //表格标题
            this.answerModeId = ""; //答案模式Id
            this.isHaveAdditionalMemo = false; //是否有附加说明
            this.questionScore = 0.0; //题目得分
            this.defaultValue = ""; //缺省值
            this.defaultSelectItem = ""; //默认选项
            this.isShow = false; //是否启用
            this.isCast = false; //是否播放
            this.likeCount = 0; //资源喜欢数量
            this.answerAttLimitSize = 0; //回答附件限制大小
            this.limitedResourceType = ""; //限制资源类型
            this.isEffective = false; //是否有效
            this.isCanInPaper = false; //是否可在Paper
            this.examGradeId = ""; //题库等级ID
            this.textDirectId = ""; //文本方向ID
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.questionCode = ""; //html代码
            this.difficultyLevelId = ""; //难度等级Id
            this.sectionTypeId = ""; //节点类型Id
            this.knowledgeGraphId = ""; //知识点图Id
            this.firstIndent = false; //首行缩进
            this.questionName_Add = ""; //题目补充
            this.codeTab = ""; //代码表
            this.codeTab_Code = ""; //CodeTab_Code
            this.codeTab_Condition = ""; //代码表_条件
            this.codeTab_Name = ""; //CodeTab_Name
            this.fillInTextHeight = 0; //填空框高度
            this.fillInTextWidth = 0; //填空框宽度
            this.isMulti4FillInText = false; //是否填空框多行
            this.checkBoxLimitCount = 0; //复选框限制数
            this.isJs = false; //是否是JS
            this.memoTextWidth = 0; //备注框宽度
            this.relaEvent = ""; //相关事件
            this.isTest = false; //是否测试
            this.levelModeTypeId = ""; //模式Id
            this.isRandom = false; //是否随机
        }
        /**
         * 题目ID(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionID(value) {
            if (value != undefined) {
                this.questionID = value;
                this.hmProperty["questionID"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目序号(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionIndex(value) {
            if (value != undefined) {
                this.questionIndex = value;
                this.hmProperty["questionIndex"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionName(value) {
            if (value != undefined) {
                this.questionName = value;
                this.hmProperty["questionName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目内容(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionContent(value) {
            if (value != undefined) {
                this.questionContent = value;
                this.hmProperty["questionContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionMemo(value) {
            if (value != undefined) {
                this.questionMemo = value;
                this.hmProperty["questionMemo"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionNo(value) {
            if (value != undefined) {
                this.questionNo = value;
                this.hmProperty["questionNo"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 父题目Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParentQuestionId(value) {
            if (value != undefined) {
                this.parentQuestionId = value;
                this.hmProperty["parentQuestionId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目答案(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExamAnswer(value) {
            if (value != undefined) {
                this.examAnswer = value;
                this.hmProperty["examAnswer"] = true;
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
         * 学习关号2(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLevelNo(value) {
            if (value != undefined) {
                this.levelNo = value;
                this.hmProperty["levelNo"] = true;
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
         * 题目类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionTypeId(value) {
            if (value != undefined) {
                this.questionTypeId = value;
                this.hmProperty["questionTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目类型Id4课程(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionTypeId4Course(value) {
            if (value != undefined) {
                this.questionTypeId4Course = value;
                this.hmProperty["questionTypeId4Course"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 答案类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerTypeId(value) {
            if (value != undefined) {
                this.answerTypeId = value;
                this.hmProperty["answerTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 表格标题(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetGridTitle(value) {
            if (value != undefined) {
                this.gridTitle = value;
                this.hmProperty["gridTitle"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 答案模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerModeId(value) {
            if (value != undefined) {
                this.answerModeId = value;
                this.hmProperty["answerModeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否有附加说明(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsHaveAdditionalMemo(value) {
            if (value != undefined) {
                this.isHaveAdditionalMemo = value;
                this.hmProperty["isHaveAdditionalMemo"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目得分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionScore(value) {
            if (value != undefined) {
                this.questionScore = value;
                this.hmProperty["questionScore"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDefaultValue(value) {
            if (value != undefined) {
                this.defaultValue = value;
                this.hmProperty["defaultValue"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 默认选项(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDefaultSelectItem(value) {
            if (value != undefined) {
                this.defaultSelectItem = value;
                this.hmProperty["defaultSelectItem"] = true;
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
         * 是否播放(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsCast(value) {
            if (value != undefined) {
                this.isCast = value;
                this.hmProperty["isCast"] = true;
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
         * 回答附件限制大小(说明:;字段类型:bigint;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerAttLimitSize(value) {
            if (value != undefined) {
                this.answerAttLimitSize = value;
                this.hmProperty["answerAttLimitSize"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 限制资源类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLimitedResourceType(value) {
            if (value != undefined) {
                this.limitedResourceType = value;
                this.hmProperty["limitedResourceType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否有效(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsEffective(value) {
            if (value != undefined) {
                this.isEffective = value;
                this.hmProperty["isEffective"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否可在Paper(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsCanInPaper(value) {
            if (value != undefined) {
                this.isCanInPaper = value;
                this.hmProperty["isCanInPaper"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题库等级ID(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetExamGradeId(value) {
            if (value != undefined) {
                this.examGradeId = value;
                this.hmProperty["examGradeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 文本方向ID(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTextDirectId(value) {
            if (value != undefined) {
                this.textDirectId = value;
                this.hmProperty["textDirectId"] = true;
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
         * html代码(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionCode(value) {
            if (value != undefined) {
                this.questionCode = value;
                this.hmProperty["questionCode"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 难度等级Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDifficultyLevelId(value) {
            if (value != undefined) {
                this.difficultyLevelId = value;
                this.hmProperty["difficultyLevelId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 节点类型Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSectionTypeId(value) {
            if (value != undefined) {
                this.sectionTypeId = value;
                this.hmProperty["sectionTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 知识点图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetKnowledgeGraphId(value) {
            if (value != undefined) {
                this.knowledgeGraphId = value;
                this.hmProperty["knowledgeGraphId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 首行缩进(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetFirstIndent(value) {
            if (value != undefined) {
                this.firstIndent = value;
                this.hmProperty["firstIndent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 题目补充(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionName_Add(value) {
            if (value != undefined) {
                this.questionName_Add = value;
                this.hmProperty["questionName_Add"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 代码表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCodeTab(value) {
            if (value != undefined) {
                this.codeTab = value;
                this.hmProperty["codeTab"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * CodeTab_Code(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCodeTab_Code(value) {
            if (value != undefined) {
                this.codeTab_Code = value;
                this.hmProperty["codeTab_Code"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 代码表_条件(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCodeTab_Condition(value) {
            if (value != undefined) {
                this.codeTab_Condition = value;
                this.hmProperty["codeTab_Condition"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * CodeTab_Name(说明:;字段类型:varchar;字段长度:50;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCodeTab_Name(value) {
            if (value != undefined) {
                this.codeTab_Name = value;
                this.hmProperty["codeTab_Name"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 填空框高度(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetFillInTextHeight(value) {
            if (value != undefined) {
                this.fillInTextHeight = value;
                this.hmProperty["fillInTextHeight"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 填空框宽度(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetFillInTextWidth(value) {
            if (value != undefined) {
                this.fillInTextWidth = value;
                this.hmProperty["fillInTextWidth"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否填空框多行(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsMulti4FillInText(value) {
            if (value != undefined) {
                this.isMulti4FillInText = value;
                this.hmProperty["isMulti4FillInText"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 复选框限制数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCheckBoxLimitCount(value) {
            if (value != undefined) {
                this.checkBoxLimitCount = value;
                this.hmProperty["checkBoxLimitCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否是JS(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsJs(value) {
            if (value != undefined) {
                this.isJs = value;
                this.hmProperty["isJs"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 备注框宽度(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMemoTextWidth(value) {
            if (value != undefined) {
                this.memoTextWidth = value;
                this.hmProperty["memoTextWidth"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 相关事件(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRelaEvent(value) {
            if (value != undefined) {
                this.relaEvent = value;
                this.hmProperty["relaEvent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否测试(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsTest(value) {
            if (value != undefined) {
                this.isTest = value;
                this.hmProperty["isTest"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 模式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetLevelModeTypeId(value) {
            if (value != undefined) {
                this.levelModeTypeId = value;
                this.hmProperty["levelModeTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否随机(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsRandom(value) {
            if (value != undefined) {
                this.isRandom = value;
                this.hmProperty["isRandom"] = true;
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
                case clsQuestionnaireEN.con_QuestionID:
                    return this.questionID;
                case clsQuestionnaireEN.con_QuestionIndex:
                    return this.questionIndex;
                case clsQuestionnaireEN.con_QuestionName:
                    return this.questionName;
                case clsQuestionnaireEN.con_QuestionContent:
                    return this.questionContent;
                case clsQuestionnaireEN.con_QuestionMemo:
                    return this.questionMemo;
                case clsQuestionnaireEN.con_QuestionNo:
                    return this.questionNo;
                case clsQuestionnaireEN.con_ParentQuestionId:
                    return this.parentQuestionId;
                case clsQuestionnaireEN.con_ExamAnswer:
                    return this.examAnswer;
                case clsQuestionnaireEN.con_CourseId:
                    return this.courseId;
                case clsQuestionnaireEN.con_LevelNo:
                    return this.levelNo;
                case clsQuestionnaireEN.con_CourseChapterId:
                    return this.courseChapterId;
                case clsQuestionnaireEN.con_QuestionTypeId:
                    return this.questionTypeId;
                case clsQuestionnaireEN.con_QuestionTypeId4Course:
                    return this.questionTypeId4Course;
                case clsQuestionnaireEN.con_AnswerTypeId:
                    return this.answerTypeId;
                case clsQuestionnaireEN.con_GridTitle:
                    return this.gridTitle;
                case clsQuestionnaireEN.con_AnswerModeId:
                    return this.answerModeId;
                case clsQuestionnaireEN.con_IsHaveAdditionalMemo:
                    return this.isHaveAdditionalMemo;
                case clsQuestionnaireEN.con_QuestionScore:
                    return this.questionScore;
                case clsQuestionnaireEN.con_DefaultValue:
                    return this.defaultValue;
                case clsQuestionnaireEN.con_DefaultSelectItem:
                    return this.defaultSelectItem;
                case clsQuestionnaireEN.con_IsShow:
                    return this.isShow;
                case clsQuestionnaireEN.con_IsCast:
                    return this.isCast;
                case clsQuestionnaireEN.con_LikeCount:
                    return this.likeCount;
                case clsQuestionnaireEN.con_AnswerAttLimitSize:
                    return this.answerAttLimitSize;
                case clsQuestionnaireEN.con_LimitedResourceType:
                    return this.limitedResourceType;
                case clsQuestionnaireEN.con_IsEffective:
                    return this.isEffective;
                case clsQuestionnaireEN.con_IsCanInPaper:
                    return this.isCanInPaper;
                case clsQuestionnaireEN.con_ExamGradeId:
                    return this.examGradeId;
                case clsQuestionnaireEN.con_TextDirectId:
                    return this.textDirectId;
                case clsQuestionnaireEN.con_UpdDate:
                    return this.updDate;
                case clsQuestionnaireEN.con_UpdUser:
                    return this.updUser;
                case clsQuestionnaireEN.con_Memo:
                    return this.memo;
                case clsQuestionnaireEN.con_QuestionCode:
                    return this.questionCode;
                case clsQuestionnaireEN.con_DifficultyLevelId:
                    return this.difficultyLevelId;
                case clsQuestionnaireEN.con_SectionTypeId:
                    return this.sectionTypeId;
                case clsQuestionnaireEN.con_KnowledgeGraphId:
                    return this.knowledgeGraphId;
                case clsQuestionnaireEN.con_FirstIndent:
                    return this.firstIndent;
                case clsQuestionnaireEN.con_QuestionName_Add:
                    return this.questionName_Add;
                case clsQuestionnaireEN.con_CodeTab:
                    return this.codeTab;
                case clsQuestionnaireEN.con_CodeTab_Code:
                    return this.codeTab_Code;
                case clsQuestionnaireEN.con_CodeTab_Condition:
                    return this.codeTab_Condition;
                case clsQuestionnaireEN.con_CodeTab_Name:
                    return this.codeTab_Name;
                case clsQuestionnaireEN.con_FillInTextHeight:
                    return this.fillInTextHeight;
                case clsQuestionnaireEN.con_FillInTextWidth:
                    return this.fillInTextWidth;
                case clsQuestionnaireEN.con_IsMulti4FillInText:
                    return this.isMulti4FillInText;
                case clsQuestionnaireEN.con_CheckBoxLimitCount:
                    return this.checkBoxLimitCount;
                case clsQuestionnaireEN.con_IsJs:
                    return this.isJs;
                case clsQuestionnaireEN.con_MemoTextWidth:
                    return this.memoTextWidth;
                case clsQuestionnaireEN.con_RelaEvent:
                    return this.relaEvent;
                case clsQuestionnaireEN.con_IsTest:
                    return this.isTest;
                case clsQuestionnaireEN.con_LevelModeTypeId:
                    return this.levelModeTypeId;
                case clsQuestionnaireEN.con_IsRandom:
                    return this.isRandom;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[Questionnaire]中不存在！`;
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
                case clsQuestionnaireEN.con_QuestionID:
                    this.questionID = strValue;
                    this.hmProperty["questionID"] = true;
                    break;
                case clsQuestionnaireEN.con_QuestionIndex:
                    this.questionIndex = Number(strValue);
                    this.hmProperty["questionIndex"] = true;
                    break;
                case clsQuestionnaireEN.con_QuestionName:
                    this.questionName = strValue;
                    this.hmProperty["questionName"] = true;
                    break;
                case clsQuestionnaireEN.con_QuestionContent:
                    this.questionContent = strValue;
                    this.hmProperty["questionContent"] = true;
                    break;
                case clsQuestionnaireEN.con_QuestionMemo:
                    this.questionMemo = strValue;
                    this.hmProperty["questionMemo"] = true;
                    break;
                case clsQuestionnaireEN.con_QuestionNo:
                    this.questionNo = strValue;
                    this.hmProperty["questionNo"] = true;
                    break;
                case clsQuestionnaireEN.con_ParentQuestionId:
                    this.parentQuestionId = strValue;
                    this.hmProperty["parentQuestionId"] = true;
                    break;
                case clsQuestionnaireEN.con_ExamAnswer:
                    this.examAnswer = strValue;
                    this.hmProperty["examAnswer"] = true;
                    break;
                case clsQuestionnaireEN.con_CourseId:
                    this.courseId = strValue;
                    this.hmProperty["courseId"] = true;
                    break;
                case clsQuestionnaireEN.con_LevelNo:
                    this.levelNo = Number(strValue);
                    this.hmProperty["levelNo"] = true;
                    break;
                case clsQuestionnaireEN.con_CourseChapterId:
                    this.courseChapterId = strValue;
                    this.hmProperty["courseChapterId"] = true;
                    break;
                case clsQuestionnaireEN.con_QuestionTypeId:
                    this.questionTypeId = strValue;
                    this.hmProperty["questionTypeId"] = true;
                    break;
                case clsQuestionnaireEN.con_QuestionTypeId4Course:
                    this.questionTypeId4Course = strValue;
                    this.hmProperty["questionTypeId4Course"] = true;
                    break;
                case clsQuestionnaireEN.con_AnswerTypeId:
                    this.answerTypeId = strValue;
                    this.hmProperty["answerTypeId"] = true;
                    break;
                case clsQuestionnaireEN.con_GridTitle:
                    this.gridTitle = strValue;
                    this.hmProperty["gridTitle"] = true;
                    break;
                case clsQuestionnaireEN.con_AnswerModeId:
                    this.answerModeId = strValue;
                    this.hmProperty["answerModeId"] = true;
                    break;
                case clsQuestionnaireEN.con_IsHaveAdditionalMemo:
                    this.isHaveAdditionalMemo = Boolean(strValue);
                    this.hmProperty["isHaveAdditionalMemo"] = true;
                    break;
                case clsQuestionnaireEN.con_QuestionScore:
                    this.questionScore = Number(strValue);
                    this.hmProperty["questionScore"] = true;
                    break;
                case clsQuestionnaireEN.con_DefaultValue:
                    this.defaultValue = strValue;
                    this.hmProperty["defaultValue"] = true;
                    break;
                case clsQuestionnaireEN.con_DefaultSelectItem:
                    this.defaultSelectItem = strValue;
                    this.hmProperty["defaultSelectItem"] = true;
                    break;
                case clsQuestionnaireEN.con_IsShow:
                    this.isShow = Boolean(strValue);
                    this.hmProperty["isShow"] = true;
                    break;
                case clsQuestionnaireEN.con_IsCast:
                    this.isCast = Boolean(strValue);
                    this.hmProperty["isCast"] = true;
                    break;
                case clsQuestionnaireEN.con_LikeCount:
                    this.likeCount = Number(strValue);
                    this.hmProperty["likeCount"] = true;
                    break;
                case clsQuestionnaireEN.con_AnswerAttLimitSize:
                    this.answerAttLimitSize = Number(strValue);
                    this.hmProperty["answerAttLimitSize"] = true;
                    break;
                case clsQuestionnaireEN.con_LimitedResourceType:
                    this.limitedResourceType = strValue;
                    this.hmProperty["limitedResourceType"] = true;
                    break;
                case clsQuestionnaireEN.con_IsEffective:
                    this.isEffective = Boolean(strValue);
                    this.hmProperty["isEffective"] = true;
                    break;
                case clsQuestionnaireEN.con_IsCanInPaper:
                    this.isCanInPaper = Boolean(strValue);
                    this.hmProperty["isCanInPaper"] = true;
                    break;
                case clsQuestionnaireEN.con_ExamGradeId:
                    this.examGradeId = strValue;
                    this.hmProperty["examGradeId"] = true;
                    break;
                case clsQuestionnaireEN.con_TextDirectId:
                    this.textDirectId = strValue;
                    this.hmProperty["textDirectId"] = true;
                    break;
                case clsQuestionnaireEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsQuestionnaireEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsQuestionnaireEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsQuestionnaireEN.con_QuestionCode:
                    this.questionCode = strValue;
                    this.hmProperty["questionCode"] = true;
                    break;
                case clsQuestionnaireEN.con_DifficultyLevelId:
                    this.difficultyLevelId = strValue;
                    this.hmProperty["difficultyLevelId"] = true;
                    break;
                case clsQuestionnaireEN.con_SectionTypeId:
                    this.sectionTypeId = strValue;
                    this.hmProperty["sectionTypeId"] = true;
                    break;
                case clsQuestionnaireEN.con_KnowledgeGraphId:
                    this.knowledgeGraphId = strValue;
                    this.hmProperty["knowledgeGraphId"] = true;
                    break;
                case clsQuestionnaireEN.con_FirstIndent:
                    this.firstIndent = Boolean(strValue);
                    this.hmProperty["firstIndent"] = true;
                    break;
                case clsQuestionnaireEN.con_QuestionName_Add:
                    this.questionName_Add = strValue;
                    this.hmProperty["questionName_Add"] = true;
                    break;
                case clsQuestionnaireEN.con_CodeTab:
                    this.codeTab = strValue;
                    this.hmProperty["codeTab"] = true;
                    break;
                case clsQuestionnaireEN.con_CodeTab_Code:
                    this.codeTab_Code = strValue;
                    this.hmProperty["codeTab_Code"] = true;
                    break;
                case clsQuestionnaireEN.con_CodeTab_Condition:
                    this.codeTab_Condition = strValue;
                    this.hmProperty["codeTab_Condition"] = true;
                    break;
                case clsQuestionnaireEN.con_CodeTab_Name:
                    this.codeTab_Name = strValue;
                    this.hmProperty["codeTab_Name"] = true;
                    break;
                case clsQuestionnaireEN.con_FillInTextHeight:
                    this.fillInTextHeight = Number(strValue);
                    this.hmProperty["fillInTextHeight"] = true;
                    break;
                case clsQuestionnaireEN.con_FillInTextWidth:
                    this.fillInTextWidth = Number(strValue);
                    this.hmProperty["fillInTextWidth"] = true;
                    break;
                case clsQuestionnaireEN.con_IsMulti4FillInText:
                    this.isMulti4FillInText = Boolean(strValue);
                    this.hmProperty["isMulti4FillInText"] = true;
                    break;
                case clsQuestionnaireEN.con_CheckBoxLimitCount:
                    this.checkBoxLimitCount = Number(strValue);
                    this.hmProperty["checkBoxLimitCount"] = true;
                    break;
                case clsQuestionnaireEN.con_IsJs:
                    this.isJs = Boolean(strValue);
                    this.hmProperty["isJs"] = true;
                    break;
                case clsQuestionnaireEN.con_MemoTextWidth:
                    this.memoTextWidth = Number(strValue);
                    this.hmProperty["memoTextWidth"] = true;
                    break;
                case clsQuestionnaireEN.con_RelaEvent:
                    this.relaEvent = strValue;
                    this.hmProperty["relaEvent"] = true;
                    break;
                case clsQuestionnaireEN.con_IsTest:
                    this.isTest = Boolean(strValue);
                    this.hmProperty["isTest"] = true;
                    break;
                case clsQuestionnaireEN.con_LevelModeTypeId:
                    this.levelModeTypeId = strValue;
                    this.hmProperty["levelModeTypeId"] = true;
                    break;
                case clsQuestionnaireEN.con_IsRandom:
                    this.isRandom = Boolean(strValue);
                    this.hmProperty["isRandom"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[Questionnaire]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"QuestionID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionID() { return "questionID"; } //题目ID
        /**
        * 常量:"QuestionIndex"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionIndex() { return "questionIndex"; } //题目序号
        /**
        * 常量:"QuestionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionName() { return "questionName"; } //题目名称
        /**
        * 常量:"QuestionContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionContent() { return "questionContent"; } //题目内容
        /**
        * 常量:"QuestionMemo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionMemo() { return "questionMemo"; } //题目说明
        /**
        * 常量:"QuestionNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionNo() { return "questionNo"; } //题目编号
        /**
        * 常量:"ParentQuestionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentQuestionId() { return "parentQuestionId"; } //父题目Id
        /**
        * 常量:"ExamAnswer"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExamAnswer() { return "examAnswer"; } //题目答案
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"LevelNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LevelNo() { return "levelNo"; } //学习关号2
        /**
        * 常量:"CourseChapterId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterId() { return "courseChapterId"; } //课程章节ID
        /**
        * 常量:"QuestionTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeId() { return "questionTypeId"; } //题目类型Id
        /**
        * 常量:"QuestionTypeId4Course"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeId4Course() { return "questionTypeId4Course"; } //题目类型Id4课程
        /**
        * 常量:"AnswerTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerTypeId() { return "answerTypeId"; } //答案类型ID
        /**
        * 常量:"GridTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GridTitle() { return "gridTitle"; } //表格标题
        /**
        * 常量:"AnswerModeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerModeId() { return "answerModeId"; } //答案模式Id
        /**
        * 常量:"IsHaveAdditionalMemo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsHaveAdditionalMemo() { return "isHaveAdditionalMemo"; } //是否有附加说明
        /**
        * 常量:"QuestionScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionScore() { return "questionScore"; } //题目得分
        /**
        * 常量:"DefaultValue"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DefaultValue() { return "defaultValue"; } //缺省值
        /**
        * 常量:"DefaultSelectItem"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DefaultSelectItem() { return "defaultSelectItem"; } //默认选项
        /**
        * 常量:"IsShow"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsShow() { return "isShow"; } //是否启用
        /**
        * 常量:"IsCast"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCast() { return "isCast"; } //是否播放
        /**
        * 常量:"LikeCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LikeCount() { return "likeCount"; } //资源喜欢数量
        /**
        * 常量:"AnswerAttLimitSize"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerAttLimitSize() { return "answerAttLimitSize"; } //回答附件限制大小
        /**
        * 常量:"LimitedResourceType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LimitedResourceType() { return "limitedResourceType"; } //限制资源类型
        /**
        * 常量:"IsEffective"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsEffective() { return "isEffective"; } //是否有效
        /**
        * 常量:"IsCanInPaper"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCanInPaper() { return "isCanInPaper"; } //是否可在Paper
        /**
        * 常量:"ExamGradeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExamGradeId() { return "examGradeId"; } //题库等级ID
        /**
        * 常量:"TextDirectId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TextDirectId() { return "textDirectId"; } //文本方向ID
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
        * 常量:"QuestionCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionCode() { return "questionCode"; } //html代码
        /**
        * 常量:"DifficultyLevelId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DifficultyLevelId() { return "difficultyLevelId"; } //难度等级Id
        /**
        * 常量:"SectionTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionTypeId() { return "sectionTypeId"; } //节点类型Id
        /**
        * 常量:"KnowledgeGraphId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeGraphId() { return "knowledgeGraphId"; } //知识点图Id
        /**
        * 常量:"FirstIndent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FirstIndent() { return "firstIndent"; } //首行缩进
        /**
        * 常量:"QuestionName_Add"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionName_Add() { return "questionName_Add"; } //题目补充
        /**
        * 常量:"CodeTab"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CodeTab() { return "codeTab"; } //代码表
        /**
        * 常量:"CodeTab_Code"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CodeTab_Code() { return "codeTab_Code"; } //CodeTab_Code
        /**
        * 常量:"CodeTab_Condition"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CodeTab_Condition() { return "codeTab_Condition"; } //代码表_条件
        /**
        * 常量:"CodeTab_Name"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CodeTab_Name() { return "codeTab_Name"; } //CodeTab_Name
        /**
        * 常量:"FillInTextHeight"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FillInTextHeight() { return "fillInTextHeight"; } //填空框高度
        /**
        * 常量:"FillInTextWidth"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FillInTextWidth() { return "fillInTextWidth"; } //填空框宽度
        /**
        * 常量:"IsMulti4FillInText"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsMulti4FillInText() { return "isMulti4FillInText"; } //是否填空框多行
        /**
        * 常量:"CheckBoxLimitCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CheckBoxLimitCount() { return "checkBoxLimitCount"; } //复选框限制数
        /**
        * 常量:"IsJs"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsJs() { return "isJs"; } //是否是JS
        /**
        * 常量:"MemoTextWidth"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MemoTextWidth() { return "memoTextWidth"; } //备注框宽度
        /**
        * 常量:"RelaEvent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RelaEvent() { return "relaEvent"; } //相关事件
        /**
        * 常量:"IsTest"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsTest() { return "isTest"; } //是否测试
        /**
        * 常量:"LevelModeTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LevelModeTypeId() { return "levelModeTypeId"; } //模式Id
        /**
        * 常量:"IsRandom"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRandom() { return "isRandom"; } //是否随机
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
    exports.clsQuestionnaireEN = clsQuestionnaireEN;
    clsQuestionnaireEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsQuestionnaireEN.CacheModeId = "02"; //客户端缓存
    clsQuestionnaireEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsQuestionnaireEN.WhereFormat = ""; //条件格式串
    clsQuestionnaireEN._CurrTabName = "Questionnaire"; //当前表名,与该类相关的表名
    clsQuestionnaireEN._KeyFldName = "QuestionID"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsQuestionnaireEN.mintAttributeCount = 52;
    clsQuestionnaireEN.AttributeName = ["questionID", "questionIndex", "questionName", "questionContent", "questionMemo", "questionNo", "parentQuestionId", "examAnswer", "courseId", "levelNo", "courseChapterId", "questionTypeId", "questionTypeId4Course", "answerTypeId", "gridTitle", "answerModeId", "isHaveAdditionalMemo", "questionScore", "defaultValue", "defaultSelectItem", "isShow", "isCast", "likeCount", "answerAttLimitSize", "limitedResourceType", "isEffective", "isCanInPaper", "examGradeId", "textDirectId", "updDate", "updUser", "memo", "questionCode", "difficultyLevelId", "sectionTypeId", "knowledgeGraphId", "firstIndent", "questionName_Add", "codeTab", "codeTab_Code", "codeTab_Condition", "codeTab_Name", "fillInTextHeight", "fillInTextWidth", "isMulti4FillInText", "checkBoxLimitCount", "isJs", "memoTextWidth", "relaEvent", "isTest", "levelModeTypeId", "isRandom"];
});
