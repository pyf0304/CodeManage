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
        ///����QuestionId ��ȡ QuestionScore�����б�
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
        /// ����ɾ�������������ϵ������¼
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
                throw new Exception("ɾ�����¼����\r\n" + objException.Message);
            }
        }
        public static int AnswerCount(long strQuestionId)
        {
            int intCount = clsAnswerDAEx.AnswerCount(strQuestionId);
            return intCount;
        }

        /// <summary>
        /// Ϊĳ��Ŀ�����д���ȷ���߲���ȷ
        /// </summary>
        /// <param name="strQuestionId">��ĿId</param>
        /// <param name="bolIsCorrect">ΪTrueʱ��ȷ��FalseʱΪ����ȷ</param>
        /// <returns>���õļ�¼��</returns>
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
                string strMsg = string.Format("���������Ͳ����ڣ�TabName={0}; FldName={1}(In {2})",
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
                //��ȡ����ͼ
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
        /// ��ʾ����Ŀ��ȷ�Ĵ�
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

                case "01"://��ѡ��
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
                            string strMsg = string.Format("�����ǣ�[{0}]({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                        }
                    }
                    break;

                case "02"://��ѡ��
                case "05":// ������                  
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
                            string strMsg = string.Format("�����ǣ�[{0}]({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                        }
                    }
                    break;

                case "03": //�ı���                    
                case "06": // ͨ���ı���
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
                litRightAnswer.Text = "����ȷ�𰸣�";
            }
            else
            {
                litRightAnswer.Text = string.Format("<span class='topTitle2' style='Color:Red'>{0}</span>: <span class='topContent2'>{1}</span>",
                    "��ȷ��", sbRightAnswer.ToString());
            }
        }

        /// <summary>
        /// ��������ı�׼��
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
                case enumQuestionType.FillInBlank_01://01	�����	0002	03	True	1	20150531015902	20150531015902	���
                    objAnswer.AnswerFillInBlank = strAnswer;
                    objAnswer.IsAutoCorrect = true;
                    break;
                case enumQuestionType.OpenQuestion_04://04	������	0002	03	True	8	20150531111909	t1	������
                case enumQuestionType.AnswerQuestions_05://05	�����	0002	03	True	6	20150531111851	t1	���
                case enumQuestionType.CaseAnysisMultiChoice_12://12	������	0002	03	True	6	20150531111851	t1	���

                    objAnswer.AnswerContent = strAnswer;
                    objAnswer.IsAutoCorrect = false;
                    break;
                case enumQuestionType.OperationQuestions_09://09	������	0002	03	True	7	20150531111859	t1	
                case enumQuestionType.ShortAnswer_10://10	�����	0002	06	True	5	20150531111841	t1	��Ҫ�������ش����Ŀ��
                    objAnswer.AnswerContent = strAnswer;
                    objAnswer.IsAutoCorrect = false;
                    break;

                case enumQuestionType.Title_06://06	����	0000	04	True	9	20150531111918	t1	������ʾ����,����Ϊ�ʾ����ݡ�
                case enumQuestionType.ExplanatoryContent_07://07	˵��������	0000	04	True	10	20150531111927	t1	˵��������,����Ϊ�ʾ�����
                    break;
                case enumQuestionType.SingleChoice_DropDownBox_08://��ѡ�⣨������
                    objAnswer.AnswerTrueOrFalse = bool.Parse(strAnswer);
                    objAnswer.IsAutoCorrect = true;
                    break;
                case enumQuestionType.SingleChoice_02:  //02	��ѡ��	0001	02	True	3	20150531111828	t1	��ѡ��
                    objAnswer.AnswerOptionId = strAnswer;
                    objAnswer.IsAutoCorrect = true;
                    break;
                case enumQuestionType.MultipleChoice_03:  //02	��ѡ��	0001	02	True	3	20150531111828	t1	��ѡ��
                    objAnswer.AnswerMultiOptions = strAnswer;
                    objAnswer.IsAutoCorrect = true;
                    break;
                case enumQuestionType.TrueorFalse_11:   //11	�ж���	0001	02	True	2	20150531111819	t1	�����ж������Ƿ���ȷ����Ŀ
                    objAnswer.AnswerTrueOrFalse = bool.Parse(strAnswer);
                    objAnswer.IsAutoCorrect = true;
                    break;
                default:
                    clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(objQuestionnaireEN.QuestionTypeId);

                    string strMsg = string.Format("���:{0}������:{1}({2})�ں���:[GetQuestionAnswerLstBy1Paper]��û�б��������飡({3})",
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
