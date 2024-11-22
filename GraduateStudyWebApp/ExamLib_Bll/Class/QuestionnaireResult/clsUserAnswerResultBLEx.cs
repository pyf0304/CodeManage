
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ExamLib.BusinessLogicEx
{
    public static class clsUserAnswerResultBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objUserAnswerResultENS">源对象</param>
        /// <returns>目标对象=>clsUserAnswerResultEN:objUserAnswerResultENT</returns>
        public static clsUserAnswerResultENEx CopyToEx(this clsUserAnswerResultEN objUserAnswerResultENS)
        {
            try
            {
                clsUserAnswerResultENEx objUserAnswerResultENT = new clsUserAnswerResultENEx();
                clsUserAnswerResultBL.UserAnswerResultDA.CopyTo(objUserAnswerResultENS, objUserAnswerResultENT);
                return objUserAnswerResultENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objUserAnswerResultENS">源对象</param>
        /// <returns>目标对象=>clsUserAnswerResultEN:objUserAnswerResultENT</returns>
        public static clsUserAnswerResultEN CopyTo(this clsUserAnswerResultENEx objUserAnswerResultENS)
        {
            try
            {
                clsUserAnswerResultEN objUserAnswerResultENT = new clsUserAnswerResultEN();
                clsUserAnswerResultBL.CopyTo(objUserAnswerResultENS, objUserAnswerResultENT);
                return objUserAnswerResultENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 用户答题结果(UserAnswerResult)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsUserAnswerResultBLEx : clsUserAnswerResultBL
    {

        #region 自带
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsUserAnswerResultDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsUserAnswerResultDAEx UserAnswerResultDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsUserAnswerResultDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objUserAnswerResultENS">源对象</param>
        /// <returns>目标对象=>clsUserAnswerResultEN:objUserAnswerResultENT</returns>
        public static clsUserAnswerResultENEx CopyToEx(clsUserAnswerResultEN objUserAnswerResultENS)
        {
            try
            {
                clsUserAnswerResultENEx objUserAnswerResultENT = new clsUserAnswerResultENEx();
                clsUserAnswerResultBL.UserAnswerResultDA.CopyTo(objUserAnswerResultENS, objUserAnswerResultENT);
                return objUserAnswerResultENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsUserAnswerResultENEx> GetObjExLst(string strCondition)
        {
            List<clsUserAnswerResultEN> arrObjLst = clsUserAnswerResultBL.GetObjLst(strCondition);
            List<clsUserAnswerResultENEx> arrObjExLst = new List<clsUserAnswerResultENEx>();
            foreach (clsUserAnswerResultEN objInFor in arrObjLst)
            {
                clsUserAnswerResultENEx objUserAnswerResultENEx = new clsUserAnswerResultENEx();
                clsUserAnswerResultBL.CopyTo(objInFor, objUserAnswerResultENEx);
                arrObjExLst.Add(objUserAnswerResultENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngMinID">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsUserAnswerResultENEx GetObjExByMinID(long lngMinID)
        {
            clsUserAnswerResultEN objUserAnswerResultEN = clsUserAnswerResultBL.GetObjByMinId(lngMinID);
            clsUserAnswerResultENEx objUserAnswerResultENEx = new clsUserAnswerResultENEx();
            clsUserAnswerResultBL.CopyTo(objUserAnswerResultEN, objUserAnswerResultENEx);
            return objUserAnswerResultENEx;
        }

        #endregion


        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static bool AddOrUpdateRecord(string UserId, string ExamBatchNo, long QuestionId, string IdCurrEduCls, string answerText)
        {
            bool bolIsExist = false;
            string CourseId = string.Empty;
            bool bolIsRight = false;
            int intQuestionScore_User = 0;

            try
            {
                //根据教学班流水号 获取课程ID;
                clsCurrEduClsEN objCurrEduCls = clsCurrEduClsBL.GetObjByIdCurrEduCls(IdCurrEduCls);
                if (objCurrEduCls != null)
                {
                    CourseId = objCurrEduCls.CourseId;
                }


                var objQuestionnaire = clsQuestionnaireBL.GetObjByQuestionIdCache(QuestionId, CourseId);

                string strWhere = "QuestionId='" + QuestionId + "' and ExamBatchNo='" + ExamBatchNo + "' and UserId='" + UserId + "'";
                //通过参数获取UserAnswerResult对象
                clsUserAnswerResultEN objUserAnswerResult = clsUserAnswerResultBL.GetFirstObj_S(strWhere);
                clsge_StuBatchQuesRelaEN objge_StuBatchQuesRela = clsge_StuBatchQuesRelaBL.GetFirstObj_S(strWhere);
                if (objge_StuBatchQuesRela == null)
                {
                    string strMsg = string.Format("条件:{0}得到学生批次题目为空，请检查！", strWhere);
                    throw new Exception(strMsg);
                }
                clsge_GameLevelEN objge_GameLevel = clsge_GameLevelBL.GetObjByGameLevelIdCache(objge_StuBatchQuesRela.GameLevelId, objge_StuBatchQuesRela.CourseId);
                if (objge_GameLevel == null)
                {
                    string strMsg = string.Format("关键字:{0}获得的关卡对象为空，请检查！", objge_StuBatchQuesRela.GameLevelId);
                    throw new Exception(strMsg);
                }
                string strQuestionOptionId = "";

                switch (objQuestionnaire.QuestionTypeId)
                {
                    case enumQuestionType.SingleChoice_02://单选题
                        strQuestionOptionId = answerText;
                        if (objUserAnswerResult != null)
                        {
                            //修改，修改时需要判断问题选择项是否是正确答案、如果是正确答案 则需要把IsRight状态修改为true；
                            bolIsRight = GetQuestionAnswer(QuestionId, CourseId, strQuestionOptionId);

                            objUserAnswerResult.AnswerOptionId = strQuestionOptionId;
                            objUserAnswerResult.IsRight = bolIsRight;
                            if (bolIsRight == true)
                            {
                                //objUserAnswerResultAdd.Score = i;//后面在函数（Addge_UserCreditsLog）中计算分数
                                intQuestionScore_User = objge_GameLevel.QuestionScore ?? 0;
                                objUserAnswerResult.Score = objge_GameLevel.QuestionScore;
                            }
                            else
                            {
                                objUserAnswerResult.Score = 0;
                            }
                            clsUserAnswerResultBL.UpdateBySql2(objUserAnswerResult);
                            SetStuBatchQuestionScore(objge_StuBatchQuesRela, bolIsRight, intQuestionScore_User);

                            //如果MarkType==1；则不触发游戏冲关分数统计；等于2则调用；
                            //if (MarkType == "2")
                            //{
                            //    bool bolIsSumit = true;
                            //    bool ilog = Addge_UserCreditsLog(ExamBatchNo, bolIsSumit, UserId, IdCurrEduCls);
                            //}

                            bolIsExist = true;
                        }
                        else
                        {
                            //需要判断问题选择项是否是正确答案、如果是正确答案 则需要把IsRight状态修改为true；
                            bolIsRight = GetQuestionAnswer(QuestionId, CourseId, strQuestionOptionId);
                            //添加
                            clsUserAnswerResultEN objUserAnswerResultAdd = new clsUserAnswerResultEN();
                            objUserAnswerResultAdd.QuestionId = QuestionId;
                            objUserAnswerResultAdd.CourseId = CourseId;
                            objUserAnswerResultAdd.IdCurrEduCls = IdCurrEduCls;
                            objUserAnswerResultAdd.ExamBatchNo = ExamBatchNo;
                            objUserAnswerResultAdd.AnswerOptionId = strQuestionOptionId;
                            objUserAnswerResultAdd.IsRight = bolIsRight;
                            if (bolIsRight == true)
                            {
                                intQuestionScore_User = objge_GameLevel.QuestionScore ?? 0;
                                //objUserAnswerResultAdd.Score = i;//后面在函数（Addge_UserCreditsLog）中计算分数
                                objUserAnswerResultAdd.Score = objge_GameLevel.QuestionScore;
                            }
                            else
                            {
                                objUserAnswerResultAdd.Score = 0;
                            }
                            //objUserAnswerResultAdd.Score = i;//后面在函数（Addge_UserCreditsLog）中计算分数
                            objUserAnswerResultAdd.UserId = UserId;
                            objUserAnswerResultAdd.UpdUser = UserId;
                            objUserAnswerResultAdd.UpdDate = clsDateTime.getTodayDateTimeStr(0);

                            clsUserAnswerResultBL.AddNewRecordBySql2(objUserAnswerResultAdd);
                            SetStuBatchQuestionScore(objge_StuBatchQuesRela, bolIsRight, intQuestionScore_User);

                            //如果MarkType==1；则不触发游戏冲关分数统计；等于2则调用；
                            //if (MarkType == "2")
                            //{
                            //    bool bolIsSumit = true;
                            //    bool ilog = Addge_UserCreditsLog(ExamBatchNo, bolIsSumit, UserId, IdCurrEduCls);

                            //}

                            bolIsExist = true;
                        }
                        break;
                    case enumQuestionType.ShortAnswer_10://单选题

                        if (objUserAnswerResult != null)
                        {
                            //修改，修改时需要判断问题选择项是否是正确答案、如果是正确答案 则需要把IsRight状态修改为true；
                            //bolIsRight = GetQuestionAnswer(QuestionId, CourseId, QuestionOptionId);

                            //objUserAnswerResult.AnswerOptionId = QuestionOptionId;
                            //objUserAnswerResult.IsRight = bolIsRight;
                            objUserAnswerResult.AnswerText = answerText;
                            objUserAnswerResult.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            objUserAnswerResult.UserId = UserId;
                            clsUserAnswerResultBL.UpdateBySql2(objUserAnswerResult);
                            SetStuBatchQuestionScore(objge_StuBatchQuesRela, bolIsRight, intQuestionScore_User);

                            //如果MarkType==1；则不触发游戏冲关分数统计；等于2则调用；
                            //if (MarkType == "2")
                            //{
                            //    bool bolIsSumit = true;
                            //    bool ilog = Addge_UserCreditsLog(ExamBatchNo, bolIsSumit, UserId, IdCurrEduCls);
                            //}

                            bolIsExist = true;
                        }
                        else
                        {
                            //需要判断问题选择项是否是正确答案、如果是正确答案 则需要把IsRight状态修改为true；
                            //bolIsRight = GetQuestionAnswer(QuestionId, CourseId, QuestionOptionId);
                            //添加
                            clsUserAnswerResultEN objUserAnswerResultAdd = new clsUserAnswerResultEN();
                            objUserAnswerResultAdd.QuestionId = QuestionId;
                            objUserAnswerResultAdd.CourseId = CourseId;
                            objUserAnswerResultAdd.IdCurrEduCls = IdCurrEduCls;

                            objUserAnswerResultAdd.ExamBatchNo = ExamBatchNo;
                            objUserAnswerResultAdd.AnswerText = answerText;
                            //objUserAnswerResultAdd.IsRight = bolIsRight;
                            //objUserAnswerResultAdd.Score = i;//后面在函数（Addge_UserCreditsLog）中计算分数
                            objUserAnswerResultAdd.UserId = UserId;
                            objUserAnswerResultAdd.UpdUser = UserId;
                            objUserAnswerResultAdd.UpdDate = clsDateTime.getTodayDateTimeStr(0);

                            clsUserAnswerResultBL.AddNewRecordBySql2(objUserAnswerResultAdd);
                            SetStuBatchQuestionScore(objge_StuBatchQuesRela, bolIsRight, intQuestionScore_User);

                            //如果MarkType==1；则不触发游戏冲关分数统计；等于2则调用；
                            //if (MarkType == "2")
                            //{
                            //    bool bolIsSumit = true;
                            //    bool ilog = Addge_UserCreditsLog(ExamBatchNo, bolIsSumit, UserId, IdCurrEduCls);

                            //}

                            bolIsExist = true;
                        }
                        break;
                    case enumQuestionType.TrueorFalse_11://判断题
                        strQuestionOptionId = answerText;
                        if (objUserAnswerResult != null)
                        {
                            //修改，修改时需要判断问题选择项是否是正确答案、如果是正确答案 则需要把IsRight状态修改为true；
                            bolIsRight = GetQuestionAnswer(QuestionId, CourseId, strQuestionOptionId);

                            objUserAnswerResult.AnswerOptionId = strQuestionOptionId;
                            objUserAnswerResult.IsRight = bolIsRight;
                            if (bolIsRight == true)
                            {
                                intQuestionScore_User = objge_GameLevel.QuestionScore ?? 0;
                                //objUserAnswerResultAdd.Score = i;//后面在函数（Addge_UserCreditsLog）中计算分数
                                objUserAnswerResult.Score = objge_GameLevel.QuestionScore;
                            }
                            else
                            {
                                objUserAnswerResult.Score = 0;
                            }
                            clsUserAnswerResultBL.UpdateBySql2(objUserAnswerResult);
                            SetStuBatchQuestionScore(objge_StuBatchQuesRela, bolIsRight, intQuestionScore_User);

                            //如果MarkType==1；则不触发游戏冲关分数统计；等于2则调用；
                            //if (MarkType == "2")
                            //{
                            //    bool bolIsSumit = true;
                            //    bool ilog = Addge_UserCreditsLog(ExamBatchNo, bolIsSumit, UserId, IdCurrEduCls);
                            //}

                            bolIsExist = true;
                        }
                        else
                        {
                            //需要判断问题选择项是否是正确答案、如果是正确答案 则需要把IsRight状态修改为true；
                            bolIsRight = GetQuestionAnswer(QuestionId, CourseId, strQuestionOptionId);
                            //添加
                            clsUserAnswerResultEN objUserAnswerResultAdd = new clsUserAnswerResultEN();
                            objUserAnswerResultAdd.QuestionId = QuestionId;
                            objUserAnswerResultAdd.CourseId = CourseId;
                            objUserAnswerResultAdd.ExamBatchNo = ExamBatchNo;
                            objUserAnswerResultAdd.AnswerOptionId = strQuestionOptionId;
                            objUserAnswerResultAdd.IsRight = bolIsRight;
                            if (bolIsRight == true)
                            {
                                intQuestionScore_User = objge_GameLevel.QuestionScore ?? 0;
                                //objUserAnswerResultAdd.Score = i;//后面在函数（Addge_UserCreditsLog）中计算分数
                                objUserAnswerResultAdd.Score = objge_GameLevel.QuestionScore;
                            }
                            else
                            {
                                objUserAnswerResultAdd.Score = 0;
                            }
                            objUserAnswerResultAdd.UserId = UserId;
                            objUserAnswerResultAdd.UpdUser = UserId;
                            objUserAnswerResultAdd.UpdDate = clsDateTime.getTodayDateTimeStr(0);

                            clsUserAnswerResultBL.AddNewRecordBySql2(objUserAnswerResultAdd);
                            SetStuBatchQuestionScore(objge_StuBatchQuesRela, bolIsRight, intQuestionScore_User);

                            //如果MarkType==1；则不触发游戏冲关分数统计；等于2则调用；
                            //if (MarkType == "2")
                            //{
                            //    bool bolIsSumit = true;
                            //    bool ilog = Addge_UserCreditsLog(ExamBatchNo, bolIsSumit, UserId, IdCurrEduCls);

                            //}

                            bolIsExist = true;
                        }
                        break;
                    default:
                        clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(objQuestionnaire.QuestionTypeId);
                        string strMsg_QuestionType = string.Format("题目Id:{0}的题目类型:{1}({2})没有被处理，请检查！(in {3})",
                            QuestionId,
                            objQuestionTypeEN.QuestionTypeName, objQuestionTypeEN.QuestionTypeId, clsStackTrace.GetCurrClassFunction());
                        clsSysParaEN.objErrorLog.WriteDebugLog(strMsg_QuestionType);
                        throw new Exception(strMsg_QuestionType);
                }

                //错题集插入；
                //如果返回结果等于false 。那么说明答案错误，需要把数据插入到题目错题集表；
                if (bolIsExist == false)
                {
                    string strWhereStudent = "StuId='" + UserId + "'";
                    clsStudentInfoEN objStudentInfo = clsStudentInfoBL.GetFirstObj_S(strWhereStudent);
                    if (objStudentInfo != null)
                    {
                        clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLib = new clscc_WorkStuRelation4ErrorLibEN();
                        objcc_WorkStuRelation4ErrorLib.CourseId = CourseId;
                        objcc_WorkStuRelation4ErrorLib.IdStudentInfo = objStudentInfo.IdStudentInfo;
                        objcc_WorkStuRelation4ErrorLib.QuestionId = QuestionId;
                        objcc_WorkStuRelation4ErrorLib.Creator = UserId;
                        objcc_WorkStuRelation4ErrorLib.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        objcc_WorkStuRelation4ErrorLib.SourceTypeId = "04";//自动创建
                        objcc_WorkStuRelation4ErrorLib.IsRedo = false;
                        objcc_WorkStuRelation4ErrorLib.IsPassed = false;
                        objcc_WorkStuRelation4ErrorLib.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        objcc_WorkStuRelation4ErrorLib.UpdUser = UserId;
                        string strCondition = objcc_WorkStuRelation4ErrorLib.GetUniCondStr();
                        if (clscc_WorkStuRelation4ErrorLibBL.IsExistRecord(strCondition) == false)
                        {
                            clscc_WorkStuRelation4ErrorLibBL.AddNewRecordBySql2(objcc_WorkStuRelation4ErrorLib);
                        }
                        else
                        {
                            objcc_WorkStuRelation4ErrorLib.UpdateWithCondition(strCondition);
                        }
                    }
                }

                //掌握度比对
                bool bolUserMaster = clsge_KnowledgesUserMasterBLEx.CalcKnowledgesUserMaster(UserId, QuestionId, CourseId);
                if (bolUserMaster == true)
                {
                    bolIsExist = true;
                }


            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID获取出错:[{0}]。{1}. (In {2})",
                QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }


            return bolIsExist;
        }

        public static bool SetStuBatchQuestionScore(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRela, bool bolIsRight, int intQuestionScore_User)
        {
            objge_StuBatchQuesRela.IsRight = bolIsRight;
            objge_StuBatchQuesRela.Score = intQuestionScore_User;
            objge_StuBatchQuesRela.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objge_StuBatchQuesRela.Update();
            return true;
        }
        public static bool Score_UserAnswer(string MarkerId, string UserId, string strGameLevelId, string ExamBatchNo, long QuestionId, string IdCurrEduCls,
            float Score, bool Passed)
        {
            //bool bolIsExist = false;
            string CourseId = string.Empty;
            try
            {
                //根据教学班流水号 获取课程ID;
                clsCurrEduClsEN objCurrEduCls = clsCurrEduClsBL.GetObjByIdCurrEduCls(IdCurrEduCls);
                if (objCurrEduCls != null)
                {
                    CourseId = objCurrEduCls.CourseId;
                }

                var objQuestionnaire = clsQuestionnaireBL.GetObjByQuestionIdCache(QuestionId, CourseId);

                string strWhere = "QuestionId='" + QuestionId + "' and ExamBatchNo='" + ExamBatchNo + "' and UserId='" + UserId + "'";
                //通过参数获取UserAnswerResult对象
                clsUserAnswerResultEN objUserAnswerResult = clsUserAnswerResultBL.GetFirstObj_S(strWhere);
                clsge_StuBatchQuesRelaEN objge_StuBatchQuesRela = clsge_StuBatchQuesRelaBL.GetFirstObj_S(strWhere);

                //string strQuestionOptionId = "";
                switch (objQuestionnaire.QuestionTypeId)
                {
                    case enumQuestionType.SingleChoice_02://单选题
                        break;
                    case enumQuestionType.ShortAnswer_10://单选题

                        if (objUserAnswerResult != null)
                        {
                            //修改，修改时需要判断问题选择项是否是正确答案、如果是正确答案 则需要把IsRight状态修改为true；
                            //bolIsRight = GetQuestionAnswer(QuestionId, CourseId, QuestionOptionId);

                            //objUserAnswerResult.AnswerOptionId = QuestionOptionId;
                            objUserAnswerResult.IsRight = Passed;
                            objUserAnswerResult.Score = Score;
                            objUserAnswerResult.MarkerId = MarkerId;
                            objUserAnswerResult.IsMarking = true;
                            objUserAnswerResult.MarkTime = clsDateTime.getTodayDateTimeStr(0);
                            clsUserAnswerResultBL.UpdateBySql2(objUserAnswerResult);
                            //如果MarkType==1；则不触发游戏冲关分数统计；等于2则调用；

                            bool bolIsSumit = true;
                            bool ilog = clsge_UserCreditsLogBLEx.Addge_UserCreditsLog_Marker(strGameLevelId, ExamBatchNo, bolIsSumit, UserId, IdCurrEduCls);


                            //bolIsExist = true;
                        }
                        if (objge_StuBatchQuesRela != null)
                        {
                            //修改，修改时需要判断问题选择项是否是正确答案、如果是正确答案 则需要把IsRight状态修改为true；
                            //bolIsRight = GetQuestionAnswer(QuestionId, CourseId, QuestionOptionId);

                            //objUserAnswerResult.AnswerOptionId = QuestionOptionId;
                            objge_StuBatchQuesRela.IsRight = Passed;
                            objge_StuBatchQuesRela.Score = Score;
                            objge_StuBatchQuesRela.MarkerId = MarkerId;
                            objge_StuBatchQuesRela.IsMarking = true;
                            //objge_StuBatchQuesRela.MarkTime = clsDateTime.getTodayDateTimeStr(0);
                            clsge_StuBatchQuesRelaBL.UpdateBySql2(objge_StuBatchQuesRela);

                        }
                        break;
                    case enumQuestionType.TrueorFalse_11://判断题
                        break;
                    default:
                        clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(objQuestionnaire.QuestionTypeId);
                        string strMsg_QuestionType = string.Format("题目Id:{0}的题目类型:{1}({2})没有被处理，请检查！(in {3})",
                            QuestionId,
                            objQuestionTypeEN.QuestionTypeName, objQuestionTypeEN.QuestionTypeId, clsStackTrace.GetCurrClassFunction());
                        clsSysParaEN.objErrorLog.WriteDebugLog(strMsg_QuestionType);
                        throw new Exception(strMsg_QuestionType);
                }



                //错题集插入；
                //如果返回结果等于false 。那么说明答案错误，需要把数据插入到题目错题集表；
                if (Passed == false)
                {
                    string strWhereStudent = "StuId='" + UserId + "'";
                    clsStudentInfoEN objStudentInfo = clsStudentInfoBL.GetFirstObj_S(strWhereStudent);
                    if (objStudentInfo != null)
                    {
                        clscc_WorkStuRelation4ErrorLibEN objcc_WorkStuRelation4ErrorLib = new clscc_WorkStuRelation4ErrorLibEN();
                        objcc_WorkStuRelation4ErrorLib.CourseId = CourseId;
                        objcc_WorkStuRelation4ErrorLib.IdStudentInfo = objStudentInfo.IdStudentInfo;
                        objcc_WorkStuRelation4ErrorLib.QuestionId = QuestionId;
                        objcc_WorkStuRelation4ErrorLib.Creator = UserId;
                        objcc_WorkStuRelation4ErrorLib.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        objcc_WorkStuRelation4ErrorLib.SourceTypeId = "04";//自动创建
                        objcc_WorkStuRelation4ErrorLib.IsRedo = false;
                        objcc_WorkStuRelation4ErrorLib.IsPassed = false;
                        objcc_WorkStuRelation4ErrorLib.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        objcc_WorkStuRelation4ErrorLib.UpdUser = UserId;
                        string strCondition = objcc_WorkStuRelation4ErrorLib.GetUniCondStr();
                        if (clscc_WorkStuRelation4ErrorLibBL.IsExistRecord(strCondition) == false)
                        {
                            clscc_WorkStuRelation4ErrorLibBL.AddNewRecordBySql2(objcc_WorkStuRelation4ErrorLib);
                        }
                        else
                        {
                            objcc_WorkStuRelation4ErrorLib.UpdateWithCondition(strCondition);
                        }
                    }
                }

                //掌握度比对
                bool bolUserMaster = clsge_KnowledgesUserMasterBLEx.CalcKnowledgesUserMaster(UserId, QuestionId, CourseId);
                return true;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID获取出错:[{0}]。{1}. (In {2})",
                QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }


        //2、通过问题ID 查询问题答案表的正确答案，如果答案一致 则修改用户答案结果表的状态为true;IsRight;
        public static bool GetQuestionAnswer(long QuestionId, string CourseId, string QuestionOptionId)
        {
            bool bolIsRight = false;
            try
            {
                string strWhere = "QuestionId='" + QuestionId + "' And CourseId='" + CourseId + "'";
                //通过参数获取UserAnswerResult对象
                clsAnswerEN objAnswer = clsAnswerBL.GetFirstObj_S(strWhere);
                if (objAnswer == null)
                {
                    var objQuestionnaire = clsQuestionnaireBL.GetObjByQuestionIdCache(QuestionId, CourseId);
                    var objQuestionType = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(objQuestionnaire.QuestionTypeId);
                    string strMsg = string.Format("[{0}]({1}){2}--没有标准答案！", objQuestionType.QuestionTypeName,
                        objQuestionnaire.QuestionId, objQuestionnaire.QuestionName);
                    throw new Exception(strMsg);
                }
                //获取问题正确答案；
                if (objAnswer.AnswerOptionId == QuestionOptionId)
                {
                    bolIsRight = true;

                }
                else
                {
                    bolIsRight = false;
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("问题ID获取出错:[{0}]。{1}. (In {2})",
                QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }


            return bolIsRight;
        }


      

        public static bool IsHasAnswer_Cache(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRela)
        {
            //    var strThisFuncName = UserAnswerResultEx_GetObjByge_StuBatchQuesRela.name;
            string strMsg = "";
            string strAnswerText = "";
            try
            {
                if (objge_StuBatchQuesRela == null)
                {
                    strMsg = string.Format("(errid:Watl000307)根据学生批次问题表获取用户答案表时，源对象不能为空.(in {0})", clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                //通过批次号+用户 课程得到 做题结果表数据
                var strWhereCondition = string.Format("{0}='{1}' And {2}='{3}' and {4}='{5}'",
                    conUserAnswerResult.ExamBatchNo, objge_StuBatchQuesRela.ExamBatchNo,
                    conUserAnswerResult.UserId, objge_StuBatchQuesRela.UserId,
                    conUserAnswerResult.QuestionId, objge_StuBatchQuesRela.QuestionId
                );

                //获取获取题目库
                var arrUserAnswerResultObjLst = clsUserAnswerResultBL.GetObjLstCache(objge_StuBatchQuesRela.IdCurrEduCls);
                if (arrUserAnswerResultObjLst == null || arrUserAnswerResultObjLst.Count == 0)
                {
                    strMsg = string.Format("(errid:Wapi000306)教学班Id:[{0}]没有相应的用户答案.(in {1}.{2})",
                        objge_StuBatchQuesRela.IdCurrEduCls, clsStackTrace.GetCurrClassFunction());

                    return false;
                    //throw (strMsg);

                }
                var arrUserAnswerResultObjLst_Sel = arrUserAnswerResultObjLst.Where(x => x.ExamBatchNo == objge_StuBatchQuesRela.ExamBatchNo
                    && x.UserId == objge_StuBatchQuesRela.UserId
                    && x.QuestionId == objge_StuBatchQuesRela.QuestionId)
                    .ToList();
                if (arrUserAnswerResultObjLst_Sel.Count == 0)
                {
                    strMsg = string.Format("(errid:Wapi000307)题Id:[{0}],用户:[{1}], 批次:[{2}]没有相应的用户答案.(in {3})",
                        objge_StuBatchQuesRela.QuestionId, objge_StuBatchQuesRela.UserId, objge_StuBatchQuesRela.ExamBatchNo,
                        clsStackTrace.GetCurrClassFunction());

                    return false;
                    //throw (strMsg);

                }
                if (arrUserAnswerResultObjLst_Sel.Count > 1)
                {
                    strMsg = string.Format("(errid:Wapi000308)题Id:[{0}],用户:[{1}], 批次:[{2}]有多个相应的用户答案.(in {3})",
                        objge_StuBatchQuesRela.QuestionId, objge_StuBatchQuesRela.UserId, objge_StuBatchQuesRela.ExamBatchNo,
                        clsStackTrace.GetCurrClassFunction());

                    //throw (strMsg);
                    return false;
                }
                var objUserAnswerResult = arrUserAnswerResultObjLst_Sel[0];
                var strQuestionId = objge_StuBatchQuesRela.QuestionId;
                var objQuestion = clsQuestionnaireBL.GetObjByQuestionIdCache(strQuestionId, objge_StuBatchQuesRela.CourseId);
                if (objQuestion == null)
                {
                    strMsg = string.Format("根据问题Id:[{0}]获取相应的记录的对象为空.(in {1})",
                        strQuestionId, clsStackTrace.GetCurrClassFunction());

                    return false;
                    //throw (strMsg);
                }
                var strQuestionTypeId = objQuestion.QuestionTypeId;


                switch (strQuestionTypeId)
                {
                    case enumQuestionType.FillInBlank_01:
                        //填空题
                        //查找答案表获取答案数 得到ID ；
                        strAnswerText = objUserAnswerResult.AnswerText;
                        if (string.IsNullOrEmpty(strAnswerText) == true) return false;
                        return true;

                    case enumQuestionType.MultipleChoice_03:

                        //多选型
                        var answerMultiOption = objUserAnswerResult.AnswerMultiOption;
                        if (string.IsNullOrEmpty(answerMultiOption) == true) return false;
                        return true;

                    case enumQuestionType.ShortAnswer_10://简答题                    
                                                         //查找答案表获取答案数 得到ID ；
                        strAnswerText = objUserAnswerResult.AnswerText;
                        if (string.IsNullOrEmpty(strAnswerText) == true) return false;
                        return true;

                    case enumQuestionType.SingleChoice_02://单选题

                        //其他题型
                        var strAnswerOptionId = objUserAnswerResult.AnswerOptionId;
                        if (string.IsNullOrEmpty(strAnswerOptionId) == true) return false;
                        return true;

                    default:
                        var objQuestionType = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(strQuestionTypeId);
                        if (objQuestionType == null)
                        {
                            strMsg = string.Format("根据问题类型Id获取相应的记录的对象为空.(in {0})", clsStackTrace.GetCurrClassFunction());
                            return false;
                        }
                        strMsg = string.Format("问题类型:{0}({1})在Switch中没有被处理.(in {2})",
                            objQuestionType.QuestionTypeName, strQuestionTypeId, clsStackTrace.GetCurrClassFunction());

                        break;
                }//switch(strQuestionTypeId)

                return false;
            }
            catch (Exception e)
            {
                strMsg = string.Format("(errid:Watl000307)根据学生批次问题表获取用户答案表出错,{0}.(in {1})", e, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        public static clsUserAnswerResultEN GetObjByge_StuBatchQuesRela_Cache(clsge_StuBatchQuesRelaEN objge_StuBatchQuesRela)
        {
            //    var strThisFuncName = UserAnswerResultEx_GetObjByge_StuBatchQuesRela.name;
            string strMsg = "";
            //string strAnswerText = "";
            try
            {
                if (objge_StuBatchQuesRela == null)
                {
                    strMsg = string.Format("(errid:Watl000307)根据学生批次问题表获取用户答案表时，源对象不能为空.(in {0})", clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }

                //通过批次号+用户 课程得到 做题结果表数据
                var strWhereCondition = string.Format("{0}='{1}' And {2}='{3}' and {4}='{5}'",
                    conUserAnswerResult.ExamBatchNo, objge_StuBatchQuesRela.ExamBatchNo,
                    conUserAnswerResult.UserId, objge_StuBatchQuesRela.UserId,
                    conUserAnswerResult.QuestionId, objge_StuBatchQuesRela.QuestionId
                );

                //获取获取题目库
                var arrUserAnswerResultObjLst = clsUserAnswerResultBL.GetObjLstCache(objge_StuBatchQuesRela.IdCurrEduCls);
                if (arrUserAnswerResultObjLst == null || arrUserAnswerResultObjLst.Count == 0)
                {
                    strMsg = string.Format("(errid:Wapi000306)教学班Id:[{0}]没有相应的用户答案.(in {1}.{2})",
                        objge_StuBatchQuesRela.IdCurrEduCls, clsStackTrace.GetCurrClassFunction());

                    throw new Exception(strMsg);

                }
                var arrUserAnswerResultObjLst_Sel = arrUserAnswerResultObjLst.Where(x => x.ExamBatchNo == objge_StuBatchQuesRela.ExamBatchNo
                    && x.UserId == objge_StuBatchQuesRela.UserId
                    && x.QuestionId == objge_StuBatchQuesRela.QuestionId)
                    .ToList();
                if (arrUserAnswerResultObjLst_Sel.Count == 0)
                {
                    strMsg = string.Format("(errid:Wapi000307)题Id:[{0}],用户:[{1}], 批次:[{2}]没有相应的用户答案.(in {3})",
                        objge_StuBatchQuesRela.QuestionId, objge_StuBatchQuesRela.UserId, objge_StuBatchQuesRela.ExamBatchNo,
                        clsStackTrace.GetCurrClassFunction());


                    throw new Exception(strMsg);

                }
                if (arrUserAnswerResultObjLst_Sel.Count > 1)
                {
                    strMsg = string.Format("(errid:Wapi000308)题Id:[{0}],用户:[{1}], 批次:[{2}]有多个相应的用户答案.(in {3})",
                        objge_StuBatchQuesRela.QuestionId, objge_StuBatchQuesRela.UserId, objge_StuBatchQuesRela.ExamBatchNo,
                        clsStackTrace.GetCurrClassFunction());

                    throw new Exception(strMsg);
                }
                var objUserAnswerResult = arrUserAnswerResultObjLst_Sel[0];
                return objUserAnswerResult;
            }
            catch (Exception e)
            {
                strMsg = string.Format("(errid:Watl000307)根据学生批次问题表获取用户答案表出错,{0}.(in {1})", e, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

    }
}

