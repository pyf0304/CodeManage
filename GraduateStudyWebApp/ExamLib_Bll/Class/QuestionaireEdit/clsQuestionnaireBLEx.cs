using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using ExamLib.BusinessLogicEx;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib.BusinessLogic
{

    public static class clsQuestionnaireBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQuestionnaireENS">源对象</param>
        /// <returns>目标对象=>clsQuestionnaireEN:objQuestionnaireENT</returns>
        public static clsQuestionnaireENEx CopyToEx(this clsQuestionnaireEN objQuestionnaireENS)
        {
            try
            {
                clsQuestionnaireENEx objQuestionnaireENT = new clsQuestionnaireENEx();
                clsQuestionnaireBL.QuestionnaireDA.CopyTo(objQuestionnaireENS, objQuestionnaireENT);
                return objQuestionnaireENT;
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
        /// <param name = "objQuestionnaireENS">源对象</param>
        /// <returns>目标对象=>clsQuestionnaireEN:objQuestionnaireENT</returns>
        public static clsQuestionnaireEN CopyTo(this clsQuestionnaireENEx objQuestionnaireENS)
        {
            try
            {
                clsQuestionnaireEN objQuestionnaireENT = new clsQuestionnaireEN();
                clsQuestionnaireBL.QuestionnaireDA.CopyTo(objQuestionnaireENS, objQuestionnaireENT);
                return objQuestionnaireENT;
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

    public static class clsQuestionnaireBLEx
    {


        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQuestionnaireDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQuestionnaireDAEx QuestionnaireDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQuestionnaireDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funGetRecCountByCond)
        /// </summary>
        /// <param name = "strWhereCond">所给定的记录条件</param>
        /// <returns>记录数,为整型</returns>
        public static int GetRecCountByCond(string strWhereCond)
        {
            int intRecCount = clsQuestionnaireDA.GetRecCountByCond(strWhereCond);
            return intRecCount;
        }

        public static int GetRecCountByCondEx(string strCourseId)
        {
            string strWhereCond = string.Format("{0}='{1}'", conQuestionnaire.CourseId, strCourseId);

            int intRecCount = clsQuestionnaireDA.GetRecCountByCond(strWhereCond);
            return intRecCount;
        }
        public static int ImportDataFromCsv(stuExcelData objExcelData)
        {
            //System.Data.DataTable dtable = BindGv_Excel();
            ////删除空行
            //removeEmpty(dtable);

            //clsPubFun.AddDateExcelToTeacherInfo(dtable);

            //string lblmess = "";
            int intCount = 0;
            System.Data.DataTable dtable = clsPubFun4DataImport.csv2table(objExcelData.Csv);
            var objQuestionType = clsQuestionTypeBLEx.GetObjByQuestionTypeName_Cache(objExcelData.QuestionTypeName);
            if (objQuestionType == null)
            {
                string strMsg = string.Format("题目类型:[{0}]不存在！", objExcelData.QuestionTypeName);
                clsSysParaEN.objLog.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            if (dtable.Rows.Count > 0)
            {
                //删除空行
                clsPubFun4DataImport.removeEmpty(dtable);
                try
                {
                    intCount = clsPubFun4DataImport.AddDateExcelToSingleQuestionnaire(dtable, objQuestionType.QuestionTypeId, objExcelData.UserId);
                    if (intCount >= 0)
                    {
                        string strMsg = string.Format("操作成功！共导入了{0}条考试批次。", intCount);
                        clsSysParaEN.objLog.WriteDebugLog(strMsg);
                    }
                    //this.lblMessFalse.Text = lblmess;
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("导入Excel时出错。错误:{0}.(In {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                    clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
                }
                //Response1.Write(this.lblMessFalse.Text);
            }
            else
            {
                throw new Exception("当前没有数据可导入，请先上传有数据的Excel文件！");
            }
            return intCount;
        }


        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strQuestionId">表关键字</param>
        /// <returns></returns>
        public static bool DelRecordExBak(long strQuestionId, string strCourseId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQuestionnaireDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[Questionnaire]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conQuestionnaire.QuestionId,
                //strQuestionId);
                //        clsQuestionnaireBL.DelQuestionnairesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsQuestionnaireBL.DelRecord(strQuestionId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsQuestionnaireBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strQuestionId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsQuestionnaireENEx> GetObjExLst(string strCondition)
        {
            List<clsQuestionnaireEN> arrObjLst = clsQuestionnaireBL.GetObjLst(strCondition);
            List<clsQuestionnaireENEx> arrObjExLst = new List<clsQuestionnaireENEx>();
            foreach (clsQuestionnaireEN objInFor in arrObjLst)
            {
                clsQuestionnaireENEx objQuestionnaireENEx = new clsQuestionnaireENEx();
                clsQuestionnaireBL.CopyTo(objInFor, objQuestionnaireENEx);
                arrObjExLst.Add(objQuestionnaireENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strQuestionId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQuestionnaireENEx GetObjExByQuestionId(long strQuestionId)
        {
            clsQuestionnaireEN objQuestionnaireEN = clsQuestionnaireBL.GetObjByQuestionId(strQuestionId);
            clsQuestionnaireENEx objQuestionnaireENEx = new clsQuestionnaireENEx();
            clsQuestionnaireBL.CopyTo(objQuestionnaireEN, objQuestionnaireENEx);
            return objQuestionnaireENEx;
        }

        public static string strCourseId_Cache_Init = "";
        public static DataTable getAnswerDTByQuestionId1(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = new clsAnswerDA().GetDataTable_Answer(strWhereCond);
                return objDT;

            }
            catch (Exception objException)
            {
                throw new Exception("获取表:Answer 数据出错！\r\n" + objException.Message);
            }



        }


        public static DataTable GetAnswerDTBy(string strWhereCond)
        {

            DataTable objDT = null;
            try
            {
                objDT = new clsAnswerDA().GetDataTable_Answer(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:Answer 数据出错！\r\n" + objException.Message);
            }

        }

        public static bool AutoCorrect(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN,
        clsQuestionnaireEN objQuestionnaireEN, List<clsAnswerEN> arrAnswerENObjLst, string strUpdUser)
        {
            if (arrAnswerENObjLst.Count == 0)
            {
                SetErrMsg(objcc_PaperStuBatchQuesRelaEN, "无答案", strUpdUser);
                return true;
            }
            clsAnswerEN objAnswerEN = arrAnswerENObjLst[0];
            switch (objQuestionnaireEN.QuestionTypeId)
            {

                case enumQuestionType.SingleChoice_02:// "02":    //02	单选题	0001	02	True	3	20150531111828	t1	单选题
                case enumQuestionType.SingleChoice_DropDownBox_08:// "08"://08	单选题(下拉框)	0001	05	False	11	20150531015850	20150531015850	单选题(下拉框)
                    if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId == objAnswerEN.AnswerOptionId)
                    {
                        SetIsRight(objcc_PaperStuBatchQuesRelaEN, strUpdUser);
                    }
                    else
                    {
                        SetIsError(objcc_PaperStuBatchQuesRelaEN, strUpdUser);
                    }
                    break;
                case enumQuestionType.FillInBlank_01:    //01	填空题	0002	03	True	1	20150531015902	20150531015902	填空

                    break;
                case enumQuestionType.MultipleChoice_03://03	多选题	0001	01	True	4	20150531015955	20150531015955	多选题
                case enumQuestionType.CaseAnysisMultiChoice_12://12 案例分析多选题	0001	01	True	4	20150531015955	20150531015955	多选题
                    string[] strOptionItems = objAnswerEN.AnswerMultiOptions.Split('|');
                    List<string> arrRightAnswer = new List<string>();
                    foreach (string str in strOptionItems)
                    {
                        string strItem = str.Trim();
                        if (string.IsNullOrEmpty(strItem) == true) continue;
                        if (arrRightAnswer.Contains(strItem) == false)
                        {
                            arrRightAnswer.Add(strItem);
                        }
                    }

                    string[] sstrUserAnswer = objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions.Split(',');
                    List<string> arrUserAnswer = new List<string>();
                    foreach (string str in sstrUserAnswer)
                    {
                        string strItem = str.Trim();
                        if (string.IsNullOrEmpty(strItem) == true) continue;
                        if (arrUserAnswer.Contains(strItem) == false)
                        {
                            arrUserAnswer.Add(strItem);
                        }
                    }
                    if (arrUserAnswer.Count > arrRightAnswer.Count)
                    {
                        SetIsError(objcc_PaperStuBatchQuesRelaEN, strUpdUser);
                    }
                    int intCorrectNum = 0;
                    foreach (string strItem in arrRightAnswer)
                    {
                        if (arrUserAnswer.Contains(strItem)) intCorrectNum++;
                    }
                    if (intCorrectNum == arrRightAnswer.Count)
                    {
                        SetIsRight(objcc_PaperStuBatchQuesRelaEN, strUpdUser);
                    }
                    else
                    {
                        SetIsError(objcc_PaperStuBatchQuesRelaEN, strUpdUser);
                    }
                    break;
                case enumQuestionType.TrueorFalse_11://11	判断题	0001	02	True	2	20150531111819	t1	用于判断描述是否正确的题目
                    if (objcc_PaperStuBatchQuesRelaEN.AnswerOptionId == "T"
                        || objcc_PaperStuBatchQuesRelaEN.AnswerOptionId == "Y")
                    {
                        if (objAnswerEN.AnswerTrueOrFalse == true)
                        {
                            SetIsRight(objcc_PaperStuBatchQuesRelaEN, strUpdUser);
                        }
                        else
                        {
                            SetIsError(objcc_PaperStuBatchQuesRelaEN, strUpdUser);
                        }
                    }
                    else
                    {
                        if (objAnswerEN.AnswerTrueOrFalse == true)
                        {
                            SetIsError(objcc_PaperStuBatchQuesRelaEN, strUpdUser);
                        }
                        else
                        {
                            SetIsRight(objcc_PaperStuBatchQuesRelaEN, strUpdUser);
                        }
                    }
                    break;
                case "05"://05	解答题	0002	03	True	6	20150531111851	t1	解答
                case "06"://06	标题	0000	04	True	9	20150531111918	t1	用于显示标题,不作为问卷内容。
                case "07"://07	说明性内容	0000	04	True	10	20150531111927	t1	说明性内容,不作为问卷内容
                case "09"://09	操作题	0002	03	True	7	20150531111859	t1	
                case "10"://10	简答题	0002	06	True	5	20150531111841	t1	需要简单论述回答的题目。
                          //case "12"://12	计算题	0001	02	True	2	20150531111819	t1	用于判断描述是否正确的题目
                case "04"://04	开放题	0002	03	True	8	20150531111909	t1	开放题

                    break;
                default:
                    clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(objQuestionnaireEN.QuestionTypeId);

                    string strMsg = string.Format("题型:{0}({1})在函数中没有被处理，请检查！({2})",
                        objQuestionTypeEN.QuestionTypeName, objQuestionTypeEN.QuestionTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
            }// switch(objQuestionnaireEN.QuestionTypeId )


            return true;
        }


        public static bool AutoCorrect(clscc_WorkStuRelationEN objcc_WorkStuRelationEN,
            clsQuestionnaireEN objQuestionnaireEN, List<clsAnswerEN> arrAnswerENObjLst, string strUpdUser)
        {
            if (arrAnswerENObjLst.Count == 0)
            {
                SetErrMsg(objcc_WorkStuRelationEN, "无答案", strUpdUser);
                return true;
            }
            clsAnswerEN objAnswerEN = arrAnswerENObjLst[0];
            switch (objQuestionnaireEN.QuestionTypeId)
            {

                case enumQuestionType.SingleChoice_02:// "02":    //02	单选题	0001	02	True	3	20150531111828	t1	单选题
                case enumQuestionType.SingleChoice_DropDownBox_08:// "08"://08	单选题(下拉框)	0001	05	False	11	20150531015850	20150531015850	单选题(下拉框)
                    if (objcc_WorkStuRelationEN.AnswerOptionId == objAnswerEN.AnswerOptionId)
                    {
                        SetIsRight(objcc_WorkStuRelationEN, strUpdUser);
                    }
                    else
                    {
                        SetIsError(objcc_WorkStuRelationEN, strUpdUser);
                    }
                    break;
                case enumQuestionType.FillInBlank_01:    //01	填空题	0002	03	True	1	20150531015902	20150531015902	填空

                    break;
                case enumQuestionType.MultipleChoice_03://03	多选题	0001	01	True	4	20150531015955	20150531015955	多选题
                    string[] strOptionItems = objAnswerEN.AnswerMultiOptions.Split('|');
                    List<string> arrRightAnswer = new List<string>();
                    foreach (string str in strOptionItems)
                    {
                        string strItem = str.Trim();
                        if (string.IsNullOrEmpty(strItem) == true) continue;
                        if (arrRightAnswer.Contains(strItem) == false)
                        {
                            arrRightAnswer.Add(strItem);
                        }
                    }

                    string[] sstrUserAnswer = objcc_WorkStuRelationEN.AnswerMultiOptions.Split(',');
                    List<string> arrUserAnswer = new List<string>();
                    foreach (string str in sstrUserAnswer)
                    {
                        string strItem = str.Trim();
                        if (string.IsNullOrEmpty(strItem) == true) continue;
                        if (arrUserAnswer.Contains(strItem) == false)
                        {
                            arrUserAnswer.Add(strItem);
                        }
                    }
                    if (arrUserAnswer.Count > arrRightAnswer.Count)
                    {
                        SetIsError(objcc_WorkStuRelationEN, strUpdUser);
                    }
                    int intCorrectNum = 0;
                    foreach (string strItem in arrRightAnswer)
                    {
                        if (arrUserAnswer.Contains(strItem)) intCorrectNum++;
                    }
                    if (intCorrectNum == arrRightAnswer.Count)
                    {
                        SetIsRight(objcc_WorkStuRelationEN, strUpdUser);
                    }
                    else
                    {
                        SetIsError(objcc_WorkStuRelationEN, strUpdUser);
                    }
                    break;
                case enumQuestionType.TrueorFalse_11://11	判断题	0001	02	True	2	20150531111819	t1	用于判断描述是否正确的题目
                    if (objcc_WorkStuRelationEN.AnswerOptionId == "T"
                        || objcc_WorkStuRelationEN.AnswerOptionId == "Y")
                    {
                        if (objAnswerEN.AnswerTrueOrFalse == true)
                        {
                            SetIsRight(objcc_WorkStuRelationEN, strUpdUser);
                        }
                        else
                        {
                            SetIsError(objcc_WorkStuRelationEN, strUpdUser);
                        }
                    }
                    else
                    {
                        if (objAnswerEN.AnswerTrueOrFalse == true)
                        {
                            SetIsError(objcc_WorkStuRelationEN, strUpdUser);
                        }
                        else
                        {
                            SetIsRight(objcc_WorkStuRelationEN, strUpdUser);
                        }
                    }
                    break;
                case "05"://05	解答题	0002	03	True	6	20150531111851	t1	解答
                case "06"://06	标题	0000	04	True	9	20150531111918	t1	用于显示标题,不作为问卷内容。
                case "07"://07	说明性内容	0000	04	True	10	20150531111927	t1	说明性内容,不作为问卷内容
                case "09"://09	操作题	0002	03	True	7	20150531111859	t1	
                case "10"://10	简答题	0002	06	True	5	20150531111841	t1	需要简单论述回答的题目。
                case "12"://12	计算题	0001	02	True	2	20150531111819	t1	用于判断描述是否正确的题目
                case "04"://04	开放题	0002	03	True	8	20150531111909	t1	开放题

                    break;
                default:
                    clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(objQuestionnaireEN.QuestionTypeId);

                    string strMsg = string.Format("题型:{0}({1})在函数中没有被处理，请检查！({2})",
                        objQuestionTypeEN.QuestionTypeName, objQuestionTypeEN.QuestionTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
            }// switch(objQuestionnaireEN.QuestionTypeId )


            return true;
        }

        /// <summary>
        /// 自动批改作业
        /// </summary>
        /// <param name="lngId_WorkStuRelation"></param>
        /// <param name="strUpdUser"></param>
        /// <returns></returns>
        public static bool AutoCorrect(long lngId_WorkStuRelation, string strUpdUser)
        {
            clscc_WorkStuRelationEN objcc_WorkStuRelationEN = clscc_WorkStuRelationBL.GetObjByIdWorkStuRelation(lngId_WorkStuRelation);
            clsQuestionnaireEN objQuestionnaireEN = clsQuestionnaireBL.GetObjByQuestionId(objcc_WorkStuRelationEN.QuestionId);
            List<clsAnswerEN> arrAnswerENObjLst = clsAnswerBLEx.GetObjLstByQuestionId_Cache(objcc_WorkStuRelationEN.QuestionId);

            if (arrAnswerENObjLst.Count == 0)
            {
                SetErrMsg(objcc_WorkStuRelationEN, "无答案", strUpdUser);
                return true;
            }
            clsAnswerEN objAnswerEN = arrAnswerENObjLst[0];
            switch (objQuestionnaireEN.QuestionTypeId)
            {

                case enumQuestionType.SingleChoice_02:// "02":    //02	单选题	0001	02	True	3	20150531111828	t1	单选题
                case enumQuestionType.SingleChoice_DropDownBox_08:// "08"://08	单选题(下拉框)	0001	05	False	11	20150531015850	20150531015850	单选题(下拉框)
                    if (objcc_WorkStuRelationEN.AnswerOptionId == objAnswerEN.AnswerOptionId)
                    {
                        SetIsRight(objcc_WorkStuRelationEN, strUpdUser);
                    }
                    else
                    {
                        SetIsError(objcc_WorkStuRelationEN, strUpdUser);
                    }
                    break;
                case enumQuestionType.FillInBlank_01:    //01	填空题	0002	03	True	1	20150531015902	20150531015902	填空

                    break;
                case enumQuestionType.MultipleChoice_03://03	多选题	0001	01	True	4	20150531015955	20150531015955	多选题
                    string[] strOptionItems = objAnswerEN.AnswerMultiOptions.Split('|');
                    List<string> arrRightAnswer = new List<string>();
                    foreach (string str in strOptionItems)
                    {
                        string strItem = str.Trim();
                        if (string.IsNullOrEmpty(strItem) == true) continue;
                        if (arrRightAnswer.Contains(strItem) == false)
                        {
                            arrRightAnswer.Add(strItem);
                        }
                    }

                    string[] sstrUserAnswer = objcc_WorkStuRelationEN.AnswerMultiOptions.Split(',');
                    List<string> arrUserAnswer = new List<string>();
                    foreach (string str in sstrUserAnswer)
                    {
                        string strItem = str.Trim();
                        if (string.IsNullOrEmpty(strItem) == true) continue;
                        if (arrUserAnswer.Contains(strItem) == false)
                        {
                            arrUserAnswer.Add(strItem);
                        }
                    }
                    if (arrUserAnswer.Count > arrRightAnswer.Count)
                    {
                        SetIsError(objcc_WorkStuRelationEN, strUpdUser);
                    }
                    int intCorrectNum = 0;
                    foreach (string strItem in arrRightAnswer)
                    {
                        if (arrUserAnswer.Contains(strItem)) intCorrectNum++;
                    }
                    if (intCorrectNum == arrRightAnswer.Count)
                    {
                        SetIsRight(objcc_WorkStuRelationEN, strUpdUser);
                    }
                    else
                    {
                        SetIsError(objcc_WorkStuRelationEN, strUpdUser);
                    }
                    break;
                case enumQuestionType.TrueorFalse_11://11	判断题	0001	02	True	2	20150531111819	t1	用于判断描述是否正确的题目
                    if (objcc_WorkStuRelationEN.AnswerOptionId == "T"
                        || objcc_WorkStuRelationEN.AnswerOptionId == "Y")
                    {
                        if (objAnswerEN.AnswerTrueOrFalse == true)
                        {
                            SetIsRight(objcc_WorkStuRelationEN, strUpdUser);
                        }
                        else
                        {
                            SetIsError(objcc_WorkStuRelationEN, strUpdUser);
                        }
                    }
                    else
                    {
                        if (objAnswerEN.AnswerTrueOrFalse == true)
                        {
                            SetIsError(objcc_WorkStuRelationEN, strUpdUser);
                        }
                        else
                        {
                            SetIsRight(objcc_WorkStuRelationEN, strUpdUser);
                        }
                    }
                    break;
                case "05"://05	解答题	0002	03	True	6	20150531111851	t1	解答
                case "06"://06	标题	0000	04	True	9	20150531111918	t1	用于显示标题,不作为问卷内容。
                case "07"://07	说明性内容	0000	04	True	10	20150531111927	t1	说明性内容,不作为问卷内容
                case "09"://09	操作题	0002	03	True	7	20150531111859	t1	
                case "10"://10	简答题	0002	06	True	5	20150531111841	t1	需要简单论述回答的题目。
                case "12"://12	计算题	0001	02	True	2	20150531111819	t1	用于判断描述是否正确的题目
                case "04"://04	开放题	0002	03	True	8	20150531111909	t1	开放题

                    break;
                default:
                    clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(objQuestionnaireEN.QuestionTypeId);

                    string strMsg = string.Format("题型:{0}({1})在函数中没有被处理，请检查！({2})",
                        objQuestionTypeEN.QuestionTypeName, objQuestionTypeEN.QuestionTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                    throw new Exception(strMsg);
            }// switch(objQuestionnaireEN.QuestionTypeId )


            return true;
        }


        public static bool SetErrMsg(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strErrMsg, string strUpdUser)
        {
            objcc_WorkStuRelationEN.ErrMsg = strErrMsg;
            objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objcc_WorkStuRelationEN.UpdUserId = strUpdUser;
            return clscc_WorkStuRelationBL.UpdateBySql2(objcc_WorkStuRelationEN);

        }
        public static bool SetIsRight(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strUpdUser)
        {
            objcc_WorkStuRelationEN.ErrMsg = "";
            objcc_WorkStuRelationEN.IsRight = true;
            objcc_WorkStuRelationEN.IsMarking = true;
            objcc_WorkStuRelationEN.Score = objcc_WorkStuRelationEN.Scores;
            objcc_WorkStuRelationEN.MarkerId = strUpdUser;
            objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objcc_WorkStuRelationEN.UpdUserId = strUpdUser;
            return clscc_WorkStuRelationBL.UpdateBySql2(objcc_WorkStuRelationEN);

        }
        public static bool SetErrMsg(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strErrMsg, string strUpdUser)
        {
            objcc_PaperStuBatchQuesRelaEN.ErrMsg = strErrMsg;
            objcc_PaperStuBatchQuesRelaEN.MarkerId = strUpdUser;
            objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objcc_PaperStuBatchQuesRelaEN.UpdUserId = strUpdUser;
            return clscc_PaperStuBatchQuesRelaBL.UpdateBySql2(objcc_PaperStuBatchQuesRelaEN);

        }
        public static bool SetIsRight(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strUpdUser)
        {
            objcc_PaperStuBatchQuesRelaEN.ErrMsg = "";
            objcc_PaperStuBatchQuesRelaEN.IsRight = true;
            objcc_PaperStuBatchQuesRelaEN.IsMarking = true;
            objcc_PaperStuBatchQuesRelaEN.Score = objcc_PaperStuBatchQuesRelaEN.Scores;
            objcc_PaperStuBatchQuesRelaEN.MarkerId = strUpdUser;
            objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objcc_PaperStuBatchQuesRelaEN.UpdUserId = strUpdUser;
            return clscc_PaperStuBatchQuesRelaBL.UpdateBySql2(objcc_PaperStuBatchQuesRelaEN);

        }
        public static bool SetIsError(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strUpdUser)
        {
            objcc_PaperStuBatchQuesRelaEN.ErrMsg = "";
            objcc_PaperStuBatchQuesRelaEN.IsRight = false;
            objcc_PaperStuBatchQuesRelaEN.IsMarking = true;
            objcc_PaperStuBatchQuesRelaEN.Score = 0;
            objcc_PaperStuBatchQuesRelaEN.MarkerId = strUpdUser;
            objcc_PaperStuBatchQuesRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objcc_PaperStuBatchQuesRelaEN.UpdUserId = strUpdUser;
            return clscc_PaperStuBatchQuesRelaBL.UpdateBySql2(objcc_PaperStuBatchQuesRelaEN);

        }

        public static bool SetIsError(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strUpdUser)
        {
            objcc_WorkStuRelationEN.ErrMsg = "";
            objcc_WorkStuRelationEN.IsRight = false;
            objcc_WorkStuRelationEN.IsMarking = true;
            objcc_WorkStuRelationEN.Score = 0;
            objcc_WorkStuRelationEN.MarkerId = strUpdUser;
            objcc_WorkStuRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objcc_WorkStuRelationEN.UpdUserId = strUpdUser;
            return clscc_WorkStuRelationBL.UpdateBySql2(objcc_WorkStuRelationEN);

        }
        public static DataTable GetQuestionId4BindDdl(string strWhere)
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select {0}, ltrim(str({1})) + '. '+ {2} as {2} from {3} where {4}",
                                conQuestionnaire.QuestionId,
                                conQuestionnaire.QuestionIndex,
                                conQuestionnaire.QuestionName,
                                clsQuestionnaireEN._CurrTabName,
                                strWhere);
            com.taishsoft.commdb.clsSpecSQLforSql mySql = new com.taishsoft.commdb.clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// </summary>
        /// <param name="objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_QuestionIdByCourseId(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("{0}='{1}' order by {2}",
                conQuestionnaire.CourseId, strCourseId,
                conQuestionnaire.QuestionIndex);
            System.Data.DataTable objDT = clsQuestionnaireBLEx.GetQuestionId4BindDdl(strCondition);
            objDDL.DataValueField = conQuestionnaire.QuestionId;
            objDDL.DataTextField = conQuestionnaire.QuestionName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

      

     

        public static clsQuestionnaireEN GetQuestionObjByQuestionIdAndCourseId(long strQuestionId, string strCourseId)
        {            
            List<clsQuestionnaireEN> arrQuestionnaireObjLstByCourse = clsQuestionnaireBL.GetObjLstCache(strCourseId);
            var objQuestionnaire = arrQuestionnaireObjLstByCourse.Find(x => x.QuestionId == strQuestionId);
            return objQuestionnaire;
        }

        public static bool DelQuestionnairesEx(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = clsQuestionnaireDAEx.DelQuestionnaireEx(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除多记录出错！\r\n" + objException.Message);
            }
        }

        public static int CopyQuestionnairesToNewSet(List<long> arrKeyId, string strQuestionnaireSetId, string strUserId)
        {
            try
            {
                int iCount = 0;
                foreach (long strQuestionId in arrKeyId)
                {

                    clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireEN(strQuestionId);
                    clsQuestionnaireBL.GetQuestionnaire(ref objQuestionnaireEN);
                    //objQuestionnaireEN.QuestionnaireSetId = strQuestionnaireSetId;

                    objQuestionnaireEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objQuestionnaireEN.UpdUser = strUserId;
                    string strCondition = string.Format("QuestionName='{0}' And QuestionnaireSetId='{1}'",
                        objQuestionnaireEN.QuestionName, strQuestionnaireSetId);
                    if (clsQuestionnaireBL.IsExistRecord(strCondition) == true)
                    {
                        if (string.IsNullOrEmpty(objQuestionnaireEN.QuestionName) == false)
                        {
                            continue;
                        }
                    }

                    objQuestionnaireEN.QuestionId = long.Parse(clsQuestionnaireBL.AddNewRecordBySql2WithReturnKey(objQuestionnaireEN));
                    string strCondition_New = string.Format("QuestionName='{0}' And QuestionnaireSetId='{1}'",
                        objQuestionnaireEN.QuestionName, strQuestionnaireSetId);
                    long strQuestionId_New = clsQuestionnaireBL.GetFirstID_S(strCondition_New);

                    string strCondition_Answer = string.Format("QuestionId = {0}", strQuestionId);
                    List<clsAnswerEN> arrAnswerObjLst = clsAnswerBL.GetObjLst(strCondition_Answer);
                    foreach (clsAnswerEN objAnswerEN in arrAnswerObjLst)
                    {
                        objAnswerEN.QuestionId = strQuestionId_New;
                        objAnswerEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objAnswerEN.UpdUser = strUserId;
                        //if (string.IsNullOrEmpty(objAnswerEN.AnswerTitle) == true)
                        //{
                        //    objAnswerEN.AnswerTitle = "空空空！请检查修改！";
                        //}
                        clsAnswerBL.AddNewRecordBySql2(objAnswerEN);
                    }
                    iCount++;
                }
                return iCount;
            }
            catch (Exception objException)
            {
                throw new Exception("复制多记录出错！\r\n" + objException.Message);
            }
        }

        public static bool ChangeRadioDirect(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().ChangeRadioDirect(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("改变文本方向出错！\r\n" + objException.Message);
            }
        }
        public static bool ChangeAutoGridTitle(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().ChangeAutoGridTitle(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("改变自动表格标题出错！\r\n" + objException.Message);
            }
        }
        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().GoTop(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        public static bool GoTopByCourse(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().GoTopByCourse(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().GoBottom(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }
        public static bool GoBottomByCourse(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().GoBottomByCourse(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }
        public static bool ClearQuestionNo(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().ClearQuestionNo(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("清除题目编号出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 自动修改相关属性
        /// </summary>
        /// <param name="arrKeyId">关键字列表</param>
        /// <returns></returns>
        public static bool AutoChangeReleProperty(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().AutoChangeReleProperty(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("自动修改相关属性出错！\r\n" + objException.Message);
            }
        }
        public static bool SetQuestionType(List<string> arrKeyId, string strQuestionTypeId)
        {
            try
            {
                bool bolResult = clsQuestionnaireDAEx.SetQuestionType(arrKeyId, strQuestionTypeId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("设置题目类型出错！\r\n" + objException.Message);
            }
        }
        public static bool SetQuestionIndex(List<string> arrKeyId, int intQuestionIndex)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().SetQuestionIndex(arrKeyId, intQuestionIndex);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("设置题目序号出错！\r\n" + objException.Message);
            }
        }

        /// <summary>
        /// 设置缺省值
        /// </summary>
        /// <param name="lstKey">题目关键字列表</param>
        /// <param name="strDefaultValue">缺省值</param>
        /// <returns></returns>
        public static bool SetDefaultValue(List<string> arrKeyId, string strDefaultValue)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().SetDefaultValue(arrKeyId, strDefaultValue);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("设置题目序号出错！\r\n" + objException.Message);
            }
        }

        /// <summary>
        /// 答案编号ABC
        /// </summary>
        /// <param name="arrKeyId">关键字列表</param>
        /// <returns></returns>
        public static bool AnswerNumberingABC(List<long> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().AnswerNumberingABC(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("答案编号ABC出错！\r\n" + objException.Message);
            }
        }

        public static bool DelRecordEx(long strQuestionId)
        {
            try
            {
                bool bolResult = clsQuestionnaireDAEx.DelRecordEx(strQuestionId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除多记录出错！\r\n" + objException.Message);
            }
        }

        public static bool CopyRecordEx(long strQuestionId, string strUserId)
        {
            try
            {
                long strNewQuestionId = 0;
                bool bolResult = clsQuestionnaireDAEx.CopyRecordEx(strQuestionId, strUserId, ref strNewQuestionId);
                long strSourceQuestionId = strQuestionId;
                StringBuilder sbCondition1 = new StringBuilder();
                sbCondition1.AppendFormat(" QuestionId ='{0}'", strSourceQuestionId);

                List<clsAnswerEN> arrAnswerLst = clsAnswerBLEx.GetObjLst(sbCondition1.ToString());

                string strDate = clsDateTime.getTodayStr(0);
                foreach (clsAnswerEN objAnswer in arrAnswerLst)
                {
                    objAnswer.QuestionId = strNewQuestionId;
                    objAnswer.UpdDate = strDate;
                    objAnswer.UpdUser = strUserId;
                    clsAnswerBL.AddNewRecordBySql2(objAnswer);
                }
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("复制多记录出错！\r\n" + objException.Message);
            }
        }

        public static int QuestionCount(string strQuestionnaireSetId)
        {
            int intCount = clsQuestionnaireDAEx.QuestionCount(strQuestionnaireSetId);
            return intCount;
        }

        public static bool AdjustSequenceNumber(string strDirect, long strQuestionId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().AdjustSequenceNumber(strDirect, strQuestionId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错！\r\n" + objException.Message);
            }
        }
        public static bool AdjustSequenceNumberByCourse(string strDirect, long strQuestionId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().AdjustSequenceNumberByCourse(strDirect, strQuestionId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错！\r\n" + objException.Message);
            }
        }
        public static bool ReOrder(string strQuestionnaireSetId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().ReOrder(strQuestionnaireSetId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错！\r\n" + objException.Message);
            }

        }
        public static bool ReOrderByCourse(string strCourseId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().ReOrderByCourse(strCourseId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错！\r\n" + objException.Message);
            }

        }

        public static bool ReOrderByCourseByChapter(string strCourseId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().ReOrderByCourseByChapter(strCourseId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错！\r\n" + objException.Message);
            }

        }
        public static bool AutoGridTitle(string strQuestionnaireSetId)
        {
            try
            {
                bool bolResult = new clsQuestionnaireDAEx().AutoGridTitle(strQuestionnaireSetId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("自动编表格标题出错！\r\n" + objException.Message);
            }

        }

        public static int GridTitleAddT(List<string> lstKey, string strUserId)
        {
            try
            {
                int intCount = new clsQuestionnaireDAEx().GridTitleAddT(lstKey, strUserId);
                return intCount;
            }
            catch (Exception objException)
            {
                throw new Exception("所选表格标题加T出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 为判断题自动添加答案，添加“是”和“否”
        /// </summary>
        /// <param name="strQuestionId">题目Id</param>
        /// <param name="strUserId">用户Id</param>
        /// <returns>是否成功</returns>
        public static bool AddQuestionOptionsLst4JudgeQuestionnaire(long strQuestionId, string strUserId)
        {
            clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN();
            objQuestionOptionsEN.QuestionId = strQuestionId;
            objQuestionOptionsEN.Score = 1.0;
            objQuestionOptionsEN.OptionIndex = 1;
            objQuestionOptionsEN.OptionName = "是";
            //objQuestionOptionsEN.OptionContent = "true";
            //objQuestionOptionsEN.QuestionOptionsTitle = "A";
            objQuestionOptionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objQuestionOptionsEN.UpdUser = strUserId;
            string strCondition = string.Format("QuestionId='{0}' And OptionName='是'", strQuestionId);
            if (clsQuestionOptionsBL.IsExistRecord(strCondition) == false)
            {
                clsQuestionOptionsBL.AddNewRecordBySql2(objQuestionOptionsEN);
            }
            objQuestionOptionsEN = new clsQuestionOptionsEN();
            objQuestionOptionsEN.QuestionId = strQuestionId;
            objQuestionOptionsEN.Score = 1.0;
            objQuestionOptionsEN.OptionIndex = 2;
            objQuestionOptionsEN.OptionName = "否";
            //objQuestionOptionsEN.OptionContent = "false";
            //objQuestionOptionsEN.QuestionOptionsTitle = "B";
            objQuestionOptionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objQuestionOptionsEN.UpdUser = strUserId;
            strCondition = string.Format("QuestionId='{0}' And OptionName='否'", strQuestionId);
            if (clsQuestionOptionsBL.IsExistRecord(strCondition) == false)
            {
                clsQuestionOptionsBL.AddNewRecordBySql2(objQuestionOptionsEN);
            }
            return true;

        }

        public static string GetQuestionnaireResourceString(string strParentCtrlId, string strContent_Replace, long strQuestionId, bool bolIsIE, clsLog objLog)
        {
            clsContentTypeEN objContentTypeEN = clsContentTypeBLEx.GetContentTypeObjByTableNameAndFldName_Cache(
                clsQuestionnaireEN._CurrTabName, conQuestionnaire.QuestionContent);

            if (objContentTypeEN == null)
            {
                string strMsg = string.Format("该内容类型不存在！TabName={0}; FldName={1}(In {2})",
                    clsQuestionnaireEN._CurrTabName, conQuestionnaire.QuestionContent, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            string strCondition = string.Format(" {0}='{1}' And {2}='{3}' order by OrderNum",
                                         convtz_ContentAttachment.ContentTypeId, objContentTypeEN.ContentTypeId,
                                         convtz_ContentAttachment.TableNameKey, strQuestionId);
            List<clsvtz_ContentAttachmentEN> arrvcc_AttachmentObjLst = clsvtz_ContentAttachmentBL.GetObjLst(strCondition);
            int intTotalContentHeight = 0;
            string strParentName = string.Format("{0}_{1}_{2}", strParentCtrlId, objContentTypeEN.ContentTypeId, strQuestionId);
            if (arrvcc_AttachmentObjLst.Count > 0)
            {
                //获取缩略图
                string strThumbnailString = clstz_ContentAttachmentBLEx.GetShowExtResourceString(arrvcc_AttachmentObjLst, true, false, objLog, false, strParentName, bolIsIE, ref intTotalContentHeight);
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
        /// 根据分类字段获取缓存中对象列表的子集，根据:QuestionTypeId字段
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetSubSet4ObjList)
        /// </summary>
        /// <param name = "strCourseId">strCourseId</param>
        /// <param name = "strQuestionTypeId">需要排序的对象列表</param>
        //public static List<clsQuestionnaireEN> GetQuestionnaireObjLstByQuestionTypeId_CacheExBak(string strCourseId, 
        //    string strQuestionTypeId)
        //{
        //    if (string.IsNullOrEmpty(strQuestionTypeId) == true) return null;
        //    //初始化列表缓存
        //    InitListCache(strCourseId);
        //    IEnumerable<clsQuestionnaireEN> arrQuestionnaireObjLst_Sel1 =
        //    from objQuestionnaireEN in clsQuestionnaireBL.arrQuestionnaireObjLst_Cache
        //    where objQuestionnaireEN.QuestionTypeId == strQuestionTypeId
        //    select objQuestionnaireEN;
        //    List<clsQuestionnaireEN> arrQuestionnaireObjLst_Sel = new List<clsQuestionnaireEN>();
        //    foreach (clsQuestionnaireEN obj in arrQuestionnaireObjLst_Sel1)
        //    {
        //        arrQuestionnaireObjLst_Sel.Add(obj);
        //    }
        //    return arrQuestionnaireObjLst_Sel;
        //}
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strCourseId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsQuestionnaireBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员！({1}->{0})", clsStackTrace.GetCurrClassFunction(), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    //初始化列表缓存
        //    if (strCourseId_Cache_Init != strCourseId) clsQuestionnaireBL.ReFreshThisCache();
        //    string strWhereCond = string.Format("{0} = '{1}' And {2}='1' order by QuestionId", 
        //        conQuestionnaire.CourseId, strCourseId, conQuestionnaire.IsEffective);

        //    if (arrQuestionnaireObjLst_Cache == null)
        //    {
        //        arrQuestionnaireObjLst_Cache = clsQuestionnaireBL.GetObjLst(strWhereCond);
        //        strMsg = string.Format("初始化成功！strCourseId={0}，strCourseId_Cache_Init={1}.({2})",
        //       strCourseId, strCourseId_Cache_Init, clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
        //        strCourseId_Cache_Init = strCourseId;
        //    }
        //}
        /// <summary>
        /// 获取音标Id
        /// </summary>
        /// <param name="objQuestionnaireEN">题目</param>
        /// <returns></returns>
        public static string GetYinBiaoId(clsQuestionnaireEN objQuestionnaireEN)
        {
            string strQuestionName = objQuestionnaireEN.QuestionName;
            int intStart = strQuestionName.IndexOf("[");
            int intEnd = strQuestionName.IndexOf("]");
            if (intStart < 0 && intEnd < 0)
            {
                string strMsg = string.Format("语音识别题名中没有语音Id,请检查！(In {0})", clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objLog.WriteDebugLog(strMsg);
                return "";
            }
            string strYinBiaoId = strQuestionName.Substring(intStart + 1, intEnd - intStart - 1);
            return strYinBiaoId;
        }

        public static bool SetQuestionAnswer4SingleChoice(string strCourseId, string strOpUser)
        {
            string strCondition = $"{conQuestionnaire.CourseId} = '{strCourseId}' and {conQuestionnaire.QuestionTypeId} = '{enumQuestionType.SingleChoice_02}'";
            var arr = clsQuestionnaireBL.GetObjLst(strCondition);
            foreach (var objQuestion in arr)
            {
                string  strAnswer = clsQuestionOptionsBLEx.GetCorrectOptionIdByQuestionId(objQuestion.QuestionId, strCourseId);
                clsAnswerBLEx.SetQuestionAnswer(objQuestion.QuestionId, strAnswer, strCourseId, strOpUser);
            }
            return true;
        }
    }
}