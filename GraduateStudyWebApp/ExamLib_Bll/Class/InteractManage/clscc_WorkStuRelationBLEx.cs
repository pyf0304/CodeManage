using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
 
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace ExamLib.BusinessLogicEx
{
    public class clscc_WorkStuRelationBLEx
    {
        /// <summary>
        /// 获取学生需要完成的作业关键字列表
        /// </summary>
        /// <param name="strid_StudentInfo"></param>
        /// <param name="stridCurrEduCls"></param>
        /// <returns></returns>
        public static List<string> GetAllQuestion4Finish(
                    string strid_StudentInfo,
                    string stridCurrEduCls,
                    string strQuestionTypeId4Course = "")
        {
            string strCondition = "";
            if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true)
            {
                strCondition = string.Format(" {0}='1' And {1}='{2}' And {3}='{4}' order by {5}",
                      concc_WorkStuRelation.IsPublish,
                        concc_WorkStuRelation.IdCurrEduCls, stridCurrEduCls,
                    concc_WorkStuRelation.IdStudentInfo,
                    strid_StudentInfo, convcc_WorkStuRelation.QuestionIndex);
            }
            else
            {
                strCondition = string.Format(" {0}='1' And {1}='{2}' And {3}='{4}' and {5}='{6}' order by {7}",
                     concc_WorkStuRelation.IsPublish,
                       concc_WorkStuRelation.IdCurrEduCls, stridCurrEduCls,
                   concc_WorkStuRelation.IdStudentInfo, strid_StudentInfo,
                   convcc_WorkStuRelation.QuestionTypeId4Course, strQuestionTypeId4Course,
                   convcc_WorkStuRelation.QuestionIndex);
            }
            List<string> arrKeyId = clsvcc_WorkStuRelationBL.GetPrimaryKeyID_S(strCondition);
            return arrKeyId;
        }
        /// <summary>
        /// 获取前一条记录
        /// </summary>
        /// <param name="arrKeyId"></param>
        /// <param name="strId_WorkStuRelation"></param>
        /// <returns></returns>
        public static string GetPreviousQuestion(List<string> arrKeyId,
            string strId_WorkStuRelation)
        {
            int intCount = arrKeyId.Count;
            int intPos = -1;
            for (int i = 0; i < intCount; i++)
            {
                if (arrKeyId[i] == strId_WorkStuRelation)
                {
                    intPos = i;
                    break;
                }
            }
            if (intPos == 0)
            {
                return "";
            }
            return arrKeyId[intPos - 1];
        }

        /// <summary>
        /// 获取前一条记录
        /// </summary>
        /// <param name="arrKeyId"></param>
        /// <param name="strId_WorkStuRelation"></param>
        /// <returns></returns>
        public static string GetNextQuestion(List<string> arrKeyId,
            string strId_WorkStuRelation)
        {
            int intCount = arrKeyId.Count;
            int intPos = -1;
            for (int i = 0; i < intCount; i++)
            {
                if (arrKeyId[i] == strId_WorkStuRelation)
                {
                    intPos = i;
                    break;
                }
            }
            if (intPos == intCount - 1)
            {
                return "";
            }
            return arrKeyId[intPos + 1];
        }


        /// <summary>
        /// 汇总学生作业完成情况
        /// </summary>
        /// <param name="strid_StudentInfo"></param>
        /// <param name="stridCurrEduCls"></param>
        /// <param name="strUserId">学生流水号</param>
        /// <returns></returns>
        public static bool p_Calc_cc_WorkStuRelation_Total(
string strid_StudentInfo,
string stridCurrEduCls,
//string strSchoolYear,
//string strSchoolTerm,
string strUserId)
        {
            //            PROCEDURE[dbo].[p_Calc_cc_WorkStuRelation_Total]
            //(@IdCurrEduCls char(8),
            //@IdStudentInfo char(8),
            //@SchoolYear varchar(10),
            //@SchoolTerm char(1),
            //--@Analyst varchar(20),
            //@UserId varchar(20)
            //)
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
            ArrayList values = new ArrayList();
            values.Add(stridCurrEduCls);
            values.Add(strid_StudentInfo);

            //values.Add(strSchoolYear);
            //values.Add(strSchoolTerm);
            values.Add(strUserId);

            objSQL.ExecSP2("p_Calc_cc_WorkStuRelation_Total", values, 2400);
            return true;
        }

        /// <summary>
        /// 汇总学生作业完成情况
        /// </summary>
        /// <param name="strid_StudentInfo"></param>
        /// <param name="stridCurrEduCls"></param>
        /// <param name="strUserId">学生流水号</param>
        /// <returns></returns>
        public static bool p_Calc_cc_WorkStuRelation_TotalByQuType(
string strid_StudentInfo,
string stridCurrEduCls,
string strQuestionTypeId,
string strUserId)
        {
            //            PROCEDURE[dbo].[p_Calc_cc_WorkStuRelation_Total]
            //(@IdCurrEduCls char(8),
            //@IdStudentInfo char(8),
            //@SchoolYear varchar(10),
            //@SchoolTerm char(1),
            //--@Analyst varchar(20),
            //@UserId varchar(20)
            //)
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
            ArrayList values = new ArrayList();
            values.Add(stridCurrEduCls);
            values.Add(strid_StudentInfo);
            values.Add(strQuestionTypeId);
            values.Add(strUserId);

            objSQL.ExecSP2("p_Calc_cc_WorkStuRelation_TotalByQuType", values, 2400);
            return true;
        }
        /// <summary>
        /// 汇总学生作业完成情况
        /// </summary>
        /// <param name="strid_StudentInfo"></param>
        /// <param name="stridCurrEduCls"></param>
        /// <param name="strUserId">学生流水号</param>
        /// <returns></returns>
        public static bool p_Calc_cc_WorkStuRelation_TotalByQuType4Course(
string strid_StudentInfo,
string stridCurrEduCls,
string strQuestionTypeId,
string strQuestionTypeId4Course,
string strUserId)
        {
            //            PROCEDURE[dbo].[p_Calc_cc_WorkStuRelation_Total]
            //(@IdCurrEduCls char(8),
            //@IdStudentInfo char(8),
            //@SchoolYear varchar(10),
            //@SchoolTerm char(1),
            //--@Analyst varchar(20),
            //@UserId varchar(20)
            //)
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clscc_ExamPaperStuRelationDA.GetSpecSQLObj();
            ArrayList values = new ArrayList();
            values.Add(stridCurrEduCls);
            values.Add(strid_StudentInfo);
            values.Add(strQuestionTypeId);
            values.Add(strQuestionTypeId4Course);
            values.Add(strUserId);

            objSQL.ExecSP2("p_Calc_cc_WorkStuRelation_TotalByQuType4Course", values, 2400);
            return true;
        }

        /// <summary>
        /// 汇总一个教学班中学生作业完成情况
        /// </summary>
        /// <param name="stridCurrEduCls"></param>   
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static bool cc_WorkStuRelation_Total(string stridCurrEduCls,
string strUserId)
        {
            string strCondition = string.Format("{0}='{1}'", conCurrEduClsStu.IdCurrEduCls, stridCurrEduCls);
            List<string> arrId_StudentInfo = clsCurrEduClsStuBL.GetFldValue(conCurrEduClsStu.IdStu, strCondition);
            foreach (string strId_StudentInfo in arrId_StudentInfo)
            {
                try
                {
                    p_Calc_cc_WorkStuRelation_Total(strId_StudentInfo, stridCurrEduCls, strUserId);
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }
            return true;
        }

        /// <summary>
        /// 汇总一个教学班中学生作业完成情况
        /// </summary>
        /// <param name="stridCurrEduCls"></param>   
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static bool cc_WorkStuRelation_TotalByQuType(string stridCurrEduCls,
string strUserId)
        {
            string strCondition = string.Format("{0}='{1}'", conCurrEduClsStu.IdCurrEduCls, stridCurrEduCls);
            List<string> arrId_StudentInfo = clsCurrEduClsStuBL.GetFldValue(conCurrEduClsStu.IdStu, strCondition);
            List<clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlLst = clsvcc_WorkStuRelationTtlBL.GetObjLst(strCondition);

            foreach (string strId_StudentInfo in arrId_StudentInfo)
            {
                try
                {
                    List<clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlLst4Stu =
                        arrvcc_WorkStuRelationTtlLst.FindAll(item => item.IdStudentInfo == strId_StudentInfo);

                    foreach (clsvcc_WorkStuRelationTtlEN objInFor in arrvcc_WorkStuRelationTtlLst4Stu)
                    {
                        if (string.IsNullOrEmpty(objInFor.QuestionTypeId4Course) == false)
                        {
                            p_Calc_cc_WorkStuRelation_TotalByQuType4Course(strId_StudentInfo,
                                stridCurrEduCls, objInFor.QuestionTypeId, objInFor.QuestionTypeId4Course, strUserId);
                        }
                        else
                        {
                            p_Calc_cc_WorkStuRelation_TotalByQuType(strId_StudentInfo,
                                stridCurrEduCls, objInFor.QuestionTypeId, strUserId);

                        }
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }
            return true;
        }


        /// <summary>
        /// 删除在当前教学班中不存在的学生数据
        /// </summary>
        /// <param name="stridCurrEduCls"></param>
        /// <returns></returns>
        public static int DeleteRemainData4Work(string stridCurrEduCls)
        {
            string strCondition = string.Format(" {5}='0' And {0}='{1}' And {2} not in (Select {3} From {4} Where {0}='{1}')",
                concc_WorkStuRelation.IdCurrEduCls, stridCurrEduCls,
                concc_WorkStuRelation.IdStudentInfo,
                conCurrEduClsStu.IdStu,
                clsCurrEduClsStuEN._CurrTabName,
                concc_WorkStuRelation.IsSubmit);
            return clscc_WorkStuRelationBL.Delcc_WorkStuRelationsByCond(strCondition);

        }


        /// <summary>
        /// 获取用户单个题目的答案
        /// </summary>
        /// <param name="strQuestionId">题目Id</param>
        /// <param name="strUserId">用户Id</param>
        /// <returns>获取的解题答案</returns>
        public static clscc_WorkStuRelationEN GetRetultByUserIdAndQuestionId(long strQuestionId, string strId_StudentInfo)
        {
            string strCondition = string.Format("{0}='{1}' And {2}='{3}'",
                concc_WorkStuRelation.IdWorkStuRelation, strQuestionId,
                concc_WorkStuRelation.IdStudentInfo, strId_StudentInfo);

            try
            {
                clscc_WorkStuRelationEN objcc_WorkStuRelation = clscc_WorkStuRelationBL.GetFirstObj_S(strCondition);
                return objcc_WorkStuRelation;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取用户的单题回答结果出错！出错信息：{0}.({1})",
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        public static string Getcc_WorkStuRelationResourceString(string strContent_Replace, long lngId_WorkStuRelation, bool bolIsIE, clsLog objErrorLog)
        {
            clsContentTypeEN objContentTypeEN = clsContentTypeBLEx.GetContentTypeObjByTableNameAndFldName_Cache(
                clscc_WorkStuRelationEN._CurrTabName, concc_WorkStuRelation.StuAnswerText);

            if (objContentTypeEN == null)
            {
                string strMsg = string.Format("该内容类型不存在！TabName={0}; FldName={1}(In {2})",
                    clscc_WorkStuRelationEN._CurrTabName, concc_WorkStuRelation.StuAnswerText,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            string strCondition = string.Format(" {0}='{1}' And {2}='{3}' order by OrderNum",
                                         convtz_ContentAttachment.ContentTypeId, objContentTypeEN.ContentTypeId,
                                         convtz_ContentAttachment.TableNameKey, lngId_WorkStuRelation);
            List<clsvtz_ContentAttachmentEN> arrvcc_AttachmentObjLst = clsvtz_ContentAttachmentBL.GetObjLst(strCondition);
            int intTotalContentHeight = 0;
            string strParentName = string.Format("{0}_{1}", objContentTypeEN.ContentTypeId, lngId_WorkStuRelation);
            if (arrvcc_AttachmentObjLst.Count > 0)
            {
                //获取缩略图
                string strThumbnailString = clstz_ContentAttachmentBLEx.GetShowExtResourceString(arrvcc_AttachmentObjLst, true, false, objErrorLog, false, strParentName, bolIsIE, ref intTotalContentHeight);
                return strThumbnailString;
            }
            else
            {
                return strContent_Replace;
                //trAttachment_Pic.Visible = false;
                //trAttachment.Visible = false;
            }
        }
        /// <summary>
        /// 显示用户的答案
        /// </summary>
        /// <param name="objQuestionnaireEN"></param>
        /// <param name="lblRightAnswer"></param>
        public static void ShowUserAnswer(clsQuestionnaireEN objQuestionnaireEN, string strIdStu,
            Label lblUserAnswer, RadioButtonList rblQuestionOptions, DropDownList ddlQuestionOptions,
            bool bolIsIE,
            clsLog objErrorLog)
        {
            if (string.IsNullOrEmpty(strIdStu) == true)
            {
                string strMsg = string.Format("学生流水号（Id_Stu）不能为空！");
                throw new Exception(strMsg);
            }
            StringBuilder sbRightAnswer = new StringBuilder();
            int intUserAnswerNum = 0;
            clscc_WorkStuRelationEN objcc_WorkStuRelation =
                clscc_WorkStuRelationBLEx.GetRetultByUserIdAndQuestionId(objQuestionnaireEN.QuestionId, strIdStu);
            if (objcc_WorkStuRelation == null)
            {
                lblUserAnswer.CssClass = "ErrMsg";
                lblUserAnswer.Text = "无用户答案！";
                return;
            }
            clsQuestionOptionsEN objQuestionOptionsEN = null;
            switch (objQuestionnaireEN.AnswerTypeId)
            {

                case "01"://复选框
                    if (string.IsNullOrEmpty(objcc_WorkStuRelation.AnswerMultiOptions) == true)
                    {
                        break;
                    }

                    string[] sstrOptionIds = objcc_WorkStuRelation.AnswerMultiOptions.Split(',');
                    foreach (string strOptionId in sstrOptionIds)
                    {
                        if (string.IsNullOrEmpty(strOptionId) == true)
                        {
                            continue;
                        }

                        objQuestionOptionsEN = clsQuestionOptionsBL.GetObjByQuestionOptionId(strOptionId);

                        //clsQuestionOptionsEN objQuestionOptionsEN = clsQuestionOptionsBL.GetObjByQuestionOptionId(objcc_WorkStuRelation.AnswerOptionId);
                        if (objQuestionOptionsEN != null)
                        {
                            intUserAnswerNum++;
                            sbRightAnswer.AppendFormat("{0}. {1}; ", intUserAnswerNum, objQuestionOptionsEN.OptionName);
                        }
                    }
                    break;

                case "02"://单选框
                case "05":// 下拉框                  
                    if (string.IsNullOrEmpty(objcc_WorkStuRelation.AnswerOptionId) == true)
                    {
                        break;
                    }

                    if (objQuestionnaireEN.QuestionTypeId == enumQuestionType.TrueorFalse_11)
                    {
                        sbRightAnswer.AppendFormat("{0}. {1}; ", intUserAnswerNum, objcc_WorkStuRelation.AnswerOptionId);
                        break;
                    }
                    objQuestionOptionsEN = clsQuestionOptionsBL.GetObjByQuestionOptionId(objcc_WorkStuRelation.AnswerOptionId);
                    if (objQuestionOptionsEN != null)
                    {
                        intUserAnswerNum++;
                        sbRightAnswer.AppendFormat("{0}. {1}; ", intUserAnswerNum, objQuestionOptionsEN.OptionName);
                    }

                    break;

                case "03": //文本框                    
                case "06": // 通行文本框

                    intUserAnswerNum++;

                    string strQuestionnaireResourceString = clscc_WorkStuRelationBLEx.Getcc_WorkStuRelationResourceString(objcc_WorkStuRelation.StuAnswerText,
                        objcc_WorkStuRelation.IdWorkStuRelation, bolIsIE, objErrorLog);
                    sbRightAnswer.AppendFormat("{1}", intUserAnswerNum, strQuestionnaireResourceString);


                    break;
            }
            switch (objQuestionnaireEN.AnswerTypeId)
            {

                case "01"://复选框
                    if (string.IsNullOrEmpty(objcc_WorkStuRelation.AnswerMultiOptions) == true)
                    {
                        break;
                    }

                    string[] sstrOptionIds = objcc_WorkStuRelation.AnswerMultiOptions.Split(',');
                    foreach (string strOptionId in sstrOptionIds)
                    {
                        if (string.IsNullOrEmpty(strOptionId) == true)
                        {
                            continue;
                        }

                        objQuestionOptionsEN = clsQuestionOptionsBL.GetObjByQuestionOptionId(strOptionId);
                        if (objQuestionOptionsEN != null)
                        {
                            intUserAnswerNum++;
                            sbRightAnswer.AppendFormat("{0} ", objQuestionOptionsEN.OptionName);
                        }
                    }
                    break;

                case "02"://单选框
                    try
                    {
                        rblQuestionOptions.SelectedValue = objcc_WorkStuRelation.AnswerOptionId;
                    }
                    catch 
                    {
                        //clsPubVar4BLEx_Local.objErrorLog.WriteDebugLog(objException.Message);
                    }
                    break;
                case "05":// 下拉框  
                    try
                    {
                        ddlQuestionOptions.SelectedValue = objcc_WorkStuRelation.AnswerOptionId;
                    }
                    catch 
                    {
                        //clsPubVar4BLEx_Local.objErrorLog.WriteDebugLog(objException.Message);
                    }
                    break;

                case "03": //文本框                    
                case "06": // 通行文本框
                    break;
            }

            lblUserAnswer.Text = string.Format("<span class='topContent2'>{0}</span>",
                sbRightAnswer.ToString());

        }
        /// <summary>
        /// 针对一套试卷或者习题的用户答案
        /// </summary>
        /// <returns></returns>
        public static clscc_WorkStuRelationEN GetUserAnswerLstBy1Paper(long strQuestionId,
            TextBox txtStuAnswerText, DropDownList ddlQuestionOptions, CheckBoxList chkQuestionOption, RadioButtonList rblQuestionOptions,
            clsLog objErrorLog)
        {
            StringBuilder sbMsg = new StringBuilder();
            bool bolIsExistError = false;
            //string strHidQLst = hidHiddenQuestionList.Value;
            //string[] arrHidQLst = strHidQLst.Split(',');

            //List<clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLst = new List<clscc_WorkStuRelationEN>();
            //List<clsvcc_CourseExamPaperRelationshipEN> arrvcc_CourseExamPaperRelationshipObjLst = vsarrvcc_CourseExamPaperRelationshipObjLst;
            //foreach (DataListItem objDLI in dlWenJuan.Items)
            //{
            //long strQuestionId = vsId_Work;// dlWenJuan.DataKeys[objDLI.ItemIndex].ToString();
            //long strQuestionId = Parse(strQuestionId);
            //clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = GetPaperRelationshipByQuestionId(arrvcc_CourseExamPaperRelationshipObjLst, strQuestionId);
            clsQuestionnaireEN objQuestionnaireEN = clsQuestionnaireBL.GetObjByQuestionId(strQuestionId);

            //clsQuestionnaireEN objQuestionnaireEN = clsQuestionnaireBLEx.GetQuestionObjByQuestionId(strQuestionId);
            //TextBox txtAdditionalMemo = (TextBox)objDLI.FindControl("txtIsHaveAdditionalMemo");
            //TextBox txtAnswerText = (TextBox)objDLI.FindControl("txtAnswerText");
            //TextBox txtAnswerText_Content = (TextBox)objDLI.FindControl("txtAnswerText_Content");
            //bool bolIsHid = false;
            //foreach (string strItem in arrHidQLst)
            //{
            //    if (strItem == "tabT" + objvcc_CourseExamPaperRelationshipEN.QuestionIndex.ToString())
            //    {
            //        bolIsHid = true;
            //        break;
            //    }
            //}
            //if (bolIsHid == true)
            //{
            //    continue;
            //}

            clscc_WorkStuRelationEN objcc_WorkStuRelation = null;
            //01	填空题	0002	03	True	1	20150531015902	20150531015902	填空
            //02	单选题	0001	02	True	3	20150531111828	t1	单选题
            //03	多选题	0001	01	True	4	20150531015955	20150531015955	多选题
            //04	开放题	0002	03	True	8	20150531111909	t1	开放题
            //05	解答题	0002	03	True	6	20150531111851	t1	解答
            //06	标题	0000	04	True	9	20150531111918	t1	用于显示标题,不作为问卷内容。
            //07	说明性内容	0000	04	True	10	20150531111927	t1	说明性内容,不作为问卷内容
            //08	单选题(下拉框)	0001	05	False	11	20150531015850	20150531015850	单选题(下拉框)
            //09	操作题	0002	03	True	7	20150531111859	t1	
            //10	简答题	0002	06	True	5	20150531111841	t1	需要简单论述回答的题目。
            //11	判断题	0001	02	True	2	20150531111819	t1	用于判断描述是否正确的题目
            //12  计算题 0002    03  True    6   20160614105239  t1
            switch (objQuestionnaireEN.QuestionTypeId)
            {
                case "01"://01	填空题	0002	03	True	1	20150531015902	20150531015902	填空
                case "04"://04	开放题	0002	03	True	8	20150531111909	t1	开放题
                case "05"://05	解答题	0002	03	True	6	20150531111851	t1	解答
                case "12"://12	计算题	0002	03	True	6	20150531111851	t1	解答

                    objcc_WorkStuRelation = new clscc_WorkStuRelationEN();
                    objcc_WorkStuRelation.IdWorkStuRelation = strQuestionId;
                    //                    objcc_WorkStuRelation.AnswerID = int.Parse(strCheckValue);
                    objcc_WorkStuRelation.StuAnswerText = txtStuAnswerText.Text.Trim();
                    objcc_WorkStuRelation.AnswerModeId = "0001";
                    if (string.IsNullOrEmpty(objcc_WorkStuRelation.StuAnswerText) == true)
                    {
                        sbMsg.AppendFormat("题目还没有做，请重做！");
                        bolIsExistError = true;
                    }
                    //arrcc_WorkStuRelationObjLst.Add(objcc_WorkStuRelation);
                    break;
                case "09"://09	操作题	0002	03	True	7	20150531111859	t1	
                case "10"://10	简答题	0002	06	True	5	20150531111841	t1	需要简单论述回答的题目。
                    objcc_WorkStuRelation = new clscc_WorkStuRelationEN();
                    objcc_WorkStuRelation.IdWorkStuRelation = strQuestionId;
                    //                    objcc_WorkStuRelation.AnswerID = int.Parse(strCheckValue);
                    objcc_WorkStuRelation.StuAnswerText = txtStuAnswerText.Text.Trim();
                    //objcc_WorkStuRelation.AnswerMode = 1;
                    if (string.IsNullOrEmpty(objcc_WorkStuRelation.StuAnswerText) == true)
                    {

                        sbMsg.AppendFormat("题目还没有做，请重做！");
                        bolIsExistError = true;
                        //                            bolIsExistError = true;

                    }
                    //arrcc_WorkStuRelationObjLst.Add(objcc_WorkStuRelation);
                    break;

                case "06"://06	标题	0000	04	True	9	20150531111918	t1	用于显示标题,不作为问卷内容。
                case "07"://07	说明性内容	0000	04	True	10	20150531111927	t1	说明性内容,不作为问卷内容
                    break;
                case "08"://单选题（下拉框）

                    //DropDownList ddlAnswerInQuestion = (DropDownList)objDLI.FindControl("ddlAnswerInQuestion");
                    objcc_WorkStuRelation = new clscc_WorkStuRelationEN();
                    objcc_WorkStuRelation.IdWorkStuRelation = strQuestionId;
                    //                    objcc_WorkStuRelation.AnswerID = int.Parse(strCheckValue);
                    objcc_WorkStuRelation.StuAnswerText = ddlQuestionOptions.SelectedItem.ToString();
                    objcc_WorkStuRelation.AnswerModeId = "0001";
                    if (string.IsNullOrEmpty(objcc_WorkStuRelation.StuAnswerText) == true ||
                        ddlQuestionOptions.SelectedIndex == 0)
                    {

                        sbMsg.AppendFormat("题目还没有做，请重做！");
                        bolIsExistError = true;

                    }
                    //arrcc_WorkStuRelationObjLst.Add(objcc_WorkStuRelation);
                    break;
                case "02":  //02	单选题	0001	02	True	3	20150531111828	t1	单选题
                case "11":   //11	判断题	0001	02	True	2	20150531111819	t1	用于判断描述是否正确的题目

                    bool bolIsChoose = false;
                    //01	复选框	NULL
                    //02	单选框	NULL
                    //03	文本框	NULL
                    //04	无答案	NULL
                    //05	下拉框	NULL
                    //06	通行文本框	NULL
                    switch (objQuestionnaireEN.AnswerTypeId)
                    {
                        case "01"://01	复选框	NULL

                            if (chkQuestionOption != null)
                            {
                                bolIsChoose = false;
                                foreach (ListItem objLI in chkQuestionOption.Items)
                                {
                                    if (objLI.Selected == true)
                                    {
                                        bolIsChoose = true;
                                        string strCheckValue = objLI.Value;
                                        if (clsString.IsNumeric(strCheckValue) == true)
                                        {
                                            objcc_WorkStuRelation = new clscc_WorkStuRelationEN();
                                            objcc_WorkStuRelation.IdWorkStuRelation = strQuestionId;
                                            objcc_WorkStuRelation.AnswerOptionId = strCheckValue;
                                            //if (txtAdditionalMemo != null)
                                            //{
                                            //    objcc_WorkStuRelation.AnswerText = txtAdditionalMemo.Text;
                                            //}
                                            objcc_WorkStuRelation.AnswerModeId = "0002";
                                            //arrcc_WorkStuRelationObjLst.Add(objcc_WorkStuRelation);
                                        }
                                    }
                                }
                                if (bolIsChoose == false)
                                {

                                    sbMsg.AppendFormat("题目还没有做，请重做！");
                                    bolIsExistError = true;
                                }
                            }

                            break;
                        case "02"://02	单选框	NULL

                            if (rblQuestionOptions != null)
                            {
                                string strRbValue = rblQuestionOptions.SelectedValue;
                                if (clsString.IsNumeric(strRbValue) == true)
                                {
                                    objcc_WorkStuRelation = new clscc_WorkStuRelationEN();
                                    objcc_WorkStuRelation.IdWorkStuRelation = strQuestionId;
                                    objcc_WorkStuRelation.AnswerOptionId = strRbValue;
                                    //if (txtAdditionalMemo != null)
                                    //{
                                    //    objcc_WorkStuRelation.AnswerText = txtAdditionalMemo.Text;
                                    //}
                                    objcc_WorkStuRelation.AnswerModeId = "0002";
                                    //arrcc_WorkStuRelationObjLst.Add(objcc_WorkStuRelation);
                                }
                                else
                                {

                                    sbMsg.AppendFormat("题目还没有做，请重做！");
                                    bolIsExistError = true;

                                }

                            }
                            break;
                        case "06":                            //06	通行文本框	NULL
                                                              //    break;
                        case "03"://03	文本框	NULL

                            objcc_WorkStuRelation = new clscc_WorkStuRelationEN();
                            objcc_WorkStuRelation.IdWorkStuRelation = strQuestionId;
                            //if (objQuestionnaireEN.IsHaveAdditionalMemo == true)
                            //{
                            //    if (txtAdditionalMemo != null)
                            //    {
                            //        objcc_WorkStuRelation.AnswerText = txtAdditionalMemo.Text.Trim();
                            //    }
                            //}
                            //else
                            //{
                            objcc_WorkStuRelation.StuAnswerText = txtStuAnswerText.Text.Trim();
                            //}
                            objcc_WorkStuRelation.AnswerModeId = "0001";
                            if (string.IsNullOrEmpty(objcc_WorkStuRelation.StuAnswerText) == true)
                            {

                                sbMsg.AppendFormat("题目还没有做，请重做！");
                                bolIsExistError = true;
                            }
                            //arrcc_WorkStuRelationObjLst.Add(objcc_WorkStuRelation);
                            break;
                        case "04"://04	无答案	NULL
                            break;
                        case "05":                            //05	下拉框	NULL
                            break;
                        //case "06":                            //06	通行文本框	NULL
                        //    break;
                        default:
                            clsAnswerTypeEN objAnswerTypeEN = clsAnswerTypeBL.GetObjByAnswerTypeIdCache(objQuestionnaireEN.AnswerTypeId);

                            string strMsg_AnswerType = string.Format("题号:{0}的答案类型:{1}({2})在函数:[GetQuestionAnswerLstBy1Paper]中没有被处理，请检查！",
                                objQuestionnaireEN.QuestionIndex,
                                objAnswerTypeEN.AnswerTypeName, objAnswerTypeEN.AnswerTypeId);
                            objErrorLog.WriteDebugLog(strMsg_AnswerType);
                            throw new Exception(strMsg_AnswerType);
                            //break;
                    }// switch (objvcc_CourseExamPaperRelationshipEN.AnswerTypeId)
                    break;
                default:
                    clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(objQuestionnaireEN.QuestionTypeId);

                    string strMsg = string.Format("题号:{0}的题型:{1}({2})在函数:[GetQuestionAnswerLstBy1Paper]中没有被处理，请检查！({3})",
                        objQuestionnaireEN.QuestionIndex,
                        objQuestionTypeEN.QuestionTypeName, objQuestionTypeEN.QuestionTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    objErrorLog.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
            }//  switch (objvcc_CourseExamPaperRelationshipEN.QuestionTypeId)

            //}// foreach (DataListItem objDLI in dlWenJuan.Items)
            if (bolIsExistError == true)
            {
                throw new Exception(sbMsg.ToString());
            }
            return objcc_WorkStuRelation;
        }

        public static bool AutoCorrect(ref clscc_WorkStuRelationEN objcc_WorkStuRelationEN,
         clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN,
         string strOpUserId)
        {
            switch (objvcc_CourseExamPaperRelationshipEN.QuestionTypeId)
            {
                case "04"://开放题

                    break;
                case "06"://标题


                    break;
                case "07"://说明性内容


                    break;
                case "08"://单选题（下拉框）


                    break;

                case "01":           //01	填空题	0002	03	True	1	20150531015902	20150531015902	填空
                case "02":    //02	单选题	0001	02	True	3	20150531111828	t1	单选题
                              //clsAnswerBLEx.get
                    List<clsAnswerEN> arrAnswerObjLst = null;
                    arrAnswerObjLst = clsAnswerBLEx.GetObjLstByQuestionId_Cache(objvcc_CourseExamPaperRelationshipEN.QuestionId??0);
                    bool bolIsRight = false;
                    foreach (clsAnswerEN objAnswerEN in arrAnswerObjLst)
                    {

                        if (objcc_WorkStuRelationEN.AnswerOptionId == objAnswerEN.AnswerContent)
                        {
                            objcc_WorkStuRelationEN.IsMarking = true;
                            objcc_WorkStuRelationEN.IsRight = true;
                            objcc_WorkStuRelationEN.Score = objvcc_CourseExamPaperRelationshipEN.QuestionScore;
                            objcc_WorkStuRelationEN.Comment = "自动批改" + clsDateTime.getTodayDateTimeStr(0);
                            objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                            objcc_WorkStuRelationEN.UpdUserId = strOpUserId;
                            clscc_WorkStuRelationBL.UpdateBySql2(objcc_WorkStuRelationEN);
                            bolIsRight = true;
                        }

                    }
                    if (bolIsRight == false)
                    {
                        objcc_WorkStuRelationEN.IsMarking = true;
                        objcc_WorkStuRelationEN.IsRight = false;
                        objcc_WorkStuRelationEN.Score = 0;
                        objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objcc_WorkStuRelationEN.UpdUserId = strOpUserId;
                        clscc_WorkStuRelationBL.UpdateBySql2(objcc_WorkStuRelationEN);

                    }
                    break;
                case "03"://03	多选题	0001	01	True	4	20150531015955	20150531015955	多选题
                    //case "04"://04	开放题	0002	03	True	8	20150531111909	t1	开放题


                    break;
                case "05"://05	解答题	0002	03	True	6	20150531111851	t1	解答
                //case "06"://06	标题	0000	04	True	9	20150531111918	t1	用于显示标题,不作为问卷内容。
                //case "07"://07	说明性内容	0000	04	True	10	20150531111927	t1	说明性内容,不作为问卷内容
                //case "08"://08	单选题(下拉框)	0001	05	False	11	20150531015850	20150531015850	单选题(下拉框)
                case "09"://09	操作题	0002	03	True	7	20150531111859	t1	
                case "10"://10	简答题	0002	06	True	5	20150531111841	t1	需要简单论述回答的题目。
                case "11"://11	判断题	0001	02	True	2	20150531111819	t1	用于判断描述是否正确的题目


                    break;
                default:
                    string strMsg = "";
                    if (string.IsNullOrEmpty(objvcc_CourseExamPaperRelationshipEN.QuestionTypeId) == true)
                    {
                        strMsg = string.Format("题号:{0}的题型为空！在函数:[dlwenjuan_ItemDataBound4ExamPaper]中，请检查！",
                                          objvcc_CourseExamPaperRelationshipEN.OrderNum);
                    }
                    else
                    {
                        clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(objvcc_CourseExamPaperRelationshipEN.QuestionTypeId);

                        strMsg = string.Format("题号:{0}的题型:{1}({2})在函数:[dlwenjuan_ItemDataBound4ExamPaper]中没有被处理，请检查！",
                           objvcc_CourseExamPaperRelationshipEN.OrderNum,
                           objQuestionTypeEN.QuestionTypeName, objQuestionTypeEN.QuestionTypeId);
                    }
                    //clsSysParaEN.objLog.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
                    //break;
            }//switch(objvcc_CourseExamPaperRelationshipEN.QuestionTypeId)

            return true;
        }

        /// <summary>
        /// 布置作业
        /// </summary>
        /// <param name="objcc_ExamPaperEduClsRelaEN"></param>
        /// <param name="strIdStu"></param>
        /// <returns></returns>
        public static bool ArrangeHomeWork(clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN, string strIdStu)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            if (string.IsNullOrEmpty(strIdStu) == true)
            {
                return false;
            }

            string strCondition_WorkStuRelation = string.Format(" {0}='{1}' And {2}='{3}' And {4}='{5}'",
                                    concc_WorkStuRelation.IdWorkStuRelation, objcc_WorkEduClsRelaEN.IdWorkEduClsRela,
                                    concc_WorkStuRelation.IdStudentInfo, strIdStu,
                                    concc_WorkStuRelation.IdCurrEduCls, objcc_WorkEduClsRelaEN.IdCurrEduCls);
            if (clscc_WorkStuRelationBL.IsExistRecord(strCondition_WorkStuRelation) == false)
            {
                clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
                objcc_WorkStuRelationEN.IdWorkStuRelation = long.Parse(objcc_WorkEduClsRelaEN.IdWorkEduClsRela.ToString());
                objcc_WorkStuRelationEN.Scores = objcc_WorkEduClsRelaEN.Scores;
                objcc_WorkStuRelationEN.IsPublish = true;
                objcc_WorkStuRelationEN.IdCurrEduCls = objcc_WorkEduClsRelaEN.IdCurrEduCls;
                objcc_WorkStuRelationEN.IdStudentInfo = strIdStu;
                objcc_WorkStuRelationEN.WorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId;

                objcc_WorkStuRelationEN.SpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate;
                objcc_WorkStuRelationEN.SchoolYear = clsSysParaEN.CurrYear;
                objcc_WorkStuRelationEN.SchoolTerm = clsSysParaEN.CurrTerm;
                objcc_WorkStuRelationEN.UpdDate = strCurrDate;
                objcc_WorkStuRelationEN.UpdUserId = "pyf";
                clscc_WorkStuRelationBL.AddNewRecordBySql2(objcc_WorkStuRelationEN);
            }
            else
            {
                clscc_WorkStuRelationEN objcc_WorkStuRelationEN = clscc_WorkStuRelationBL.GetFirstObj_S(strCondition_WorkStuRelation);
                objcc_WorkStuRelationEN.SpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate;
                objcc_WorkStuRelationEN.Scores = objcc_WorkEduClsRelaEN.Scores;
                objcc_WorkStuRelationEN.WorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId;
                objcc_WorkStuRelationEN.IsPublish = true;
                objcc_WorkStuRelationEN.SchoolYear = clsSysParaEN.CurrYear;
                objcc_WorkStuRelationEN.SchoolTerm = clsSysParaEN.CurrTerm;
                objcc_WorkStuRelationEN.UpdDate = strCurrDate;
                objcc_WorkStuRelationEN.UpdUserId = "pyf"; ;
                clscc_WorkStuRelationBL.UpdateBySql2(objcc_WorkStuRelationEN);
            }
            return true;
        }
        public static int GetHomeWork(string strIdStu)
        {
            string strMsg = "";
            if (string.IsNullOrEmpty(strIdStu) == true)
            {

                strMsg = string.Format("当前学号流水号:{0}为空，不能获取作业！", strIdStu);
                throw new Exception(strMsg);
            }
            List<string> arrIdCurrEduClsLst = clsCurrEduClsStuBLEx.GetidCurrEduClsListById_StudentInfo(strIdStu);
            if (arrIdCurrEduClsLst.Count == 0)
            {
                clsStudentInfoEN objStu = clsStudentInfoBL.GetObjByIdStudentInfo(strIdStu);
                strMsg = string.Format("当前学号:[{0}]的相关教学班数为0，不能获取作业！", strIdStu);
                throw new Exception(strMsg);
            }
            int intCount = 0;
            foreach (string strIdCurrEduCls in arrIdCurrEduClsLst)
            {
                string strCondition_Stu = string.Format(" {0} ='{1}' and {2} not in (select {2} From {3} where {4}='{5}' And {0}='{1}') And {6}='1'[exclude]select [/exclude]",
                                        concc_WorkEduClsRela.IdCurrEduCls,
                                        strIdCurrEduCls,
                                        concc_WorkEduClsRela.IdWorkEduClsRela,
                                        clscc_WorkStuRelationEN._CurrTabName,
                                        concc_WorkStuRelation.IdStudentInfo,
                                        strIdStu,
                                        concc_WorkEduClsRela.IsPublish);
                List<clscc_WorkEduClsRelaEN> arrcc_WorkEduClsRelaObjLst = clscc_WorkEduClsRelaBL.GetObjLst(strCondition_Stu);
                if (arrcc_WorkEduClsRelaObjLst.Count == 0)
                {
                    continue;
                    //clsCommonJsFunc.Alert(this, "没有需要获取的新的作业!");
                    //return;
                }
                string strCurrDate = clsDateTime.getTodayStr(0);

                foreach (clscc_WorkEduClsRelaEN objcc_WorkEduClsRelaEN in arrcc_WorkEduClsRelaObjLst)
                {
                    if (string.IsNullOrEmpty(objcc_WorkEduClsRelaEN.SpecifyCompletionDate) == true)
                    {
                        continue;
                    }
                    clscc_WorkStuRelationEN objcc_WorkStuRelationEN = new clscc_WorkStuRelationEN();
                    objcc_WorkStuRelationEN.IdWorkStuRelation = long.Parse(objcc_WorkEduClsRelaEN.IdWorkEduClsRela.ToString());
                    objcc_WorkStuRelationEN.Scores = objcc_WorkEduClsRelaEN.Scores;
                    objcc_WorkStuRelationEN.IsPublish = true;
                    objcc_WorkStuRelationEN.IdCurrEduCls = objcc_WorkEduClsRelaEN.IdCurrEduCls;
                    objcc_WorkStuRelationEN.IdStudentInfo = strIdStu;
                    objcc_WorkStuRelationEN.WorkTypeId = objcc_WorkEduClsRelaEN.WorkTypeId;

                    objcc_WorkStuRelationEN.SpecifyCompletionDate = objcc_WorkEduClsRelaEN.SpecifyCompletionDate;
                    objcc_WorkStuRelationEN.SchoolYear = clsSysParaEN.CurrYear;
                    objcc_WorkStuRelationEN.SchoolTerm = clsSysParaEN.CurrTerm;
                    objcc_WorkStuRelationEN.UpdDate = strCurrDate;
                    objcc_WorkStuRelationEN.UpdUserId = "pyf"; ;
                    clscc_WorkStuRelationBL.AddNewRecordBySql2(objcc_WorkStuRelationEN);
                    intCount++;
                }
            }
            string strMsg1 = string.Format("获取作业完成！共获取了:[{0}]条记录。", intCount);
            return intCount;
        }

    }
}
