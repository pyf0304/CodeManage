
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvViewpointScoreBLEx
表名:vViewpointScore(01120609)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 14:51:20
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using ExamLib.BusinessLogic;
using System;
using System.Text;

namespace ExamLib.BusinessLogicEx
{
    public static class clsIndexBLEx
    {
        public static string GetAllCount(string strUserId)
        {
            try
            {
                //string strJson = "";

                DateTime dt = DateTime.Now;  //当前时间
                DateTime startMonth = dt.AddDays(1 - dt.Day);  //本月月初                                      
                //DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);  //本月月末//
                string strStartMonth = startMonth.ToString("yyyy-MM-dd");

                DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d")));  //本周周一                                                                       
                //DateTime endWeek = startWeek.AddDays(6);  //本周周日
                string strStartWeek = startWeek.ToString("yyyy-MM-dd");
                string strToday = dt.ToString("yyyy-MM-dd");//当天

                //论文
                int PersonalPaperNum = clsPaperBL.GetRecCountByCond("1=1 And UpdUser = '" + strUserId + "'");
                int MonthPaperNum = clsPaperBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekPaperNum = clsPaperBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodayPaperNum = clsPaperBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //关注论文
                int PersonalPaperAttentionNum = clsgs_PaperAttentionBL.GetRecCountByCond("1=1 And UpdUser = '" + strUserId + "'");
                int MonthPaperAttentionNum = clsgs_PaperAttentionBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekPaperAttentionNum = clsgs_PaperAttentionBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodayPaperAttentionNum = clsgs_PaperAttentionBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //论文子观点
                int PersonalPaperSubViewpointNum = clsPaperSubViewpointBL.GetRecCountByCond("1=1 And UpdUser = '" + strUserId + "'");
                int MonthPaperSubViewpointNum = clsPaperSubViewpointBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekPaperSubViewpointNum = clsPaperSubViewpointBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodayPaperSubViewpointNum = clsPaperSubViewpointBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //论文答疑
                int Personalqa_QuestionsNum = clsqa_QuestionsBL.GetRecCountByCond("1=1 And UpdUser = '" + strUserId + "'");
                int Monthqa_QuestionsNum = clsqa_QuestionsBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int Weekqa_QuestionsNum = clsqa_QuestionsBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int Todayqa_QuestionsNum = clsqa_QuestionsBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //论文标注
                int Personalgs_TagsNum = clsgs_TagsBL.GetRecCountByCond("1=1 And UpdUser = '" + strUserId + "'");
                int Monthgs_TagsNum = clsgs_TagsBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int Weekgs_TagsNum = clsgs_TagsBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int Todaygs_TagsNum = clsgs_TagsBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //主题个人观点
                int PersonalViewpointNum = clsViewpointBL.GetRecCountByCond("1=1 And UserTypeId = '01' And UpdUser = '" + strUserId + "'");
                int MonthViewpointNum = clsViewpointBL.GetRecCountByCond("1=1 And UserTypeId = '01' And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekViewpointNum = clsViewpointBL.GetRecCountByCond("1=1 And UserTypeId = '01' And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodayViewpointNum = clsViewpointBL.GetRecCountByCond("1=1 And UserTypeId = '01' And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //主题专家观点
                int PersonalExpertViewpointNum = clsViewpointBL.GetRecCountByCond("1=1 And UserTypeId = '02' And UpdUser = '" + strUserId + "'");
                int MonthExpertViewpointNum = clsViewpointBL.GetRecCountByCond("1=1 And UserTypeId = '02' And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekExpertViewpointNum = clsViewpointBL.GetRecCountByCond("1=1 And UserTypeId = '02' And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodayExpertViewpointNum = clsViewpointBL.GetRecCountByCond("1=1 And UserTypeId = '02' And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //主题概念
                int PersonalConceptNum = clsConceptBL.GetRecCountByCond("1=1 And UpdUser = '" + strUserId + "'");
                int MonthConceptNum = clsConceptBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekConceptNum = clsConceptBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodayConceptNum = clsConceptBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //客观事实
                int PersonalObjectiveFactNum = clsTopicObjectiveBL.GetRecCountByCond("1=1 And ObjectiveType = '01' And UpdUser = '" + strUserId + "'");
                int MonthObjectiveFactNum = clsTopicObjectiveBL.GetRecCountByCond("1=1 And ObjectiveType = '01' And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekObjectiveFactNum = clsTopicObjectiveBL.GetRecCountByCond("1=1 And ObjectiveType = '01' And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodayObjectiveFactNum = clsTopicObjectiveBL.GetRecCountByCond("1=1 And ObjectiveType = '01' And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //客观数据
                int PersonalObjectiveBasisNum = clsTopicObjectiveBL.GetRecCountByCond("1=1 And ObjectiveType = '02' And UpdUser = '" + strUserId + "'");
                int MonthObjectiveBasisNum = clsTopicObjectiveBL.GetRecCountByCond("1=1 And ObjectiveType = '02' And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekObjectiveBasisNum = clsTopicObjectiveBL.GetRecCountByCond("1=1 And ObjectiveType = '02' And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodayObjectiveBasisNum = clsTopicObjectiveBL.GetRecCountByCond("1=1 And ObjectiveType = '02' And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //操作技能
                int PersonalSysSkillNum = clsSysSkillBL.GetRecCountByCond("1=1 And UpdUser = '" + strUserId + "'");
                int MonthSysSkillNum = clsSysSkillBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekSysSkillNum = clsSysSkillBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodaySysSkillNum = clsSysSkillBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //社会关系
                int PersonalSysSocialRelationsNum = clsSysSocialRelationsBL.GetRecCountByCond("1=1 And UpdUser = '" + strUserId + "'");
                int MonthSysSocialRelationsNum = clsSysSocialRelationsBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekSysSocialRelationsNum = clsSysSocialRelationsBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodaySysSocialRelationsNum = clsSysSocialRelationsBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //评论
                int PersonalSysCommentNum = clsSysCommentBL.GetRecCountByCond("1=1 And UpdUser = '" + strUserId + "'");
                int MonthSysCommentNum = clsSysCommentBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int WeekSysCommentNum = clsSysCommentBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int TodaySysCommentNum = clsSysCommentBL.GetRecCountByCond("1=1 And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");

                //教师问题回答
                int Personalqa_AnswerNum = clsqa_AnswerBL.GetRecCountByCond("1=1 And AnswerTypeId = '01' And UpdUser = '" + strUserId + "'");
                int Monthqa_AnswerNum = clsqa_AnswerBL.GetRecCountByCond("1=1 And AnswerTypeId = '01' And UpdUser='" + strUserId + "' and UpdDate >='" + strStartMonth + "'");
                int Weekqa_AnswerNum = clsqa_AnswerBL.GetRecCountByCond("1=1 And AnswerTypeId = '01' And UpdUser='" + strUserId + "' and UpdDate >='" + strStartWeek + "'");
                int Todayqa_AnswerNum = clsqa_AnswerBL.GetRecCountByCond("1=1 And AnswerTypeId = '01' And UpdUser='" + strUserId + "' and UpdDate like'%" + strToday + "%'");


                StringBuilder sbJSON = new StringBuilder();
                sbJSON.Append("{");
              
                sbJSON.AppendFormat("\"PersonalPaperNum\":\"{0}\",",PersonalPaperNum);
                sbJSON.AppendFormat("\"MonthPaperNum\":\"{0}\",", MonthPaperNum);
                sbJSON.AppendFormat("\"WeekPaperNum\":\"{0}\",", WeekPaperNum);
                sbJSON.AppendFormat("\"TodayPaperNum\":\"{0}\",", TodayPaperNum);

                sbJSON.AppendFormat("\"PersonalPaperAttentionNum\":\"{0}\",", PersonalPaperAttentionNum);
                sbJSON.AppendFormat("\"MonthPaperAttentionNum\":\"{0}\",", MonthPaperAttentionNum);
                sbJSON.AppendFormat("\"WeekPaperAttentionNum\":\"{0}\",", WeekPaperAttentionNum);
                sbJSON.AppendFormat("\"TodayPaperAttentionNum\":\"{0}\",", TodayPaperAttentionNum);

                sbJSON.AppendFormat("\"PersonalPaperSubViewpointNum\":\"{0}\",", PersonalPaperNum);
                sbJSON.AppendFormat("\"MonthPaperSubViewpointNum\":\"{0}\",", MonthPaperNum);
                sbJSON.AppendFormat("\"WeekPaperSubViewpointNum\":\"{0}\",", WeekPaperNum);
                sbJSON.AppendFormat("\"TodayPaperSubViewpointNum\":\"{0}\",", TodayPaperNum);

                sbJSON.AppendFormat("\"Personalqa_QuestionsNum\":\"{0}\",", Personalqa_QuestionsNum);
                sbJSON.AppendFormat("\"Monthqa_QuestionsNum\":\"{0}\",", Monthqa_QuestionsNum);
                sbJSON.AppendFormat("\"Weekqa_QuestionsNum\":\"{0}\",", Weekqa_QuestionsNum);
                sbJSON.AppendFormat("\"Todayqa_QuestionsNum\":\"{0}\",", Todayqa_QuestionsNum);

                sbJSON.AppendFormat("\"Personalgs_TagsNum\":\"{0}\",", Personalgs_TagsNum);
                sbJSON.AppendFormat("\"Monthgs_TagsNum\":\"{0}\",", Monthgs_TagsNum);
                sbJSON.AppendFormat("\"Weekgs_TagsNum\":\"{0}\",", Weekgs_TagsNum);
                sbJSON.AppendFormat("\"Todaygs_TagsNum\":\"{0}\",", Todaygs_TagsNum);

                sbJSON.AppendFormat("\"PersonalViewpointNum\":\"{0}\",", PersonalViewpointNum);
                sbJSON.AppendFormat("\"MonthViewpointNum\":\"{0}\",", MonthViewpointNum);
                sbJSON.AppendFormat("\"WeekViewpointNum\":\"{0}\",", WeekViewpointNum);
                sbJSON.AppendFormat("\"TodayViewpointNum\":\"{0}\",", TodayViewpointNum);

                sbJSON.AppendFormat("\"PersonalExpertViewpointNum\":\"{0}\",", PersonalExpertViewpointNum);
                sbJSON.AppendFormat("\"MonthExpertViewpointNum\":\"{0}\",", MonthExpertViewpointNum);
                sbJSON.AppendFormat("\"WeekExpertViewpointNum\":\"{0}\",", WeekExpertViewpointNum);
                sbJSON.AppendFormat("\"TodayExpertViewpointNum\":\"{0}\",", TodayExpertViewpointNum);

                sbJSON.AppendFormat("\"PersonalConceptNum\":\"{0}\",", PersonalConceptNum);
                sbJSON.AppendFormat("\"MonthConceptNum\":\"{0}\",", MonthConceptNum);
                sbJSON.AppendFormat("\"WeekConceptNum\":\"{0}\",", WeekConceptNum);
                sbJSON.AppendFormat("\"TodayConceptNum\":\"{0}\",", TodayConceptNum);

                sbJSON.AppendFormat("\"PersonalObjectiveFactNum\":\"{0}\",", PersonalObjectiveFactNum);
                sbJSON.AppendFormat("\"MonthObjectiveFactNum\":\"{0}\",", MonthObjectiveFactNum);
                sbJSON.AppendFormat("\"WeekObjectiveFactNum\":\"{0}\",", WeekObjectiveFactNum);
                sbJSON.AppendFormat("\"TodayObjectiveFactNum\":\"{0}\",", TodayObjectiveFactNum);

                sbJSON.AppendFormat("\"PersonalObjectiveBasisNum\":\"{0}\",", PersonalObjectiveBasisNum);
                sbJSON.AppendFormat("\"MonthObjectiveBasisNum\":\"{0}\",", MonthObjectiveBasisNum);
                sbJSON.AppendFormat("\"WeekObjectiveBasisNum\":\"{0}\",", WeekObjectiveBasisNum);
                sbJSON.AppendFormat("\"TodayObjectiveBasisNum\":\"{0}\",", TodayObjectiveBasisNum);

                sbJSON.AppendFormat("\"PersonalSysSkillNum\":\"{0}\",", PersonalSysSkillNum);
                sbJSON.AppendFormat("\"MonthSysSkillNum\":\"{0}\",", MonthSysSkillNum);
                sbJSON.AppendFormat("\"WeekSysSkillNum\":\"{0}\",", WeekSysSkillNum);
                sbJSON.AppendFormat("\"TodaySysSkillNum\":\"{0}\",", TodaySysSkillNum);

                sbJSON.AppendFormat("\"PersonalSysSocialRelationsNum\":\"{0}\",", PersonalSysSocialRelationsNum);
                sbJSON.AppendFormat("\"MonthSysSocialRelationsNum\":\"{0}\",", MonthSysSocialRelationsNum);
                sbJSON.AppendFormat("\"WeekSysSocialRelationsNum\":\"{0}\",", WeekSysSocialRelationsNum);
                sbJSON.AppendFormat("\"TodaySysSocialRelationsNum\":\"{0}\",", TodaySysSocialRelationsNum);

                sbJSON.AppendFormat("\"PersonalSysCommentNum\":\"{0}\",", PersonalSysCommentNum);
                sbJSON.AppendFormat("\"MonthSysCommentNum\":\"{0}\",", MonthSysCommentNum);
                sbJSON.AppendFormat("\"WeekSysCommentNum\":\"{0}\",", WeekSysCommentNum);
                sbJSON.AppendFormat("\"TodaySysCommentNum\":\"{0}\",", TodaySysCommentNum);

                sbJSON.AppendFormat("\"Personalqa_AnswerNum\":\"{0}\",", Personalqa_AnswerNum);
                sbJSON.AppendFormat("\"Monthqa_AnswerNum\":\"{0}\",", Monthqa_AnswerNum);
                sbJSON.AppendFormat("\"Weekqa_AnswerNum\":\"{0}\",", Weekqa_AnswerNum);
                sbJSON.AppendFormat("\"Todayqa_AnswerNum\":\"{0}\",", Todayqa_AnswerNum);

                //sbJSON.Remove(sbJSON.Length - 1, 1);
                sbJSON.Append("}");
                return sbJSON.ToString();


                //strJson += '{';
                //strJson += '"PersonalPaperNum:"' + PersonalPaperNum + ",";

                //strJson += '}';

                //return strJson;


            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)统计json数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

    }
}