using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using ExamLib.BusinessLogic;

using ExamLib.Entity;

namespace ExamLib.BusinessLogicEx
{
    public class clsPubFun4DataImport
    {
        public static DataTable ExcelTable = null;

        public static int AddDateExcelToSingleQuestionnaire(DataTable objDT, string strQuestionTypeId, string strOpUserId)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            List<string> arrNeedFld = new List<string>() {
                "课程名",
                 "章名",
                 "题号",
                "正确答案",
                "分值",
                "题目",
                "选项A",
                "选项B",
                "选项C",
                "选项D"};
            arrNeedFld.ForEach((x) =>
            {
                if (objDT.Columns.Contains(x) == false)
                {
                    string strMsg = string.Format("您所上传的excel格式不对,缺少字段:[{0}]！请下载excel模板", x);
                    throw new Exception(strMsg);
                }
            });

            List<string> arrFieldValue = null;
            StringBuilder sbErrInfo = new StringBuilder();
            List<clscc_CourseEN> arrcc_Course_ForSelectCourse = clscc_CourseBL.GetObjLstCache();
            List<string> arrCourseName_ForSelectCourse = arrcc_Course_ForSelectCourse.Select(x => x.CourseName).ToList();
            List<string> arrCourseName_Fld = new List<string>() {
                "课程名"};
            arrCourseName_Fld.ForEach(x =>
            {
                arrFieldValue = GetDistinctFieldValue(objDT, x);
                foreach (string strFieldValue in arrFieldValue)
                {
                    if (arrCourseName_ForSelectCourse.Contains(strFieldValue) == false)
                    {
                        sbErrInfo.AppendFormat("{2}：[{0}]在可供选科课程名[{3}]中不存在！({1})\r\n",
                          strFieldValue,
                          clsStackTrace.GetCurrClassFunction(), x, clsArray.GetSqlInStrByArray(arrCourseName_ForSelectCourse, false));
                        continue;
                    }
                    clscc_CourseEN obj = clscc_CourseBLEx.GetObjByCourseName_Cache(strFieldValue);
                    if (obj == null)
                    {
                        sbErrInfo.AppendFormat("{2}：[{0}]在课程表中不存在！({1})\r\n",
                            strFieldValue,
                            clsStackTrace.GetCurrClassFunction(), x);
                    }
                }
            });
            var objcc_Course = clscc_CourseBLEx.GetObjByCourseName_Cache(arrFieldValue[0]);
            if (objcc_Course == null)
            {
                string strMsg = string.Format("课程名:{0}不存在！", arrCourseName_Fld[0]);
                throw new Exception(strMsg);
            }
            var strCourseId = objcc_Course.CourseId;
            //检查章名
            {
                List<clscc_CourseChapterEN> arrcc_CourseChapter_ForSelect = clscc_CourseChapterBL.GetObjLstCache(strCourseId);
                List<string> arrQuestionName_ForSelect = arrcc_CourseChapter_ForSelect.Select(x => x.ChapterNameSim).ToList();
                arrQuestionName_ForSelect = arrQuestionName_ForSelect.Distinct().ToList();
                //concc_CourseChapter.ChapterNameSim
                //concc_CourseChapter.ChapterId

                string strQuestionName_Fld = "章名";

                arrFieldValue = GetDistinctFieldValue(objDT, strQuestionName_Fld);
                foreach (string strFieldValue in arrFieldValue)
                {
                    if (arrQuestionName_ForSelect.Contains(strFieldValue) == false)
                    {
                        sbErrInfo.AppendFormat("{2}：[{0}]在可供选择章名[{3}]中不存在！({1})\r\n",
                          strFieldValue,
                          clsStackTrace.GetCurrClassFunction(), strQuestionName_Fld, clsArray.GetSqlInStrByArray(arrQuestionName_ForSelect, false));
                    }
                }
            }

            //检查题目名
            //{
            //    List<clsQuestionnaireEN> arrQuestionnaire_ForSelect = clsQuestionnaireBL.GetObjLstCache(strCourseId);
            //    List<string> arrQuestionName_ForSelect = arrQuestionnaire_ForSelect.Select(x => x.QuestionName).ToList();
            //    //conQuestionnaire.QuestionName
            //    string strQuestionName_Fld = "题目";

