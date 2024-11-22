
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsRTUserRelaBLEx
表名:RTUserRela(01120582)
生成代码版本:2020.09.24.1
生成日期:2020/10/12 15:37:03
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data;
using System.Data.SqlClient;
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicExs
{
    public class clsRTUserRelaBLEx
    {

        //private static string strMsg = "";
        /// <summary>
        /// 单例模式:访问数据访问层的单例模式
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
        /// </summary>
        private static clsRTUserRelaDA uniqueInstance = null;
        /// <summary>
        /// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
        /// </summary>
        public static clsRTUserRelaDA RTUserRelaDA
        {
            get
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new clsRTUserRelaDA();
                }
                return uniqueInstance;
            }
        }


        #region 用户修改色码后需要更新所有相关表的 内容背景色码  函数处理；

        //修改主题用户关系后，需要读取 、qa_answer 、gs_PaperParagraph、会议纪要；
        public static bool UpdateTypeTableHtml(string OldCodeColor, string NewCodeColor, string UserId)
        {
            string strid_CurrEdulcs = string.Empty;
            bool result = false;
            try
            {
                //1.首先查询用户存在多少个教学班、
                //查询用户各个类型的分数；
                List<clsvCurrEduClsStuEN> objvCurrEduClsStuList = clsvCurrEduClsStuBL.GetObjLst("StuId = '" + UserId + "'");
                //1.1循环列表得到教学班ID
                foreach (clsvCurrEduClsStuEN objvCurrEduClsStu in objvCurrEduClsStuList)
                {
                    strid_CurrEdulcs = objvCurrEduClsStu.IdCurrEduCls;

                    //2通过教学班ID得到所属的主题
                    List<clsResearchTopicEN> objResearchTopicList = clsResearchTopicBL.GetObjLst("IdCurrEduCls = '" + strid_CurrEdulcs + "'");
                    //2.1如果大于0
                    if (objResearchTopicList.Count > 0)
                    {
                        //2.2循环主题数据；通过主题ID查询 各表的数据；
                        foreach (clsResearchTopicEN objResearchTopic in objResearchTopicList)
                        {
                            string strTopicId = objResearchTopic.TopicId;
                            //1.主题会议 
                            UpdateTopicMeeting(OldCodeColor,NewCodeColor,strTopicId,UserId);

                            //2.问题回答，小组答案；
                            UpdateQa_Answer(OldCodeColor, NewCodeColor, strTopicId, UserId);

                            //3.论文段落
                            Updategs_PaperParagraph(OldCodeColor, NewCodeColor, strTopicId, UserId);
                        }

                        result = true;
                    }

                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
            return result;
        }


        //1通过主题ID查询 主题会议 更新主题会议 用户背景色块；
        public static void UpdateTopicMeeting(string OldCodeColor, string NewCodeColor, string strTopicId, string strUserId)
        {
            string strMeetingMinutesContent = string.Empty;
            string strMeetingId = string.Empty;
            try
            {

                //组合新字符 老字符、用于数据替换；
                string OldStr = "<span style='color:#" + OldCodeColor + "' name='" + strUserId + "'>";
                string NewStr = "<span style='color:#" + NewCodeColor + "' name='" + strUserId + "'>";


                #region 主题会议
                //1.查询主题会议表，更新会议表数据；
                List<clsgs_MeetingMinutesEN> objgs_MeetingMinutesList = clsgs_MeetingMinutesBL.GetObjLst("TopicId = '" + strTopicId + "'");
                if (objgs_MeetingMinutesList.Count > 0)
                {
                    //2.2循环主题数据；通过主题ID查询 各表的数据；
                    foreach (clsgs_MeetingMinutesEN objgs_MeetingMinutes in objgs_MeetingMinutesList)
                    {

                        strMeetingMinutesContent = objgs_MeetingMinutes.MeetingContent;
                        strMeetingId = objgs_MeetingMinutes.MeetingId;
                        strMeetingMinutesContent = strMeetingMinutesContent.Replace(OldStr, NewStr);


                        clsgs_MeetingMinutesEN objUpdgs_Meeting = clsgs_MeetingMinutesBL.GetObjByMeetingId(strMeetingId);

                        objUpdgs_Meeting.MeetingContent = strMeetingMinutesContent;
                        clsgs_MeetingMinutesBL.UpdateBySql2(objUpdgs_Meeting);



                        #region ----主题会议 历史表；
                        //1.查询主题会议表，更新会议表数据；

                        List<clsgs_MeetingMinutesVerEN> objgs_MeetingMinutesVList = clsgs_MeetingMinutesVerBL.GetObjLst("MeetingId = '" + strMeetingId + "'");
                        if (objgs_MeetingMinutesVList.Count > 0)
                        {
                            foreach (clsgs_MeetingMinutesVerEN objgs_MeetingV in objgs_MeetingMinutesVList)
                            {
                                string strMeetingContentV = objgs_MeetingV.MeetingContent;
                                strMeetingContentV = strMeetingContentV.Replace(OldStr, NewStr);
                                int mId = Convert.ToInt32(objgs_MeetingV.MeetingVId);

                                clsgs_MeetingMinutesVerEN objUpdgs_Meetingv = clsgs_MeetingMinutesVerBL.GetObjByMeetingVId(mId);

                                objUpdgs_Meetingv.MeetingContent = strMeetingContentV;
                                clsgs_MeetingMinutesVerBL.UpdateBySql2(objUpdgs_Meetingv);

                            }
                        }
                        #endregion


                    }
                }

                #endregion

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }

        }

        //2通过主题ID 查询主题下 论文-问题-答案数据；更新小组答案数据背景；
        public static void UpdateQa_Answer(string OldCodeColor, string NewCodeColor, string strTopicId, string strUserId)
        {
            try
            {
                //组合新字符 老字符、用于数据替换；
                string OldStr = "<span style='color:#" + OldCodeColor + "' name='" + strUserId + "'>";
                string NewStr = "<span style='color:#" + NewCodeColor + "' name='" + strUserId + "'>";
                //1.先通过主题查询得到主题相关的论文、01 引用论文；
                List<clsvRTPaperRelaEN> objvRTPaperRelaList = clsvRTPaperRelaBL.GetObjLst("TopicId = '" + strTopicId + "' And PaperTypeId='01'");
                if (objvRTPaperRelaList.Count > 0)
                {
                    //1.1循环论文
                    foreach (clsvRTPaperRelaEN objvRTPaperRela in objvRTPaperRelaList)
                    {

                        string strPaperId = objvRTPaperRela.PaperId;

                        //2.通过论文iD 查询问题； 02 代表教师提问
                        List<clsqa_QuestionsEN> objqa_QuestionsList = clsqa_QuestionsBL.GetObjLst("PaperId = '" + strPaperId + "' And QuestionsTypeId='02'");
                        if (objqa_QuestionsList.Count > 0)
                        {
                            foreach (clsqa_QuestionsEN objqa_Questions in objqa_QuestionsList)
                            {
                                string strQuestionsId = objqa_Questions.QuestionsId;

                                //3通过问题Id 查询 问题回答 IsRecommend='1' 小组答案 才需要多人编辑 背景codecolor 替换；
                                List<clsqa_AnswerEN> objqa_AnswerList = clsqa_AnswerBL.GetObjLst("QuestionsId = '" + strQuestionsId + "' And IsRecommend='1'");
                                if (objqa_AnswerList.Count > 0)
                                {
                                    foreach (clsqa_AnswerEN objqa_Answer in objqa_AnswerList)
                                    {

                                        string strAnswerContent = objqa_Answer.AnswerContent;
                                        string strAnswerId = objqa_Answer.AnswerId;
                                        strAnswerContent = strAnswerContent.Replace(OldStr, NewStr);


                                        clsqa_AnswerEN objUpdqa_Answer = clsqa_AnswerBL.GetObjByAnswerId(strAnswerId);

                                        objUpdqa_Answer.AnswerContent = strAnswerContent;
                                        clsqa_AnswerBL.UpdateBySql2(objUpdqa_Answer);


                                        #region ---问题回答 历史表；

                                        List<clsqa_AnswerVerEN> objqa_AnswerVList = clsqa_AnswerVerBL.GetObjLst("AnswerId = '" + strAnswerId + "'");
                                        if (objqa_AnswerVList.Count > 0)
                                        {
                                            foreach (clsqa_AnswerVerEN objqa_AnswerV in objqa_AnswerVList)
                                            {
                                                string strAnswerContentV = objqa_AnswerV.AnswerContent;
                                                strAnswerContentV = strAnswerContentV.Replace(OldStr, NewStr);
                                                int mId = Convert.ToInt32(objqa_AnswerV.AnswerVId);

                                                clsqa_AnswerVerEN objUpdqa_Answerv = clsqa_AnswerVerBL.GetObjByAnswerVId(mId);

                                                objUpdqa_Answerv.AnswerContent = strAnswerContentV;
                                                clsqa_AnswerVerBL.UpdateBySql2(objUpdqa_Answerv);

                                            }
                                        }

                                        #endregion
                                    }
                                }
                            }
                        }

                    }
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        //3 通过主题查询 写作论文、-论文写作段落；
        public static void Updategs_PaperParagraph(string OldCodeColor, string NewCodeColor, string strTopicId, string strUserId)
        {
            try
            {
                //组合新字符 老字符、用于数据替换；
                string OldStr = "<span style='color:#" + OldCodeColor + "' name='" + strUserId + "'>";
                string NewStr = "<span style='color:#" + NewCodeColor + "' name='" + strUserId + "'>";
                //1.先通过主题查询得到主题相关的论文、02  自己写作论文；
                List<clsvRTPaperRelaEN> objvRTPaperRelaList = clsvRTPaperRelaBL.GetObjLst("TopicId = '" + strTopicId + "' And PaperTypeId='02'");
                if (objvRTPaperRelaList.Count > 0)
                {
                    //1.1循环论文
                    foreach (clsvRTPaperRelaEN objvRTPaperRela in objvRTPaperRelaList)
                    {
                        string strPaperId = objvRTPaperRela.PaperId;

                        //2 通过论文ID  查询段落 01 代表文本;
                        List<clsgs_PaperParagraphEN> objgs_PaperParagraphList = clsgs_PaperParagraphBL.GetObjLst("PaperId = '" + strPaperId + "' And ParagraphTypeId='01'");
                        if (objgs_PaperParagraphList.Count > 0)
                        {
                            foreach (clsgs_PaperParagraphEN objgs_PaperParagraph in objgs_PaperParagraphList)
                            {

                                string strParagraphContent = objgs_PaperParagraph.ParagraphContent;
                                string strParagraphId = objgs_PaperParagraph.ParagraphId;
                                strParagraphContent = strParagraphContent.Replace(OldStr, NewStr);


                                clsgs_PaperParagraphEN objUpdgs_PaperParagraph = clsgs_PaperParagraphBL.GetObjByParagraphId(strParagraphId);

                                objUpdgs_PaperParagraph.ParagraphContent = strParagraphContent;
                                clsgs_PaperParagraphBL.UpdateBySql2(objUpdgs_PaperParagraph);

                                #region ---论文段落 历史表；

                                List<clsgs_PaperParagraphVerEN> objgs_PaperParagraphVList = clsgs_PaperParagraphVerBL.GetObjLst("ParagraphId = '" + strParagraphId + "'");
                                if (objgs_PaperParagraphVList.Count > 0)
                                {
                                    foreach (clsgs_PaperParagraphVerEN objgs_PaperParagraphV in objgs_PaperParagraphVList)
                                    {
                                        string strParagraphContentV = objgs_PaperParagraphV.ParagraphContent;
                                        strParagraphContentV = strParagraphContentV.Replace(OldStr, NewStr);
                                        int mId = Convert.ToInt32(objgs_PaperParagraphV.ParagraphVId);

                                        clsgs_PaperParagraphVerEN objUpdgs_PaperParagraphv = clsgs_PaperParagraphVerBL.GetObjByParagraphVId(mId);

                                        objUpdgs_PaperParagraphv.ParagraphContent = strParagraphContentV;
                                        clsgs_PaperParagraphVerBL.UpdateBySql2(objUpdgs_PaperParagraphv);

                                    }
                                }

                                #endregion

                            }
                        }
                    }
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }



            #endregion
        }
    }
}
