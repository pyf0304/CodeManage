using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using ExamLib.BusinessLogic;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib.BusinessLogicEx
{
    public class clsgs_TotalDataStatisticsNewBLEx : clsgs_TotalDataStatisticsBL
    {

        #region 一、各个类型表 增加、删除、修改后 数据总表需要获取相关类型表数据操作；
        //传入3个参数;主键Tablekey，字表类型TotalDataTypeId，页面操作类型PageTypeId(1,2,3,代表添加、修改、删除；)
        public static bool AddAndUpdateAndDeleteTotalStatis(string strTablekey, string strTotalDataTypeId, string PageTypeId, string strIdCurrEduCls)
        {
            bool bolResult = false;
            string strStartDate = string.Empty;//开始日期
            string strEndDate = string.Empty;//结束日期
            //string strCurrEduclsId = string.Empty;//教学班；
            float fScore = 0;
            float fTeaScore = 0;
            float fStuScore = 0;
            string strCreateDate = string.Empty;
            string strUpdUser = string.Empty;
            try
            {
                #region 获取教学班数据
                //得到类型判断调用不同的类型表数据
                string strDataType = string.Empty;
                strDataType = strTotalDataTypeId;

                switch (strDataType)
                {
                    case "01":
                        //01  论文 Paper   PaperId
                        clsPaperEN objPaperEN = clsPaperBL.GetObjByPaperId(strTablekey);
                        if (objPaperEN != null)
                        {
                            //strCurrEduclsId = objPaperEN.IdCurrEduCls;
                            fScore = objPaperEN.Score ?? 0;
                            fTeaScore = objPaperEN.TeaScore ?? 0;
                            fStuScore = objPaperEN.StuScore ?? 0;
                            strCreateDate = objPaperEN.CreateDate;
                            strUpdUser = objPaperEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strIdCurrEduCls + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strIdCurrEduCls, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore,fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "论文操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "论文操作失败", "TotalDataLog");
                            }
                        }
                        break;
                    case "02":
                        //02  论文读写 PaperReadWrite  PaperRWId
                        clsPaperReadWriteEN objPaperReadWriteEN = clsPaperReadWriteBL.GetObjByPaperRWId(strTablekey);
                        if (objPaperReadWriteEN != null)
                        {
                            string strCurrEduclsId = objPaperReadWriteEN.IdCurrEduCls;
                            fScore = 0;
                            fTeaScore = 0;

                            strCreateDate = objPaperReadWriteEN.CreateDate;
                            strUpdUser = objPaperReadWriteEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "论文读写操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "论文读写操作失败", "TotalDataLog");
                            }
                        }

                        break;
                    case "03":
                        ///03  论文子观点 PaperSubViewpoint   SubViewpointId
                        clsvPaperSubViewpointEN objPaperSubViewpointEN = clsvPaperSubViewpointBL.GetObjBySubViewpointId(long.Parse( strTablekey));
                        if (objPaperSubViewpointEN != null)
                        {
                         string   strCurrEduclsId = objPaperSubViewpointEN.IdCurrEduCls;
                            fScore = objPaperSubViewpointEN.Score ?? 0;
                            fTeaScore = objPaperSubViewpointEN.TeaScore ?? 0;
                            fStuScore = objPaperSubViewpointEN.StuScore ?? 0;
                            strCreateDate = objPaperSubViewpointEN.CreateDate;
                            strUpdUser = objPaperSubViewpointEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "论文子观点操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "论文子观点操作失败", "TotalDataLog");
                            }
                        }
                        break;
                    case "04":
                        ////04  个人观点 Viewpoint   ViewpointId
                        clsViewpointEN objViewpointEN = clsViewpointBL.GetObjByViewpointId(strTablekey);
                        if (objViewpointEN != null)
                        {
                         string   strCurrEduclsId = objViewpointEN.IdCurrEduCls;
                            fScore = objViewpointEN.Score ?? 0;
                            fTeaScore = objViewpointEN.TeaScore ?? 0;
                            fStuScore = objViewpointEN.StuScore ?? 0;
                            strCreateDate = objViewpointEN.CreateDate;
                            strUpdUser = objViewpointEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "个人观点操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "个人观点操作失败", "TotalDataLog");
                            }
                        }
                        break;
                    case "05":
                        //05  专家观点 Viewpoint   ViewpointId
                        clsViewpointEN objExpertViewpointEN = clsViewpointBL.GetObjByViewpointId(strTablekey);
                        if (objExpertViewpointEN != null)
                        {
                         string   strCurrEduclsId = objExpertViewpointEN.IdCurrEduCls;
                            fScore = objExpertViewpointEN.Score ?? 0;
                            fTeaScore = objExpertViewpointEN.TeaScore ?? 0;
                            fStuScore = objExpertViewpointEN.StuScore ?? 0;
                            strCreateDate = objExpertViewpointEN.CreateDate;
                            strUpdUser = objExpertViewpointEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "专家观点操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "专家观点操作失败", "TotalDataLog");
                            }
                        }
                        break;
                    case "06":
                        //06  主题概念 Concept ConceptId
                        clsConceptEN objConceptEN = clsConceptBL.GetObjByConceptId(strTablekey);
                        if (objConceptEN != null)
                        {
                        string    strCurrEduclsId = objConceptEN.IdCurrEduCls;
                            fScore = objConceptEN.Score ?? 0;
                            fTeaScore = objConceptEN.TeaScore ?? 0;
                            fStuScore = objConceptEN.StuScore ?? 0;
                            strCreateDate = objConceptEN.CreateDate;
                            strUpdUser = objConceptEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "主题概念操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "主题概念操作失败", "TotalDataLog");
                            }
                        }
                        break;
                    case "07":
                        //07  客观事实 TopicObjective  TopicObjectiveId
                        clsTopicObjectiveEN objTopicObjectiveEN = clsTopicObjectiveBL.GetObjByTopicObjectiveId(strTablekey);
                        if (objTopicObjectiveEN != null)
                        {
                        string    strCurrEduclsId = objTopicObjectiveEN.IdCurrEduCls;
                            fScore = objTopicObjectiveEN.Score ?? 0;
                            fTeaScore = objTopicObjectiveEN.TeaScore ?? 0;
                            fStuScore = objTopicObjectiveEN.StuScore ?? 0;
                            strCreateDate = objTopicObjectiveEN.CreateDate;
                            strUpdUser = objTopicObjectiveEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "客观事实操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "客观事实操作失败", "TotalDataLog");
                            }
                        }
                        break;
                    case "08":
                        //08  客观数据 TopicObjective  TopicObjectiveId
                        clsTopicObjectiveEN objTopicObjectiveBasisEN = clsTopicObjectiveBL.GetObjByTopicObjectiveId(strTablekey);
                        if (objTopicObjectiveBasisEN != null)
                        {
                        string    strCurrEduclsId = objTopicObjectiveBasisEN.IdCurrEduCls;
                            fScore = objTopicObjectiveBasisEN.Score ?? 0;
                            fTeaScore = objTopicObjectiveBasisEN.TeaScore ?? 0;
                            fStuScore = objTopicObjectiveBasisEN.StuScore ?? 0;
                            strCreateDate = objTopicObjectiveBasisEN.CreateDate;
                            strUpdUser = objTopicObjectiveBasisEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "客观数据操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "客观数据操作失败", "TotalDataLog");
                            }
                        }
                        break;
                    case "09":
                        //09  技能 SysSkill    SkillId
                        clsSysSkillEN objSysSkillEN = clsSysSkillBL.GetObjBySkillId(strTablekey);
                        if (objSysSkillEN != null)
                        {
                        string    strCurrEduclsId = objSysSkillEN.IdCurrEduCls;
                            fScore = objSysSkillEN.Score ?? 0;
                            fTeaScore = objSysSkillEN.TeaScore ?? 0;
                            fStuScore = objSysSkillEN.StuScore ?? 0;
                            strCreateDate = objSysSkillEN.CreateDate;
                            strUpdUser = objSysSkillEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "技能操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "技能操作失败", "TotalDataLog");
                            }
                        }

                        break;
                    case "10":
                        //10  社会关系 SysSocialRelations  SocialId
                        clsSysSocialRelationsEN objSysSocialRelationsEN = clsSysSocialRelationsBL.GetObjBySocialId(strTablekey);
                        if (objSysSocialRelationsEN != null)
                        {
                       string     strCurrEduclsId = objSysSocialRelationsEN.IdCurrEduCls;
                            fScore = objSysSocialRelationsEN.Score ?? 0;
                            fTeaScore = objSysSocialRelationsEN.TeaScore ?? 0;
                            fStuScore = objSysSocialRelationsEN.StuScore ?? 0;
                            strCreateDate = objSysSocialRelationsEN.CreateDate;
                            strUpdUser = objSysSocialRelationsEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "技能操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "技能操作失败", "TotalDataLog");
                            }
                        }
                        break;
                    case "11":
                        //11  教师问题回答 qa_Answer  AnswerId
                        clsvqa_AnswerEN objqa_AnswerEN = clsvqa_AnswerBL.GetObjByAnswerId(strTablekey);
                        if (objqa_AnswerEN != null)
                        {
                       string     strCurrEduclsId = clsResearchTopicBLEx.GetIdCurrEduClsByTopicId( objqa_AnswerEN.TopicId);
                            fScore = objqa_AnswerEN.Score ?? 0;
                            fTeaScore = objqa_AnswerEN.TeaScore ?? 0;
                            fStuScore = objqa_AnswerEN.StuScore ?? 0;
                            strCreateDate = objqa_AnswerEN.UpdDate;
                            strUpdUser = objqa_AnswerEN.UpdUser;
                            //获取教学班日期数据
                            clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                            strStartDate = objgs_TeachingDate.StartDate;
                            strEndDate = objgs_TeachingDate.EndDate;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, fStuScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "技能操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "技能操作失败", "TotalDataLog");
                            }
                        }
                        break;
                    default:
                        string strMsg = string.Format("没有获得类型数据");

                        break;

                }
                #endregion

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("操作记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolResult;
        }

        #endregion

        #region 二、根据《一》各个表 增加、修改、删除、总表数据；
        //添加/修改、删除；数据总表
        public static bool AddUpdDelTotalStatistics(string strCurrEduclsId, string TotalDataTypeId, string TableKey, string DataUser, string DataAddDate, float fScore, float fTeaScore,float fStuScore, string strStartDate, string strPageType)
        {
            bool bolresult = false;

            try
            {
                //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                string strwhereCond = "TotalDataTypeId='" + TotalDataTypeId + "' And TableKey='" + TableKey + "' And IdCurrEduCls='" + strCurrEduclsId + "'";
                clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);

                if (strPageType == "1")
                {
                    //添加
                    clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                    //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
                    objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(TotalDataTypeId, TableKey);

                    objNewgs_TotalDataStatistics.IdCurrEduCls = strCurrEduclsId;
                    objNewgs_TotalDataStatistics.TotalDataTypeId = TotalDataTypeId;
                    //得到分数
                    objNewgs_TotalDataStatistics.Score = fScore;
                    objNewgs_TotalDataStatistics.TeaScore = fTeaScore;
                    objNewgs_TotalDataStatistics.StuScore = fStuScore;
                    objNewgs_TotalDataStatistics.TableKey = TableKey;
                    objNewgs_TotalDataStatistics.DataUser = DataUser;
                    objNewgs_TotalDataStatistics.DataAddDate = DataAddDate;
                    //根据时间得到 月 周、
                    objNewgs_TotalDataStatistics.Month = Convert.ToInt32(DataAddDate.Substring(5, 2));
                    objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStartDate, DataAddDate);
                    objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStartDate, DataAddDate), strStartDate);

                    objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewgs_TotalDataStatistics.UpdUser = DataUser;

                    bool i = clsgs_TotalDataStatisticsBL.AddNewRecordBySql2(objNewgs_TotalDataStatistics);
                    if (i == true)
                    {
                        bolresult = true;
                        WriteTextLog("AddUpdDelTotalStatistics", "添加成功", "TotalDataLog");
                    }
                    else
                    {
                        bolresult = false;
                        WriteTextLog("AddUpdDelTotalStatistics", "添加失败", "TotalDataLog");
                    }

                }
                else if (strPageType == "2")
                {
                    //、修改
                    bool i = UpdDataTotalStatistics(objUpdTotalData, strStartDate, DataAddDate, DataUser, fScore, fTeaScore, fStuScore);
                    if (i == true)
                    {
                        bolresult = true;
                        WriteTextLog("AddUpdDelTotalStatistics", "修改成功", "TotalDataLog");
                    }
                    else
                    {
                        bolresult = false;
                        WriteTextLog("AddUpdDelTotalStatistics", "修改失败", "TotalDataLog");
                    }
                }
                else
                {
                    //删除
                    var StrTotalId = objUpdTotalData.TotalDataId;
                    int i = clsgs_TotalDataStatisticsBL.DelRecord(StrTotalId);
                    if (i > 0)
                    {
                        bolresult = true;
                        WriteTextLog("AddUpdDelTotalStatistics", "删除成功", "TotalDataLog");
                    }
                    else
                    {
                        bolresult = false;
                        WriteTextLog("AddUpdDelTotalStatistics", "删除失败", "TotalDataLog");
                    }
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("论文统计记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }

        #endregion

        #region 三、根据《一》《六》统计表扩展函数，用于统计表数据的更新
        //统计表扩展函数，用于统计表数据的更新
        public static bool UpdDataTotalStatistics(clsgs_TotalDataStatisticsEN objUpdTotalData, string strStart, string strCreateDate, string strUpdUser, float strScore, float strTeaScore,float strStuScore)
        {
            bool bolresult = false;
            objUpdTotalData.Week = GetWeekByDate(strStart, strCreateDate);
            objUpdTotalData.Score = strScore;
            objUpdTotalData.TeaScore = strTeaScore;
            objUpdTotalData.StuScore = strStuScore;
            objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            objUpdTotalData.UpdUser = strUpdUser;
            objUpdTotalData.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, strCreateDate), strStart);
            bool i = clsgs_TotalDataStatisticsBL.UpdateBySql2(objUpdTotalData);
            if (i == true)
            {
                bolresult = true;
            }
            else
            {
                bolresult = false;
            }
            return bolresult;
        }
        #endregion

        #region  四、根据《二》 、相关转换函数位置；
        //4.1根据传入的类型和主键判断数据；
        public static string GetTabKeyByTypeAndKey(string strTypeId, string strTabkey)
        {
            string strFullTabKey = string.Empty;
            //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
            if (strTabkey.Length > 8)
            {
                strFullTabKey = strTypeId + strTabkey;
            }
            else
            {
                strFullTabKey = strTypeId + "00" + strTabkey;
            }
            return strFullTabKey;
        }
        //4.2 根据开始时间，结束时间得到周；
        public static int GetWeekByDate(string BeginDate, string CurrDate)
        {


            int strWeekTotal = 0;
            string strBeginDate = BeginDate.Substring(0, 10);//2020-06-01
            clsDateTime objDT = new clsDateTime(strBeginDate);
            DateTime objBeginDate = objDT.GetDateTime();

            string strCurrDate = CurrDate.Substring(0, 10);//2020-08-01
            clsDateTime objDT2 = new clsDateTime(strCurrDate);
            DateTime objCurrDate = objDT2.GetDateTime();


            DateTime t1 = Convert.ToDateTime(objBeginDate);
            DateTime t2 = Convert.ToDateTime(objCurrDate);
            int compNum = DateTime.Compare(t2, t1);

            //t2 > t1
            if (compNum > 0)
            {
                //第一种方式
                //var aa = objCurrDate - objBeginDate;
                //int strWeekTotalDayNum = Convert.ToInt32(Math.Ceiling(aa.TotalDays / 7));//向上取整；
                WriteTextLog(objBeginDate.ToString() + "---" + objCurrDate.ToString(), "开始日期/天--结束日期/天", "TotalDataLog");

                //得到第几周 用天数除以7取整得到周
                //第二种方式得到周；
                TimeSpan ts = objCurrDate.Subtract(objBeginDate);
                var DayNum = Convert.ToDecimal(ts.Days);
                strWeekTotal = Convert.ToInt32(Math.Ceiling(DayNum / 7));//向上取整；
                WriteTextLog(DayNum.ToString(), "时间相减DayNum", "TotalDataLog");
                WriteTextLog(strWeekTotal.ToString(), "得到DayNum周", "TotalDataLog");

                //StringBuilder sbMsg = new StringBuilder();
                //sbMsg.AppendFormat("当前日期：{0} 周：{1}", objBeginDate.ToLongDateString(), objBeginDate.DayOfWeek.ToString());
                //sbMsg.AppendFormat("现在距开始日期的天数：{0}", aa.TotalDays);
                //sbMsg.AppendFormat("第：{0}周", strWeekTotal);
            }
            else
            {
                //t2 <= t1
                strWeekTotal = 1;
            }
            return strWeekTotal;
        }

        //4.3 //根据得到的周 和教学班时间范围起始时间、可以得到当前周的范围时间
        public static string GetWeekTimeRange(int Week, string BeginDate)
        {
            string strWeekRange = string.Empty;
            try
            {

                int DayNum = Week * 7;//当前周*7
                WriteTextLog(DayNum.ToString(), "周*7", "TotalDataLog");
                //得到周的结束时间；
                DateTime dt1 = Convert.ToDateTime(BeginDate);
                var strEndDate = dt1.AddDays(DayNum).ToString("yyyy-MM-dd");// ReTime("2020-03-02 12:55:56", DayNum);//开始时间，添加天数

                var strWeekEndDate = dt1.AddDays(DayNum - 1).ToString("yyyy-MM-dd");//减1是为了防止周日期开始时间重叠问题；

                WriteTextLog(strEndDate.ToString(), "周*7 得到周的结束时间", "TotalDataLog");
                //用结束时间，减去7得到周的开始时间；
                DateTime dt = Convert.ToDateTime(strEndDate);

                string strStartDate = dt.AddDays(-7).ToString("yyyy-MM-dd"); //当前时间减去7天 
                WriteTextLog(strStartDate.ToString(), "周*7 得到周的开始时间", "TotalDataLog");
                strWeekRange = strStartDate + "---" + strWeekEndDate;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取周范围出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);

            }
            return strWeekRange;
        }
        #endregion



        /// <summary>  
        /// 写入日志到文本文件  
        /// </summary>  
        /// <param name="action">动作</param>  
        /// <param name="strMessage">日志内容</param>  
        /// <param name="time">时间</param>  
        public static void WriteTextLog(string http, string strMessage, string Event)
        {
            string path = "D:\\IOT_log\\";
            //string path = AppDomain.CurrentDomain.BaseDirectory + @"IOT_log\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string fileFullPath = path + DateTime.Now.ToString("yyyy-MM-dd") + "." + Event + ".txt";
            StringBuilder str = new StringBuilder();
            str.Append("Time:    " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n");
            str.Append("callbackURL:  " + http + "\r\n");
            str.Append("Message: " + strMessage + "\r\n");
            str.Append("-----------------------------------------------------------\r\n\r\n");
            StreamWriter sw;
            if (!File.Exists(fileFullPath))
            {
                sw = File.CreateText(fileFullPath);
            }
            else
            {
                sw = File.AppendText(fileFullPath);
            }
            sw.WriteLine(str.ToString());
            sw.Close();
        }



        #region 五、用来得到个人的 各个表类型的 各个数据的教师打分、学生打分，以及名称；
        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static List<clsgs_TotalDataStatisticsEN> GetObjLstEx(string strWhereCond)
        {
            List<clsgs_TotalDataStatisticsEN> arrObjLst = new List<clsgs_TotalDataStatisticsEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsgs_TotalDataStatisticsEN objgs_TotalDataStatisticsEN = new clsgs_TotalDataStatisticsEN();
                try
                {
                    objgs_TotalDataStatisticsEN.TotalDataId = objRow[congs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
                    objgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[congs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //当前教学班流水号
                    string stridCurrEduCls = objRow[congs_TotalDataStatistics.IdCurrEduCls].ToString().Trim();
                    objgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[congs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
                    objgs_TotalDataStatisticsEN.TableKey = objRow[congs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
                    objgs_TotalDataStatisticsEN.DataUser = objRow[congs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
                    objgs_TotalDataStatisticsEN.DataAddDate = objRow[congs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
                    objgs_TotalDataStatisticsEN.Month = clsEntityBase2.TransNullToInt_S(objRow[congs_TotalDataStatistics.Month].ToString().Trim()); //月
                    objgs_TotalDataStatisticsEN.Week = clsEntityBase2.TransNullToInt_S(objRow[congs_TotalDataStatistics.Week].ToString().Trim()); //周
                    objgs_TotalDataStatisticsEN.UpdDate = objRow[congs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
                    objgs_TotalDataStatisticsEN.UpdUser = objRow[congs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人

                    string strTotalDataTypeId = objRow[congs_TotalDataStatistics.TotalDataTypeId].ToString().Trim();
                    string strTableKey = objRow[congs_TotalDataStatistics.TableKey].ToString().Trim();
                    objgs_TotalDataStatisticsEN.Memo = GetNameByTableTypeAndKeyId(strTotalDataTypeId,strTableKey, stridCurrEduCls); //备注 --这里用来存放临时 类型名称数据；

                    objgs_TotalDataStatisticsEN.Score = clsEntityBase2.TransNullToFloat_S(objRow[congs_TotalDataStatistics.Score].ToString().Trim()); //评分
                    objgs_TotalDataStatisticsEN.TeaScore = clsEntityBase2.TransNullToFloat_S(objRow[congs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
                    objgs_TotalDataStatisticsEN.WeekTimeRange = objRow[congs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
                    objgs_TotalDataStatisticsEN.StuScore = clsEntityBase2.TransNullToFloat_S(objRow[congs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objgs_TotalDataStatisticsEN);
            }
            objDT = null;
            return arrObjLst;
        }
        //根据总表类型ID 查询不同的表数据 和TabkeKey 得到名称
        public static string GetNameByTableTypeAndKeyId(string strTableType,string strTablekey,string stridCurrEduCls) {
            string strTableTypeName = "";
            try
            {
                switch (strTableType)
                {
                    case "01":
                        //01  论文 Paper   PaperId
                        List<clsPaperEN> arrObjLst = clsPaperBL.GetObjLstCache();
                        if (arrObjLst.Count>0)
                        {
                            clsPaperEN objPaperEN = arrObjLst.Find(x => x.PaperId == strTablekey);
                            if (objPaperEN == null)
                            {
                                strTableTypeName = "";
                            }
                           else
                            {
                                strTableTypeName = objPaperEN.PaperTitle;
                            }
                        }
                        // clsPaperEN objPaperEN = clsPaperBL.GetObjByPaperId(strTablekey);
                        //if (objPaperEN != null)
                        //{
                        //    strTableTypeName = objPaperEN.PaperTitle;

                        //}
                        break;
                    case "02":
                        List<clsPaperReadWriteEN> arrObjPaperReadWriteLst = clsPaperReadWriteBL.GetObjLstCache(stridCurrEduCls);
                        if (arrObjPaperReadWriteLst.Count > 0)
                        {
                            clsPaperReadWriteEN objPaperReadWriteEN = arrObjPaperReadWriteLst.Find(x => x.PaperRWId == strTablekey);
                            //02  论文读写 PaperReadWrite  PaperRWId
                            //clsPaperReadWriteEN objPaperReadWriteEN = clsPaperReadWriteBL.GetObjByPaperRWId(strTablekey);
                            if (objPaperReadWriteEN != null)
                            {
                                strTableTypeName = "";
                            }
                        }
                        break;
                    case "03":
                        List<clsvPaperSubViewpointEN> arrvPaperSubViewpointLst = clsvPaperSubViewpointBL.GetObjLstCache(stridCurrEduCls);
                        if (arrvPaperSubViewpointLst.Count > 0)
                        {
                            ///03  论文子观点 PaperSubViewpoint   SubViewpointId
                            clsvPaperSubViewpointEN objPaperSubViewpointEN = arrvPaperSubViewpointLst.Find(x => x.SubViewpointId == long.Parse( strTablekey));
                            //clsvPaperSubViewpointEN objPaperSubViewpointEN = clsvPaperSubViewpointBL.GetObjBySubViewpointId(strTablekey);
                            if (objPaperSubViewpointEN != null)
                            {
                                strTableTypeName = objPaperSubViewpointEN.SubViewpointContent;
                            }
                        }
                        break;
                    case "04":
                        List<clsViewpointEN> arrViewpointLst = clsViewpointBL.GetObjLstCache(stridCurrEduCls);
                        if (arrViewpointLst.Count > 0)
                        {
                            ////04  个人观点 Viewpoint   ViewpointId
                            clsViewpointEN objViewpointEN = arrViewpointLst.Find(x=>x.ViewpointId == strTablekey);
                            //clsViewpointEN objViewpointEN = clsViewpointBL.GetObjByViewpointId(strTablekey);
                            if (objViewpointEN != null)
                            {
                                strTableTypeName = objViewpointEN.ViewpointName;
                            }
                        }
                        break;
                    case "05":
                        List<clsViewpointEN> arrExpertViewpointLst = clsViewpointBL.GetObjLstCache(stridCurrEduCls);
                        if (arrExpertViewpointLst.Count > 0)
                        {
                            //05  专家观点 Viewpoint   ViewpointId
                            clsViewpointEN objExpertViewpointEN = arrExpertViewpointLst.Find(x => x.ViewpointId == strTablekey);
                            //clsViewpointEN objExpertViewpointEN = clsViewpointBL.GetObjByViewpointId(strTablekey);
                            if (objExpertViewpointEN != null)
                            {
                                strTableTypeName = objExpertViewpointEN.ViewpointName;
                            } 
                        }
                        break;
                    case "06":
                        List<clsConceptEN> arrConceptLst = clsConceptBL.GetObjLstCache(stridCurrEduCls);
                        if (arrConceptLst.Count > 0)
                        {
                            //06  主题概念 Concept ConceptId
                            clsConceptEN objConceptEN = arrConceptLst.Find(x => x.ConceptId == strTablekey);
                            //clsConceptEN objConceptEN = clsConceptBL.GetObjByConceptId(strTablekey);
                            if (objConceptEN != null)
                            {
                                strTableTypeName = objConceptEN.ConceptName;
                            }
                        }
                        break;
                    case "07":
                        List<clsTopicObjectiveEN> arrTopicObjectiveLst = clsTopicObjectiveBL.GetObjLstCache(stridCurrEduCls);
                        if (arrTopicObjectiveLst.Count > 0)
                        {
                            //07  客观事实 TopicObjective  TopicObjectiveId
                            clsTopicObjectiveEN objTopicObjectiveEN = arrTopicObjectiveLst.Find(x => x.TopicObjectiveId == strTablekey);
                            //clsTopicObjectiveEN objTopicObjectiveEN = clsTopicObjectiveBL.GetObjByTopicObjectiveId(strTablekey);
                            if (objTopicObjectiveEN != null)
                            {
                                strTableTypeName = objTopicObjectiveEN.ObjectiveName;
                            }
                        }
                        break;
                    case "08":
                        List<clsTopicObjectiveEN> arrTopicObjectiveBasisLst = clsTopicObjectiveBL.GetObjLstCache(stridCurrEduCls);
                        if (arrTopicObjectiveBasisLst.Count > 0)
                        {
                            //08  客观数据 TopicObjective  TopicObjectiveId
                            clsTopicObjectiveEN objTopicObjectiveBasisEN = arrTopicObjectiveBasisLst.Find(x => x.TopicObjectiveId == strTablekey);
                            //clsTopicObjectiveEN objTopicObjectiveBasisEN = clsTopicObjectiveBL.GetObjByTopicObjectiveId(strTablekey);
                            if (objTopicObjectiveBasisEN != null)
                            {
                                strTableTypeName = objTopicObjectiveBasisEN.ObjectiveName;
                            }
                        }
                        break;
                    case "09":
                        List<clsSysSkillEN> arrSysSkillLst = clsSysSkillBL.GetObjLstCache(stridCurrEduCls);
                        if (arrSysSkillLst.Count > 0)
                        {
                            //09  技能 SysSkill    SkillId
                            clsSysSkillEN objSysSkillEN = arrSysSkillLst.Find(x => x.SkillId == strTablekey);
                            //clsSysSkillEN objSysSkillEN = clsSysSkillBL.GetObjBySkillId(strTablekey);
                            if (objSysSkillEN != null)
                            {
                                strTableTypeName = objSysSkillEN.SkillName;
                            }
                        }
                        break;
                    case "10":
                        List<clsSysSocialRelationsEN> arrSysSocialRelationsLst = clsSysSocialRelationsBL.GetObjLstCache(stridCurrEduCls);
                        if (arrSysSocialRelationsLst.Count > 0)
                        {
                            //10  社会关系 SysSocialRelations  SocialId
                            clsSysSocialRelationsEN objSysSocialRelationsEN = arrSysSocialRelationsLst.Find(x => x.SocialId == strTablekey);
                            //clsSysSocialRelationsEN objSysSocialRelationsEN = clsSysSocialRelationsBL.GetObjBySocialId(strTablekey);
                            if (objSysSocialRelationsEN != null)
                            {
                                //姓名加成就；
                                strTableTypeName = objSysSocialRelationsEN.FullName + "---" + objSysSocialRelationsEN.Achievement;
                            }
                        }
                        break;
                    case "11":
                        List<clsqa_AnswerEN> arrqa_AnswerLst = clsqa_AnswerBL.GetObjLstCache(stridCurrEduCls);
                        if (arrqa_AnswerLst.Count > 0)
                        {
                            //11  回答问题 qa_Answer AnswerId
                            clsqa_AnswerEN objqa_AnswerEN = arrqa_AnswerLst.Find(x => x.AnswerId == strTablekey);
                          //  clsqa_AnswerEN objqa_AnswerEN = clsqa_AnswerBL.GetObjByAnswerId(strTablekey);
                            if (objqa_AnswerEN != null)
                            {
                                //答案内容；
                                strTableTypeName = objqa_AnswerEN.AnswerContent;
                            }
                        }
                        break;
                    default:
                        string strMsg = string.Format("没有获得类型数据");

                        break;

                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("得到类型名字出错, :[{0}]。{1}. (In {2})",
                strTableTypeName, objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            return strTableTypeName;
        }


        /// <summary>
        /// 根据条件分页获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
        /// </summary>
        /// <param name = "objPagerPara">分页获取记录的参数对象</param>
        /// <returns>返回分页对象列表</returns>
        public static List<clsgs_TotalDataStatisticsEN> GetObjLstByPagerEx(stuPagerPara objPagerPara)
        {
            return GetObjLstByPagerEx(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
        }

        /// <summary>
        /// 根据条件分页获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
        /// </summary>
        /// <param name = "intPageIndex">页序号</param>
        /// <param name = "intPageSize">页记录数</param>
        /// <param name = "strWhereCond">给定条件</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <returns>返回分页对象列表</returns>
        public static List<clsgs_TotalDataStatisticsEN> GetObjLstByPagerEx(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
        {
            List<clsgs_TotalDataStatisticsEN> arrObjLst = new List<clsgs_TotalDataStatisticsEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsgs_TotalDataStatisticsEN objgs_TotalDataStatisticsEN = new clsgs_TotalDataStatisticsEN();
                try
                {
                    objgs_TotalDataStatisticsEN.TotalDataId = objRow[congs_TotalDataStatistics.TotalDataId].ToString().Trim(); //TotalDataId
                    objgs_TotalDataStatisticsEN.IdCurrEduCls = objRow[congs_TotalDataStatistics.IdCurrEduCls].ToString().Trim(); //当前教学班流水号
                    string stridCurrEduCls = objRow[congs_TotalDataStatistics.IdCurrEduCls].ToString().Trim();
                    objgs_TotalDataStatisticsEN.TotalDataTypeId = objRow[congs_TotalDataStatistics.TotalDataTypeId].ToString().Trim(); //总数据类型Id
                    objgs_TotalDataStatisticsEN.TableKey = objRow[congs_TotalDataStatistics.TableKey].ToString().Trim(); //表主键
                    objgs_TotalDataStatisticsEN.DataUser = objRow[congs_TotalDataStatistics.DataUser].ToString().Trim(); //数据用户
                    objgs_TotalDataStatisticsEN.DataAddDate = objRow[congs_TotalDataStatistics.DataAddDate].ToString().Trim(); //数据添加日期
                    objgs_TotalDataStatisticsEN.Month = clsEntityBase2.TransNullToInt_S(objRow[congs_TotalDataStatistics.Month].ToString().Trim()); //月
                    objgs_TotalDataStatisticsEN.Week = clsEntityBase2.TransNullToInt_S(objRow[congs_TotalDataStatistics.Week].ToString().Trim()); //周
                    objgs_TotalDataStatisticsEN.UpdDate = objRow[congs_TotalDataStatistics.UpdDate].ToString().Trim(); //修改日期
                    objgs_TotalDataStatisticsEN.UpdUser = objRow[congs_TotalDataStatistics.UpdUser].ToString().Trim(); //修改人
                   

                    string strTotalDataTypeId = objRow[congs_TotalDataStatistics.TotalDataTypeId].ToString().Trim();
                    string strTableKey = objRow[congs_TotalDataStatistics.TableKey].ToString().Trim();
                    objgs_TotalDataStatisticsEN.Memo = GetNameByTableTypeAndKeyId(strTotalDataTypeId, strTableKey, stridCurrEduCls); //备注 --这里用来存放临时 类型名称数据；


                    objgs_TotalDataStatisticsEN.Score = clsEntityBase2.TransNullToFloat_S(objRow[congs_TotalDataStatistics.Score].ToString().Trim()); //评分
                    objgs_TotalDataStatisticsEN.TeaScore = clsEntityBase2.TransNullToFloat_S(objRow[congs_TotalDataStatistics.TeaScore].ToString().Trim()); //教师评分
                    objgs_TotalDataStatisticsEN.WeekTimeRange = objRow[congs_TotalDataStatistics.WeekTimeRange].ToString().Trim(); //WeekTimeRange
                    objgs_TotalDataStatisticsEN.StuScore = clsEntityBase2.TransNullToFloat_S(objRow[congs_TotalDataStatistics.StuScore].ToString().Trim()); //学生平均分
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objgs_TotalDataStatisticsEN.TotalDataId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objgs_TotalDataStatisticsEN);
            }
            objDT = null;
            return arrObjLst;
        }
        #endregion



        #region 六 用于各个表数据换算 月 周 后存放统计表 根据教学班来查询 (参数： 教学班、编辑人)

        public static bool GetTotalStatisticsByTable(string strCurrEduclsId, string strUpdUser)
        {
            bool bolResult = false;
            string strStartDate = string.Empty;//开始日期
            string strEndDate = string.Empty;//结束日期
            try
            {
                #region 获取教学班数据
                //获取教学班日期数据
                clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                strStartDate = objgs_TeachingDate.StartDate;
                strEndDate = objgs_TeachingDate.EndDate;

                //获取统计类型数据
                List<clsgs_TotalDataTypeEN> arrList = clsgs_TotalDataTypeBL.GetObjLst("1=1");
                //2.3循环数据对象
                foreach (clsgs_TotalDataTypeEN objgs_TotalDataTypeEN in arrList)
                {
                    //得到类型判断调用不同的类型表数据
                    string strDataType = string.Empty;
                    strDataType = objgs_TotalDataTypeEN.TotalDataTypeId;

                    switch (strDataType)
                    {
                        case "01":
                            //01  论文 Paper   PaperId
                            bool bolPaper = GetPaperListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetPaperListUpdateTotalStatistics", "论文同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetPaperListUpdateTotalStatistics", "论文同步失败", "TotalDataLog");
                            }


                            break;
                        case "02":
                            //02  论文读写 PaperReadWrite  PaperRWId
                            bool bolPaperReadWrite = GetPaperReadWriteListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser);
                            if (bolPaperReadWrite == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetPaperReadWriteListUpdateTotalStatistics", "论文读写同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetPaperReadWriteListUpdateTotalStatistics", "论文读写同步失败", "TotalDataLog");
                            }
                            break;
                        case "03":
                            ///03  论文子观点 PaperSubViewpoint   SubViewpointId
                            bool bolPaperSubViewpoint = GetPaperSubViewpointListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser);
                            if (bolPaperSubViewpoint == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetPaperSubViewpointListUpdateTotalStatistics", "论文子观点同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetPaperSubViewpointListUpdateTotalStatistics", "论文子观点同步失败", "TotalDataLog");
                            }
                            break;
                        case "04":
                            ////04  个人观点 Viewpoint   ViewpointId
                            string strViewpointtype = "01";
                            bool bolViewpoint = GetViewpointListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser, strViewpointtype);
                            if (bolViewpoint == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetViewpointListUpdateTotalStatistics", "个人观点同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetViewpointListUpdateTotalStatistics", "个人观点同步失败", "TotalDataLog");
                            }
                            break;
                        case "05":
                            //05  专家观点 Viewpoint   ViewpointId
                            string strExpertpointtype = "02";
                            bool bolExpertpoint = GetViewpointListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser, strExpertpointtype);
                            if (bolExpertpoint == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetViewpointListUpdateTotalStatistics", "专家观点同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetViewpointListUpdateTotalStatistics", "专家观点同步失败", "TotalDataLog");
                            }
                            break;
                        case "06":
                            //06  主题概念 Concept ConceptId
                            bool bolConcept = GetConceptListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser);
                            if (bolConcept == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetConceptListUpdateTotalStatistics", "主题概念同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetConceptListUpdateTotalStatistics", "主题概念同步失败", "TotalDataLog");
                            }
                            break;
                        case "07":
                            //07  客观事实 TopicObjective  TopicObjectiveId
                            string strObjectivefact = "01";
                            bool bolTopicObjective = GetTopicObjectiveListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser, strObjectivefact);
                            if (bolTopicObjective == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetTopicObjectiveListUpdateTotalStatistics", "客观事实同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetTopicObjectiveListUpdateTotalStatistics", "客观事实同步失败", "TotalDataLog");
                            }
                            break;
                        case "08":
                            //08  客观数据 TopicObjective  TopicObjectiveId
                            string strObjectiveBasis = "02";
                            bool bolObjectiveBasis = GetTopicObjectiveListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser, strObjectiveBasis);
                            if (bolObjectiveBasis == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetTopicObjectiveListUpdateTotalStatistics", "客观数据同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetTopicObjectiveListUpdateTotalStatistics", "客观数据同步失败", "TotalDataLog");
                            }
                            break;
                        case "09":
                            //09  技能 SysSkill    SkillId
                            bool bolSysSkill = GetSysSkillListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser);
                            if (bolSysSkill == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetSysSkillListUpdateTotalStatistics", "技能同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetSysSkillListUpdateTotalStatistics", "技能同步失败", "TotalDataLog");
                            }
                            break;
                        case "10":
                            //10  社会关系 SysSocialRelations  SocialId
                            bool bolSysSocialRelations = GetSysSocialRelationsListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser);
                            if (bolSysSocialRelations == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetSysSocialRelationsListUpdateTotalStatistics", "社会关系同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetSysSocialRelationsListUpdateTotalStatistics", "社会关系同步失败", "TotalDataLog");
                            }
                            break;
                        case "11":
                            //11  教师问题回答 qa_Answer  AnswerId
                            bool bolqa_Answer = Getqa_AnswerListUpdateTotalStatistics(strStartDate, strEndDate, strCurrEduclsId, strDataType, strUpdUser);
                            if (bolqa_Answer == true)
                            {
                                bolResult = true;
                                WriteTextLog("GetSysSocialRelationsListUpdateTotalStatistics", "教师问题回答同步成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("GetSysSocialRelationsListUpdateTotalStatistics", "教师问题回答同步失败", "TotalDataLog");
                            }
                            break;
                        default:
                            string strMsg = string.Format("没有获得类型数据");

                            break;

                    }
                }

                #endregion

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("统计记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolResult;

        }


        #endregion


        #region 七 根据 《六》 需要的函数位置，各个表的数据处理 
        //统计表扩展函数，用于统计表数据的更新
        //public static bool UpdDataTotalStatistics(clsgs_TotalDataStatisticsEN objUpdTotalData, string strStart, string strCreateDate, string strUpdUser, float strScore, float strTeaScore)
        //{
        //    bool bolresult = false;
        //    objUpdTotalData.Week = GetWeekByDate(strStart, strCreateDate);
        //    objUpdTotalData.Score = strScore;
        //    objUpdTotalData.TeaScore = strTeaScore;
        //    objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //    objUpdTotalData.UpdUser = strUpdUser;
        //    objUpdTotalData.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, strCreateDate), strStart);
        //    bool i = clsgs_TotalDataStatisticsBL.UpdateBySql2(objUpdTotalData);
        //    if (i == true)
        //    {
        //        bolresult = true;
        //    }
        //    else
        //    {
        //        bolresult = false;
        //    }
        //    return bolresult;
        //}
        //论文01
        public static bool GetPaperListUpdateTotalStatistics(string strStart, string strEnd, string strIdCurrEduCls, string strDataType, string strUpdUser)
        {
            bool bolresult = false;
            try
            {
                string strwhere = "CreateDate >= '" + strStart + "' And CreateDate <='" + strEnd + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                List<clsPaperEN> ArrList = clsPaperBL.GetObjLst(strwhere);

                if (ArrList.Count > 0)
                {
                    foreach (clsPaperEN objPaperEN in ArrList)
                    {

                        //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                        string strwhereCond = "TotalDataTypeId='" + strDataType + "' And TableKey='" + objPaperEN.PaperId + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                        clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                        if (objUpdTotalData == null)
                        {
                            clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                            //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
                            objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(strDataType, objPaperEN.PaperId);

                            objNewgs_TotalDataStatistics.IdCurrEduCls = strIdCurrEduCls;
                            objNewgs_TotalDataStatistics.TotalDataTypeId = strDataType;
                            //得到分数
                            objNewgs_TotalDataStatistics.Score = objPaperEN.Score;
                            objNewgs_TotalDataStatistics.TeaScore = objPaperEN.TeaScore;
                            objNewgs_TotalDataStatistics.StuScore = objPaperEN.StuScore;
                            objNewgs_TotalDataStatistics.TableKey = objPaperEN.PaperId;
                            objNewgs_TotalDataStatistics.DataUser = objPaperEN.UpdUser;
                            objNewgs_TotalDataStatistics.DataAddDate = objPaperEN.CreateDate;
                            //根据时间得到 月 周、
                            objNewgs_TotalDataStatistics.Month = Convert.ToInt32(objPaperEN.CreateDate.Substring(5, 2));
                            objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStart, objPaperEN.CreateDate);
                            objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, objPaperEN.CreateDate), strStart);

                            objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNewgs_TotalDataStatistics.UpdUser = strUpdUser;

                            bool i = clsgs_TotalDataStatisticsBL.AddNewRecordBySql2(objNewgs_TotalDataStatistics);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }
                        else
                        {

                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objPaperEN.CreateDate, strUpdUser, objPaperEN.Score ?? 0, objPaperEN.TeaScore ?? 0, objPaperEN.StuScore ?? 0);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }
                    }
                }

                ////获取总表的类型数据
                ////根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                string strwhereTotalCond = "TotalDataTypeId='" + strDataType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                List<clsgs_TotalDataStatisticsEN> ArrListTotalData = clsgs_TotalDataStatisticsBL.GetObjLst(strwhereTotalCond);
                //获取论文所有key
                var ArrKey = ArrList.Select(x => x.PaperId).ToList();
                //var arrSelDel = arr_sel.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                //获取论文总数据所有key
                var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                if (arrSelDel.Count > 0)
                {
                    //删除总数据的key；
                    arrSelDel.ForEach(x => x.Delete());
                    WriteTextLog(arrSelDel.ToString(), "删除论文数据", "TotalDataLog");
                }
                //  }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("论文统计记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }


        //论文读写02
        public static bool GetPaperReadWriteListUpdateTotalStatistics(string strStart, string strEnd, string strIdCurrEduCls, string strDataType, string strUpdUser)
        {
            bool bolresult = false;
            try
            {
                string strwhere = "updDate >= '" + strStart + "' And updDate <='" + strEnd + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                List<clsPaperReadWriteEN> ArrList = clsPaperReadWriteBL.GetObjLst(strwhere);
                if (ArrList.Count > 0)
                {
                    foreach (clsPaperReadWriteEN objPaperReadWriteEN in ArrList)
                    {

                        //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                        string strwhereCond = "TotalDataTypeId='" + strDataType + "' And TableKey='" + objPaperReadWriteEN.PaperRWId + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                        WriteTextLog(strwhereCond, "条件串", "TotalDataLog");
                        clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                        if (objUpdTotalData == null)
                        {
                            clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                            //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
                            objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(strDataType, objPaperReadWriteEN.PaperRWId);

                            objNewgs_TotalDataStatistics.IdCurrEduCls = strIdCurrEduCls;
                            objNewgs_TotalDataStatistics.TotalDataTypeId = strDataType;
                            //得到分数
                            objNewgs_TotalDataStatistics.Score = 0;
                            objNewgs_TotalDataStatistics.TeaScore = 0;
                            objNewgs_TotalDataStatistics.StuScore = 0;
                            objNewgs_TotalDataStatistics.TableKey = objPaperReadWriteEN.PaperRWId;
                            objNewgs_TotalDataStatistics.DataUser = objPaperReadWriteEN.UpdUser;
                            objNewgs_TotalDataStatistics.DataAddDate = objPaperReadWriteEN.CreateDate;
                            //根据时间得到 月 周、
                            objNewgs_TotalDataStatistics.Month = Convert.ToInt32(objPaperReadWriteEN.CreateDate.Substring(5, 2));
                            WriteTextLog(GetWeekByDate(strStart, objPaperReadWriteEN.CreateDate).ToString(), "添加获取周", "TotalDataLog");
                            objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStart, objPaperReadWriteEN.CreateDate);
                            objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, objPaperReadWriteEN.CreateDate), strStart);
                            objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNewgs_TotalDataStatistics.UpdUser = strUpdUser;

                            bool i = clsgs_TotalDataStatisticsBL.AddNewRecordBySql2(objNewgs_TotalDataStatistics);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }

                        }
                        else
                        {

                            //objUpdTotalData.Week = GetWeekByDate(strStart, objPaperReadWriteEN.CreateDate);
                            //objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            //objUpdTotalData.UpdUser = strUpdUser;
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objPaperReadWriteEN.CreateDate, strUpdUser, 0, 0,0);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }
                    }
                }

                if (bolresult == true)
                {
                    ////获取总表的类型数据
                    ////根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                    string strwhereTotalCond = "TotalDataTypeId='" + strDataType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                    List<clsgs_TotalDataStatisticsEN> ArrListTotalData = clsgs_TotalDataStatisticsBL.GetObjLst(strwhereTotalCond);
                    //获取论文读写所有key
                    var ArrKey = ArrList.Select(x => x.PaperRWId).ToList();
                    //var arrSelDel = arr_sel.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //获取论文总数据所有key
                    var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //删除总数据的key；
                    if (arrSelDel.Count > 0)
                    {
                        //删除总数据的key；
                        arrSelDel.ForEach(x => x.Delete());
                        WriteTextLog(arrSelDel.ToString(), "删除论文读写数据", "TotalDataLog");
                    }

                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("论文读写数据记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
            return bolresult;
        }

        //论文子观点 03
        public static bool GetPaperSubViewpointListUpdateTotalStatistics(string strStart, string strEnd, string strIdCurrEduCls, string strDataType, string strUpdUser)
        {
            bool bolresult = false;
            try
            {
                string strwhere = "CreateDate >= '" + strStart + "' And CreateDate <='" + strEnd + "'  And IdCurrEduCls='" + strIdCurrEduCls + "'";
                List<clsvPaperSubViewpointEN> ArrList = clsvPaperSubViewpointBL.GetObjLst(strwhere);
                if (ArrList.Count > 0)
                {
                    foreach (clsvPaperSubViewpointEN objPaperSubViewpointEN in ArrList)
                    {

                        //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                        string strwhereCond = "TotalDataTypeId='" + strDataType + "' And TableKey='" + objPaperSubViewpointEN.SubViewpointId + "'  And IdCurrEduCls='" + strIdCurrEduCls + "'";
                        WriteTextLog(strwhereCond, "论文子观点条件查询", "TotalDataLog");
                        clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                        if (objUpdTotalData == null)
                        {
                            clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                            //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
                            objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(strDataType, objPaperSubViewpointEN.SubViewpointId.ToString());

                            objNewgs_TotalDataStatistics.IdCurrEduCls = strIdCurrEduCls;
                            objNewgs_TotalDataStatistics.TotalDataTypeId = strDataType;
                            //得到分数
                            objNewgs_TotalDataStatistics.Score = objPaperSubViewpointEN.Score;
                            objNewgs_TotalDataStatistics.TeaScore = objPaperSubViewpointEN.TeaScore;
                            objNewgs_TotalDataStatistics.StuScore = objPaperSubViewpointEN.StuScore;
                            objNewgs_TotalDataStatistics.TableKey = objPaperSubViewpointEN.SubViewpointId.ToString();
                            objNewgs_TotalDataStatistics.DataUser = objPaperSubViewpointEN.UpdUser;
                            objNewgs_TotalDataStatistics.DataAddDate = objPaperSubViewpointEN.CreateDate;
                            //根据时间得到 月 周、

                            objNewgs_TotalDataStatistics.Month = Convert.ToInt32(objPaperSubViewpointEN.CreateDate.Substring(5, 2));
                            objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStart, objPaperSubViewpointEN.CreateDate);
                            objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, objPaperSubViewpointEN.CreateDate), strStart);

                            objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNewgs_TotalDataStatistics.UpdUser = strUpdUser;

                            bool i = clsgs_TotalDataStatisticsBL.AddNewRecordBySql2(objNewgs_TotalDataStatistics);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }

                        }
                        else
                        {
                            WriteTextLog(GetWeekByDate(strStart, objPaperSubViewpointEN.CreateDate).ToString(), "论文子观点周", "TotalDataLog");
                            //objUpdTotalData.Week = GetWeekByDate(strStart, objPaperSubViewpointEN.CreateDate);
                            //objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            //objUpdTotalData.UpdUser = strUpdUser;
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objPaperSubViewpointEN.CreateDate, strUpdUser, objPaperSubViewpointEN.Score ?? 0, objPaperSubViewpointEN.TeaScore ?? 0, objPaperSubViewpointEN.StuScore ?? 0);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }

                    }
                }

                if (bolresult == true)
                {
                    ////获取总表的类型数据
                    ////根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                    string strwhereTotalCond = "TotalDataTypeId='" + strDataType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                    List<clsgs_TotalDataStatisticsEN> ArrListTotalData = clsgs_TotalDataStatisticsBL.GetObjLst(strwhereTotalCond);

                    ////获取统计类型数据
                    //List<clsgs_TotalDataTypeEN> arrList = clsgs_TotalDataTypeBL.GetObjLst("1=1");
                    ////2.3循环数据对象
                    //foreach (clsgs_TotalDataTypeEN objgs_TotalDataTypeEN in arrList)
                    //{
                    //    var arr_sel= ArrListTotalData.Where(x => x.TotalDataTypeId== objgs_TotalDataTypeEN.TotalDataTypeId).ToList();
                    //获取论文子观点所有key
                    var ArrKey = ArrList.Select(x => x.SubViewpointId).ToList();
                    //var arrSelDel = arr_sel.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //获取论文总数据所有key
                    var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(long.Parse( x.TableKey)) == false).ToList();
                    //删除总数据的key；
                    if (arrSelDel.Count > 0)
                    {
                        //删除总数据的key；
                        arrSelDel.ForEach(x => x.Delete());
                        WriteTextLog(arrSelDel.ToString(), "删除论文子观点数据", "TotalDataLog");
                    }


                }

                //  }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("论文子观点记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }

        //观点  个人 专家 0405
        public static bool GetViewpointListUpdateTotalStatistics(string strStart, string strEnd, string strIdCurrEduCls, string strDataType, string strUpdUser, string strUserType)
        {
            bool bolresult = false;
            try
            {
                string strwhere = "CreateDate >= '" + strStart + "' And CreateDate <='" + strEnd + "' And UserTypeId='" + strUserType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                List<clsViewpointEN> ArrList = clsViewpointBL.GetObjLst(strwhere);
                if (ArrList.Count > 0)
                {
                    foreach (clsViewpointEN objViewpointEN in ArrList)
                    {

                        //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                        string strwhereCond = "TotalDataTypeId='" + strDataType + "' And TableKey='" + objViewpointEN.ViewpointId + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                        clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                        if (objUpdTotalData == null)
                        {
                            clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                            //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
                            objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(strDataType, objViewpointEN.ViewpointId);

                            objNewgs_TotalDataStatistics.IdCurrEduCls = strIdCurrEduCls;
                            objNewgs_TotalDataStatistics.TotalDataTypeId = strDataType;
                            //得到分数
                            objNewgs_TotalDataStatistics.Score = objViewpointEN.Score;
                            objNewgs_TotalDataStatistics.TeaScore = objViewpointEN.TeaScore;
                            objNewgs_TotalDataStatistics.StuScore = objViewpointEN.StuScore;
                            objNewgs_TotalDataStatistics.TableKey = objViewpointEN.ViewpointId.ToString();
                            objNewgs_TotalDataStatistics.DataUser = objViewpointEN.UpdUser;
                            objNewgs_TotalDataStatistics.DataAddDate = objViewpointEN.CreateDate;
                            //根据时间得到 月 周、
                            objNewgs_TotalDataStatistics.Month = Convert.ToInt32(objViewpointEN.CreateDate.Substring(5, 2));
                            objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStart, objViewpointEN.CreateDate);
                            objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, objViewpointEN.CreateDate), strStart);

                            objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNewgs_TotalDataStatistics.UpdUser = strUpdUser;

                            bool i = clsgs_TotalDataStatisticsBL.AddNewRecordBySql2(objNewgs_TotalDataStatistics);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }

                        }
                        else
                        {
                            //objUpdTotalData.Week = GetWeekByDate(strStart, objViewpointEN.CreateDate);
                            //objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            //objUpdTotalData.UpdUser = strUpdUser;
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objViewpointEN.CreateDate, strUpdUser, objViewpointEN.Score ?? 0, objViewpointEN.TeaScore ?? 0, objViewpointEN.StuScore ?? 0);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }
                    }
                }
                if (bolresult == true)
                {
                    ////获取总表的类型数据
                    ////根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                    string strwhereTotalCond = "TotalDataTypeId='" + strDataType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                    List<clsgs_TotalDataStatisticsEN> ArrListTotalData = clsgs_TotalDataStatisticsBL.GetObjLst(strwhereTotalCond);

                    //获取观点所有key
                    var ArrKey = ArrList.Select(x => x.ViewpointId).ToList();
                    //var arrSelDel = arr_sel.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //获取论文总数据所有key
                    var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //删除总数据的key；
                    if (arrSelDel.Count > 0)
                    {
                        //删除总数据的key；
                        arrSelDel.ForEach(x => x.Delete());
                        WriteTextLog(arrSelDel.ToString(), "删除观点数据", "TotalDataLog");
                    }
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("观点记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
            return bolresult;
        }

        //概念 06
        public static bool GetConceptListUpdateTotalStatistics(string strStart, string strEnd, string strIdCurrEduCls, string strDataType, string strUpdUser)
        {
            bool bolresult = false;
            try
            {
                string strwhere = "CreateDate >= '" + strStart + "' And CreateDate <='" + strEnd + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                List<clsConceptEN> ArrList = clsConceptBL.GetObjLst(strwhere);
                if (ArrList.Count > 0)
                {
                    foreach (clsConceptEN objConceptEN in ArrList)
                    {

                        //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                        string strwhereCond = "TotalDataTypeId='" + strDataType + "' And TableKey='" + objConceptEN.ConceptId + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                        clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                        if (objUpdTotalData == null)
                        {
                            clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                            //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
                            objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(strDataType, objConceptEN.ConceptId);

                            objNewgs_TotalDataStatistics.IdCurrEduCls = strIdCurrEduCls;
                            objNewgs_TotalDataStatistics.TotalDataTypeId = strDataType;
                            //得到分数
                            objNewgs_TotalDataStatistics.Score = objConceptEN.Score;
                            objNewgs_TotalDataStatistics.TeaScore = objConceptEN.TeaScore;
                            objNewgs_TotalDataStatistics.StuScore = objConceptEN.StuScore;
                            objNewgs_TotalDataStatistics.TableKey = objConceptEN.ConceptId;
                            objNewgs_TotalDataStatistics.DataUser = objConceptEN.UpdUser;
                            objNewgs_TotalDataStatistics.DataAddDate = objConceptEN.CreateDate;
                            //根据时间得到 月 周、
                            objNewgs_TotalDataStatistics.Month = Convert.ToInt32(objConceptEN.CreateDate.Substring(5, 2));
                            objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStart, objConceptEN.CreateDate);
                            objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, objConceptEN.CreateDate), strStart);
                            objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNewgs_TotalDataStatistics.UpdUser = strUpdUser;

                            bool i = clsgs_TotalDataStatisticsBL.AddNewRecordBySql2(objNewgs_TotalDataStatistics);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }

                        }
                        else
                        {
                            //objUpdTotalData.Week = GetWeekByDate(strStart, objConceptEN.CreateDate);
                            //objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            //objUpdTotalData.UpdUser = strUpdUser;
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objConceptEN.CreateDate, strUpdUser, objConceptEN.Score ?? 0, objConceptEN.TeaScore ?? 0, objConceptEN.StuScore ?? 0);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }
                    }
                }

                if (bolresult == true)
                {
                    ////获取总表的类型数据
                    ////根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                    string strwhereTotalCond = "TotalDataTypeId='" + strDataType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                    List<clsgs_TotalDataStatisticsEN> ArrListTotalData = clsgs_TotalDataStatisticsBL.GetObjLst(strwhereTotalCond);

                    //获取概念所有key
                    var ArrKey = ArrList.Select(x => x.ConceptId).ToList();
                    //var arrSelDel = arr_sel.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //获取论文总数据所有key
                    var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //删除总数据的key；
                    if (arrSelDel.Count > 0)
                    {
                        //删除总数据的key；
                        arrSelDel.ForEach(x => x.Delete());
                        WriteTextLog(arrSelDel.ToString(), "删除概念数据", "TotalDataLog");
                    }

                }

                //  }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("概念记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }

        //客观  事实 数据 0708
        public static bool GetTopicObjectiveListUpdateTotalStatistics(string strStart, string strEnd, string strIdCurrEduCls, string strDataType, string strUpdUser, string strObjectiveType)
        {
            bool bolresult = false;
            try
            {
                string strwhere = "CreateDate >= '" + strStart + "' And CreateDate <='" + strEnd + "' And ObjectiveType='" + strObjectiveType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                List<clsTopicObjectiveEN> ArrList = clsTopicObjectiveBL.GetObjLst(strwhere);
                if (ArrList.Count > 0)
                {
                    foreach (clsTopicObjectiveEN objTopicObjectiveEN in ArrList)
                    {

                        //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                        string strwhereCond = "TotalDataTypeId='" + strDataType + "' And TableKey='" + objTopicObjectiveEN.TopicObjectiveId + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                        clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                        if (objUpdTotalData == null)
                        {
                            clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                            //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
                            objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(strDataType, objTopicObjectiveEN.TopicObjectiveId.ToString());

                            objNewgs_TotalDataStatistics.IdCurrEduCls = strIdCurrEduCls;
                            objNewgs_TotalDataStatistics.TotalDataTypeId = strDataType;
                            //得到分数
                            objNewgs_TotalDataStatistics.Score = objTopicObjectiveEN.Score;
                            objNewgs_TotalDataStatistics.TeaScore = objTopicObjectiveEN.TeaScore;
                            objNewgs_TotalDataStatistics.StuScore = objTopicObjectiveEN.StuScore;
                            objNewgs_TotalDataStatistics.TableKey = objTopicObjectiveEN.TopicObjectiveId.ToString();
                            objNewgs_TotalDataStatistics.DataUser = objTopicObjectiveEN.UpdUser;
                            objNewgs_TotalDataStatistics.DataAddDate = objTopicObjectiveEN.CreateDate;
                            //根据时间得到 月 周、
                            objNewgs_TotalDataStatistics.Month = Convert.ToInt32(objTopicObjectiveEN.CreateDate.Substring(5, 2));
                            objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStart, objTopicObjectiveEN.CreateDate);
                            objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, objTopicObjectiveEN.CreateDate), strStart);
                            objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNewgs_TotalDataStatistics.UpdUser = strUpdUser;

                            bool i = clsgs_TotalDataStatisticsBL.AddNewRecordBySql2(objNewgs_TotalDataStatistics);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }

                        }
                        else
                        {
                            //objUpdTotalData.Week = GetWeekByDate(strStart, objTopicObjectiveEN.CreateDate);
                            //objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            //objUpdTotalData.UpdUser = strUpdUser;
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objTopicObjectiveEN.CreateDate, strUpdUser, objTopicObjectiveEN.Score ?? 0, objTopicObjectiveEN.TeaScore ?? 0, objTopicObjectiveEN.StuScore ?? 0);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }
                    }
                }
                if (bolresult == true)
                {

                    ////获取总表的类型数据
                    ////根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                    string strwhereTotalCond = "TotalDataTypeId='" + strDataType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                    List<clsgs_TotalDataStatisticsEN> ArrListTotalData = clsgs_TotalDataStatisticsBL.GetObjLst(strwhereTotalCond);

                    ////获取统计类型数据
                    //List<clsgs_TotalDataTypeEN> arrList = clsgs_TotalDataTypeBL.GetObjLst("1=1");
                    ////2.3循环数据对象
                    //foreach (clsgs_TotalDataTypeEN objgs_TotalDataTypeEN in arrList)
                    //{
                    //    var arr_sel= ArrListTotalData.Where(x => x.TotalDataTypeId== objgs_TotalDataTypeEN.TotalDataTypeId).ToList();
                    //获取客观事实数据所有key
                    var ArrKey = ArrList.Select(x => x.TopicObjectiveId).ToList();
                    //var arrSelDel = arr_sel.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //获取论文总数据所有key
                    var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //删除总数据的key；
                    if (arrSelDel.Count > 0)
                    {
                        //删除总数据的key；
                        arrSelDel.ForEach(x => x.Delete());
                        WriteTextLog(arrSelDel.ToString(), "删除客观数据", "TotalDataLog");
                    }


                }

                //  }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("客观数据记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }

        //技能 09
        public static bool GetSysSkillListUpdateTotalStatistics(string strStart, string strEnd, string strIdCurrEduCls, string strDataType, string strUpdUser)
        {
            bool bolresult = false;
            try
            {
                string strwhere = "CreateDate >= '" + strStart + "' And CreateDate <='" + strEnd + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                List<clsSysSkillEN> ArrList = clsSysSkillBL.GetObjLst(strwhere);
                if (ArrList.Count > 0)
                {
                    foreach (clsSysSkillEN objSysSkillEN in ArrList)
                    {

                        //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                        string strwhereCond = "TotalDataTypeId='" + strDataType + "' And TableKey='" + objSysSkillEN.SkillId + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                        clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                        if (objUpdTotalData == null)
                        {
                            clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                            //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
                            objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(strDataType, objSysSkillEN.SkillId);

                            objNewgs_TotalDataStatistics.IdCurrEduCls = strIdCurrEduCls;
                            objNewgs_TotalDataStatistics.TotalDataTypeId = strDataType;
                            //得到分数
                            objNewgs_TotalDataStatistics.Score = objSysSkillEN.Score;
                            objNewgs_TotalDataStatistics.TeaScore = objSysSkillEN.TeaScore;
                            objNewgs_TotalDataStatistics.StuScore = objSysSkillEN.StuScore;
                            objNewgs_TotalDataStatistics.TableKey = objSysSkillEN.SkillId;
                            objNewgs_TotalDataStatistics.DataUser = objSysSkillEN.UpdUser;
                            objNewgs_TotalDataStatistics.DataAddDate = objSysSkillEN.CreateDate;
                            //根据时间得到 月 周、
                            objNewgs_TotalDataStatistics.Month = Convert.ToInt32(objSysSkillEN.CreateDate.Substring(5, 2));
                            objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStart, objSysSkillEN.CreateDate);
                            objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, objSysSkillEN.CreateDate), strStart);

                            objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNewgs_TotalDataStatistics.UpdUser = strUpdUser;

                            bool i = clsgs_TotalDataStatisticsBL.AddNewRecordBySql2(objNewgs_TotalDataStatistics);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }

                        }
                        else
                        {
                            //objUpdTotalData.Week = GetWeekByDate(strStart, objSysSkillEN.CreateDate);
                            //objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            //objUpdTotalData.UpdUser = strUpdUser;
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objSysSkillEN.CreateDate, strUpdUser, objSysSkillEN.Score ?? 0, objSysSkillEN.TeaScore ?? 0, objSysSkillEN.StuScore ?? 0);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }
                    }
                }
                if (bolresult == true)
                {
                    ////获取总表的类型数据
                    ////根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                    string strwhereTotalCond = "TotalDataTypeId='" + strDataType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                    List<clsgs_TotalDataStatisticsEN> ArrListTotalData = clsgs_TotalDataStatisticsBL.GetObjLst(strwhereTotalCond);

                    ////获取统计类型数据
                    //List<clsgs_TotalDataTypeEN> arrList = clsgs_TotalDataTypeBL.GetObjLst("1=1");
                    ////2.3循环数据对象
                    //foreach (clsgs_TotalDataTypeEN objgs_TotalDataTypeEN in arrList)
                    //{
                    //    var arr_sel= ArrListTotalData.Where(x => x.TotalDataTypeId== objgs_TotalDataTypeEN.TotalDataTypeId).ToList();
                    //获取技能所有key
                    var ArrKey = ArrList.Select(x => x.SkillId).ToList();
                    //var arrSelDel = arr_sel.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //获取论文总数据所有key
                    var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //删除总数据的key；
                    if (arrSelDel.Count > 0)
                    {
                        //删除总数据的key；
                        arrSelDel.ForEach(x => x.Delete());
                        WriteTextLog(arrSelDel.ToString(), "删除技能数据", "TotalDataLog");
                    }
                    //  }


                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("技能记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }

        //社会关系 10
        public static bool GetSysSocialRelationsListUpdateTotalStatistics(string strStart, string strEnd, string strIdCurrEduCls, string strDataType, string strUpdUser)
        {
            bool bolresult = false;
            try
            {
                string strwhere = "CreateDate >= '" + strStart + "' And CreateDate <='" + strEnd + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                List<clsSysSocialRelationsEN> ArrList = clsSysSocialRelationsBL.GetObjLst(strwhere);
                if (ArrList.Count > 0)
                {
                    foreach (clsSysSocialRelationsEN objSysSocialRelationsEN in ArrList)
                    {

                        //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                        string strwhereCond = "TotalDataTypeId='" + strDataType + "' And TableKey='" + objSysSocialRelationsEN.SocialId + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                        clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                        if (objUpdTotalData == null)
                        {
                            clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                            objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(strDataType, objSysSocialRelationsEN.SocialId);

                            objNewgs_TotalDataStatistics.IdCurrEduCls = strIdCurrEduCls;
                            objNewgs_TotalDataStatistics.TotalDataTypeId = strDataType;
                            //得到分数
                            objNewgs_TotalDataStatistics.Score = objSysSocialRelationsEN.Score;
                            objNewgs_TotalDataStatistics.TeaScore = objSysSocialRelationsEN.TeaScore;
                            objNewgs_TotalDataStatistics.StuScore = objSysSocialRelationsEN.StuScore;
                            objNewgs_TotalDataStatistics.TableKey = objSysSocialRelationsEN.SocialId;
                            objNewgs_TotalDataStatistics.DataUser = objSysSocialRelationsEN.UpdUser;
                            objNewgs_TotalDataStatistics.DataAddDate = objSysSocialRelationsEN.CreateDate;
                            //根据时间得到 月 周、
                            objNewgs_TotalDataStatistics.Month = Convert.ToInt32(objSysSocialRelationsEN.CreateDate.Substring(5, 2));
                            objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStart, objSysSocialRelationsEN.CreateDate);
                            objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, objSysSocialRelationsEN.CreateDate), strStart);

                            objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNewgs_TotalDataStatistics.UpdUser = strUpdUser;

                            bool i = clsgs_TotalDataStatisticsBL.AddNewRecordBySql2(objNewgs_TotalDataStatistics);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }

                        }
                        else
                        {
                            //objUpdTotalData.Week = GetWeekByDate(strStart, objSysSocialRelationsEN.CreateDate);
                            //objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            //objUpdTotalData.UpdUser = strUpdUser;
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objSysSocialRelationsEN.CreateDate, strUpdUser, objSysSocialRelationsEN.Score ?? 0, objSysSocialRelationsEN.TeaScore ?? 0, objSysSocialRelationsEN.StuScore ?? 0);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }

                    }
                }

                if (bolresult == true)
                {
                    ////获取总表的类型数据
                    ////根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                    string strwhereTotalCond = "TotalDataTypeId='" + strDataType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                    List<clsgs_TotalDataStatisticsEN> ArrListTotalData = clsgs_TotalDataStatisticsBL.GetObjLst(strwhereTotalCond);

                    ////获取统计类型数据
                    //List<clsgs_TotalDataTypeEN> arrList = clsgs_TotalDataTypeBL.GetObjLst("1=1");
                    ////2.3循环数据对象
                    //foreach (clsgs_TotalDataTypeEN objgs_TotalDataTypeEN in arrList)
                    //{
                    //    var arr_sel= ArrListTotalData.Where(x => x.TotalDataTypeId== objgs_TotalDataTypeEN.TotalDataTypeId).ToList();
                    //获取社会关系所有key
                    var ArrKey = ArrList.Select(x => x.SocialId).ToList();
                    //var arrSelDel = arr_sel.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //获取论文总数据所有key
                    var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();

                    //删除总数据的key；
                    if (arrSelDel.Count > 0)
                    {
                        //删除总数据的key；
                        arrSelDel.ForEach(x => x.Delete());
                        WriteTextLog(arrSelDel.ToString(), "删除社会关系数据", "TotalDataLog");
                    }


                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("社会关系记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }

        //教师问题回答 11
        public static bool Getqa_AnswerListUpdateTotalStatistics(string strStart, string strEnd, string strIdCurrEduCls, string strDataType, string strUpdUser) {
            bool bolresult = false;
            try
            {
                string strwhere = "CreateDate >= '" + strStart + "' And CreateDate <='" + strEnd + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                List<clsqa_AnswerEN> ArrList = clsqa_AnswerBL.GetObjLst(strwhere);
                if (ArrList.Count > 0)
                {
                    foreach (clsqa_AnswerEN objqa_AnswerEN in ArrList)
                    {

                        //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                        string strwhereCond = "TotalDataTypeId='" + strDataType + "' And TableKey='" + objqa_AnswerEN.AnswerId + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                        clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                        if (objUpdTotalData == null)
                        {
                            clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                            objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(strDataType, objqa_AnswerEN.AnswerId);

                            objNewgs_TotalDataStatistics.IdCurrEduCls = strIdCurrEduCls;
                            objNewgs_TotalDataStatistics.TotalDataTypeId = strDataType;
                            //得到分数
                            objNewgs_TotalDataStatistics.Score = objqa_AnswerEN.Score;
                            objNewgs_TotalDataStatistics.TeaScore = objqa_AnswerEN.TeaScore;
                            objNewgs_TotalDataStatistics.StuScore = objqa_AnswerEN.StuScore;
                            objNewgs_TotalDataStatistics.TableKey = objqa_AnswerEN.AnswerId;
                            objNewgs_TotalDataStatistics.DataUser = objqa_AnswerEN.UpdUser;
                            objNewgs_TotalDataStatistics.DataAddDate = objqa_AnswerEN.UpdDate;
                            //根据时间得到 月 周、
                            objNewgs_TotalDataStatistics.Month = Convert.ToInt32(objqa_AnswerEN.UpdDate.Substring(5, 2));
                            objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStart, objqa_AnswerEN.UpdDate);
                            objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStart, objqa_AnswerEN.UpdDate), strStart);

                            objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            objNewgs_TotalDataStatistics.UpdUser = strUpdUser;

                            bool i = clsgs_TotalDataStatisticsBL.AddNewRecordBySql2(objNewgs_TotalDataStatistics);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }

                        }
                        else
                        {
                            //objUpdTotalData.Week = GetWeekByDate(strStart, objSysSocialRelationsEN.CreateDate);
                            //objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            //objUpdTotalData.UpdUser = strUpdUser;
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objqa_AnswerEN.UpdDate, strUpdUser, objqa_AnswerEN.Score ?? 0, objqa_AnswerEN.TeaScore ?? 0, objqa_AnswerEN.StuScore ?? 0);
                            if (i == true)
                            {
                                bolresult = true;
                            }
                            else
                            {
                                bolresult = false;
                            }
                        }

                    }
                }

                if (bolresult == true)
                {
                    ////获取总表的类型数据
                    ////根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                    string strwhereTotalCond = "TotalDataTypeId='" + strDataType + "' And IdCurrEduCls='" + strIdCurrEduCls + "'";
                    List<clsgs_TotalDataStatisticsEN> ArrListTotalData = clsgs_TotalDataStatisticsBL.GetObjLst(strwhereTotalCond);

                    ////获取统计类型数据
                    //List<clsgs_TotalDataTypeEN> arrList = clsgs_TotalDataTypeBL.GetObjLst("1=1");
                    ////2.3循环数据对象
                    //foreach (clsgs_TotalDataTypeEN objgs_TotalDataTypeEN in arrList)
                    //{
                    //    var arr_sel= ArrListTotalData.Where(x => x.TotalDataTypeId== objgs_TotalDataTypeEN.TotalDataTypeId).ToList();
                    //获取社会关系所有key
                    var ArrKey = ArrList.Select(x => x.AnswerId).ToList();
                    //var arrSelDel = arr_sel.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();
                    //获取论文总数据所有key
                    var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(x.TableKey) == false).ToList();

                    //删除总数据的key；
                    if (arrSelDel.Count > 0)
                    {
                        //删除总数据的key；
                        arrSelDel.ForEach(x => x.Delete());
                        WriteTextLog(arrSelDel.ToString(), "删除社会关系数据", "TotalDataLog");
                    }


                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("社会关系记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }
        #endregion
    }
}