            //    arrFieldValue = GetDistinctFieldValue(objDT, strQuestionName_Fld);
            //    foreach (string strFieldValue in arrFieldValue)
            //    {
            //        if (arrQuestionName_ForSelect.Contains(strFieldValue) == false)
            //        {
            //            sbErrInfo.AppendFormat("{2}：[{0}]在可供选择题目[{3}]中不存在！({1})\r\n",
            //              strFieldValue,
            //              clsStackTrace.GetCurrClassFunction(), strQuestionName_Fld, clsArray.GetSqlInStrByArray(arrQuestionName_ForSelect, false));
            //        }
            //    }
            //}


            if (sbErrInfo.Length > 0)
            {
                throw new Exception(sbErrInfo.ToString());
            }
            int intRecNo_Exist = clsQuestionnaireBLEx.GetRecCountByCondEx(strCourseId);
            int intCount = 0;

            HashSet<string> hsExamBatchId = new HashSet<string>();
            foreach (DataRow row in objDT.Rows)
            {
                //                考试日期 考试类型    序 届   入学年级 年级  课程 总分
                string strCourseName = row[arrNeedFld[0]].ToString();//   "课程名",
                string strChapterName_Sim = row[arrNeedFld[1]].ToString();//   "章名",
                string strQuestionNo = row[arrNeedFld[2]].ToString();//    "正确答案",
                string strAnswer = row[arrNeedFld[3]].ToString();//    "正确答案",
                string strQuestionScore = row[arrNeedFld[4]].ToString();//    "分值",
                string strQuestionName = row[arrNeedFld[5]].ToString();//    "题目",
                string strOptionA = row[arrNeedFld[6]].ToString();//  "选项A",
                string strOptionB = row[arrNeedFld[7]].ToString();//  "选项B",
                string strOptionC = row[arrNeedFld[8]].ToString();//  "选项C",
                string strOptionD = row[arrNeedFld[9]].ToString();//  "选项D",
                //string strGraduateYear = row[arrNeedFld[8]].ToString();//   "届",
                if (string.IsNullOrEmpty(strQuestionName) == true)
                {
                    continue;
                }
                float fltScore = 0.0f;
                if (string.IsNullOrEmpty(strQuestionScore) == false)
                {
                    fltScore = float.Parse(strQuestionScore);
                }
                //判断学号是否存在
                try
                {
                    var objcc_CourseChapter = clscc_CourseChapterBLEx.GetObjByChapterName_Sim_Cache(strChapterName_Sim, strCourseId);
                    if (objcc_CourseChapter == null)
                    {
                        var strMsg = string.Format("在课程:{0}没有章名:{1},请检查Excel.", strCourseName, strChapterName_Sim);
                        throw new Exception(strMsg);
                    }
                    var pobjQuestionnaireEN = new clsQuestionnaireEN();
                    //pobjQuestionnaireEN.QuestionId = clsQuestionnaireBL.GetMaxStrId_S();
                    pobjQuestionnaireEN.QuestionIndex = intRecNo_Exist + intCount + 1;
                    pobjQuestionnaireEN.QuestionNo = pobjQuestionnaireEN.QuestionIndex.ToString();// ("D4");
                    pobjQuestionnaireEN.SetQuestionTypeId(strQuestionTypeId);
                    //pobjQuestionnaireEN.SetQuestionTypeId4Course(strQuestionTypeId);
                    pobjQuestionnaireEN.SetQuestionName(strQuestionName);// 题目名称
                    pobjQuestionnaireEN.SetDifficultyLevelId(enumge_DifficultyLevel.Easy_01);// 难度等级
                    pobjQuestionnaireEN.SetQuestionContent("");// 题目内容
                    pobjQuestionnaireEN.SetQuestionCode("");// html代码
                    pobjQuestionnaireEN.SetQuestionScore(fltScore);// html代码
                    pobjQuestionnaireEN.SetCourseId(strCourseId);// 课程
                    pobjQuestionnaireEN.SetCourseChapterId(objcc_CourseChapter.CourseChapterId);// 课程章节
                    pobjQuestionnaireEN.SetAnswerTypeId(enumAnswerType.Radio_02);// 答案类型
                    pobjQuestionnaireEN.SetSectionTypeId(enumge_StructureSectionType.Type1_00000001);// 节点类型
                    pobjQuestionnaireEN.SetKnowledgeGraphId("0000000000");// 节点类型                                                                                   // pobjQuestionnaireEN.SetIsHaveAdditionalMemo(this.IsHaveAdditionalMemo;// 是否有附加说明
                    pobjQuestionnaireEN.SetLevelModeTypeId(enumge_LevelModeType.Practice_01);// 操作模式
                    pobjQuestionnaireEN.SetIsShow(true);// 是否启用
                    pobjQuestionnaireEN.SetIsRandom(true);// 是否随机
                    pobjQuestionnaireEN.SetIsEffective(true);// 是否有效

                    //pobjQuestionnaireEN.SetisTest(false;// 是否测试
                    pobjQuestionnaireEN.SetMemo("通过Excel导入");// 备注
                    pobjQuestionnaireEN.SetUpdDate(clsDateTime.getTodayDateTimeStr(0));// 修改日期
                    pobjQuestionnaireEN.SetUpdUser(strOpUserId);// 修改人                    
                    pobjQuestionnaireEN.QuestionId = long.Parse(clsQuestionnaireBL.AddNewRecordBySql2WithReturnKey(pobjQuestionnaireEN));
                    var arrOptionName = new List<string>() { strOptionA, strOptionB, strOptionC, strOptionD};
                    char chrAnswer = strAnswer.ToCharArray()[0];

                    int intAnswer = chrAnswer;
                    if (intAnswer > 72 || intAnswer < 65)
                    {
                        string strMsg = string.Format("选择题答案:{0}应该用大写字母。", strAnswer);
                        throw new Exception(strMsg);
                    }
                    int intAnswerIndex = intAnswer - 65;
                    int intIndex = 0;
                    string strQuestionOptionId = "";
                    foreach (string strOptionName in arrOptionName)
                    {
                        clsQuestionOptionsEN pobjQuestionOptionsEN = new clsQuestionOptionsEN();
                        pobjQuestionOptionsEN.QuestionOptionId = clsQuestionOptionsBL.GetMaxStrId_S();
                        pobjQuestionOptionsEN.QuestionId = pobjQuestionnaireEN.QuestionId;
                        pobjQuestionOptionsEN.SetOptionName(strOptionName);// 选项名称
                        //pobjQuestionOptionsEN.SetoptionIndex(this.optionIndex;// 选项序号
                        //pobjQuestionOptionsEN.SetOptionTitle(this.OptionTitle;// 选项标题
                        //pobjQuestionOptionsEN.SetOptionContent(this.OptionContent;// 选项内容
                        if (intAnswerIndex == intIndex)
                        {
                            pobjQuestionOptionsEN.SetIsCorrect(true);// 是否正确
                            strQuestionOptionId = pobjQuestionOptionsEN.QuestionOptionId;
                        }
                        else
                        {
                            pobjQuestionOptionsEN.SetIsCorrect(false);// 是否正确
                        }
                        pobjQuestionOptionsEN.SetCourseId(strCourseId);

                        pobjQuestionOptionsEN.SetIsShow(true);// 是否启用
                        pobjQuestionOptionsEN.SetMemo("通过Excel导入！");// 备注
                        pobjQuestionOptionsEN.SetUpdDate(clsDateTime.getTodayDateTimeStr(0));// 修改日期
                        pobjQuestionOptionsEN.SetUpdUser(strOpUserId);// 修改人  
                 
                        bool bolResult2 = clsQuestionOptionsBL.AddNewRecordBySql2(pobjQuestionOptionsEN);
                        intIndex++;
                    }

                    //添加到Answer
                    var pobjAnswerEN = new clsAnswerEN();
                    pobjAnswerEN.SetQuestionId(pobjQuestionnaireEN.QuestionId);
                    pobjAnswerEN.SetCourseId(strCourseId);
                    pobjAnswerEN.SetAnswerContent(strAnswer);// 答案内容
                    switch (strQuestionTypeId )
                    {
                        case enumQuestionType.SingleChoice_02:
                            pobjAnswerEN.SetAnswerOptionId(strQuestionOptionId);
                            pobjAnswerEN.SetIsAutoCorrect(true);
                            break;
                        case enumQuestionType.FillInBlank_01:
                            pobjAnswerEN.SetAnswerFillInBlank(strAnswer);// 填空题
                            break;
                        default:
                            pobjAnswerEN.SetIsAutoCorrect(false);
                            break;
                    }                 
                                                                              //pobjAnswerEN.SetisShow(this.isShow;// 是否启用
                    pobjAnswerEN.SetIsShow(true);// 是否启用
                    pobjAnswerEN.SetMemo("通过Excel导入！");// 备注
                    pobjAnswerEN.SetProvider(strOpUserId);
                    pobjAnswerEN.SetScore(fltScore);
                    pobjAnswerEN.SetUpdDate(clsDateTime.getTodayDateTimeStr(0));// 修改日期
                    pobjAnswerEN.SetUpdUser(strOpUserId);// 修改人
                    pobjAnswerEN.AddNewRecord();
                    if (pobjQuestionnaireEN.QuestionId>0) intCount++;
                }

                catch (Exception objException)
                {
                    string strMsg = string.Format("出错：{0}.(课程:{1}, 题目名:{2})(In {3})", objException.Message,
                        strCourseName,
                        strQuestionName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
            }
            return intCount;
        }


        /// <summary>
        /// 是否包含列表
        /// </summary>
        /// <param name="objDT"></param>
        /// <param name="strColumnName"></param>
        /// <returns></returns>
        private static string IsContainsColumnName(DataTable objDT, string strColumnName)
        {
            foreach (DataColumn objDC in objDT.Columns)
            {
                string strColumnName_In = objDC.ColumnName;
                if (strColumnName_In.IndexOf(strColumnName) >= 0 && strColumnName_In != strColumnName)
                {
                    return strColumnName_In;
                }
            }
            return "";
        }
        private static bool IsExistColumnName(DataTable objDT, string strColumnName)
        {
            foreach (DataColumn objDC in objDT.Columns)
            {
                string strColumnName_In = objDC.ColumnName;
                if (strColumnName == strColumnName_In)
                {
                    return true;
                }
            }
            return false;
        }


        public static List<string> GetDistinctFieldValue(DataTable objDT, string strFieldname)
        {
            List<string> arrFieldValue = new List<string>();
            foreach (DataRow row in objDT.Rows)
            {
                string strFieldValue = row[strFieldname].ToString();
                if (arrFieldValue.Contains(strFieldValue) == false)
                {
                    arrFieldValue.Add(strFieldValue);
                }
            }
            return arrFieldValue;
        }

        public static Dictionary<string, string> GetDistinctDictLst(DataTable objDT, string strKeyFieldName, string strValueFieldName)
        {
            Dictionary<string, string> dicLst = new Dictionary<string, string>();
            foreach (DataRow row in objDT.Rows)
            {
                string strKeyFieldNameValue = row[strKeyFieldName].ToString();
                string strValueFieldNameValue = row[strValueFieldName].ToString();
                if (dicLst.ContainsKey(strKeyFieldNameValue) == false)
                {
                    dicLst[strKeyFieldNameValue] = strValueFieldNameValue;
                }
            }
            return dicLst;
        }



        //删除DataTable里面空行数据
        public static void removeEmpty(System.Data.DataTable dt)
        {
            List<DataRow> removelist = new List<DataRow>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool rowdataisnull = true;
                for (int j = 0; j < dt.Columns.Count; j++)
                {

                    if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString().Trim()))
                    {

                        rowdataisnull = false;
                    }

                }
                if (rowdataisnull)
                {
                    removelist.Add(dt.Rows[i]);
                }

            }
            for (int i = 0; i < removelist.Count; i++)
            {
                dt.Rows.Remove(removelist[i]);
            }
        }
        public static DataTable csv2table(string csv)
        {
            DataTable objDT = new DataTable();
            var rows = csv.Split('\n');
            if (rows.Length == 0) return null;
            string strHeader = rows[0];
            var headers = strHeader.Split(',');
            foreach (string strColumn in headers)
            {
                var objColumn = new DataColumn();
                objColumn.ColumnName = strColumn.Trim();
                objDT.Columns.Add(objColumn);
            }
            bool bolIsFirst = true;
            foreach (string strRow in rows)
            {
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    continue;
                }
                DataRow objDR = objDT.Rows.Add();
                var columns = strRow.Split(',');
                for (int i = 0; i < objDT.Columns.Count; i++)
                {

                    string strColumn = "";
                    try
                    {
                        strColumn = columns[i];
                        objDR[objDT.Columns[i]] = strColumn;
                    }
                    catch 
                    {
                        continue;
                    }

                }
                //objDT.Rows.Add(objDR);
            }

            return objDT;
        }




        public static int AddDateExcelToJournalSubjectCategory(DataTable objDT, string strOpUserId, ref string lblMess)
        {
            //List<string> arrFieldValue = null;
            StringBuilder sbErrInfo = new StringBuilder();

            List<string> arrNeedFld = new List<string>() {
                "学科门类"
};
            arrNeedFld.ForEach((x) =>
            {
                if (objDT.Columns.Contains(x) == false)
                {
                    string strMsg = string.Format("您所上传的excel格式不对,缺少字段:[{0}]！请下载excel模板", x);
                    throw new Exception(strMsg);
                }
            });


            if (sbErrInfo.Length > 0)
            {
                throw new Exception(sbErrInfo.ToString());
            }
            int intCount = 0;
            foreach (DataRow row in objDT.Rows)
            {
                //                考试日期 考试类型    序 届   入学年级 年级  课程 总分


                string strJournalSubjectCategoryName = row["学科门类"].ToString().Trim();

                if (string.IsNullOrEmpty(strJournalSubjectCategoryName) == true) continue;

                clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
                objJournalSubjectCategoryEN.JournalSubjectCategoryName = strJournalSubjectCategoryName;
                objJournalSubjectCategoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objJournalSubjectCategoryEN.UpdUser = strOpUserId;
                objJournalSubjectCategoryEN.JournalSubjectCategoryId = clsJournalSubjectCategoryBL.GetMaxStrId_S();
                string strWhereCond = string.Format("{0}='{1}' ",
                    conJournalSubjectCategory.JournalSubjectCategoryName, objJournalSubjectCategoryEN.JournalSubjectCategoryName);
                bool bolIsExist = clsJournalSubjectCategoryBL.IsExistRecord(strWhereCond);


                //判断学号是否存在
                try
                {
                    if (bolIsExist == false)
                    {
                        clsJournalSubjectCategoryBL.AddNewRecordBySql2(objJournalSubjectCategoryEN);
                        intCount++;
                    }
                    //else
                    //{
                    //    clsJournalSubjectCategoryBL.UpdateBySqlWithCondition(objJournalSubjectCategoryEN, strWhereCond);
                    //    intCount++;
                    //}
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("出错：{0}.(学科门类:{1})(In {2})", objException.Message, strJournalSubjectCategoryName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
            }

            lblMess = string.Format("操作成功！共导入了{0}个学科门类记录。", intCount);
            return intCount;



        }



        //导入教师表的信息
        public static int AddDateExcelToJournalSubject(DataTable objDT, string strOpUserId, ref string lblmess)
        {
            clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
            int intCount = 0;
            //if (dt.Rows.Count > 0)
            //{
            List<string> arrNeedFld = new List<string>() {
                "学科门类",
                "学科代码",
                "学科"
};
            arrNeedFld.ForEach((x) =>
            {
                if (objDT.Columns.Contains(x) == false)
                {
                    string strMsg = string.Format("您所上传的excel格式不对,缺少字段:[{0}]！请下载excel模板", x);
                    throw new Exception(strMsg);
                }
            });



            List<string> arrFieldValue = null;
            StringBuilder sbErrInfo = new StringBuilder();

            arrFieldValue = GetDistinctFieldValue(objDT, "学科门类");
            foreach (string strFieldValue in arrFieldValue)
            {
                clsJournalSubjectCategoryEN college = clsJournalSubjectCategoryBLEx.GetObjByJournalSubjectCategoryNameEx(strFieldValue);
                if (college == null)
                {
                    sbErrInfo.AppendFormat("组别名：[{0}]在学科门类表中不存在！\r\n", strFieldValue);

                }
            }


            if (sbErrInfo.Length > 0)
            {
                throw new Exception(sbErrInfo.ToString());
            }
            foreach (DataRow row in objDT.Rows)
            {
                try
                {
                    objJournalSubjectEN.JournalSubjectId = clsJournalSubjectBL.GetMaxStrId_S();

                    objJournalSubjectEN.JournalSubjectCode = row["学科代码"].ToString();

                    if (string.IsNullOrEmpty(objJournalSubjectEN.JournalSubjectCode) == true)
                    {
                        continue;
                    }

                    objJournalSubjectEN.JournalSubjectName = row["学科"].ToString();
                    objJournalSubjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objJournalSubjectEN.UpdUser = strOpUserId;
                    //学院流水号获取
                    clsJournalSubjectCategoryEN objJournalSubjectCategory
                        = clsJournalSubjectCategoryBLEx.GetObjByJournalSubjectCategoryNameEx(row["学科门类"].ToString());
                    if (objJournalSubjectCategory != null)
                    {
                        objJournalSubjectEN.JournalSubjectCategoryId = objJournalSubjectCategory.JournalSubjectCategoryId;
                    }
                    string strCondition = string.Format("{0}='{1}'", conJournalSubject.JournalSubjectName,
                        objJournalSubjectEN.JournalSubjectName);
                    if (clsJournalSubjectBL.IsExistRecord(strCondition) == false)
                    {
                        clsJournalSubjectBL.AddNewRecordBySql2(objJournalSubjectEN);

                        intCount++;
                    }
                    else
                    {
                        objJournalSubjectEN.UpdateWithCondition(strCondition);
                        intCount++;
                    }
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("在导入学科:{0}时出错！错误:{1}.", objJournalSubjectEN.JournalSubjectName, objException.Message);
                    throw new Exception(strMsg);
                }
            }

            lblmess = string.Format("操作成功！共导入了{0}门期刊学科。", intCount);

            return intCount;

        }



        public static int AddDateExcelToAcademicJournals(DataTable objDT, string strOpUserId, ref string lblmess)
        {
            clsAcademicJournalsEN objAcademicJournalsEN = new clsAcademicJournalsEN();
            int intCount = 0;
            //if (dt.Rows.Count > 0)
            //{
            List<string> arrNeedFld = new List<string>() {
                "学科门类",
                "学科代码",
                "学科",
                "中文刊名"
};
            arrNeedFld.ForEach((x) =>
            {
                if (objDT.Columns.Contains(x) == false)
                {
                    string strMsg = string.Format("您所上传的excel格式不对,缺少字段:[{0}]！请下载excel模板", x);
                    throw new Exception(strMsg);
                }
            });



            List<string> arrFieldValue = null;
            StringBuilder sbErrInfo = new StringBuilder();

            arrFieldValue = GetDistinctFieldValue(objDT, "学科门类");
            foreach (string strFieldValue in arrFieldValue)
            {
                clsJournalSubjectCategoryEN college = clsJournalSubjectCategoryBLEx.GetObjByJournalSubjectCategoryNameEx(strFieldValue);
                if (college == null)
                {
                    sbErrInfo.AppendFormat("学科门类名：[{0}]在学科门类表中不存在！\r\n", strFieldValue);

                }
            }

            arrFieldValue = GetDistinctFieldValue(objDT, "学科");
            foreach (string strFieldValue in arrFieldValue)
            {
                clsJournalSubjectEN objJournalSubject = clsJournalSubjectBLEx.GetObjByJournalSubjectNameEx(strFieldValue);
                if (objJournalSubject == null)
                {
                    sbErrInfo.AppendFormat("学科名：[{0}]在学科表中不存在！\r\n", strFieldValue);

                }
            }


            if (sbErrInfo.Length > 0)
            {
                throw new Exception(sbErrInfo.ToString());
            }
            foreach (DataRow row in objDT.Rows)
            {
                try
                {
                    objAcademicJournalsEN.JournalId = clsAcademicJournalsBL.GetMaxStrId_S();

                    objAcademicJournalsEN.JournalName = row["中文刊名"].ToString();

                    if (string.IsNullOrEmpty(objAcademicJournalsEN.JournalName) == true)
                    {
                        continue;
                    }

                    //学院流水号获取
                    clsJournalSubjectCategoryEN objJournalSubjectCategory
                        = clsJournalSubjectCategoryBLEx.GetObjByJournalSubjectCategoryNameEx(row["学科门类"].ToString());
                    if (objJournalSubjectCategory != null)
                    {
                        objAcademicJournalsEN.JournalSubjectCategoryId = objJournalSubjectCategory.JournalSubjectCategoryId;
                    }
                    clsJournalSubjectEN objJournalSubject
                        = clsJournalSubjectBLEx.GetObjByJournalSubjectNameEx(row["学科"].ToString());
                    if (objJournalSubject != null)
                    {
                        objAcademicJournalsEN.JournalSubjectId = objJournalSubject.JournalSubjectId;
                    }
                    objAcademicJournalsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objAcademicJournalsEN.UpdUser = strOpUserId;
                    string strCondition = string.Format("{0}='{1}'", conAcademicJournals.JournalName,
                        objAcademicJournalsEN.JournalName);
                    if (clsAcademicJournalsBL.IsExistRecord(strCondition) == false)
                    {
                        clsAcademicJournalsBL.AddNewRecordBySql2(objAcademicJournalsEN);

                        intCount++;
                    }
                    else
                    {
                        objAcademicJournalsEN.UpdateWithCondition(strCondition);
                        intCount++;
                    }
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("在导入学术期刊:{0}时出错！错误:{1}.", objAcademicJournalsEN.JournalName, objException.Message);
                    throw new Exception(strMsg);
                }
            }

            lblmess = string.Format("操作成功！共导入了{0}门学术期刊。", intCount);

            return intCount;

        }

    }
}