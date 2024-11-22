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

        public static int AddDateExcelToSingleQuestionnaire(DataTable objDT, string strOpUserId)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            List<string> arrNeedFld = new List<string>() {
                "课程名",
                 "章名",
                 "题号",
                "正确答案",
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
            List<clscc_CourseEN> arrcc_Course_ForSelectCourse = clscc_CourseBL.GetObjLst_Cache();
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
            var objcc_Course = clscc_CourseBLEx.GetObjByCourseName_Cache(arrCourseName_Fld[0]);
            if (objcc_Course == null)
            {
                string strMsg = string.Format("课程名:{0}不存在！", arrCourseName_Fld[0]);
                throw new Exception(strMsg);
            }
            var strCourseId = objcc_Course.CourseId;
            //检查章名
            {
                List<clscc_CourseChapterEN> arrcc_CourseChapter_ForSelect = clscc_CourseChapterBL.GetObjLst_Cache(strCourseId);
                List<string> arrQuestionName_ForSelect = arrcc_CourseChapter_ForSelect.Select(x => x.ChapterName_Sim).ToList();
                //concc_CourseChapter.ChapterName_Sim
                //concc_CourseChapter.ChapterId

                string strQuestionName_Fld = "题目";

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
            {
                List<clsQuestionnaireEN> arrQuestionnaire_ForSelect = clsQuestionnaireBL.GetObjLst_Cache(strCourseId);
                List<string> arrQuestionName_ForSelect = arrQuestionnaire_ForSelect.Select(x => x.QuestionName).ToList();
                //conQuestionnaire.QuestionName
                string strQuestionName_Fld = "题目";

                arrFieldValue = GetDistinctFieldValue(objDT, strQuestionName_Fld);
                foreach (string strFieldValue in arrFieldValue)
                {
                    if (arrQuestionName_ForSelect.Contains(strFieldValue) == false)
                    {
                        sbErrInfo.AppendFormat("{2}：[{0}]在可供选择行政班[{3}]中不存在！({1})\r\n",
                          strFieldValue,
                          clsStackTrace.GetCurrClassFunction(), strQuestionName_Fld, clsArray.GetSqlInStrByArray(arrQuestionName_ForSelect, false));
                    }
                }
            }


            if (sbErrInfo.Length > 0)
            {
                throw new Exception(sbErrInfo.ToString());
            }
            int intCount = 0;

            HashSet<string> hsExamBatchId = new HashSet<string>();
            foreach (DataRow row in objDT.Rows)
            {
                //                考试日期 考试类型    序 届   入学年级 年级  课程 总分
                string strCourseName = row[arrNeedFld[0]].ToString();//   "课程名",
                string strChapterName_Sim = row[arrNeedFld[1]].ToString();//   "章名",
                string strAnswer = row[arrNeedFld[2]].ToString();//    "正确答案",
                string strQuestionName = row[arrNeedFld[3]].ToString();//    "题目",
                string strOptionA = row[arrNeedFld[4]].ToString();//  "选项A",
                string strOptionB = row[arrNeedFld[5]].ToString();//  "选项B",
                string strOptionC = row[arrNeedFld[6]].ToString();//  "选项C",
                string strOptionD = row[arrNeedFld[7]].ToString();//  "选项D",
                //string strGraduateYear = row[arrNeedFld[8]].ToString();//   "届",
                if (string.IsNullOrEmpty(strQuestionName) == true)
                {
                    continue;
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
                    pobjQuestionnaireEN.SetQuestionTypeId4Course(strCourseId);
                    pobjQuestionnaireEN.SetQuestionName(strQuestionName);// 题目名称
                    pobjQuestionnaireEN.SetDifficultyLevelId(enumge_DifficultyLevel.Easy_01);// 难度等级
                    pobjQuestionnaireEN.SetQuestionContent("");// 题目内容
                    pobjQuestionnaireEN.SetQuestionCode("");// html代码
                    pobjQuestionnaireEN.SetCourseId(strCourseId);// 课程
                    pobjQuestionnaireEN.SetCourseChapterId(objcc_CourseChapter.ChapterId);// 课程章节
                    pobjQuestionnaireEN.SetQuestionTypeId(enumQuestionType.SingleTopic_02);// 题目类型
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
                    bool bolResult = clsQuestionnaireBL.AddNewRecordBySql2(pobjQuestionnaireEN);
                    if (bolResult == true) intCount++;
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
                    catch (Exception objException)
                    {
                        continue;
                    }

                }
                //objDT.Rows.Add(objDR);
            }

            return objDT;
        }
    }
}