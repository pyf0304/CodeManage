
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_TotalDataStatisticsBLEx
表名:gs_TotalDataStatistics(01120683)
生成代码版本:2020.06.21.1
生成日期:2020/06/23 22:48:08
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研培设置
模块英文名:GraduateEduTools
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using com.taishsoft.datetime;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace ExamLib.BusinessLogicEx
{
    public static class clsgs_TotalDataStatisticsBLEx_Static
    {
        #region 自带各种函数
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_TotalDataStatisticsENS">源对象</param>
        /// <returns>目标对象=>clsgs_TotalDataStatisticsEN:objgs_TotalDataStatisticsENT</returns>
        public static clsgs_TotalDataStatisticsENEx CopyToEx(this clsgs_TotalDataStatisticsEN objgs_TotalDataStatisticsENS)
        {
            try
            {
                clsgs_TotalDataStatisticsENEx objgs_TotalDataStatisticsENT = new clsgs_TotalDataStatisticsENEx();
                clsgs_TotalDataStatisticsBL.gs_TotalDataStatisticsDA.CopyTo(objgs_TotalDataStatisticsENS, objgs_TotalDataStatisticsENT);
                return objgs_TotalDataStatisticsENT;
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
        /// <param name = "objgs_TotalDataStatisticsENS">源对象</param>
        /// <returns>目标对象=>clsgs_TotalDataStatisticsEN:objgs_TotalDataStatisticsENT</returns>
        public static clsgs_TotalDataStatisticsEN CopyTo(this clsgs_TotalDataStatisticsENEx objgs_TotalDataStatisticsENS)
        {
            try
            {
                clsgs_TotalDataStatisticsEN objgs_TotalDataStatisticsENT = new clsgs_TotalDataStatisticsEN();
                clsgs_TotalDataStatisticsBL.CopyTo(objgs_TotalDataStatisticsENS, objgs_TotalDataStatisticsENT);
                return objgs_TotalDataStatisticsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        #endregion
    }
    /// <summary>
    /// 总数据统计(gs_TotalDataStatistics)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_TotalDataStatisticsBLEx : clsgs_TotalDataStatisticsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_TotalDataStatisticsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_TotalDataStatisticsDAEx gs_TotalDataStatisticsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_TotalDataStatisticsDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        #region 自带的各种函数
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_TotalDataStatisticsENS">源对象</param>
        /// <returns>目标对象=>clsgs_TotalDataStatisticsEN:objgs_TotalDataStatisticsENT</returns>
        public static clsgs_TotalDataStatisticsENEx CopyToEx(clsgs_TotalDataStatisticsEN objgs_TotalDataStatisticsENS)
        {
            try
            {
                clsgs_TotalDataStatisticsENEx objgs_TotalDataStatisticsENT = new clsgs_TotalDataStatisticsENEx();
                clsgs_TotalDataStatisticsBL.gs_TotalDataStatisticsDA.CopyTo(objgs_TotalDataStatisticsENS, objgs_TotalDataStatisticsENT);
                return objgs_TotalDataStatisticsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsgs_TotalDataStatisticsENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_TotalDataStatisticsEN> arrObjLst = clsgs_TotalDataStatisticsBL.GetObjLst(strCondition);
            List<clsgs_TotalDataStatisticsENEx> arrObjExLst = new List<clsgs_TotalDataStatisticsENEx>();
            foreach (clsgs_TotalDataStatisticsEN objInFor in arrObjLst)
            {
                clsgs_TotalDataStatisticsENEx objgs_TotalDataStatisticsENEx = new clsgs_TotalDataStatisticsENEx();
                clsgs_TotalDataStatisticsBL.CopyTo(objInFor, objgs_TotalDataStatisticsENEx);
                arrObjExLst.Add(objgs_TotalDataStatisticsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_TotalDataStatisticsENEx GetObjExBymId(string strTotaoDataId)
        {
            clsgs_TotalDataStatisticsEN objgs_TotalDataStatisticsEN = clsgs_TotalDataStatisticsBL.GetObjByTotalDataId(strTotaoDataId);
            clsgs_TotalDataStatisticsENEx objgs_TotalDataStatisticsENEx = new clsgs_TotalDataStatisticsENEx();
            clsgs_TotalDataStatisticsBL.CopyTo(objgs_TotalDataStatisticsEN, objgs_TotalDataStatisticsENEx);
            return objgs_TotalDataStatisticsENEx;
        }

        #endregion

        #region  用户单个类型数据 添加删除；
        //IdCurrEduCls TotalDataTypeId 总数据类型Id 一TableKey 表主键 DataUser 数据用户 DataAddDate 数据添加日期  score 评分  TeaScore 教师评分
        //各个统计表类型的 添加 修改
        public static bool AddTotalStatisticsByTypeData(string strCurrEduclsId, string TotalDataTypeId, string TableKey, string DataUser, string DataAddDate, float fScore, float fTeaScore)
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


                bool boltal = AddAndUpdateTotalStatistics(strCurrEduclsId, TotalDataTypeId, TableKey, DataUser, DataAddDate, fScore, fTeaScore, strStartDate);
                if (boltal == true)
                {
                    bolResult = true;
                    WriteTextLog("AddAndUpdateTotalStatistics", "操作成功", "TotalDataLog");
                }
                else
                {
                    bolResult = false;
                    WriteTextLog("AddAndUpdateTotalStatistics", "操作失败", "TotalDataLog");
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
        //各种类型数据添加
        public static bool AddAndUpdateTotalStatistics(string strCurrEduclsId, string TotalDataTypeId, string TableKey, string DataUser, string DataAddDate, float fScore, float fTeaScore, string strStart)
        {
            bool bolresult = false;
            try
            {


                //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                string strwhereCond = "TotalDataTypeId='" + TotalDataTypeId + "' And TableKey='" + TableKey + "' And IdCurrEduCls='" + strCurrEduclsId + "'";
                clsgs_TotalDataStatisticsEN objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                if (objUpdTotalData == null)
                {
                    clsgs_TotalDataStatisticsEN objNewgs_TotalDataStatistics = new clsgs_TotalDataStatisticsEN();
                    //主键 类型+Tabkey  tabkey长度10，和8 所以需要转化
                    objNewgs_TotalDataStatistics.TotalDataId = GetTabKeyByTypeAndKey(TotalDataTypeId, TableKey);

                    objNewgs_TotalDataStatistics.IdCurrEduCls = strCurrEduclsId;
                    objNewgs_TotalDataStatistics.TotalDataTypeId = TotalDataTypeId;
                    //得到分数
                    objNewgs_TotalDataStatistics.Score = fScore;
                    objNewgs_TotalDataStatistics.TeaScore = fTeaScore;
                    objNewgs_TotalDataStatistics.TableKey = TableKey;
                    objNewgs_TotalDataStatistics.DataUser = DataUser;
                    objNewgs_TotalDataStatistics.DataAddDate = DataAddDate;
                    //根据时间得到 月 周、
                    objNewgs_TotalDataStatistics.Month = Convert.ToInt32(DataAddDate.Substring(5, 2));
                    int intWeek = GetWeekByDate(strStart, DataAddDate);
                    objNewgs_TotalDataStatistics.Week = intWeek;
                    objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(intWeek, strStart);

                    objNewgs_TotalDataStatistics.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewgs_TotalDataStatistics.UpdUser = DataUser;

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

                    bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, DataAddDate, DataUser, fScore, fTeaScore);
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
            catch (Exception objException)
            {
                string strMsg = string.Format("论文统计记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return bolresult;
        }


        //传入3个参数;主键Tablekey，字表类型TotalDataTypeId，页面操作类型PageTypeId(1,2,3,代表添加、修改、删除；)
        public static bool AddAndUpdateAndDeleteTotalStatis(string strTablekey, string strTotalDataTypeId, string PageTypeId, string strIdCurrEduCls)
        {
            bool bolResult = false;
            string strStartDate = string.Empty;//开始日期
            string strEndDate = string.Empty;//结束日期
            string strCurrEduclsId = string.Empty;//教学班；
            float fScore = 0;
            float fTeaScore = 0;
            string strCreateDate = string.Empty;
            string strUpdUser = string.Empty;
            try
            {
                #region 获取教学班数据
                //得到类型判断调用不同的类型表数据
                string strDataType = string.Empty;
                strDataType = strTotalDataTypeId;
                //获取教学班日期数据
                clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                if (objgs_TeachingDate != null)
                {
                    strStartDate = objgs_TeachingDate.StartDate;
                    strEndDate = objgs_TeachingDate.EndDate;
                }

                switch (strDataType)
                {
                    case "01":
                        //01  论文 Paper   PaperId
                        clsPaperEN objPaperEN = clsPaperBL.GetObjByPaperId(strTablekey);
                        if (objPaperEN != null)
                        {
                            strCurrEduclsId = strIdCurrEduCls;
                            fScore = objPaperEN.Score ?? 0;
                            fTeaScore = objPaperEN.TeaScore ?? 0;
                            strCreateDate = objPaperEN.CreateDate;
                            strUpdUser = objPaperEN.UpdUser;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
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
                            strCurrEduclsId = objPaperReadWriteEN.IdCurrEduCls;
                            fScore = 0;
                            fTeaScore = 0;
                            strCreateDate = objPaperReadWriteEN.CreateDate;
                            strUpdUser = objPaperReadWriteEN.UpdUser;
                            //获取教学班日期数据

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
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
                        if (string.IsNullOrEmpty(strTablekey) == false)
                        {
                            clsvPaperSubViewpointEN objPaperSubViewpointEN = clsvPaperSubViewpointBL.GetObjBySubViewpointId(long.Parse(strTablekey));
                            if (objPaperSubViewpointEN != null)
                            {
                                strCurrEduclsId = objPaperSubViewpointEN.IdCurrEduCls;
                                fScore = objPaperSubViewpointEN.Score ?? 0;
                                fTeaScore = objPaperSubViewpointEN.TeaScore ?? 0;
                                strCreateDate = objPaperSubViewpointEN.CreateDate;
                                strUpdUser = objPaperSubViewpointEN.UpdUser;

                                bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
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
                        }
                        break;
                    case "04":
                        ////04  个人观点 Viewpoint   ViewpointId
                        clsViewpointEN objViewpointEN = clsViewpointBL.GetObjByViewpointId(strTablekey);
                        if (objViewpointEN != null)
                        {
                            strCurrEduclsId = objViewpointEN.IdCurrEduCls;
                            fScore = objViewpointEN.Score ?? 0;
                            fTeaScore = objViewpointEN.TeaScore ?? 0;
                            strCreateDate = objViewpointEN.CreateDate;
                            strUpdUser = objViewpointEN.UpdUser;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
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
                            strCurrEduclsId = objExpertViewpointEN.IdCurrEduCls;
                            fScore = objExpertViewpointEN.Score ?? 0;
                            fTeaScore = objExpertViewpointEN.TeaScore ?? 0;
                            strCreateDate = objExpertViewpointEN.CreateDate;
                            strUpdUser = objExpertViewpointEN.UpdUser;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
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
                            strCurrEduclsId = objConceptEN.IdCurrEduCls;
                            fScore = objConceptEN.Score ?? 0;
                            fTeaScore = objConceptEN.TeaScore ?? 0;
                            strCreateDate = objConceptEN.CreateDate;
                            strUpdUser = objConceptEN.UpdUser;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
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
                            strCurrEduclsId = objTopicObjectiveEN.IdCurrEduCls;
                            fScore = objTopicObjectiveEN.Score ?? 0;
                            fTeaScore = objTopicObjectiveEN.TeaScore ?? 0;
                            strCreateDate = objTopicObjectiveEN.CreateDate;
                            strUpdUser = objTopicObjectiveEN.UpdUser;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
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
                            strCurrEduclsId = objTopicObjectiveBasisEN.IdCurrEduCls;
                            fScore = objTopicObjectiveBasisEN.Score ?? 0;
                            fTeaScore = objTopicObjectiveBasisEN.TeaScore ?? 0;
                            strCreateDate = objTopicObjectiveBasisEN.CreateDate;
                            strUpdUser = objTopicObjectiveBasisEN.UpdUser;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
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
                            strCurrEduclsId = objSysSkillEN.IdCurrEduCls;
                            fScore = objSysSkillEN.Score ?? 0;
                            fTeaScore = objSysSkillEN.TeaScore ?? 0;
                            strCreateDate = objSysSkillEN.CreateDate;
                            strUpdUser = objSysSkillEN.UpdUser;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
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
                            strCurrEduclsId = objSysSocialRelationsEN.IdCurrEduCls;
                            fScore = objSysSocialRelationsEN.Score ?? 0;
                            fTeaScore = objSysSocialRelationsEN.TeaScore ?? 0;
                            strCreateDate = objSysSocialRelationsEN.CreateDate;
                            strUpdUser = objSysSocialRelationsEN.UpdUser;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
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
                        //11 问题回答 qa_Answer  AnswerId
                        clsqa_AnswerEN objqa_AnswerEN = clsqa_AnswerBL.GetObjByAnswerId(strTablekey);
                        if (objqa_AnswerEN != null)
                        {
                            strCurrEduclsId = objqa_AnswerEN.IdCurrEduCls;
                            fScore = objqa_AnswerEN.Score ?? 0;
                            fTeaScore = objqa_AnswerEN.TeaScore ?? 0;
                            strCreateDate = objqa_AnswerEN.CreateDate;
                            strUpdUser = objqa_AnswerEN.UpdUser;

                            bool bolPaper = AddUpdDelTotalStatistics(strCurrEduclsId, strTotalDataTypeId, strTablekey, strUpdUser, strCreateDate, fScore, fTeaScore, strStartDate, PageTypeId);
                            if (bolPaper == true)
                            {
                                bolResult = true;
                                WriteTextLog("AddUpdDelTotalStatistics", "问题回答操作成功", "TotalDataLog");
                            }
                            else
                            {
                                bolResult = false;
                                WriteTextLog("AddUpdDelTotalStatistics", "问题回答操作失败", "TotalDataLog");
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

        //添加/修改、删除；数据总表
        public static bool AddUpdDelTotalStatistics(string strCurrEduclsId, string TotalDataTypeId, string TableKey, string DataUser, string DataAddDate, float fScore, float fTeaScore, string strStartDate, string strPageType)
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
                    objNewgs_TotalDataStatistics.TableKey = TableKey;
                    objNewgs_TotalDataStatistics.DataUser = DataUser;
                    objNewgs_TotalDataStatistics.DataAddDate = DataAddDate;
                    //根据时间得到 月 周、
                    objNewgs_TotalDataStatistics.Month = Convert.ToInt32(DataAddDate.Substring(5, 2));
                    if (string.IsNullOrEmpty(strStartDate) == false)
                    {
                        objNewgs_TotalDataStatistics.Week = GetWeekByDate(strStartDate, DataAddDate);
                        objNewgs_TotalDataStatistics.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStartDate, DataAddDate), strStartDate);
                    }
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
                    if (string.IsNullOrEmpty(strStartDate) == false)
                    {
                        //、修改
                        bool i = UpdDataTotalStatistics(objUpdTotalData, strStartDate, DataAddDate, DataUser, fScore, fTeaScore);
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
                }
                else
                {
                    if (objUpdTotalData == null)
                    {
                        strwhereCond = string.Format("TotalDataTypeId='{0}' And TableKey='{1}' And {2}='{3}'",
                            TotalDataTypeId, TableKey, congs_TotalDataStatistics.DataUser, DataUser);
                        objUpdTotalData = clsgs_TotalDataStatisticsBL.GetFirstObj_S(strwhereCond);
                    }
                    if (objUpdTotalData != null)
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
                    else
                    {
                        bolresult = true;
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




        #region  用于各个表数据换算 月 周 后存放统计表 根据教学班来查询 (参数： 教学班、编辑人)

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

        #region 根据传入的日期，需要增加的天数返回一个字符串
        /// <summary>
        /// 根据传入的日期，需要增加的天数返回一个字符串
        /// </summary>
        /// <param name="data"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReTime(string data, int str)
        {
            string strBeginDate = data.Substring(0, 10);
            DateTime dt = DateTime.Parse(strBeginDate);
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int n = DateTime.DaysInMonth(year, month);
            int k = day + str;
            if (k > n)
            {
                day = str - (n - day);
                month = month + 1;
                if (month > 12)
                {
                    month = 1;
                    year = year + 1;
                }
            }
            else
            {
                day = day + str;
            }
            string c = year + "-" + month + "-" + day;
            return c;
        }
        #endregion

        //根据得到的周 和教学班时间范围起始时间、可以得到当前周的范围时间
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

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    lblMsg.Text = ReTime("2020-03-02", 28);
        //    string strStart = lblMsg.Text;
        //    DateTime dt = DateTime.Parse(strStart);
        //    lblMsg.Text += dt.AddDays(-7).ToString("yyyy-MM-dd"); //当前时间减去7天
        //}

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
        public static string GetMonthDate(string NowDate)
        {
            string strCurrDate = NowDate.Substring(5, 2);//2020-08-01
            StringBuilder sbMsg = new StringBuilder();

            sbMsg.AppendFormat("当前月：{0}", strCurrDate);
            return sbMsg.ToString();
        }
        //根据传入的类型和主键判断数据；
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



        #region 各个表的数据处理 
        //统计表扩展函数，用于统计表数据的更新
        public static bool UpdDataTotalStatistics(clsgs_TotalDataStatisticsEN objUpdTotalData, string strStartDate, string strCreateDate, string strUpdUser, float strScore, float strTeaScore)
        {
            bool bolresult = false;
            objUpdTotalData.Week = GetWeekByDate(strStartDate, strCreateDate);
            objUpdTotalData.Score = strScore;
            objUpdTotalData.TeaScore = strTeaScore;
            objUpdTotalData.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            objUpdTotalData.UpdUser = strUpdUser;
            objUpdTotalData.WeekTimeRange = GetWeekTimeRange(GetWeekByDate(strStartDate, strCreateDate), strStartDate);
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

                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objPaperEN.CreateDate, strUpdUser, objPaperEN.Score ?? 0, objPaperEN.TeaScore ?? 0);
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
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objPaperReadWriteEN.CreateDate, strUpdUser, 0, 0);
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
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objPaperSubViewpointEN.CreateDate, strUpdUser, objPaperSubViewpointEN.Score ?? 0, objPaperSubViewpointEN.TeaScore ?? 0);
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
                    var arrSelDel = ArrListTotalData.Where(x => ArrKey.Contains(long.Parse(x.TableKey)) == false).ToList();
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
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objViewpointEN.CreateDate, strUpdUser, objViewpointEN.Score ?? 0, objViewpointEN.TeaScore ?? 0);
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
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objConceptEN.CreateDate, strUpdUser, objConceptEN.Score ?? 0, objConceptEN.TeaScore ?? 0);
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
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objTopicObjectiveEN.CreateDate, strUpdUser, objTopicObjectiveEN.Score ?? 0, objTopicObjectiveEN.TeaScore ?? 0);
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
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objSysSkillEN.CreateDate, strUpdUser, objSysSkillEN.Score ?? 0, objSysSkillEN.TeaScore ?? 0);
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
                            bool i = UpdDataTotalStatistics(objUpdTotalData, strStart, objSysSocialRelationsEN.CreateDate, strUpdUser, objSysSocialRelationsEN.Score ?? 0, objSysSocialRelationsEN.TeaScore ?? 0);
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


        #endregion



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
    }
}