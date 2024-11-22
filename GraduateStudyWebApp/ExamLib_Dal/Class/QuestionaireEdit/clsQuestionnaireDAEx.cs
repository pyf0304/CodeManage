
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamLib.DAL
{
    /// <summary>
    /// 题目(Questionnaire)
    /// (AutoGCLib.DALExCode4CSharp:GeneCode)
    /// </summary>

    public class clsQuestionnaireDAEx : clsQuestionnaireDA
    {
        //同时删除多条记录
        public static bool DelQuestionnaireEx(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQuestionnaireDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);

            strSQL = "";
            //删除ExamLib本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from UserAnswerResult where QuestionId in (" + strKeyList + ");";
            strSQL = strSQL + "Delete from Answer where QuestionId in (" + strKeyList + ");";
            strSQL = strSQL + "Delete from ExamLib where QuestionId in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }
        //同时删除多条记录
        public bool ChangeRadioDirect(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {
                if (objQuestionnaire.TextDirectId == "0002")
                {
                    objQuestionnaire.TextDirectId = "0001";
                }
                else
                {
                    objQuestionnaire.TextDirectId = "0002";
                }
                UpdateBySql2(objQuestionnaire);
            }
            return true;
        }


        //同时删除多条记录
        public bool ChangeAutoGridTitle(List<string> lstKey)
        {
            //string strKeyList;
            //if (lstKey.Count == 0) return true;
            //strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            //List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            //foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            //{
            //    if (objQuestionnaire.IsAutoGridTitle)
            //    {
            //        objQuestionnaire.IsAutoGridTitle = false;
            //    }
            //    else
            //    {
            //        objQuestionnaire.IsAutoGridTitle = true;
            //    }
            //    UpdateBySql2(objQuestionnaire);
            //}
            return true;
        }

        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {

                objQuestionnaire.QuestionIndex = objQuestionnaire.QuestionIndex - 10000;

                UpdateBySql2(objQuestionnaire);
            }
            return true;
        }

        public bool GoTopByCourse(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {

                objQuestionnaire.QuestionIndex = objQuestionnaire.QuestionIndex - 10000;

                UpdateBySql2(objQuestionnaire);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {

                objQuestionnaire.QuestionIndex = objQuestionnaire.QuestionIndex + 10000;

                UpdateBySql2(objQuestionnaire);
            }
            return true;
        }

        public bool GoBottomByCourse(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {

                objQuestionnaire.QuestionIndex = objQuestionnaire.QuestionIndex + 10000;

                UpdateBySql2(objQuestionnaire);
            }

            return true;
        }

        //同时删除多条记录
        public static bool DelRecordEx(long strQuestionId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQuestionnaireDA.GetSpecSQLObj();
            string strSQL;


            strSQL = "";
            //删除ExamLib本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("Delete from {0} where {1} ='{2}';",
                concc_CourseExamPaperRelationship._CurrTabName,
                concc_CourseExamPaperRelationship.QuestionId,
                strQuestionId);
            strSQL = strSQL + string.Format("Delete from {0} where {1} ='{2}';",
                conUserAnswerResult._CurrTabName,
                conUserAnswerResult.QuestionId,
                strQuestionId);
            strSQL = strSQL + string.Format("Delete from {0} where {1} ='{2}';",
                conQuestionOptions._CurrTabName,
                conQuestionOptions.QuestionId,
                strQuestionId);
            strSQL = strSQL + string.Format("Delete from {0} where {1} ='{2}';",
                conAnswer._CurrTabName,
                conAnswer.QuestionId,
                strQuestionId);
            strSQL = strSQL + string.Format("Delete from {0} where {1} ='{2}';",
                conQuestionnaire._CurrTabName,
                conQuestionnaire.QuestionId,
                strQuestionId);
            return objSQL.ExecSql(strSQL);
        }

        public static int QuestionCount(string strQuestionnaireSetId)
        {
            int intCount = clsGeneralTab.funGetRecCountByCond(conQuestionnaire._CurrTabName, "QuestionnaireSetId = '" + strQuestionnaireSetId + "'");
            return intCount;
        }

        public bool ReOrder(string strQuestionnaireSetId)
        {
            List<clsQuestionnaireEN> arrQuestionnaireObjList = new clsQuestionnaireDA().GetObjLst("QuestionnaireSetId = '" + strQuestionnaireSetId + "' order by QuestionIndex ");
            int intIndex = 1;
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireObjList)
            {
                objQuestionnaire.QuestionIndex = intIndex;
                //objQuestionnaire.QuestionnaireSetId
                this.UpdateBySql2(objQuestionnaire);
                intIndex++;
            }
            return true;
        }

        public bool ReOrderByCourse(string strCourseId)
        {
            List<clsQuestionnaireEN> arrQuestionnaireObjList = new clsQuestionnaireDA().GetObjLst("CourseId = '" + strCourseId + "' order by QuestionIndex ");
            int intIndex = 1;
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireObjList)
            {
                objQuestionnaire.QuestionIndex = intIndex;
                objQuestionnaire.QuestionNo = objQuestionnaire.QuestionIndex.ToString();

                //objQuestionnaire.QuestionnaireSetId
                this.UpdateBySql2(objQuestionnaire);
                intIndex++;
            }
            return true;
        }
        public bool ReOrderByCourseByChapter(string strCourseId)
        {
            string strCondition = string.Format("CourseId = '{0}' order by {1},{2} ",
                strCourseId,
                convQuestionnaire.ChapterOrderNum,
                convQuestionnaire.QuestionIndex);
            List<clsvQuestionnaireEN> arrQuestionnaireObjList = new clsvQuestionnaireDA().GetObjLst(strCondition);
            int intIndex = 1;
            foreach (clsvQuestionnaireEN objvQuestionnaire in arrQuestionnaireObjList)
            {
                clsQuestionnaireEN objQuestionnaireEN = new clsQuestionnaireDA().GetObjByQuestionId(objvQuestionnaire.QuestionId);
                objQuestionnaireEN.QuestionIndex = intIndex;
                objQuestionnaireEN.QuestionNo = objQuestionnaireEN.QuestionIndex.ToString();

                //objQuestionnaire.QuestionnaireSetId
                this.UpdateBySql2(objQuestionnaireEN);
                intIndex++;
            }
            return true;
        }
        public bool AutoGridTitle(string strQuestionnaireSetId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("QuestionnaireSetId = '{0}' and IsAutoGridTitle='1' order by QuestionIndex ", strQuestionnaireSetId);
            List<clsQuestionnaireEN> arrQuestionnaireObjList = new clsQuestionnaireDA().GetObjLst(sbCondition.ToString());
            int intIndex = 1;
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireObjList)
            {
                objQuestionnaire.GridTitle = "T" + intIndex.ToString();
                objQuestionnaire.QuestionNo = intIndex.ToString();
                this.UpdateBySql2(objQuestionnaire);
                intIndex++;
            }
            return true;
        }

        public int GridTitleAddT(List<string> lstKey, string strUserId)
        {
            string strKeyList;
            if (lstKey.Count == 0) return 0;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            int iCount = 0;
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {
                objQuestionnaire.GridTitle = "T" + objQuestionnaire.QuestionNo;
                objQuestionnaire.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objQuestionnaire.UpdUser = strUserId;
                this.UpdateBySql2(objQuestionnaire);
                iCount++;
            }
            return iCount;
        }
        public bool ClearQuestionNo(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {

                objQuestionnaire.QuestionNo = "";
                this.UpdateBySql2(objQuestionnaire);
            }
            return true;
        }

        public bool AnswerNumberingABC(List<long> lstKey)
        {
            if (lstKey.Count == 0) return true;

            foreach (long strQuestionId in lstKey)
            {
                StringBuilder sbCondition2 = new StringBuilder();
                sbCondition2.AppendFormat(" QuestionId ='{0}'", strQuestionId);
                List<clsAnswerEN> arrAnswerLst = new clsAnswerDA().GetObjLst(sbCondition2.ToString());
                int i = 0;
                foreach (clsAnswerEN objAnswer in arrAnswerLst)
                {
                    //if (objAnswer.AnswerName.Length == 0) break;
                    //string strHeadStr = Convert.ToChar(i + 65) + "";
                    //if (objAnswer.AnswerName.Substring(0, 1) != strHeadStr)
                    //{
                    //    objAnswer.AnswerName = Convert.ToChar(i + 65) + "、" + objAnswer.AnswerName;
                    //    //objAnswer.AnswerTitle = Convert.ToChar(i + 65).ToString();
                    //}
                    objAnswer.AnswerIndex = i + 1;
                    new clsAnswerDA().UpdateBySql2(objAnswer);
                    i++;
                }

            }
            return true;
        }


        /// <summary>
        /// 设置题目序号
        /// </summary>
        /// <param name="lstKey">题目关键字列表</param>
        /// <param name="intQuestionTypeId">新的题目序号</param>
        /// <returns></returns>
        public bool SetQuestionIndex(List<string> lstKey, int intQuestionIndex)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            //====题目类型====    
            //01	填空题	填空
            //02	单选题	单选题
            //03	多选题	多选题
            //04	开放题	开放题
            //05	解答题	解答
            //06	标题	用于显示标题，不作为问卷内容。
            //07	说明性内容	说明性内容，不作为问卷内容
            //08	单选题(下拉框)	单选题(下拉框)
            //====答案类型====
            //1	复选框	NULL
            //2	单选框	NULL
            //3	文本框	NULL
            //4	无答案	NULL
            //5	下拉框	NULL
            //====答案模式====
            //0000	无	
            //0001	代码	NULL
            //0002	文本	NULL
            //0003	代码、文本	NULL

            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {
                objQuestionnaire.QuestionIndex = intQuestionIndex;
                if (objQuestionnaire.QuestionTypeId == "01")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "02")
                {
                    objQuestionnaire.AnswerTypeId = "02";
                }
                else if (objQuestionnaire.QuestionTypeId == "03")
                {
                    objQuestionnaire.AnswerTypeId = "01";
                }
                else if (objQuestionnaire.QuestionTypeId == "04")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "05")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "06")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "07")
                {
                    objQuestionnaire.AnswerTypeId = "04";
                }
                else if (objQuestionnaire.QuestionTypeId == "08")
                {
                    objQuestionnaire.AnswerTypeId = "02";
                }
                if (objQuestionnaire.IsHaveAdditionalMemo)
                {
                    objQuestionnaire.MemoTextWidth = 500;
                }
                if (objQuestionnaire.IsHaveAdditionalMemo && (objQuestionnaire.QuestionTypeId == "02" || objQuestionnaire.QuestionTypeId == "03"))
                {
                    objQuestionnaire.AnswerModeId = "0003";
                }
                if (objQuestionnaire.IsHaveAdditionalMemo == false && (objQuestionnaire.QuestionTypeId == "02" || objQuestionnaire.QuestionTypeId == "03"))
                {
                    objQuestionnaire.AnswerModeId = "0001";
                }
                this.UpdateBySql2(objQuestionnaire);
            }
            return true;
        }




        /// <summary>
        /// 设置缺省值
        /// </summary>
        /// <param name="lstKey">题目关键字列表</param>
        /// <param name="strDefaultValue">缺省值</param>
        /// <returns></returns>
        public bool SetDefaultValue(List<string> lstKey, string strDefaultValue)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {
                objQuestionnaire.DefaultValue = strDefaultValue;
                if (objQuestionnaire.QuestionTypeId == "01")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "02")
                {
                    objQuestionnaire.AnswerTypeId = "02";
                }
                else if (objQuestionnaire.QuestionTypeId == "03")
                {
                    objQuestionnaire.AnswerTypeId = "01";
                }
                else if (objQuestionnaire.QuestionTypeId == "04")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "05")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "06")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "07")
                {
                    objQuestionnaire.AnswerTypeId = "04";
                }
                else if (objQuestionnaire.QuestionTypeId == "08")
                {
                    objQuestionnaire.AnswerTypeId = "02";
                }
                if (objQuestionnaire.IsHaveAdditionalMemo)
                {
                    objQuestionnaire.MemoTextWidth = 500;
                }
                if (objQuestionnaire.IsHaveAdditionalMemo && (objQuestionnaire.QuestionTypeId == "02"
                    || objQuestionnaire.QuestionTypeId == "03"))
                {
                    objQuestionnaire.AnswerModeId = "0003";
                }
                if (objQuestionnaire.IsHaveAdditionalMemo == false && (objQuestionnaire.QuestionTypeId == "02"
                    || objQuestionnaire.QuestionTypeId == "03"))
                {
                    objQuestionnaire.AnswerModeId = "0001";
                }
                this.UpdateBySql2(objQuestionnaire);
            }
            return true;
        }
        /// <summary>
        /// 设置题目类型
        /// </summary>
        /// <param name="lstKey">题目关键字列表</param>
        /// <param name="intQuestionTypeId">新的题目类型</param>
        /// <returns></returns>
        public static bool SetQuestionType(List<string> lstKey, string strQuestionTypeId)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = new clsQuestionnaireDA().GetObjLst(sbCondition.ToString());
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {
                objQuestionnaire.QuestionTypeId = strQuestionTypeId;
                if (objQuestionnaire.QuestionTypeId == "01")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "02")
                {
                    objQuestionnaire.AnswerTypeId = "02";
                }
                else if (objQuestionnaire.QuestionTypeId == "03")
                {
                    objQuestionnaire.AnswerTypeId = "01";
                }
                else if (objQuestionnaire.QuestionTypeId == "04")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "05")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "06")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "07")
                {
                    objQuestionnaire.AnswerTypeId = "04";
                }
                else if (objQuestionnaire.QuestionTypeId == "08")
                {
                    objQuestionnaire.AnswerTypeId = "02";
                }
                if (objQuestionnaire.IsHaveAdditionalMemo)
                {
                    objQuestionnaire.MemoTextWidth = 500;
                }
                if (objQuestionnaire.IsHaveAdditionalMemo && (objQuestionnaire.QuestionTypeId == "02"
                    || objQuestionnaire.QuestionTypeId == "03"))
                {
                    objQuestionnaire.AnswerModeId = "0003";
                }
                if (objQuestionnaire.IsHaveAdditionalMemo == false && (objQuestionnaire.QuestionTypeId == "02"
                    || objQuestionnaire.QuestionTypeId == "03"))
                {
                    objQuestionnaire.AnswerModeId = "0001";
                }
                new clsQuestionnaireDA().UpdateBySql2(objQuestionnaire);
            }
            return true;
        }
        public bool AutoChangeReleProperty(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QuestionId in ({0})", strKeyList);
            List<clsQuestionnaireEN> arrQuestionnaireLst = GetObjLst(sbCondition.ToString());
            foreach (clsQuestionnaireEN objQuestionnaire in arrQuestionnaireLst)
            {
                //1	填空题	填空
                //2	单选题	单选题
                //3	多选题	多选题
                //4	开放题	开放题
                //5	解答题	解答
                //6	标题	用于显示标题，不作为问卷内容。
                //7	说明性内容	说明性内容，不作为问卷内容
                //8	单选题(下拉框)	单选题(下拉框)
                if (objQuestionnaire.QuestionTypeId == "01")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "02")
                {
                    objQuestionnaire.AnswerTypeId = "02";
                }
                else if (objQuestionnaire.QuestionTypeId == "03")
                {
                    objQuestionnaire.AnswerTypeId = "01";
                }
                else if (objQuestionnaire.QuestionTypeId == "04")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "05")
                {
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "06")
                {
                    objQuestionnaire.AnswerModeId = "0000";
                    objQuestionnaire.AnswerTypeId = "03";
                    objQuestionnaire.FillInTextWidth = 300;
                }
                else if (objQuestionnaire.QuestionTypeId == "07")
                {
                    objQuestionnaire.AnswerTypeId = "04";
                }
                else if (objQuestionnaire.QuestionTypeId == "08")
                {
                    objQuestionnaire.AnswerTypeId = "02";
                }
                if (objQuestionnaire.IsHaveAdditionalMemo)
                {
                    objQuestionnaire.MemoTextWidth = 500;
                }
                if (objQuestionnaire.IsHaveAdditionalMemo && (objQuestionnaire.QuestionTypeId == "02"
                    || objQuestionnaire.QuestionTypeId == "03"))
                {
                    objQuestionnaire.AnswerModeId = "0003";
                }
                if (objQuestionnaire.IsHaveAdditionalMemo == false && (objQuestionnaire.QuestionTypeId == "02"
                    || objQuestionnaire.QuestionTypeId == "03"))
                {
                    objQuestionnaire.AnswerModeId = "0001";
                }
                if (objQuestionnaire.QuestionTypeId == "01")
                {
                    objQuestionnaire.AnswerModeId = "0002";
                }

                this.UpdateBySql2(objQuestionnaire);
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, long strQuestionId)
        {
            ///操作步骤：
            ///1、获取当前所选中的关键字QuestionId。
            ///2、根据关键字QuestionId来获取字的序号
            ///3、如果当前序号是否是末端序号，
            ///		3.1 如果是末端序号，就退出，
            ///		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            ///		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            ///		    如果是向上移动，就判断当前序号是否“大于”1，
            ///		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            ///4、获取下(上)一个序号字段的关键字QuestionId
            ///5、把当前关键字QuestionId的序号加(减)1
            ///6、把下一个序号的关键字QuestionId减(加)1
            ///7、重新显示DATAGRID
            ///

            int intQuestionIndex;   //当前记录的序号
            int intPrevQuestionIndex, intNextQuestionIndex; //上下两条记录的序号
                                                            //			long strQuestionId;
            long strPrevQuestionId = 0;  //上一条序号的关键字QuestionId
            long strNextQuestionId = 0;  //下一条序号的关键字QuestionId
            int intTabRecNum;       //当前表中字段的记录数
            string strCurrQuestionnaireSetId;
            //List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            ///1、获取当前所选中的字段ID。

            clsQuestionnaireEN objQuestionnaire = new clsQuestionnaireEN(strQuestionId);
            this.GetQuestionnaire(ref objQuestionnaire);
            intQuestionIndex = objQuestionnaire.QuestionIndex ?? 0;
            intPrevQuestionIndex = intQuestionIndex - 1;
            intNextQuestionIndex = intQuestionIndex + 1;
            ///3、如果当前序号是否是末端序号，
            ///		3.1 如果是末端序号，就退出，
            strCurrQuestionnaireSetId = "";// objQuestionnaire.QuestionnaireSetId;		//获取当前记录的{表ID}
            intTabRecNum = clsQuestionnaireDA.GetRecCountByCond("QuestionnaireSetId = '" + strCurrQuestionnaireSetId + "'");    //获取当前{表ID}的记录数
            if (strDirect == "UP")
            {
                if (intQuestionIndex <= 1)
                {
                    throw new Exception("已经是第一条记录，不能再上移!");
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intQuestionIndex >= intTabRecNum)   //如果当前序号大于表记录数
                {
                    throw new Exception("已经是最后一条记录，不能再下移!");
                }
            }
            ///		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            ///		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            ///		    如果是向上移动，就判断当前序号是否“大于”1，
            ///		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。

            ///4、获取下(上)一个序号字段的关键字QuestionId
            if (strDirect == "UP")
            {
                strCondition.AppendFormat("QuestionnaireSetId = '{0}' and QuestionIndex = {1}",
                    strCurrQuestionnaireSetId, intQuestionIndex - 1);
                strPrevQuestionId = this.GetFirstID(strCondition.ToString());

                if (strPrevQuestionId == 0)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat("QuestionnaireSetId = '{0}' and QuestionIndex = {1}",
                    strCurrQuestionnaireSetId, intQuestionIndex + 1);
                strNextQuestionId = this.GetFirstID(strCondition.ToString());

                if (strNextQuestionId == 0)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            ///5、把当前关键字QuestionId的序号加(减)1
            ///6、把下一个序号的关键字QuestionId减(加)1
            if (strDirect == "UP")
            {
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionIndex, intQuestionIndex - 1,
                    string.Format("{0} = '{1}'", conQuestionnaire.QuestionId, strQuestionId));
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionIndex, intPrevQuestionIndex + 1,
                    "QuestionId = '" + strPrevQuestionId + "'");
            }
            else if (strDirect == "DOWN")
            {
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionIndex, intQuestionIndex + 1,
                    "QuestionId = '" + strQuestionId + "'");
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionIndex, intNextQuestionIndex - 1,
                    "QuestionId = '" + strNextQuestionId + "'");
            }
            ///7、重新显示DATAGRID
            return true;
        }
        public bool AdjustSequenceNumberByCourse(string strDirect, long strQuestionId)
        {
            ///操作步骤：
            ///1、获取当前所选中的关键字QuestionId。
            ///2、根据关键字QuestionId来获取字的序号
            ///3、如果当前序号是否是末端序号，
            ///		3.1 如果是末端序号，就退出，
            ///		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            ///		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            ///		    如果是向上移动，就判断当前序号是否“大于”1，
            ///		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            ///4、获取下(上)一个序号字段的关键字QuestionId
            ///5、把当前关键字QuestionId的序号加(减)1
            ///6、把下一个序号的关键字QuestionId减(加)1
            ///7、重新显示DATAGRID
            ///

            int intQuestionIndex;   //当前记录的序号
            int intPrevQuestionIndex, intNextQuestionIndex; //上下两条记录的序号
                                                            //			long strQuestionId;
            long strPrevQuestionId =0;  //上一条序号的关键字QuestionId
            long strNextQuestionId = 0;  //下一条序号的关键字QuestionId
            int intTabRecNum;       //当前表中字段的记录数
            string strCurrCourseId;
            //List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            ///1、获取当前所选中的字段ID。

            clsQuestionnaireEN objQuestionnaire = new clsQuestionnaireEN(strQuestionId);
            this.GetQuestionnaire(ref objQuestionnaire);
            intQuestionIndex = objQuestionnaire.QuestionIndex ?? 0;
            intPrevQuestionIndex = intQuestionIndex - 1;
            intNextQuestionIndex = intQuestionIndex + 1;
            ///3、如果当前序号是否是末端序号，
            ///		3.1 如果是末端序号，就退出，
            strCurrCourseId = objQuestionnaire.CourseId;        //获取当前记录的{表ID}
            intTabRecNum = clsQuestionnaireDA.GetRecCountByCond("CourseId = '" + strCurrCourseId + "'");    //获取当前{表ID}的记录数
            if (strDirect == "UP")
            {
                if (intQuestionIndex <= 1)
                {
                    throw new Exception("已经是第一条记录，不能再上移!");
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intQuestionIndex >= intTabRecNum)   //如果当前序号大于表记录数
                {
                    throw new Exception("已经是最后一条记录，不能再下移!");
                }
            }
            ///		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            ///		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            ///		    如果是向上移动，就判断当前序号是否“大于”1，
            ///		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。

            ///4、获取下(上)一个序号字段的关键字QuestionId
            if (strDirect == "UP")
            {
                strCondition.AppendFormat("CourseId = '{0}' and QuestionIndex = {1}",
                    strCurrCourseId, intQuestionIndex - 1);
                strPrevQuestionId = this.GetFirstID(strCondition.ToString());

                if (strPrevQuestionId == 0)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat("CourseId = '{0}' and QuestionIndex = {1}",
                    strCurrCourseId, intQuestionIndex + 1);
                strNextQuestionId = this.GetFirstID(strCondition.ToString());

                if (strNextQuestionId == 0)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            ///5、把当前关键字QuestionId的序号加(减)1
            ///6、把下一个序号的关键字QuestionId减(加)1
            if (strDirect == "UP")
            {
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionIndex, intQuestionIndex - 1, "QuestionId = '" + strQuestionId + "'");
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionIndex, intPrevQuestionIndex + 1, "QuestionId = '" + strPrevQuestionId + "'");
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionNo, (intQuestionIndex - 1).ToString(), "QuestionId = '" + strQuestionId + "'");
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionNo, (intPrevQuestionIndex + 1).ToString(), "QuestionId = '" + strPrevQuestionId + "'");
            }
            else if (strDirect == "DOWN")
            {
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionIndex, intQuestionIndex + 1, "QuestionId = '" + strQuestionId + "'");
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionIndex, intNextQuestionIndex - 1, "QuestionId = '" + strNextQuestionId + "'");
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionNo, (intQuestionIndex + 1).ToString(), "QuestionId = '" + strQuestionId + "'");
                new clsQuestionnaireDA().SetFldValue(conQuestionnaire.QuestionNo, (intNextQuestionIndex - 1).ToString(), "QuestionId = '" + strNextQuestionId + "'");
            }
            ///7、重新显示DATAGRID
            return true;
        }

        public static bool CopyRecordEx(long strQuestionId, string strUserId, ref long strNewQuestionId)
        {
            clsQuestionnaireEN objQuestionnaire = new clsQuestionnaireEN(strQuestionId);
            new clsQuestionnaireDA().GetQuestionnaire(ref objQuestionnaire);
            objQuestionnaire.QuestionName = objQuestionnaire.QuestionName + "-复制";
            objQuestionnaire.UpdDate = clsDateTime.getTodayStr(0);
            objQuestionnaire.UpdUser = strUserId;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("QuestionName='{0}'", objQuestionnaire.QuestionName);
            sbCondition.AppendFormat(" And UpdDate='{0}'", objQuestionnaire.UpdDate);

            bool bolResult = new clsQuestionnaireDA().AddNewRecordBySQL2(objQuestionnaire);
            strNewQuestionId = new clsQuestionnaireDA().GetFirstID(sbCondition.ToString());
            return bolResult;
        }
    }
}
