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
    exports.clscc_ExamPaperStuRelationEN = void 0;
    /**
    * 类名:clscc_ExamPaperStuRelationEN
    * 表名:cc_ExamPaperStuRelation(01120235)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:54:45
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:互动管理(InteractManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 考卷与学生关系(cc_ExamPaperStuRelation)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clscc_ExamPaperStuRelationEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mlngId_ExamPaperStuRelation = 0; //流水号
            this.mstrCourseExamPaperId = ""; //考卷流水号
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mdblScores = 0; //分值
            this.mstrSpecifyCompletionDate = ""; //指定完成日期
            this.mstrid_StudentInfo = ""; //学生流水号
            this.mstrAnswerModeId = ""; //答案模式Id
            this.mstrAnswerOptionId = ""; //回答选项Id
            this.mstrAnswerMultiOptions = ""; //多选项答案
            this.mstrStuAnswerText = ""; //学生回答文本
            this.mbolIsPublish = false; //是否发布
            this.mbolIsLook = false; //是否查看
            this.mbolIsSave = false; //是否保存
            this.mbolIsSubmit = false; //是否提交
            this.mstrApplySendBackDate = ""; //申请退回日期
            this.mbolIsApplySendBack = false; //是否申请退回
            this.mstrRealFinishDate = ""; //实际完成日期
            this.mstrOperateTime = ""; //操作时间
            this.mdblScore = 0; //得分
            this.mstrComment = ""; //批注
            this.mbolIsMarking = false; //是否批阅
            this.mstrMarkerId = ""; //打分者
            this.mstrMarkDate = ""; //打分日期
            this.mbolIsSendBack = false; //是否退回
            this.mbolIsInErrorQuestion = false; //是否进入错题
            this.mstrWorkTypeId = ""; //作业类型Id
            this.mstrAnswerIP = ""; //回答IP
            this.mstrAnswerDate = ""; //回答日期
            this.mstrAnswerTime = ""; //回答时间
            this.mbolIsRight = false; //是否正确
            this.mbolIsAccessKnowledge = false; //是否处理知识点
            this.mbolIsNotProcessTimeout = false; //是否不处理超时
            this.mstrSchoolYear = ""; //学年
            this.mstrSchoolTerm = ""; //学期
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUserId = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.id_ExamPaperStuRelation = 0; //流水号
            this.courseExamPaperId = ""; //考卷流水号
            this.id_CurrEduCls = ""; //教学班流水号
            this.scores = 0; //分值
            this.specifyCompletionDate = ""; //指定完成日期
            this.id_StudentInfo = ""; //学生流水号
            this.answerModeId = ""; //答案模式Id
            this.answerOptionId = ""; //回答选项Id
            this.answerMultiOptions = ""; //多选项答案
            this.stuAnswerText = ""; //学生回答文本
            this.isPublish = false; //是否发布
            this.isLook = false; //是否查看
            this.isSave = false; //是否保存
            this.isSubmit = false; //是否提交
            this.applySendBackDate = ""; //申请退回日期
            this.isApplySendBack = false; //是否申请退回
            this.realFinishDate = ""; //实际完成日期
            this.operateTime = ""; //操作时间
            this.score = 0; //得分
            this.comment = ""; //批注
            this.isMarking = false; //是否批阅
            this.markerId = ""; //打分者
            this.markDate = ""; //打分日期
            this.isSendBack = false; //是否退回
            this.isInErrorQuestion = false; //是否进入错题
            this.workTypeId = ""; //作业类型Id
            this.answerIP = ""; //回答IP
            this.answerDate = ""; //回答日期
            this.answerTime = ""; //回答时间
            this.isRight = false; //是否正确
            this.isAccessKnowledge = false; //是否处理知识点
            this.isNotProcessTimeout = false; //是否不处理超时
            this.schoolYear = ""; //学年
            this.schoolTerm = ""; //学期
            this.updDate = ""; //修改日期
            this.updUserId = ""; //修改用户Id
            this.memo = ""; //备注
        }
        /**
         * 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetId_ExamPaperStuRelation(value) {
            if (value != undefined) {
                this.id_ExamPaperStuRelation = value;
                this.hmProperty["id_ExamPaperStuRelation"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
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
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CurrEduCls(value) {
            if (value != undefined) {
                this.id_CurrEduCls = value;
                this.hmProperty["id_CurrEduCls"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 分值(说明:;字段类型:decimal;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScores(value) {
            if (value != undefined) {
                this.scores = value;
                this.hmProperty["scores"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 指定完成日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSpecifyCompletionDate(value) {
            if (value != undefined) {
                this.specifyCompletionDate = value;
                this.hmProperty["specifyCompletionDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_StudentInfo(value) {
            if (value != undefined) {
                this.id_StudentInfo = value;
                this.hmProperty["id_StudentInfo"] = true;
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
         * 回答选项Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerOptionId(value) {
            if (value != undefined) {
                this.answerOptionId = value;
                this.hmProperty["answerOptionId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 多选项答案(说明:;字段类型:varchar;字段长度:300;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerMultiOptions(value) {
            if (value != undefined) {
                this.answerMultiOptions = value;
                this.hmProperty["answerMultiOptions"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学生回答文本(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuAnswerText(value) {
            if (value != undefined) {
                this.stuAnswerText = value;
                this.hmProperty["stuAnswerText"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否发布(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsPublish(value) {
            if (value != undefined) {
                this.isPublish = value;
                this.hmProperty["isPublish"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否查看(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsLook(value) {
            if (value != undefined) {
                this.isLook = value;
                this.hmProperty["isLook"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否保存(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSave(value) {
            if (value != undefined) {
                this.isSave = value;
                this.hmProperty["isSave"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSubmit(value) {
            if (value != undefined) {
                this.isSubmit = value;
                this.hmProperty["isSubmit"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 申请退回日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetApplySendBackDate(value) {
            if (value != undefined) {
                this.applySendBackDate = value;
                this.hmProperty["applySendBackDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否申请退回(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsApplySendBack(value) {
            if (value != undefined) {
                this.isApplySendBack = value;
                this.hmProperty["isApplySendBack"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 实际完成日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetRealFinishDate(value) {
            if (value != undefined) {
                this.realFinishDate = value;
                this.hmProperty["realFinishDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 操作时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOperateTime(value) {
            if (value != undefined) {
                this.operateTime = value;
                this.hmProperty["operateTime"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 得分(说明:;字段类型:decimal;字段长度:6;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScore(value) {
            if (value != undefined) {
                this.score = value;
                this.hmProperty["score"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 批注(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetComment(value) {
            if (value != undefined) {
                this.comment = value;
                this.hmProperty["comment"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否批阅(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsMarking(value) {
            if (value != undefined) {
                this.isMarking = value;
                this.hmProperty["isMarking"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 打分者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMarkerId(value) {
            if (value != undefined) {
                this.markerId = value;
                this.hmProperty["markerId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 打分日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMarkDate(value) {
            if (value != undefined) {
                this.markDate = value;
                this.hmProperty["markDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否退回(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSendBack(value) {
            if (value != undefined) {
                this.isSendBack = value;
                this.hmProperty["isSendBack"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否进入错题(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsInErrorQuestion(value) {
            if (value != undefined) {
                this.isInErrorQuestion = value;
                this.hmProperty["isInErrorQuestion"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 作业类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetWorkTypeId(value) {
            if (value != undefined) {
                this.workTypeId = value;
                this.hmProperty["workTypeId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 回答IP(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerIP(value) {
            if (value != undefined) {
                this.answerIP = value;
                this.hmProperty["answerIP"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 回答日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerDate(value) {
            if (value != undefined) {
                this.answerDate = value;
                this.hmProperty["answerDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 回答时间(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerTime(value) {
            if (value != undefined) {
                this.answerTime = value;
                this.hmProperty["answerTime"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsRight(value) {
            if (value != undefined) {
                this.isRight = value;
                this.hmProperty["isRight"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否处理知识点(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsAccessKnowledge(value) {
            if (value != undefined) {
                this.isAccessKnowledge = value;
                this.hmProperty["isAccessKnowledge"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 是否不处理超时(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsNotProcessTimeout(value) {
            if (value != undefined) {
                this.isNotProcessTimeout = value;
                this.hmProperty["isNotProcessTimeout"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolYear(value) {
            if (value != undefined) {
                this.schoolYear = value;
                this.hmProperty["schoolYear"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSchoolTerm(value) {
            if (value != undefined) {
                this.schoolTerm = value;
                this.hmProperty["schoolTerm"] = true;
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
                case clscc_ExamPaperStuRelationEN.con_Id_ExamPaperStuRelation:
                    return this.id_ExamPaperStuRelation;
                case clscc_ExamPaperStuRelationEN.con_CourseExamPaperId:
                    return this.courseExamPaperId;
                case clscc_ExamPaperStuRelationEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clscc_ExamPaperStuRelationEN.con_Scores:
                    return this.scores;
                case clscc_ExamPaperStuRelationEN.con_SpecifyCompletionDate:
                    return this.specifyCompletionDate;
                case clscc_ExamPaperStuRelationEN.con_id_StudentInfo:
                    return this.id_StudentInfo;
                case clscc_ExamPaperStuRelationEN.con_AnswerModeId:
                    return this.answerModeId;
                case clscc_ExamPaperStuRelationEN.con_AnswerOptionId:
                    return this.answerOptionId;
                case clscc_ExamPaperStuRelationEN.con_AnswerMultiOptions:
                    return this.answerMultiOptions;
                case clscc_ExamPaperStuRelationEN.con_StuAnswerText:
                    return this.stuAnswerText;
                case clscc_ExamPaperStuRelationEN.con_IsPublish:
                    return this.isPublish;
                case clscc_ExamPaperStuRelationEN.con_IsLook:
                    return this.isLook;
                case clscc_ExamPaperStuRelationEN.con_IsSave:
                    return this.isSave;
                case clscc_ExamPaperStuRelationEN.con_IsSubmit:
                    return this.isSubmit;
                case clscc_ExamPaperStuRelationEN.con_ApplySendBackDate:
                    return this.applySendBackDate;
                case clscc_ExamPaperStuRelationEN.con_IsApplySendBack:
                    return this.isApplySendBack;
                case clscc_ExamPaperStuRelationEN.con_RealFinishDate:
                    return this.realFinishDate;
                case clscc_ExamPaperStuRelationEN.con_OperateTime:
                    return this.operateTime;
                case clscc_ExamPaperStuRelationEN.con_Score:
                    return this.score;
                case clscc_ExamPaperStuRelationEN.con_Comment:
                    return this.comment;
                case clscc_ExamPaperStuRelationEN.con_IsMarking:
                    return this.isMarking;
                case clscc_ExamPaperStuRelationEN.con_MarkerId:
                    return this.markerId;
                case clscc_ExamPaperStuRelationEN.con_MarkDate:
                    return this.markDate;
                case clscc_ExamPaperStuRelationEN.con_IsSendBack:
                    return this.isSendBack;
                case clscc_ExamPaperStuRelationEN.con_IsInErrorQuestion:
                    return this.isInErrorQuestion;
                case clscc_ExamPaperStuRelationEN.con_WorkTypeId:
                    return this.workTypeId;
                case clscc_ExamPaperStuRelationEN.con_AnswerIP:
                    return this.answerIP;
                case clscc_ExamPaperStuRelationEN.con_AnswerDate:
                    return this.answerDate;
                case clscc_ExamPaperStuRelationEN.con_AnswerTime:
                    return this.answerTime;
                case clscc_ExamPaperStuRelationEN.con_IsRight:
                    return this.isRight;
                case clscc_ExamPaperStuRelationEN.con_IsAccessKnowledge:
                    return this.isAccessKnowledge;
                case clscc_ExamPaperStuRelationEN.con_IsNotProcessTimeout:
                    return this.isNotProcessTimeout;
                case clscc_ExamPaperStuRelationEN.con_SchoolYear:
                    return this.schoolYear;
                case clscc_ExamPaperStuRelationEN.con_SchoolTerm:
                    return this.schoolTerm;
                case clscc_ExamPaperStuRelationEN.con_UpdDate:
                    return this.updDate;
                case clscc_ExamPaperStuRelationEN.con_UpdUserId:
                    return this.updUserId;
                case clscc_ExamPaperStuRelationEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_ExamPaperStuRelation]中不存在！`;
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
                case clscc_ExamPaperStuRelationEN.con_Id_ExamPaperStuRelation:
                    this.id_ExamPaperStuRelation = Number(strValue);
                    this.hmProperty["id_ExamPaperStuRelation"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_CourseExamPaperId:
                    this.courseExamPaperId = strValue;
                    this.hmProperty["courseExamPaperId"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_Scores:
                    this.scores = Number(strValue);
                    this.hmProperty["scores"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_SpecifyCompletionDate:
                    this.specifyCompletionDate = strValue;
                    this.hmProperty["specifyCompletionDate"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_id_StudentInfo:
                    this.id_StudentInfo = strValue;
                    this.hmProperty["id_StudentInfo"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_AnswerModeId:
                    this.answerModeId = strValue;
                    this.hmProperty["answerModeId"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_AnswerOptionId:
                    this.answerOptionId = strValue;
                    this.hmProperty["answerOptionId"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_AnswerMultiOptions:
                    this.answerMultiOptions = strValue;
                    this.hmProperty["answerMultiOptions"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_StuAnswerText:
                    this.stuAnswerText = strValue;
                    this.hmProperty["stuAnswerText"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsPublish:
                    this.isPublish = Boolean(strValue);
                    this.hmProperty["isPublish"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsLook:
                    this.isLook = Boolean(strValue);
                    this.hmProperty["isLook"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsSave:
                    this.isSave = Boolean(strValue);
                    this.hmProperty["isSave"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_ApplySendBackDate:
                    this.applySendBackDate = strValue;
                    this.hmProperty["applySendBackDate"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsApplySendBack:
                    this.isApplySendBack = Boolean(strValue);
                    this.hmProperty["isApplySendBack"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_RealFinishDate:
                    this.realFinishDate = strValue;
                    this.hmProperty["realFinishDate"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_OperateTime:
                    this.operateTime = strValue;
                    this.hmProperty["operateTime"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_Score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_Comment:
                    this.comment = strValue;
                    this.hmProperty["comment"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsMarking:
                    this.isMarking = Boolean(strValue);
                    this.hmProperty["isMarking"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_MarkerId:
                    this.markerId = strValue;
                    this.hmProperty["markerId"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_MarkDate:
                    this.markDate = strValue;
                    this.hmProperty["markDate"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsSendBack:
                    this.isSendBack = Boolean(strValue);
                    this.hmProperty["isSendBack"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsInErrorQuestion:
                    this.isInErrorQuestion = Boolean(strValue);
                    this.hmProperty["isInErrorQuestion"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_WorkTypeId:
                    this.workTypeId = strValue;
                    this.hmProperty["workTypeId"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_AnswerIP:
                    this.answerIP = strValue;
                    this.hmProperty["answerIP"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_AnswerDate:
                    this.answerDate = strValue;
                    this.hmProperty["answerDate"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_AnswerTime:
                    this.answerTime = strValue;
                    this.hmProperty["answerTime"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsRight:
                    this.isRight = Boolean(strValue);
                    this.hmProperty["isRight"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsAccessKnowledge:
                    this.isAccessKnowledge = Boolean(strValue);
                    this.hmProperty["isAccessKnowledge"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_IsNotProcessTimeout:
                    this.isNotProcessTimeout = Boolean(strValue);
                    this.hmProperty["isNotProcessTimeout"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_SchoolYear:
                    this.schoolYear = strValue;
                    this.hmProperty["schoolYear"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_SchoolTerm:
                    this.schoolTerm = strValue;
                    this.hmProperty["schoolTerm"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_UpdUserId:
                    this.updUserId = strValue;
                    this.hmProperty["updUserId"] = true;
                    break;
                case clscc_ExamPaperStuRelationEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_ExamPaperStuRelation]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"Id_ExamPaperStuRelation"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Id_ExamPaperStuRelation() { return "id_ExamPaperStuRelation"; } //流水号
        /**
        * 常量:"CourseExamPaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseExamPaperId() { return "courseExamPaperId"; } //考卷流水号
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"Scores"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Scores() { return "scores"; } //分值
        /**
        * 常量:"SpecifyCompletionDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SpecifyCompletionDate() { return "specifyCompletionDate"; } //指定完成日期
        /**
        * 常量:"id_StudentInfo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_StudentInfo() { return "id_StudentInfo"; } //学生流水号
        /**
        * 常量:"AnswerModeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerModeId() { return "answerModeId"; } //答案模式Id
        /**
        * 常量:"AnswerOptionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerOptionId() { return "answerOptionId"; } //回答选项Id
        /**
        * 常量:"AnswerMultiOptions"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerMultiOptions() { return "answerMultiOptions"; } //多选项答案
        /**
        * 常量:"StuAnswerText"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuAnswerText() { return "stuAnswerText"; } //学生回答文本
        /**
        * 常量:"IsPublish"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsPublish() { return "isPublish"; } //是否发布
        /**
        * 常量:"IsLook"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsLook() { return "isLook"; } //是否查看
        /**
        * 常量:"IsSave"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSave() { return "isSave"; } //是否保存
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"ApplySendBackDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ApplySendBackDate() { return "applySendBackDate"; } //申请退回日期
        /**
        * 常量:"IsApplySendBack"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsApplySendBack() { return "isApplySendBack"; } //是否申请退回
        /**
        * 常量:"RealFinishDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RealFinishDate() { return "realFinishDate"; } //实际完成日期
        /**
        * 常量:"OperateTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OperateTime() { return "operateTime"; } //操作时间
        /**
        * 常量:"Score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Score() { return "score"; } //得分
        /**
        * 常量:"Comment"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Comment() { return "comment"; } //批注
        /**
        * 常量:"IsMarking"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsMarking() { return "isMarking"; } //是否批阅
        /**
        * 常量:"MarkerId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MarkerId() { return "markerId"; } //打分者
        /**
        * 常量:"MarkDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MarkDate() { return "markDate"; } //打分日期
        /**
        * 常量:"IsSendBack"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSendBack() { return "isSendBack"; } //是否退回
        /**
        * 常量:"IsInErrorQuestion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsInErrorQuestion() { return "isInErrorQuestion"; } //是否进入错题
        /**
        * 常量:"WorkTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WorkTypeId() { return "workTypeId"; } //作业类型Id
        /**
        * 常量:"AnswerIP"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerIP() { return "answerIP"; } //回答IP
        /**
        * 常量:"AnswerDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerDate() { return "answerDate"; } //回答日期
        /**
        * 常量:"AnswerTime"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerTime() { return "answerTime"; } //回答时间
        /**
        * 常量:"IsRight"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRight() { return "isRight"; } //是否正确
        /**
        * 常量:"IsAccessKnowledge"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsAccessKnowledge() { return "isAccessKnowledge"; } //是否处理知识点
        /**
        * 常量:"IsNotProcessTimeout"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsNotProcessTimeout() { return "isNotProcessTimeout"; } //是否不处理超时
        /**
        * 常量:"SchoolYear"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolYear() { return "schoolYear"; } //学年
        /**
        * 常量:"SchoolTerm"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SchoolTerm() { return "schoolTerm"; } //学期
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
    exports.clscc_ExamPaperStuRelationEN = clscc_ExamPaperStuRelationEN;
    clscc_ExamPaperStuRelationEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clscc_ExamPaperStuRelationEN.CacheModeId = "02"; //客户端缓存
    clscc_ExamPaperStuRelationEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clscc_ExamPaperStuRelationEN.WhereFormat = ""; //条件格式串
    clscc_ExamPaperStuRelationEN._CurrTabName = "cc_ExamPaperStuRelation"; //当前表名,与该类相关的表名
    clscc_ExamPaperStuRelationEN._KeyFldName = "Id_ExamPaperStuRelation"; //当前表中的关键字名称,与该类相关的表中关键字名
    clscc_ExamPaperStuRelationEN.mintAttributeCount = 37;
    clscc_ExamPaperStuRelationEN.AttributeName = ["id_ExamPaperStuRelation", "courseExamPaperId", "id_CurrEduCls", "scores", "specifyCompletionDate", "id_StudentInfo", "answerModeId", "answerOptionId", "answerMultiOptions", "stuAnswerText", "isPublish", "isLook", "isSave", "isSubmit", "applySendBackDate", "isApplySendBack", "realFinishDate", "operateTime", "score", "comment", "isMarking", "markerId", "markDate", "isSendBack", "isInErrorQuestion", "workTypeId", "answerIP", "answerDate", "answerTime", "isRight", "isAccessKnowledge", "isNotProcessTimeout", "schoolYear", "schoolTerm", "updDate", "updUserId", "memo"];
});
