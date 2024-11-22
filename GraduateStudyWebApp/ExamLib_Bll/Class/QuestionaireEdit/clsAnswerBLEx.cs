using com.taishsoft.common;
using com.taishsoft.datetime;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace ExamLib.BusinessLogicEx
{
    public class clsAnswerBLEx : clsAnswerBL
    {
        ///
        ///根据QuestionId 获取 QuestionScore对象列表
        ///

        public static List<clsAnswerEN> GetObjLstByQuestionId_Cache(long strQuestionId)
        {
            if (clsAnswerENEx.arrAnswerObjLst == null || clsSysParaEN.bolIsNeedReloadAnswerObjLst == true)
            {
                clsAnswerENEx.arrAnswerObjLst = new clsAnswerDA().GetObjLst("1=1 order by AnswerIndex");
                clsSysParaEN.bolIsNeedReloadAnswerObjLst = false;
            }

            IEnumerable<clsAnswerEN> arrAnswerObjLst_Sel1 =
          from objAnswerEN in clsAnswerENEx.arrAnswerObjLst
          where objAnswerEN.QuestionId == strQuestionId
          select objAnswerEN;


            List<clsAnswerEN> arrAnswerObjLst_Sel = new List<clsAnswerEN>();
            foreach (clsAnswerEN obj in arrAnswerObjLst_Sel1)
            {
                arrAnswerObjLst_Sel.Add(obj);
            }
            //foreach (clsAnswerEN objAnswer in clsAnswerENEx.arrAnswerObjLst)
            //{

            //    if (objAnswer.QuestionId == strQuestionId)
            //    {

            //        arrAnswerLst.Add(objAnswer);
            //    }
            //}
            return arrAnswerObjLst_Sel;
        }
        /// <summary>
        /// 可以删除具有主外键关系外键表记录
        /// </summary>
        /// <param name="arrStdId"></param>
        /// <returns></returns>
        public static bool DelAnswersEx(ArrayList arrStdId)
        {
            try
            {
                bool bolResult = clsAnswerDAEx.DelAnswerEx(arrStdId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除多记录出错！\r\n" + objException.Message);
            }
        }
        public static int AnswerCount(long strQuestionId)
        {
            int intCount = clsAnswerDAEx.AnswerCount(strQuestionId);
            return intCount;
        }

        /// <summary>
        /// 为某题目的所有答案正确或者不正确
        /// </summary>
        /// <param name="strQuestionId">题目Id</param>
        /// <param name="bolIsCorrect">为True时正确，False时为不正确</param>
        /// <returns>设置的记录数</returns>
        public static int SetCorrectAnswer(long strQuestionId, bool bolIsCorrect)
        {
            int intCount = clsAnswerDAEx.SetCorrectAnswer(strQuestionId, bolIsCorrect);
            return intCount;
        }

        public static string GetAnswerResourceString(string strParentCtrlId, string strContent_Replace, long lngAnswerId, bool bolIsIE, clsLog objErrorLog)
        {
            clsContentTypeEN objContentTypeEN
                = clsContentTypeBLEx.GetContentTypeObjByTableNameAndFldName_Cache(clsAnswerEN._CurrTabName, conAnswer.AnswerContent);
            if (objContentTypeEN == null)
            {
                string strMsg = string.Format("该内容类型不存在！TabName={0}; FldName={1}(In {2})",
                    clsAnswerEN._CurrTabName, conAnswer.AnswerContent,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strCondition = string.Format(" {0}='{1}' And {2}='{3}' order by OrderNum",
                                         convtz_ContentAttachment.ContentTypeId, objContentTypeEN.ContentTypeId,
                                         convtz_ContentAttachment.TableNameKey, lngAnswerId);
            List<clsvtz_ContentAttachmentEN> arrvcc_AttachmentObjLst = clsvtz_ContentAttachmentBL.GetObjLst(strCondition);
            int intTotalContentHeight = 0;
            string strParentName = string.Format("{0}_{1}_{2}", strParentCtrlId, objContentTypeEN.ContentTypeId, lngAnswerId);
            if (arrvcc_AttachmentObjLst.Count > 0)
            {
                //获取缩略图
                string strThumbnailString = clstz_ContentAttachmentBLEx.GetShowExtResourceString(arrvcc_AttachmentObjLst,
                    true, false, objErrorLog, false, strParentName, bolIsIE, ref intTotalContentHeight);
                return strThumbnailString;
            }
            else
            {
                return strContent_Replace;
            }
        }
        /// <summary>
        /// 显示该题目正确的答案
        /// </summary>
        /// <param name="objQuestionnaireEN"></param>
        /// <param name="lblRightAnswer"></param>
        public static void ShowRightAnswer(clsQuestionnaireEN objQuestionnaireEN,
                        List<clsAnswerEN> arrAnswerENObjLst,
                        Literal litRightAnswer, bool bolIsIE, clsLog objErrorLog)
        {
            StringBuilder sbRightAnswer = new StringBuilder();
            int intRightAnswerNum = 0;
            switch (objQuestionnaireEN.AnswerTypeId)
            {

                case "01"://复选框
                    foreach (clsAnswerEN objAnswerEN in arrAnswerENObjLst)
                    {
                        if (string.IsNullOrEmpty(objAnswerEN.AnswerMultiOptions) == true) continue;
                        try
                        {
                            string[] sstrOptionIds = objAnswerEN.AnswerMultiOptions.Split(',');
                            foreach (string strOptionId in sstrOptionIds)
                            {
                                clsQuestionOptionsEN objQuestionOptionsEN = clsQuestionOptionsBL.GetObjByQuestionOptionId(strOptionId);
                                if (objQuestionOptionsEN != null)
                                {
                                    intRightAnswerNum++;
                                    sbRightAnswer.AppendFormat("{0}. {1}; ", intRightAnswerNum, objQuestionOptionsEN.OptionName);
                                }
                            }
                        }
                        catch (Exception objException)
                        {
                            string strMsg = string.Format("错误是：[{0}]({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                        }
                    }
                    break;

                case "02"://单选框
                case "05":// 下拉框                  
                    foreach (clsAnswerEN objAnswerEN in arrAnswerENObjLst)
                    {
                        if (objQuestionnaireEN.QuestionTypeId == enumQuestionType.TrueorFalse_11)
                        {
                            intRightAnswerNum++;
                            sbRightAnswer.AppendFormat("{0}. {1}; ", intRightAnswerNum, objAnswerEN.AnswerTrueOrFalse);
                            continue;
                        }
                        if (string.IsNullOrEmpty(objAnswerEN.AnswerOptionId) == true) continue;
                        try
                        {
                            clsQuestionOptionsEN objQuestionOptionsEN = clsQuestionOptionsBL.GetObjByQuestionOptionId(objAnswerEN.AnswerOptionId);
                            if (objQuestionOptionsEN != null)
                            {
                                intRightAnswerNum++;
                                sbRightAnswer.AppendFormat("{0}. {1}; ", intRightAnswerNum, objQuestionOptionsEN.OptionName);
                            }
                        }
                        catch (Exception objException)
                        {
                            string strMsg = string.Format("错误是：[{0}]({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                        }
                    }
                    break;

                case "03": //文本框                    
                case "06": // 通行文本框
                    foreach (clsAnswerEN objAnswerEN in arrAnswerENObjLst)
                    {
                        intRightAnswerNum++;
                        string strRightAnswerString = clsAnswerBLEx.GetAnswerResourceString(litRightAnswer.ClientID, objAnswerEN.AnswerContent, objAnswerEN.AnswerId, bolIsIE, objErrorLog);

                        sbRightAnswer.AppendFormat("{0}. {1}; ", intRightAnswerNum, strRightAnswerString);
                    }
                    break;
            }

            if (intRightAnswerNum == 0)
            {
                //litRightAnswer.CssClass = "ErrMsg";
                litRightAnswer.Text = "无正确答案！";
            }
            else
            {
                litRightAnswer.Text = string.Format("<span class='topTitle2' style='Color:Red'>{0}</span>: <span class='topContent2'>{1}</span>",
                    "正确答案", sbRightAnswer.ToString());
            }
        }

        /// <summary>
        /// 设置问题的标准答案
        /// </summary>
        /// <param name="strQuestionId"></param>
        /// <param name="strAnswer"></param>
        /// <param name="strCourseId"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool SetQuestionAnswer(long strQuestionId, string strAnswer, string strCourseId, string strOpUser)
        {
            clsQuestionnaireEN objQuestionnaireEN = clsQuestionnaireBL.GetObjByQuestionIdCache(strQuestionId, strCourseId);
            var objAnswer = new clsAnswerEN();
            objAnswer.QuestionId = strQuestionId;
            objAnswer.AnswerIndex = 1;
            objAnswer.CourseId = strCourseId;
            switch (objQuestionnaireEN.QuestionTypeId)
            {
                case enumQuestionType.FillInBlank_01://01	填空题	0002	03	True	1	20150531015902	20150531015902	填空
                    objAnswer.AnswerFillInBlank = strAnswer;
                    objAnswer.IsAutoCorrect = true;
                    break;
                case enumQuestionType.OpenQuestion_04://04	开放题	0002	03	True	8	20150531111909	t1	开放题
                case enumQuestionType.AnswerQuestions_05://05	解答题	0002	03	True	6	20150531111851	t1	解答
                case enumQuestionType.CaseAnysisMultiChoice_12://12	计算题	0002	03	True	6	20150531111851	t1	解答

                    objAnswer.AnswerContent = strAnswer;
                    objAnswer.IsAutoCorrect = false;
                    break;
                case enumQuestionType.OperationQuestions_09://09	操作题	0002	03	True	7	20150531111859	t1	
                case enumQuestionType.ShortAnswer_10://10	简答题	0002	06	True	5	20150531111841	t1	需要简单论述回答的题目。
                    objAnswer.AnswerContent = strAnswer;
                    objAnswer.IsAutoCorrect = false;
                    break;

                case enumQuestionType.Title_06://06	标题	0000	04	True	9	20150531111918	t1	用于显示标题,不作为问卷内容。
                case enumQuestionType.ExplanatoryContent_07://07	说明性内容	0000	04	True	10	20150531111927	t1	说明性内容,不作为问卷内容
                    break;
                case enumQuestionType.SingleChoice_DropDownBox_08://单选题（下拉框）
                    objAnswer.AnswerTrueOrFalse = bool.Parse(strAnswer);
                    objAnswer.IsAutoCorrect = true;
                    break;
                case enumQuestionType.SingleChoice_02:  //02	单选题	0001	02	True	3	20150531111828	t1	单选题
                    objAnswer.AnswerOptionId = strAnswer;
                    objAnswer.IsAutoCorrect = true;
                    break;
                case enumQuestionType.MultipleChoice_03:  //02	单选题	0001	02	True	3	20150531111828	t1	单选题
                    objAnswer.AnswerMultiOptions = strAnswer;
                    objAnswer.IsAutoCorrect = true;
                    break;
                case enumQuestionType.TrueorFalse_11:   //11	判断题	0001	02	True	2	20150531111819	t1	用于判断描述是否正确的题目
                    objAnswer.AnswerTrueOrFalse = bool.Parse(strAnswer);
                    objAnswer.IsAutoCorrect = true;
                    break;
                default:
                    clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(objQuestionnaireEN.QuestionTypeId);

                    string strMsg = string.Format("题号:{0}的题型:{1}({2})在函数:[GetQuestionAnswerLstBy1Paper]中没有被处理，请检查！({3})",
                        objQuestionnaireEN.QuestionIndex,
                        objQuestionTypeEN.QuestionTypeName, objQuestionTypeEN.QuestionTypeId,
                        clsStackTrace.GetCurrClassFunction());

                    throw new Exception(strMsg);
            }//  switch (objvcc_CourseExamPaperRelationshipEN.QuestionTypeId)
            objAnswer.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objAnswer.UpdUser = strOpUser;
            string strUniCondition = objAnswer.GetUniCondStr();
            if (clsAnswerBL.IsExistRecord(strUniCondition) == true)
            {
                objAnswer.UpdateWithCondition(strUniCondition);
            }
            else
            {
                objAnswer.AddNewRecord();
            }
            return true;
        }

    }
}
