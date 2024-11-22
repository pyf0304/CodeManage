using ExamLib.BusinessLogic;
using ExamLib.Entity;
using System.Collections.Generic;

namespace ExamLib.BusinessLogicEx
{
    public partial class clsQuestionRecommendBLEx
    {
        /// <summary>
        /// 通过用户、课程、知识点获取推荐的题目
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strCourseId"></param>
        /// <param name="strCourseKnowledgeId"></param>
        /// <returns></returns>
        public static long Get_RecommendQuestion(string strUserId, string strCourseId, string strCourseKnowledgeId)
        {

            try
            {
                //List<string> objKnowledgesList = clsUserAnswerResultBLEx.Getcc_CourseKnowledgesList(strUserId, strCourseId);

                
                long strQuestionId = 0;
                string strWhere1 = " CourseKnowledgeId='" + strCourseKnowledgeId + "'";
                List<clscc_KnowledgesExamLibRelaEN> arrcc_KnowledgesExamLibRela = clscc_KnowledgesExamLibRelaBL.GetObjLst(strWhere1);

                List<clsUserAnswerResultEN> arrUserAnswerResult1 = new List<clsUserAnswerResultEN>();
                List<clsUserAnswerResultEN> arrUserAnswerResult2 = new List<clsUserAnswerResultEN>();

                string strWhere2 = " UserId='" + strUserId + "' and CourseId='" + strCourseId + "' order by Update Asc";
                arrUserAnswerResult1 = clsUserAnswerResultBL.GetObjLst(strWhere2);

                int KnowledgesExamNum = arrcc_KnowledgesExamLibRela.Count;//知识点的题目数


                if (KnowledgesExamNum > 0)
                {
                    if (KnowledgesExamNum == 1)//如果当前知识点下面只有一个题目，那么就返回这一道题目
                    {
                        return arrcc_KnowledgesExamLibRela[0].QuestionId;
                    }
                    else//如果有多道，那么就优先返回没有做过的题目
                    {
                        int OperationNum = 0;
                        foreach (clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRela in arrcc_KnowledgesExamLibRela)
                        {
                            strQuestionId = objcc_KnowledgesExamLibRela.QuestionId;
                            arrUserAnswerResult2 = arrUserAnswerResult1.FindAll(x => x.QuestionId == strQuestionId);
                            if (arrUserAnswerResult2.Count == 0)
                            {
                                return strQuestionId;
                            }
                            else
                            {
                                OperationNum++;
                            }
                        }

                        if (KnowledgesExamNum == OperationNum)//如果知识点的题目数和操作数相等，说明当前知识点的题目都被做过了，那么我们就取最好的题目返回
                        {
                            return arrUserAnswerResult1[0].QuestionId??0;
                        }
                    }
                }
                else
                {
                    return 0;
                }

                return strQuestionId;
            }
            catch (System.Exception)
            {

                throw;
            }


        }
    }
}
