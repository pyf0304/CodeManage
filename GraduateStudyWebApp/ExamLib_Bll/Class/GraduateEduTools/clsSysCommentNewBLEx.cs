using com.taishsoft.common;
using com.taishsoft.dynamiccompiler;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib.BusinessLogicExs
{
    public class clsSysCommentNewBLEx
    {
        private static string strMsg = "";
        /// <summary>
        /// 单例模式:访问数据访问层的单例模式
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
        /// </summary>
        private static clsSysCommentDA uniqueInstance = null;
        /// <summary>
        /// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
        /// </summary>
        public static clsSysCommentDA SysCommentDA
        {
            get
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new clsSysCommentDA();
                }
                return uniqueInstance;
            }
        }



        #region 一、添加评论 统计各个观点分 总分

        /// <summary>
        ///  添加评论数据、同时插入其他表数据 有则更新、无则插入；

        public static bool AddNewRecordEx(clsSysCommentEN objSysCommentEN)
        {
            #region 参数存放

            bool result = false;
            //存放类型id;
            string strCommentTypeId = string.Empty;
            //存放tablekey主键
            string strTableKeyId = string.Empty;
            //评分类型
            string strScoreTypeId = string.Empty;
            //用户当前编辑用户
            string strUserId = string.Empty;
            //父键
            string strParentId = string.Empty;
            //评论的分值；
            string strScore = string.Empty;
            //当前打分人的教学班；
            string strCurrEduId = string.Empty;

            //声明一个类型用户（各个观点、概念、客观数据 事实的用户）
            string strTypeUser = string.Empty;

            //数量统计；
            int allCount = 0;
            //总分统计
            float fScore = 0.00f;
            //学生平均分
            float fStuScore = 0.00f;
            //教师平均分
            float fTeaScore = 0.00f;

            #endregion



            try
            {
                #region 参数赋值
                //得到类型Id
                strCommentTypeId = objSysCommentEN.CommentTypeId;
                //得到主键tablekey
                strTableKeyId = objSysCommentEN.TableKey;
                strScoreTypeId = objSysCommentEN.ScoreType;
                strUserId = objSysCommentEN.UpdUser;//评论编辑人；
                strParentId = objSysCommentEN.ParentId;
                strScore = objSysCommentEN.Score.ToString();
                strCurrEduId = objSysCommentEN.IdCurrEduCls;//当前打分人教学班；
                #endregion

                //bool bolResult = objSysCommentEN.AddNewRecordWithMaxId();
                //string strCommentId = objSysCommentEN.AddNewRecordWithMaxId();



                #region 获取评论中的统计数据；
                //1先获取评论中的统计数据；
                DataTable objDt = clsSysCommentBLEx.GetSysCommentNumDataTable(strCommentTypeId, strTableKeyId);
                if (objDt.Rows.Count > 0)
                {
                    foreach (DataRow row in objDt.Rows)
                    {
                        allCount = int.Parse(row["Pacount"].ToString());
                        fScore = float.Parse(row["PScore"].ToString());
                        if (row["StuScore"] == DBNull.Value)
                        {
                            fStuScore = 0;
                        }
                        else
                        {
                            fStuScore = float.Parse(row["StuScore"].ToString());
                        }
                        if (row["TeaScore"] == DBNull.Value)
                        {
                            fTeaScore = 0;
                        }
                        else
                        {

                            fTeaScore = float.Parse(row["TeaScore"].ToString());
                        }

                    }
                    string msgpaper = string.Format("获取SysComment综合评论数据成功");

                }
                else
                {
                    string msgpaper = string.Format("未能获取获取SysComment综合评论数据或统计为0");

                }

                #endregion

                #region 封装字段到对象
                clsSysCountENEx objcountEnEx = new clsSysCountENEx();
                objcountEnEx.CountType = strCommentTypeId;//评分统计类型Id
                objcountEnEx.Pacount = allCount;//评论数
                objcountEnEx.FScore = fScore; //统计分
                objcountEnEx.FStuScore = fStuScore; //学生统计分
                objcountEnEx.FTeaScore = fTeaScore;//教师统计分
                objcountEnEx.UserId = strUserId;//用户
                objcountEnEx.Tablekey = strTableKeyId;//主键
                objcountEnEx.ParrentId = strParentId;//存放主题；


                #endregion

                //通过类型判断调用不同的表数据；
                switch (strCommentTypeId)
                {
                    case "01":

                        //论文
                        clsPaperEN objPaper = clsPaperBL.GetObjByPaperId(strTableKeyId);

                        objPaper.AppraiseCount = allCount;//评论数
                        objPaper.Score = fScore;//总评分
                        objPaper.StuScore = fStuScore;//学生评分
                        objPaper.TeaScore = fTeaScore;//教师评分

                        strTypeUser = objPaper.UpdUser;
                        //调用论文修改；
                        bool pi = UpdateRecordPaper(objPaper);
                        if (pi == true)
                        {
                            bool Si = GetSysCountData(objcountEnEx);
                            if (Si == true)
                            {
                                string msgpaper = string.Format("Paper表数据更新完成");
                                result = true;

                            }
                            else
                            {
                                string msgpaper = string.Format("Paper表数据更新失败");
                                result = false;
                            }

                        }
                        else
                        {
                            string msgpaper = string.Format("Paper表数据更新失败");
                            result = false;
                        }

                        break;
                    case "02":

                        //论文子观点
                        clsPaperSubViewpointEN objsubviewpoint = clsPaperSubViewpointBL.GetObjBySubViewpointId(long.Parse( strTableKeyId));

                        objsubviewpoint.AppraiseCount = allCount;
                        objsubviewpoint.Score = fScore;//总评分
                        objsubviewpoint.StuScore = fStuScore;//学生评分
                        objsubviewpoint.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objsubviewpoint.UpdUser;

                        //调用论文修改；
                        bool psubi = UpdateRecordPapersubviewpoint(objsubviewpoint);
                        if (psubi == true)
                        {
                            //调用数据统计
                            bool psi = GetSysCountData(objcountEnEx);
                            if (psi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0001";//论文子观点 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0031";//论文子观点 学生分数类型
                                }
                                //判断传入的parendId 是否是root 如果是root 则是针对观点的评价、否则就是针对他人评价的评价；
                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("论文子观点表数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据更新失败");
                                            result = false;
                                        }
                                    }

                                }

                                //  }

                            }
                            else
                            {
                                string msgpaper = string.Format("论文统计数据失败");
                                result = false;
                            }


                        }
                        else
                        {
                            string msgpaper = string.Format("论文子观点表数据更新失败");
                            result = false;
                        }

                        break;
                    case "03":
                        //个人观点
                        clsViewpointEN objviewpoint = clsViewpointBL.GetObjByViewpointId(strTableKeyId);
                        objviewpoint.AppraiseCount = allCount;
                        objviewpoint.Score = fScore;//总评分
                        objviewpoint.StuScore = fStuScore;//学生评分
                        objviewpoint.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objviewpoint.UpdUser;

                        //调用论文修改；
                        bool vi = UpdateRecordViewpoint(objviewpoint);
                        if (vi == true)
                        {
                            bool vsi = GetSysCountData(objcountEnEx);
                            if (vsi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0002";//个人观点 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0032";//个人观点 学生分数类型
                                }

                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("个人观点表数据更新完成，统计数据完成");
                                        result = true;

                                    }
                                    else
                                    {
                                        string msg = string.Format("个人观点统计数据失败");
                                        result = false;

                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据更新失败");
                                            result = false;
                                        }
                                    }

                                }
                                //  }
                            }




                        }
                        else
                        {
                            string msgpaper = string.Format("个人观点表数据更新失败");
                            result = false;
                        }

                        break;
                    case "04":
                        //专家观点
                        clsViewpointEN objExpertviewpoint = clsViewpointBL.GetObjByViewpointId(strTableKeyId);
                        objExpertviewpoint.AppraiseCount = allCount;
                        objExpertviewpoint.Score = fScore;//总评分
                        objExpertviewpoint.StuScore = fStuScore;//学生评分
                        objExpertviewpoint.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objExpertviewpoint.UpdUser;

                        //调用论文修改；
                        bool evi = UpdateRecordViewpoint(objExpertviewpoint);
                        if (evi == true)
                        {
                            bool evsi = GetSysCountData(objcountEnEx);
                            if (evsi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0003";//专家观点 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0033";//专家观点 学生分数类型
                                }

                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("专家观点表数据更新完成，统计数据完成,评分统计完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("专家观点评分统计数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据更新失败");
                                            result = false;
                                        }
                                    }

                                }
                                // }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("专家观点表数据更新失败");
                            result = false;
                        }

                        break;
                    case "05":
                        //概念
                        clsConceptEN objconcept = clsConceptBL.GetObjByConceptId(strTableKeyId);

                        objconcept.AppraiseCount = allCount;
                        objconcept.Score = fScore;//总评分
                        objconcept.StuScore = fStuScore;//学生评分
                        objconcept.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objconcept.UpdUser;

                        //调用论文修改；
                        bool ci = UpdateRecordConcept(objconcept);
                        if (ci == true)
                        {
                            bool csi = GetSysCountData(objcountEnEx);
                            if (csi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0004";//概念观点 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0034";//概念观点 学生分数类型
                                }

                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； ---参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("概念表数据更新完成，概念统计数据完成,概念评分统计完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("概念评分统计数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("概念更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("概念更新失败");
                                            result = false;
                                        }
                                    }

                                }
                                //  }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("概念表数据更新失败");
                            result = false;
                        }

                        break;
                    case "06":
                        //客观事实
                        clsTopicObjectiveEN objective = clsTopicObjectiveBL.GetObjByTopicObjectiveId(strTableKeyId);

                        objective.AppraiseCount = allCount;
                        objective.Score = fScore;//总评分
                        objective.StuScore = fStuScore;//学生评分
                        objective.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objective.UpdUser;

                        //调用论文修改；
                        bool oi = UpdateRecordTopicObjective(objective);
                        if (oi == true)
                        {
                            bool soi = GetSysCountData(objcountEnEx);
                            if (soi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0005";//客观事实 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0035";//客观事实 学生分数类型
                                }
                                if (strParentId == "root")
                                {

                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("客观事实表数据更新完成，客观事实统计数据完成,客观事实评分统计完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("客观事实评分统计数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("客观事实数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("客观事实更新失败");
                                            result = false;
                                        }
                                    }

                                }

                                //  }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("客观事实更新失败");
                            result = false;
                        }

                        break;
                    case "07":
                        //客观数据
                        clsTopicObjectiveEN objectiveBasis = clsTopicObjectiveBL.GetObjByTopicObjectiveId(strTableKeyId);

                        objectiveBasis.AppraiseCount = allCount;
                        objectiveBasis.Score = fScore;//总评分
                        objectiveBasis.StuScore = fStuScore;//学生评分
                        objectiveBasis.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objectiveBasis.UpdUser;

                        //调用论文修改；
                        bool obi = UpdateRecordTopicObjective(objectiveBasis);
                        if (obi == true)
                        {
                            bool bobi = GetSysCountData(objcountEnEx);
                            if (bobi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0006";//客观数据 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0036";//客观数据 学生分数类型
                                }

                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("客观数据更新完成，客观数据统计数据完成,客观数据评分统计完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("客观数据评分统计数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("客观数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("客观数据更新失败");
                                            result = false;
                                        }
                                    }

                                }

                                // }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("客观数据更新失败");
                            result = false;
                        }
                        break;
                    case "08":
                        //人员评分
                        //必须是教师评分才统计
                        if (strScoreTypeId == "2")
                        {
                            //这里strTableKeyId 存放的主键就是用户Id 所以直接赋值给类型用户；
                            strTypeUser = strTableKeyId;
                            //添加各个观点、概念 换算后的数据插入或修改； ---参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                            bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0008", strCommentTypeId, strCurrEduId, strUserId);

                            if (blpsi == true)
                            {
                                string msg = string.Format("客观数据更新完成，客观数据统计数据完成,客观数据评分统计完成");
                                result = true;
                            }
                            else
                            {
                                string msg = string.Format("客观数据评分统计数据失败");
                                result = false;
                            }
                        }

                        break;
                    case "09":
                        //技能
                        clsSysSkillEN objSysSkill = clsSysSkillBL.GetObjBySkillId(strTableKeyId);

                        objSysSkill.AppraiseCount = allCount;
                        objSysSkill.Score = fScore;//总评分
                        objSysSkill.StuScore = fStuScore;//学生评分
                        objSysSkill.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objSysSkill.UpdUser;

                        //调用论文修改；
                        bool obiskill = UpdateRecordSysSkill(objSysSkill);
                        if (obiskill == true)
                        {
                            bool bobi = GetSysCountData(objcountEnEx);
                            if (bobi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0021";//技能 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0037";//技能 学生分数类型
                                }

                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("技能更新完成，技能统计数据完成,技能评分统计完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("技能评分统计数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("技能更新完成，技能完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("技能更新失败");
                                            result = false;
                                        }
                                    }

                                }

                                // }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("技能更新失败");
                            result = false;
                        }
                        break;
                    case "10":
                        //社会关系
                        clsSysSocialRelationsEN objSysSocialRelations = clsSysSocialRelationsBL.GetObjBySocialId(strTableKeyId);

                        objSysSocialRelations.AppraiseCount = allCount;
                        objSysSocialRelations.Score = fScore;//总评分
                        objSysSocialRelations.StuScore = fStuScore;//学生评分
                        objSysSocialRelations.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objSysSocialRelations.UpdUser;

                        //调用论文修改；
                        bool obiSocial = UpdateRecordSysSocialRelations(objSysSocialRelations);
                        if (obiSocial == true)
                        {
                            bool bobi = GetSysCountData(objcountEnEx);
                            if (bobi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0023";//社会关系 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0038";//社会关系 学生分数类型
                                }

                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("社会关系更新完成，技能统计数据完成,技能评分统计完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("社会关系评分统计数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("社会关系更新完成，技能完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("社会关系更新失败");
                                            result = false;
                                        }
                                    }

                                }

                                // }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("社会关系更新失败");
                            result = false;
                        }
                        break;
                    case "11":
                        //教师问题回答
                        clsqa_AnswerEN objqa_Answer = clsqa_AnswerBL.GetObjByAnswerId(strTableKeyId);

                        objqa_Answer.AppraiseCount = allCount;
                        objqa_Answer.Score = fScore;//总评分
                        objqa_Answer.StuScore = fStuScore;//学生评分
                        objqa_Answer.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objqa_Answer.UpdUser;

                        //调用论文修改；
                        bool obiqa_Answer = UpdateRecordqa_Answer(objqa_Answer);
                        if (obiqa_Answer == true)
                        {
                            bool bobi = GetSysCountData(objcountEnEx);
                            if (bobi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0025";//教师问题回答 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0039";//教师问题回答 学生分数类型
                                }

                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("教师问题回答更新完成，技能统计数据完成,技能评分统计完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("教师问题回答评分统计数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("教师问题回答更新完成，技能完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("教师问题回答更新失败");
                                            result = false;
                                        }
                                    }

                                }

                                // }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("教师问题回答更新失败");
                            result = false;
                        }
                        break;
                    case "12":
                        //论文汇报
                        clsgs_PaperReportEN objgs_PaperReport = clsgs_PaperReportBL.GetObjByReportId(strTableKeyId);

                        objgs_PaperReport.AppraiseCount = allCount;
                        objgs_PaperReport.Score = fScore;//总评分
                        objgs_PaperReport.StuScore = fStuScore;//学生评分
                        objgs_PaperReport.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objgs_PaperReport.UpdUser;

                        //调用论文修改；
                        bool obigs_PaperReport = UpdateRecordgs_PaperReport(objgs_PaperReport);
                        if (obigs_PaperReport == true)
                        {
                            bool bobi = GetSysCountData(objcountEnEx);
                            if (bobi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0043";//教师问题回答 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0044";//教师问题回答 学生分数类型
                                }

                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("论文汇报更新完成，论文汇报统计数据完成,论文汇报评分统计完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("论文汇报评分统计数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("论文汇报回答更新完成，技能完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文汇报回答更新失败");
                                            result = false;
                                        }
                                    }

                                }

                                // }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("论文汇报回答更新失败");
                            result = false;
                        }
                        break;
                    case enumSysCommentType.gs_ResearchResult_13:
                        //研究成果
                        clsgs_ResearchResultEN objgs_ResearchResult = clsgs_ResearchResultBL.GetObjByResultId(strTableKeyId);

                        objgs_ResearchResult.AppraiseCount = allCount;
                        objgs_ResearchResult.Score = fScore;//总评分
                        objgs_ResearchResult.StuScore = fStuScore;//学生评分
                        objgs_ResearchResult.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objgs_ResearchResult.UpdUser;

                        //调用论文修改；
                        bool obigs_ResearchResult = UpdateRecordgs_ResearchResult(objgs_ResearchResult);
                        if (obigs_ResearchResult == true)
                        {
                            bool bobi = GetSysCountData(objcountEnEx);
                            if (bobi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0046";//教师问题回答 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0047";//教师问题回答 学生分数类型
                                }

                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("研究成果更新完成，研究成果统计数据完成,研究成果评分统计完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("研究成果评分统计数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("研究成果回答更新完成，技能完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("研究成果回答更新失败");
                                            result = false;
                                        }
                                    }

                                }

                                // }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("研究成果回答更新失败");
                            result = false;
                        }
                        break;
                    case enumSysCommentType.RTUserRela_14:
                        //研究成果
                        clsRTUserRelaEN objRTUserRela = clsRTUserRelaBL.GetObjBymId(long.Parse( strTableKeyId));

                        objRTUserRela.AppraiseCount = allCount;
                        objRTUserRela.Score = fScore;//总评分
                        objRTUserRela.StuScore = fStuScore;//学生评分
                        objRTUserRela.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objRTUserRela.UpdUser;

                        //调用论文修改；
                        bool obiRTUserRela = UpdateRecordRTUserRela(objRTUserRela);
                        if (obiRTUserRela == true)
                        {
                            bool bobi = GetSysCountData(objcountEnEx);
                            if (bobi == true)
                            {
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                //教师评分
                                if (strScoreTypeId == "2")
                                {
                                    strSTypeId = "0046";//教师问题回答 分数类型
                                }
                                else
                                {
                                    strSTypeId = "0047";//教师问题回答 学生分数类型
                                }

                                if (strParentId == "root")
                                {
                                    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                    if (blpsi == true)
                                    {
                                        string msg = string.Format("主题用户更新完成，主题用户统计数据完成,主题用户评分统计完成");
                                        result = true;
                                    }
                                    else
                                    {
                                        string msg = string.Format("主题用户评分统计数据失败");
                                        result = false;
                                    }
                                }
                                else
                                {
                                    //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                    clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                    if (objSysment != null)
                                    {
                                        strTypeUser = objSysment.UpdUser;

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("主题用户回答更新完成，技能完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("主题用户回答更新失败");
                                            result = false;
                                        }
                                    }

                                }

                                // }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("研究成果回答更新失败");
                            result = false;
                        }
                        break;

                    default:
                        string strMsg = string.Format("类型数据:[{0}]在switch中没有处理！(in {1})", strCommentTypeId, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);

                }


            }
            catch (Exception objException)
            {
                string strMsg = string.Format("核算评分记录出错, {1}.(from {0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                result = false;
                throw new Exception(strMsg);

            }
            return result;
        }

        #region 《一》所需的交互函数
        //各类型观点，人员分数；----------------  通过得到的类型用户查询 分数统计表数据；同时还需要查询权重表数据比例；
        //2者数据相乘得到结果 存在则 原数据+传入数据；没有则添加 ，strViewpointRations(各个观点占比的权重)
        public static bool AddorUpdateSysScoreSummaryByWhere(string strTypeUserId, string strScore, string strScoreType, string strCommentTypeId, string strCurrEduId, string strUserId)
        {
            bool result = false;
            float fScore = 0;//用来存放分值，传递给占比分统计方法 统计 分数占比；
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                //通过用户Id 和评分类型查询得到实体，如果有则修改、 没有则插入；
                clsSysScoreSummaryEN objSysScoreSummary = clsSysScoreSummaryBL.GetFirstObj_S("UserId= '" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId='" + strScoreType + "'");
                if (objSysScoreSummary != null)
                {

                    //0008是人员分，所以不能累计；除开人员 其他都可以累计积分；
                    if (strScoreType == "0008")
                    {
                        objSysScoreSummary.Score = float.Parse(strScore);
                    }
                    else
                    {
                        objSysScoreSummary.Score += float.Parse(strScore);
                    }
                    fScore = objSysScoreSummary.Score ?? 0;
                    objSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    #region 修改方法
                    bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objSysScoreSummary);
                    if (bolResult == true)
                    {
                        //修改各个观点、概念分数后，需要计算各观点分数
                        //bool i = AddviewpointWeightScore(strTypeUserId, strCurrEduId, strScoreType, strCommentTypeId, strUserId, fScore);
                        //这个地方判断评论类型、 调用统计各个观点的总分方法；
                        if (strCommentTypeId == "08")
                        {
                            //代表用户，不用统计总分；
                        }
                        else
                        {
                            //计算各观点总分；
                            bool i = AddViewpointTotal(strTypeUserId, strCurrEduId, strUserId);
                            if (i == true)
                            {
                                //bool iTotal = AddViewpointTotal(strTypeUserId, strCurrEduId, strUserId);
                                //if (iTotal == true)
                                //{
                                //再次调用学生打分 总计；
                                AddStuScoreTotal(strTypeUserId, strCurrEduId, strUserId);
                                //}
                                string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                                result = true;
                            }
                            else
                            {
                                string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                                result = false;
                            }

                        }

                    }
                    else
                    {
                        string strMsg = string.Format("SysScoreSummary统计分数修改数据失败");

                        result = false;
                    }
                    #endregion
                }
                else
                {

                    //添加；
                    clsSysScoreSummaryEN objNewSysScoreSummary = new clsSysScoreSummaryEN();

                    //SchoolYear 学年
                    objNewSysScoreSummary.SchoolYear = GetSchoolYearbyNow();
                    objNewSysScoreSummary.UserId = strTypeUserId;
                    objNewSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewSysScoreSummary.UpdUser = strUserId;
                    objNewSysScoreSummary.Score = float.Parse(strScore);//分数；
                    objNewSysScoreSummary.ScoreTypeId = strScoreType;//类型
                    objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;

                    //用户传值用；
                    fScore = objNewSysScoreSummary.Score ?? 0;


                    #region 添加方法
                    //添加方法
                    bool i = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);
                    if (i == true)
                    {
                        //修改各个观点、概念分数后，需要计算占比分数
                        // AddviewpointWeightScore(strTypeUserId, strCurrEduId, strScoreType, strCommentTypeId, strUserId, fScore);
                        //这个地方判断评论类型、 调用统计各个观点的总分方法；
                        if (strCommentTypeId == "08")
                        {
                            //代表用户，不用统计总分；
                        }
                        else
                        {
                            bool iTotal = AddViewpointTotal(strTypeUserId, strCurrEduId, strUserId);
                            if (iTotal == true)
                            {
                                //再次调用学生打分 总计；
                                AddStuScoreTotal(strTypeUserId, strCurrEduId, strUserId);
                            }
                            string msgpaper = string.Format("各观点统计数据添加成功");

                            result = true;
                        }

                    }
                    else
                    {
                        string msgpaper = string.Format("各观点统计数据添加失败");

                        result = false;
                    }
                    #endregion

                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                result = false;

            }
            return result;

        }

        //通过 表主键和类型 去查询评论统计表、如果存在此数据，则更新、否则就数据插入；传入其他参数用于数据的 修改 或添加；
        public static bool GetSysCountData(clsSysCountENEx objcountEnEx)
        {
            bool result = false;
            string strcounttypeId = objcountEnEx.CountType;
            string strtablekeyId = objcountEnEx.Tablekey;
            try
            {
                string strWhereCond = " 1=1 and CountTypeId='" + strcounttypeId + "' and TableKey='" + strtablekeyId + "'";
                //1.先通条件去查询得到数据
                clsSysCountEN objSysCountEN = clsSysCountBL.GetFirstObj_S(strWhereCond);
                if (objSysCountEN != null)
                {
                    //数据修改
                    objSysCountEN.CommentCount = objcountEnEx.Pacount;
                    objSysCountEN.Score = objcountEnEx.FScore;
                    objSysCountEN.StuScore = objcountEnEx.FStuScore;
                    objSysCountEN.TeaScore = objcountEnEx.FTeaScore;

                    bool bolResult = clsSysCountBL.UpdateBySql2(objSysCountEN);
                    if (bolResult == true)
                    {
                        string strMsg = string.Format("Syscount统计表修改数据成功");

                        result = true;
                    }
                    else
                    {
                        string strMsg = string.Format("Syscount统计表修改数据失败");

                        result = false;
                    }

                }
                else
                {
                    //数据添加
                    clsSysCountEN objNewSysCountEN = new clsSysCountEN();
                    objNewSysCountEN.CountTypeId = objcountEnEx.CountType;//评分统计类型Id
                    objNewSysCountEN.CommentCount = objcountEnEx.Pacount;//评论数
                    objNewSysCountEN.Score = objcountEnEx.FScore; //统计分
                    objNewSysCountEN.StuScore = objcountEnEx.FStuScore; //学生统计分
                    objNewSysCountEN.TeaScore = objcountEnEx.FTeaScore;//教师统计分
                    objNewSysCountEN.UpdUser = objcountEnEx.UserId;//用户
                    objNewSysCountEN.TableKey = objcountEnEx.Tablekey;//主键
                    objNewSysCountEN.ParentId = objcountEnEx.ParrentId;//存放主题；论文主键等；
                    objNewSysCountEN.UpdDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                    var bolResult = objNewSysCountEN.AddNewRecordWithMaxId();
                    if (bolResult != "")
                    {
                        string strMsg = string.Format("Syscount统计表添加数据成功");

                        result = true;
                    }
                    else
                    {
                        string strMsg = string.Format("Syscount统计表添加数据失败");

                        result = false;
                    }
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                result = false;

            }
            return result;
        }


        //各个观点总分 --------通过用户查询各个观点、概念 客观的数据相加得到总分数；
        public static bool AddViewpointTotal(string strTypeUserId, string strCurrEduId, string strUserId)
        {
            #region 参数
            bool result = false;
            float ViewpointScore = 0;//个观点分数总计；
            #endregion

            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {

                //查询用户各个类型的分数；
                List<clsSysScoreSummaryEN> objList = clsSysScoreSummaryBL.GetObjLst("UserId= '" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId in('0001','0002','0003','0004','0005','0006','0007','0021','0023','0025','0041','0042')");

                foreach (clsSysScoreSummaryEN objSysScore in objList)
                {
                    ViewpointScore += objSysScore.Score ?? 0;
                }


                //首先要查询当前用户 和 个观点统计总分是否存在，存在则修改、不存在则插入；0009代表个观点 总分
                clsSysScoreSummaryEN objSysScoreSummary = clsSysScoreSummaryBL.GetFirstObj_S("UserId= '" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId='0009'");
                if (objSysScoreSummary != null)
                {
                    #region 修改
                    objSysScoreSummary.Score = ViewpointScore;
                    objSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                    bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objSysScoreSummary);
                    if (bolResult == true)
                    {
                        //调用统计各个观点的总分 占比分方法
                        result = true;
                    }
                    else
                    {
                        string strMsg = string.Format("AddViewpointTotal统计分数修改数据失败");

                        result = false;
                    }
                    #endregion

                }
                else
                {
                    //添加；
                    clsSysScoreSummaryEN objNewSysScoreSummary = new clsSysScoreSummaryEN();
                    //SchoolYear 学年
                    objNewSysScoreSummary.SchoolYear = GetSchoolYearbyNow();
                    objNewSysScoreSummary.UserId = strTypeUserId;
                    objNewSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewSysScoreSummary.UpdUser = strUserId;
                    objNewSysScoreSummary.Score = ViewpointScore;
                    objNewSysScoreSummary.ScoreTypeId = "0009";//各个观点总计分；
                    objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;//教学班Id；

                    //添加方法
                    bool boolresult = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);

                    if (boolresult == true)
                    {
                        result = true;
                    }
                    else
                    {

                        string msgpaper = string.Format("统计各观点合计分，总分失败");


                        result = false;
                    }
                }


            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                result = false;

            }
            return result;
        }

        //各学生打分总分 ------------- 通过各个观点、概念技能、等等 得到学生总分、类型0040 （学生总分；）
        public static bool AddStuScoreTotal(string strTypeUserId, string strCurrEduId, string strUserId)
        {
            #region 参数
            bool result = false;
            float ViewpointScore = 0;//个观点分数总计；
            #endregion

            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {

                //查询用户各个类型的分数；
                List<clsSysScoreSummaryEN> objList = clsSysScoreSummaryBL.GetObjLst("UserId= '" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId in('0031','0032','0033','0034','0035','0036','0037','0038','0039')");

                foreach (clsSysScoreSummaryEN objSysScore in objList)
                {
                    ViewpointScore += objSysScore.Score ?? 0;
                }


                //首先要查询当前用户 和 个观点统计总分是否存在，存在则修改、不存在则插入；0009代表个观点 总分
                clsSysScoreSummaryEN objSysScoreSummary = clsSysScoreSummaryBL.GetFirstObj_S("UserId= '" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId='0040'");
                if (objSysScoreSummary != null)
                {
                    #region 修改
                    objSysScoreSummary.Score = ViewpointScore;
                    objSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                    bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objSysScoreSummary);
                    if (bolResult == true)
                    {
                        //调用统计各个观点的总分 占比分方法
                        result = true;
                    }
                    else
                    {
                        string strMsg = string.Format("AddViewpointTotal统计分数修改数据失败");

                        result = false;
                    }
                    #endregion

                }
                else
                {
                    //添加；
                    clsSysScoreSummaryEN objNewSysScoreSummary = new clsSysScoreSummaryEN();
                    //SchoolYear 学年
                    objNewSysScoreSummary.SchoolYear = GetSchoolYearbyNow();
                    objNewSysScoreSummary.UserId = strTypeUserId;
                    objNewSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewSysScoreSummary.UpdUser = strUserId;
                    objNewSysScoreSummary.Score = ViewpointScore;
                    objNewSysScoreSummary.ScoreTypeId = "0040";//各个观点总计分；
                    objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;//教学班Id；

                    //添加方法
                    bool boolresult = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);

                    if (boolresult == true)
                    {
                        result = true;
                    }
                    else
                    {

                        string msgpaper = string.Format("统计各观点合计分，总分失败");


                        result = false;
                    }
                }


            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                result = false;

            }
            return result;
        }

        #endregion


        #region  《一》一 所需相关转换函数；
        //学年换算
        public static string GetSchoolYearbyNow()
        {
            string strSchoolYear = string.Empty;
            int strMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));
            if (strMonth > 1 && strMonth < 9)
            {
                strSchoolYear = DateTime.Now.ToString("yyyy");
            }
            else
            {
                strSchoolYear = DateTime.Now.ToString("yyyy");
                strSchoolYear = (Convert.ToInt32(strSchoolYear) + 1).ToString();
            }

            return strSchoolYear;
        }




        #endregion

        #region 根据《一》 几个表的数据修改
        //论文

        public static bool UpdateRecordPaper(clsPaperEN objPaperEN)
        {
            bool bolResult;
            try
            {

                bolResult = clsPaperBL.UpdateBySql2(objPaperEN);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                return false;
            }
        }

        /// <summary>
        /// 论文子观点

        public static bool UpdateRecordPapersubviewpoint(clsPaperSubViewpointEN objPaperSubViewpointEN)
        {
            bool bolResult;
            try
            {

                bolResult = clsPaperSubViewpointBL.UpdateBySql2(objPaperSubViewpointEN);

                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                return false;
            }
        }

        /// <summary>
        ///观点、个人、专家

        public static bool UpdateRecordViewpoint(clsViewpointEN objViewpointEN)
        {
            bool bolResult;
            try
            {

                bolResult = clsViewpointBL.UpdateBySql2(objViewpointEN);

                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                return false;
            }
        }

        /// <summary>
        /// 概念

        public static bool UpdateRecordConcept(clsConceptEN objConceptEN)
        {
            bool bolResult;
            try
            {

                bolResult = clsConceptBL.UpdateBySql2(objConceptEN);

                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());


                return false;
            }
        }

        /// <summary>
        ///客观 、事实、数据；

        public static bool UpdateRecordTopicObjective(clsTopicObjectiveEN objTopicObjectiveEN)
        {
            bool bolResult;
            try
            {

                bolResult = clsTopicObjectiveBL.UpdateBySql2(objTopicObjectiveEN);

                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());


                return false;
            }
        }


        /// <summary>
        /// 技能

        public static bool UpdateRecordSysSkill(clsSysSkillEN objSysSkillEN)
        {
            bool bolResult;
            try
            {

                bolResult = clsSysSkillBL.UpdateBySql2(objSysSkillEN);

                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());


                return false;
            }
        }

        /// <summary>
        ///社会关系

        public static bool UpdateRecordSysSocialRelations(clsSysSocialRelationsEN objSysSocialRelations)
        {
            bool bolResult;
            try
            {

                bolResult = clsSysSocialRelationsBL.UpdateBySql2(objSysSocialRelations);

                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());


                return false;
            }
        }
        /// <summary>
        ///教师问题回答

        public static bool UpdateRecordqa_Answer(clsqa_AnswerEN objqa_Answer)
        {
            bool bolResult;
            try
            {

                bolResult = clsqa_AnswerBL.UpdateBySql2(objqa_Answer);

                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());


                return false;
            }
        }

        /// <summary>
        ///论文汇报

        public static bool UpdateRecordgs_PaperReport(clsgs_PaperReportEN objgs_PaperReport)
        {
            bool bolResult;
            try
            {

                bolResult = clsgs_PaperReportBL.UpdateBySql2(objgs_PaperReport);

                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());


                return false;
            }
        }


        /// <summary>
        ///研究成果

        public static bool UpdateRecordgs_ResearchResult(clsgs_ResearchResultEN objgs_ResearchResult)
        {
            bool bolResult;
            try
            {

                bolResult = clsgs_ResearchResultBL.UpdateBySql2(objgs_ResearchResult);

                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());


                return false;
            }
        }

        public static bool UpdateRecordRTUserRela(clsRTUserRelaEN objRTUserRela)
        {
            bool bolResult;
            try
            {

                bolResult = clsRTUserRelaBL.UpdateBySql2(objRTUserRela);

                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());


                return false;
            }
        }


        #endregion

        #endregion







        //#region  二、用于总分核算的方法 UpdUser用于记录当前是谁在核算操作；
        //public static bool GetTotalRevalidation(string UpdUser)
        //{
        //    bool bolResult = false;
        //    string stridCurrEduCls = string.Empty;
        //    string strScoreType = string.Empty;
        //    int yNumber = 0;
        //    try
        //    {


        //        #region 获取教学班数据
        //        //1.获取评分教学班数据
        //        DataTable objDt = clsSysCommentBLEx.GetSysScoreSummaryCurrEduCls();
        //        if (objDt.Rows.Count > 0)
        //        {
        //            foreach (DataRow row in objDt.Rows)
        //            {
        //                stridCurrEduCls = row["IdCurrEduCls"].ToString();

        //                //#region 获取当前教学班下 分数最高的用户，得到百分比值
        //                ////1，首先需要通过总分类型来排序；得到百分比后的分值；
        //                ////通过观点0009查询（各观点总分）， 根据分数排序；得到最高分
        //                //clsSysScoreSummaryEN objSysScoreSummaryOrderby = clsSysScoreSummaryBL.GetFirstObj_S(" 1=1 And ScoreTypeId='0009' And IdCurrEduCls='" + stridCurrEduCls + "' order by score desc");
        //                ////取出排序最高的各个观点统计分数，然后换算；
        //                //float HighScore = objSysScoreSummaryOrderby.Score;
        //                ////除以100；按百分比 换算
        //                //float resultNum = HighScore / 100;
        //                //#endregion


        //                #region 根据条件获取用户数据，进行分数换算
        //                //2.获取当前每个用户的数据总分 然后再通过最高分计算总分占比
        //                //2.1 条件，根据ScoreTypeId 和教学班 获取每个用户总分，通过分数排序；
        //                string strWhere = "ScoreTypeId='0009' And IdCurrEduCls='" + stridCurrEduCls + "' order by score desc";
        //                //2.2得到数据源
        //                List<clsSysScoreSummaryEN> ArrList = clsSysScoreSummaryBL.GetObjLst(strWhere);

        //                if (ArrList.Count > 0)
        //                {
        //                    //2.3循环数据对象
        //                    foreach (clsSysScoreSummaryEN objSysScoreSummaryEN in ArrList)
        //                    {
        //                        yNumber++;
        //                        //2.4得到用户分数 和教学班Id .用户Id；评分类型；
        //                        float fScore = 0;
        //                        string strUserId = string.Empty;


        //                        //stridCurrEduCls = objSysScoreSummaryEN.IdCurrEduCls;
        //                        fScore = objSysScoreSummaryEN.Score;
        //                        strScoreType = objSysScoreSummaryEN.ScoreTypeId;
        //                        strUserId = objSysScoreSummaryEN.UserId;

        //                        string strall = yNumber + "/" + strUserId + "/" + stridCurrEduCls + "/" + UpdUser + "/" + fScore;
        //                        WriteTextLog("101.251.68.133", strall, "SysCommentLog");
        //                        //2.5、调用分数占比统计方法
        //                        bool i = clsSysCommentBLEx.AddWeightViewpointTotal(strUserId, stridCurrEduCls, UpdUser, fScore);
        //                        //bool i = RevalidationViewpointTotal(strUserId, stridCurrEduCls, UpdUser, fScore, resultNum);
        //                        if (i == true)
        //                        {
        //                            bolResult = true;


        //                            WriteTextLog("101.251.68.133", strall, "SysCommentLog");

        //                        }
        //                        else
        //                        {


        //                            WriteTextLog("101.251.68.133", strall, "SysCommentLog");
        //                            bolResult = false;
        //                        }
        //                    }
        //                }

        //                #endregion


        //            }

        //        }
        //        else
        //        {
        //            bolResult = false;
        //        }

        //        #endregion

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("核算评分记录出错, {1}.(from {0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);


        //    }
        //    return bolResult;
        //}

        //#endregion

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


        #region 《三》删除评论方法的扩展
        /// <summary>
        /// 功能:删除关键字所指定的记录
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
        /// </summary>
        /// <param name = "strCommentId">给定的关键字值</param>
        /// <returns>返回删除的记录数</returns>
        public static int DelRecord(string strCommentId)
        {
            #region 参数声明赋值；
            //执行之后，需要进行数据核算
            string strUserId = string.Empty;
            string strTableKeyId = string.Empty;
            string strCommentTypeId = string.Empty;
            string strParentId = string.Empty;
            string strid_CurrEducls = string.Empty;
            #endregion
            try
            {
                clsSysCommentEN objSysCommentEN = clsSysCommentBL.GetObjByCommentId(strCommentId);

                #region 参数赋值
                strUserId = objSysCommentEN.UserId;
                strTableKeyId = objSysCommentEN.TableKey;
                strCommentTypeId = objSysCommentEN.CommentTypeId;
                strParentId = objSysCommentEN.ParentId;
                strid_CurrEducls = objSysCommentEN.IdCurrEduCls;
                #endregion
                /// string strWhere = " 1=1 And CommentId = '" + strCommentId + "'";


                //回复的子数据也需要删除;通过父节点删除子数据；需要先得到子数据的ID 删除子数据；因为只有一层回复，所以只会有一条回复数据
                var strWhereChild = " 1=1 And ParentId = '" + strCommentId + "'";

                clsSysCommentEN objSysComment = clsSysCommentBL.GetFirstObj_S(strWhereChild);
                if (objSysComment != null)
                {
                    //得到回答ID 查询是否存在点赞数据，如果存在则删除；
                    string strCommentIdChild = objSysComment.CommentId;

                    //删除子回复数据
                    clsqa_AnswerBL.DelRecord(strCommentIdChild);
                }
                //删除回复点赞 02 代表子观点 
                string strWhereVote = " 1=1 And VoteTypeId='02' And TableKey = '" + strCommentId + "'";
                clsSysVoteBL.DelSysVotesByCond(strWhereVote);


                //删除子观点评论；
                int intRecNum = SysCommentDA.DelRecord(strCommentId);

                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                ReFreshCache();




                if (intRecNum > 0)
                {
                    string strall = strUserId + "/" + strTableKeyId + "/" + strCommentTypeId + "/" + strParentId + "/" + strid_CurrEducls;
                    //计算分数；
                    bool i = PersonalScoreStatistics(strUserId, strTableKeyId, strCommentTypeId, strParentId, strid_CurrEducls);
                    if (i == true)
                    {

                    }
                    else
                    {
                        //错误写日志；
                        WriteTextLog("101.25.36.133", strall, "SysCommentLog");
                    }
                }

                return intRecNum;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
        /// </summary>
        public static void ReFreshCache()
        {
            if (clsSysParaEN.spIsUseQueue4Task == true)
            {
                if (clsSysParaEN.arrFunctionLst4Queue == null)
                {
                    clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
                }
                clsDynamicFunction objDynamicFunction = new clsDynamicFunction()
                {
                    NameSpace = "ExamLib.BusinessLogic",
                    ClassName = "clsSysCommentBL",
                    AssemblyType = typeof(ExamLib.BusinessLogic.clsSysCommentBL),
                    FunctionName = clsStackTrace.GetCurrFunction()
                };
                if (clsDynamicFunction.IsExistSameFunction(clsSysParaEN.arrFunctionLst4Queue, objDynamicFunction) == true)
                {
                    return;
                }
                clsSysParaEN.arrFunctionLst4Queue.Enqueue(objDynamicFunction);
                return;
            }
            if (clsSysCommentBL.objCommFun4BL != null)
            {
                string strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
               clsStackTrace.GetCurrClassFunction(),
               clsStackTrace.GetCurrClassFunctionByLevel(2),
               clsStackTrace.GetCurrClassFunctionByLevel(3));
                clsSysParaEN.objLog.WriteDebugLog(strMsg);
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                string strKey = string.Format("{0}", clsSysCommentEN._CurrTabName);
                CacheHelper.Remove(strKey);
                clsSysCommentBL.objCommFun4BL.ReFreshCache();
            }
        }


        //strUserId 计算谁的评分；tabkeyId 主键；CommentTypeId 评论类型；ParentId=root，区分是否是内容的评论，还是他人回复的评论；IdCurrEduCls,教学班；
        public static bool PersonalScoreStatistics(string strUserId, string strTableKeyId, string strCommentTypeId, string strParentId, string strCurrEduId)
        {
            #region 参数存放

            bool result = false;
            //教师评分类型
            string strScoreTypeId = string.Empty;
            //评论的分值；
            string strScore = string.Empty;
            //评分类型
            string strScoreType = string.Empty;
            //声明一个类型用户（各个观点、概念、客观数据 事实的用户）
            string strTypeUser = string.Empty;

            //数量统计；
            int allCount = 0;
            //总分统计
            float fScore = 0.00f;
            //学生平均分
            float fStuScore = 0.00f;
            //教师平均分
            float fTeaScore = 0.00f;

            int iScore = 0;//个人分数汇总

            #endregion

            try
            {

                #region 获取评论中的统计数据；
                //1先获取评论中的统计数据；
                DataTable objDt = clsSysCommentBLEx.GetSysCommentNumDataTable(strCommentTypeId, strTableKeyId);
                if (objDt.Rows.Count > 0)
                {
                    foreach (DataRow row in objDt.Rows)
                    {
                        allCount = int.Parse(row["Pacount"].ToString());
                        fScore = float.Parse(row["PScore"].ToString());
                        if (row["StuScore"] == DBNull.Value)
                        {
                            fStuScore = 0;
                        }
                        else
                        {
                            fStuScore = float.Parse(row["StuScore"].ToString());
                        }
                        if (row["TeaScore"] == DBNull.Value)
                        {
                            fTeaScore = 0;
                        }
                        else
                        {

                            fTeaScore = float.Parse(row["TeaScore"].ToString());
                        }

                    }
                    string msgpaper = string.Format("获取SysComment综合评论数据成功");

                }
                else
                {
                    string msgpaper = string.Format("未能获取获取SysComment综合评论数据或统计为0");

                }

                #endregion

                #region 封装字段到对象
                clsSysCountENEx objcountEnEx = new clsSysCountENEx();
                objcountEnEx.CountType = strCommentTypeId;//评分统计类型Id
                objcountEnEx.Pacount = allCount;//评论数
                objcountEnEx.FScore = fScore; //统计分
                objcountEnEx.FStuScore = fStuScore; //学生统计分
                objcountEnEx.FTeaScore = fTeaScore;//教师统计分
                objcountEnEx.UserId = strUserId;//用户
                objcountEnEx.Tablekey = strTableKeyId;//主键
                objcountEnEx.ParrentId = strParentId;//存放主题；


                #endregion

                //通过类型判断调用不同的表数据；
                switch (strCommentTypeId)
                {
                    case "01":

                        #region //论文
                        clsPaperEN objPaper = clsPaperBL.GetObjByPaperId(strTableKeyId);

                        objPaper.AppraiseCount = allCount;//评论数
                        objPaper.Score = fScore;//总评分
                        objPaper.StuScore = fStuScore;//学生评分
                        objPaper.TeaScore = fTeaScore;//教师评分

                        strTypeUser = objPaper.UpdUser;
                        //调用论文修改；
                        bool pi = UpdateRecordPaper(objPaper);
                        if (pi == true)
                        {
                            bool Si = GetSysCountData(objcountEnEx);
                            if (Si == true)
                            {
                                string msgpaper = string.Format("Paper表数据更新完成");
                                result = true;

                            }
                            else
                            {
                                string msgpaper = string.Format("Paper表数据更新失败");
                                result = false;
                            }

                        }
                        else
                        {
                            string msgpaper = string.Format("Paper表数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "论文方法1", "SysCommentLog");
                        break;
                    case "02":

                        #region //论文子观点
                        clsPaperSubViewpointEN objsubviewpoint = clsPaperSubViewpointBL.GetObjBySubViewpointId(long.Parse( strTableKeyId));

                        objsubviewpoint.AppraiseCount = allCount;
                        objsubviewpoint.Score = fScore;//总评分
                        objsubviewpoint.StuScore = fStuScore;//学生评分
                        objsubviewpoint.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objsubviewpoint.UpdUser;

                        //调用论文修改；
                        bool psubi = UpdateRecordPapersubviewpoint(objsubviewpoint);
                        if (psubi == true)
                        {
                            //调用数据统计
                            bool psi = GetSysCountData(objcountEnEx);
                            if (psi == true)
                            {

                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0001";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (i == true)
                                {
                                    string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("论文子观点表数据更新失败");
                                    result = false;
                                }
                            }
                            else
                            {
                                string msgpaper = string.Format("论文统计数据失败");
                                result = false;
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("论文子观点表数据更新失败");
                            result = false;
                        }
                        WriteTextLog("101.251.68.133", "子观点1", "SysCommentLog");
                        #endregion
                        break;
                    case "03":
                        #region  个人观点
                        //个人观点
                        clsViewpointEN objviewpoint = clsViewpointBL.GetObjByViewpointId(strTableKeyId);
                        objviewpoint.AppraiseCount = allCount;
                        objviewpoint.Score = fScore;//总评分
                        objviewpoint.StuScore = fStuScore;//学生评分
                        objviewpoint.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objviewpoint.UpdUser;

                        //调用论文修改；
                        bool vi = UpdateRecordViewpoint(objviewpoint);
                        if (vi == true)
                        {
                            bool vsi = GetSysCountData(objcountEnEx);
                            if (vsi == true)
                            {

                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0002";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (i == true)
                                {
                                    string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("论文子观点表数据更新失败");
                                    result = false;
                                }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("个人观点表数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "个人观点1", "SysCommentLog");
                        break;
                    case "04":
                        #region  //专家观点
                        clsViewpointEN objExpertviewpoint = clsViewpointBL.GetObjByViewpointId(strTableKeyId);
                        objExpertviewpoint.AppraiseCount = allCount;
                        objExpertviewpoint.Score = fScore;//总评分
                        objExpertviewpoint.StuScore = fStuScore;//学生评分
                        objExpertviewpoint.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objExpertviewpoint.UpdUser;

                        //调用论文修改；
                        bool evi = UpdateRecordViewpoint(objExpertviewpoint);
                        if (evi == true)
                        {
                            bool evsi = GetSysCountData(objcountEnEx);
                            if (evsi == true)
                            {

                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0003";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (i == true)
                                {
                                    string msg = string.Format("专家观点更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("专家观点更新失败");
                                    result = false;
                                }

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("专家观点表数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "专家观点1", "SysCommentLog");
                        break;
                    case "05":
                        #region //概念
                        clsConceptEN objconcept = clsConceptBL.GetObjByConceptId(strTableKeyId);

                        objconcept.AppraiseCount = allCount;
                        objconcept.Score = fScore;//总评分
                        objconcept.StuScore = fStuScore;//学生评分
                        objconcept.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objconcept.UpdUser;

                        //调用论文修改；
                        bool ci = UpdateRecordConcept(objconcept);
                        if (ci == true)
                        {
                            bool csi = GetSysCountData(objcountEnEx);
                            if (csi == true)
                            {

                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0004";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (i == true)
                                {
                                    string msg = string.Format("概念更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("概念更新失败");
                                    result = false;
                                }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("概念表数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "概念1", "SysCommentLog");
                        break;
                    case "06":
                        #region //客观事实
                        clsTopicObjectiveEN objective = clsTopicObjectiveBL.GetObjByTopicObjectiveId(strTableKeyId);

                        objective.AppraiseCount = allCount;
                        objective.Score = fScore;//总评分
                        objective.StuScore = fStuScore;//学生评分
                        objective.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objective.UpdUser;

                        //调用论文修改；
                        bool oi = UpdateRecordTopicObjective(objective);
                        if (oi == true)
                        {
                            bool soi = GetSysCountData(objcountEnEx);
                            if (soi == true)
                            {

                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0005";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool itb = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (itb == true)
                                {
                                    string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("论文子观点表数据更新失败");
                                    result = false;
                                }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("客观事实更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "客观事实1", "SysCommentLog");
                        break;
                    case "07":
                        #region //客观数据
                        clsTopicObjectiveEN objectiveBasis = clsTopicObjectiveBL.GetObjByTopicObjectiveId(strTableKeyId);

                        objectiveBasis.AppraiseCount = allCount;
                        objectiveBasis.Score = fScore;//总评分
                        objectiveBasis.StuScore = fStuScore;//学生评分
                        objectiveBasis.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objectiveBasis.UpdUser;

                        //调用论文修改；
                        bool obi = UpdateRecordTopicObjective(objectiveBasis);
                        if (obi == true)
                        {
                            bool bobi = GetSysCountData(objcountEnEx);
                            if (bobi == true)
                            {

                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0006";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool it = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (it == true)
                                {
                                    string msg = string.Format("客观数据更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("客观数据更新失败");
                                    result = false;
                                }
                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("客观数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "客观数据1", "SysCommentLog");
                        break;
                    case "08":
                        #region 人员评分



                        iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                        strScore = iScore.ToString();
                        strScoreType = "0008";


                        //统计用户类型分数 存入对应的分数类型表数据
                        bool ip = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                        if (ip == true)
                        {
                            string msg = string.Format("客观数据更新完成，统计数据完成");
                            result = true;
                        }
                        else
                        {
                            string msg = string.Format("客观数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "人员评分1", "SysCommentLog");
                        break;
                    case "09":
                        #region //技能
                        clsSysSkillEN objSkill = clsSysSkillBL.GetObjBySkillId(strTableKeyId);

                        objSkill.AppraiseCount = allCount;
                        objSkill.Score = fScore;//总评分
                        objSkill.StuScore = fStuScore;//学生评分
                        objSkill.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objSkill.UpdUser;

                        //调用技能修改；
                        bool cski = UpdateRecordSysSkill(objSkill);
                        if (cski == true)
                        {
                            bool csi = GetSysCountData(objcountEnEx);
                            if (csi == true)
                            {
                                #region 注释
                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0021";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (i == true)
                                {
                                    string msg = string.Format("技能更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("技能更新失败");
                                    result = false;
                                }
                                #endregion



                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("技能表数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "技能1", "SysCommentLog");
                        break;
                    case "10":
                        #region //社会关系
                        clsSysSocialRelationsEN objSysSocialRelations = clsSysSocialRelationsBL.GetObjBySocialId(strTableKeyId);

                        objSysSocialRelations.AppraiseCount = allCount;
                        objSysSocialRelations.Score = fScore;//总评分
                        objSysSocialRelations.StuScore = fStuScore;//学生评分
                        objSysSocialRelations.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objSysSocialRelations.UpdUser;

                        //调用论文修改；
                        bool cSoci = UpdateRecordSysSocialRelations(objSysSocialRelations);
                        if (cSoci == true)
                        {
                            bool csi = GetSysCountData(objcountEnEx);
                            if (csi == true)
                            {
                                #region 操作

                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0023";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (i == true)
                                {
                                    string msg = string.Format("概念更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("概念更新失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("概念表数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "社会关系1", "SysCommentLog");
                        break;
                    case "11":
                        #region //问题回答
                        clsqa_AnswerEN objqa_Answer = clsqa_AnswerBL.GetObjByAnswerId(strTableKeyId);

                        objqa_Answer.AppraiseCount = allCount;
                        objqa_Answer.Score = fScore;//总评分
                        objqa_Answer.StuScore = fStuScore;//学生评分
                        objqa_Answer.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objqa_Answer.UpdUser;

                        //调用论文修改；
                        bool cqa = UpdateRecordqa_Answer(objqa_Answer);
                        if (cqa == true)
                        {
                            bool csi = GetSysCountData(objcountEnEx);
                            if (csi == true)
                            {
                                #region 操作

                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0025";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (i == true)
                                {
                                    string msg = string.Format("问题回答更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("问题回答更新失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("问题回答表数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "教师回答讨论", "SysCommentLog");
                        break;
                    case "12":
                        #region //论文汇报
                        clsgs_PaperReportEN objgs_PaperReport = clsgs_PaperReportBL.GetObjByReportId(strTableKeyId);

                        objgs_PaperReport.AppraiseCount = allCount;
                        objgs_PaperReport.Score = fScore;//总评分
                        objgs_PaperReport.StuScore = fStuScore;//学生评分
                        objgs_PaperReport.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objgs_PaperReport.UpdUser;

                        //调用论文修改；
                        bool cpr = UpdateRecordgs_PaperReport(objgs_PaperReport);
                        if (cpr == true)
                        {
                            bool csi = GetSysCountData(objcountEnEx);
                            if (csi == true)
                            {
                                #region 操作

                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0043";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (i == true)
                                {
                                    string msg = string.Format("论文汇报更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("论文汇报更新失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("论文汇报表数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "论文汇报", "SysCommentLog");
                        break;
                    case "13":
                        #region //研究成果
                        clsgs_ResearchResultEN objgs_ResearchResult = clsgs_ResearchResultBL.GetObjByResultId(strTableKeyId);

                        objgs_ResearchResult.AppraiseCount = allCount;
                        objgs_ResearchResult.Score = fScore;//总评分
                        objgs_ResearchResult.StuScore = fStuScore;//学生评分
                        objgs_ResearchResult.TeaScore = fTeaScore;//教师评分
                        strTypeUser = objgs_ResearchResult.UpdUser;

                        //调用论文修改；
                        bool crr = UpdateRecordgs_ResearchResult(objgs_ResearchResult);
                        if (crr == true)
                        {
                            bool csi = GetSysCountData(objcountEnEx);
                            if (csi == true)
                            {
                                #region 操作

                                iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                                strScore = iScore.ToString();
                                if (strParentId == "root")
                                {
                                    strScoreType = "0046";
                                }
                                else
                                {
                                    strScoreType = "0007";
                                }


                                //统计用户类型分数 存入对应的分数类型表数据
                                bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                                if (i == true)
                                {
                                    string msg = string.Format("研究成果更新完成，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("研究成果更新失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("研究成果表数据更新失败");
                            result = false;
                        }
                        #endregion
                        WriteTextLog("101.251.68.133", "研究成果", "SysCommentLog");
                        break;
                    #region 注释
                    //case "21":
                    //    #region 中学生课件
                    //    strTypeUser = UpdDatazx_TextReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                    //    if (string.IsNullOrEmpty(strTypeUser) == false)
                    //    {
                    //        bool csi = GetSysCountData(objcountEnEx);
                    //        if (csi == true)
                    //        {
                    //            #region 操作

                    //            iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                    //            strScore = iScore.ToString();
                    //            if (strParentId == "root")
                    //            {
                    //                strScoreType = "0023";
                    //            }
                    //            else
                    //            {
                    //                strScoreType = "0007";
                    //            }


                    //            //统计用户类型分数 存入对应的分数类型表数据
                    //            bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                    //            if (i == true)
                    //            {
                    //                string msg = string.Format("概念更新完成，统计数据完成");
                    //                result = true;
                    //            }
                    //            else
                    //            {
                    //                string msg = string.Format("概念更新失败");
                    //                result = false;
                    //            }

                    //            #endregion

                    //        }
                    //    }
                    //    else
                    //    {
                    //        string msgpaper = string.Format("更新失败");
                    //        result = false;
                    //    }
                    //    #endregion
                    //    WriteTextLog("101.251.68.133", "中学生课件1", "SysCommentLog");
                    //    break;
                    //case "22":
                    //    #region 中学个人观点
                    //    strTypeUser = UpdDatazx_ViewpointReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                    //    if (string.IsNullOrEmpty(strTypeUser) == false)
                    //    {
                    //        bool csi = GetSysCountData(objcountEnEx);
                    //        if (csi == true)
                    //        {
                    //            #region 操作

                    //            iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                    //            strScore = iScore.ToString();
                    //            if (strParentId == "root")
                    //            {
                    //                strScoreType = "0023";
                    //            }
                    //            else
                    //            {
                    //                strScoreType = "0007";
                    //            }


                    //            //统计用户类型分数 存入对应的分数类型表数据
                    //            bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                    //            if (i == true)
                    //            {
                    //                string msg = string.Format("中学个人观点，统计数据完成");
                    //                result = true;
                    //            }
                    //            else
                    //            {
                    //                string msg = string.Format("中学个人观点失败");
                    //                result = false;
                    //            }

                    //            #endregion

                    //        }
                    //    }
                    //    else
                    //    {
                    //        string msgpaper = string.Format("更新失败");
                    //        result = false;
                    //    }
                    //    #endregion
                    //    WriteTextLog("101.251.68.133", "中学个人观点1", "SysCommentLog");
                    //    break;
                    //case "23":
                    //    #region 中学专家观点
                    //    strTypeUser = UpdDatazx_ViewpointReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                    //    if (string.IsNullOrEmpty(strTypeUser) == false)
                    //    {
                    //        bool csi = GetSysCountData(objcountEnEx);
                    //        if (csi == true)
                    //        {
                    //            #region 操作

                    //            iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                    //            strScore = iScore.ToString();
                    //            if (strParentId == "root")
                    //            {
                    //                strScoreType = "0023";
                    //            }
                    //            else
                    //            {
                    //                strScoreType = "0007";
                    //            }


                    //            //统计用户类型分数 存入对应的分数类型表数据
                    //            bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                    //            if (i == true)
                    //            {
                    //                string msg = string.Format("中学个人观点，统计数据完成");
                    //                result = true;
                    //            }
                    //            else
                    //            {
                    //                string msg = string.Format("中学个人观点失败");
                    //                result = false;
                    //            }

                    //            #endregion

                    //        }
                    //    }
                    //    else
                    //    {
                    //        string msgpaper = string.Format("更新失败");
                    //        result = false;
                    //    }
                    //    #endregion
                    //    WriteTextLog("101.251.68.133", "中学专家观点1", "SysCommentLog");
                    //    break;
                    //case "24":
                    //    #region 中学概念
                    //    strTypeUser = UpdDatazx_ConceptReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                    //    if (string.IsNullOrEmpty(strTypeUser) == false)
                    //    {
                    //        bool csi = GetSysCountData(objcountEnEx);
                    //        if (csi == true)
                    //        {
                    //            #region 操作

                    //            iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                    //            strScore = iScore.ToString();
                    //            if (strParentId == "root")
                    //            {
                    //                strScoreType = "0023";
                    //            }
                    //            else
                    //            {
                    //                strScoreType = "0007";
                    //            }


                    //            //统计用户类型分数 存入对应的分数类型表数据
                    //            bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                    //            if (i == true)
                    //            {
                    //                string msg = string.Format("中学概念，统计数据完成");
                    //                result = true;
                    //            }
                    //            else
                    //            {
                    //                string msg = string.Format("中学概念失败");
                    //                result = false;
                    //            }

                    //            #endregion

                    //        }
                    //    }
                    //    else
                    //    {
                    //        string msgpaper = string.Format("更新失败");
                    //        result = false;
                    //    }
                    //    #endregion
                    //    WriteTextLog("101.251.68.133", "中学概念1", "SysCommentLog");
                    //    break;
                    //case "25":
                    //    #region 中学客观事实
                    //    strTypeUser = UpdDatazx_TopicObjectiveReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                    //    if (string.IsNullOrEmpty(strTypeUser) == false)
                    //    {
                    //        bool csi = GetSysCountData(objcountEnEx);
                    //        if (csi == true)
                    //        {
                    //            #region 操作

                    //            iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                    //            strScore = iScore.ToString();
                    //            if (strParentId == "root")
                    //            {
                    //                strScoreType = "0023";
                    //            }
                    //            else
                    //            {
                    //                strScoreType = "0007";
                    //            }


                    //            //统计用户类型分数 存入对应的分数类型表数据
                    //            bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                    //            if (i == true)
                    //            {
                    //                string msg = string.Format("中学客观事实，统计数据完成");
                    //                result = true;
                    //            }
                    //            else
                    //            {
                    //                string msg = string.Format("中学客观事实失败");
                    //                result = false;
                    //            }

                    //            #endregion

                    //        }
                    //    }
                    //    else
                    //    {
                    //        string msgpaper = string.Format("更新失败");
                    //        result = false;
                    //    }
                    //    #endregion
                    //    WriteTextLog("101.251.68.133", "中学客观事实1", "SysCommentLog");
                    //    break;
                    //case "26":
                    //    #region 中学客观数据
                    //    strTypeUser = UpdDatazx_TopicObjectiveReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                    //    if (string.IsNullOrEmpty(strTypeUser) == false)
                    //    {
                    //        bool csi = GetSysCountData(objcountEnEx);
                    //        if (csi == true)
                    //        {
                    //            #region 操作

                    //            iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                    //            strScore = iScore.ToString();
                    //            if (strParentId == "root")
                    //            {
                    //                strScoreType = "0023";
                    //            }
                    //            else
                    //            {
                    //                strScoreType = "0007";
                    //            }


                    //            //统计用户类型分数 存入对应的分数类型表数据
                    //            bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                    //            if (i == true)
                    //            {
                    //                string msg = string.Format("中学客观数据，统计数据完成");
                    //                result = true;
                    //            }
                    //            else
                    //            {
                    //                string msg = string.Format("中学客观数据失败");
                    //                result = false;
                    //            }

                    //            #endregion

                    //        }
                    //    }
                    //    else
                    //    {
                    //        string msgpaper = string.Format("更新失败");
                    //        result = false;
                    //    }
                    //    #endregion
                    //    WriteTextLog("101.251.68.133", "中学客观数据1", "SysCommentLog");
                    //    break;
                    //case "27":
                    //    #region 中学技能 zx_Skill
                    //    strTypeUser = UpdDatazx_SkillReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                    //    if (string.IsNullOrEmpty(strTypeUser) == false)
                    //    {
                    //        bool csi = GetSysCountData(objcountEnEx);
                    //        if (csi == true)
                    //        {
                    //            #region 操作

                    //            iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                    //            strScore = iScore.ToString();
                    //            if (strParentId == "root")
                    //            {
                    //                strScoreType = "0023";
                    //            }
                    //            else
                    //            {
                    //                strScoreType = "0007";
                    //            }


                    //            //统计用户类型分数 存入对应的分数类型表数据
                    //            bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                    //            if (i == true)
                    //            {
                    //                string msg = string.Format("中学技能，统计数据完成");
                    //                result = true;
                    //            }
                    //            else
                    //            {
                    //                string msg = string.Format("中学技能失败");
                    //                result = false;
                    //            }

                    //            #endregion

                    //        }
                    //    }
                    //    else
                    //    {
                    //        string msgpaper = string.Format("更新失败");
                    //        result = false;
                    //    }
                    //    #endregion
                    //    WriteTextLog("101.251.68.133", "中学技能1", "SysCommentLog");
                    //    break;
                    //case "28":
                    //    #region 28	中学社会关系 zx_SocialRelations  SocialId
                    //    strTypeUser = UpdDatazx_SocialRelationsReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                    //    if (string.IsNullOrEmpty(strTypeUser) == false)
                    //    {
                    //        bool csi = GetSysCountData(objcountEnEx);
                    //        if (csi == true)
                    //        {
                    //            #region 操作

                    //            iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                    //            strScore = iScore.ToString();
                    //            if (strParentId == "root")
                    //            {
                    //                strScoreType = "0023";
                    //            }
                    //            else
                    //            {
                    //                strScoreType = "0007";
                    //            }


                    //            //统计用户类型分数 存入对应的分数类型表数据
                    //            bool i = AddorUpdateScoreByWhere(strTypeUser, strScore, strScoreType, strCommentTypeId, strCurrEduId, strUserId);
                    //            if (i == true)
                    //            {
                    //                string msg = string.Format("中学社会关系，统计数据完成");
                    //                result = true;
                    //            }
                    //            else
                    //            {
                    //                string msg = string.Format("中学社会关系失败");
                    //                result = false;
                    //            }

                    //            #endregion

                    //        }
                    //    }
                    //    else
                    //    {
                    //        string msgpaper = string.Format("更新失败");
                    //        result = false;
                    //    }
                    //    #endregion
                    //    break;
                    #endregion
                    default:
                        string strMsg = string.Format("没有该类型数据统计");
                        result = true;
                        break;
                }


            }
            catch (Exception objException)
            {
                string strMsg = string.Format("核算评分记录出错, {1}.(from {0})",
                  clsStackTrace.GetCurrClassFunction(),
                  objException.Message);
                result = false;
                throw new Exception(strMsg);
            }
            return result;
        }


        //通过用户Id 评论类型；以及 是否教师评论  和教学班 得到用户评论类型 汇总分数 
        public static int GetUserScore(string strUserId, string strCommentTypeId, string strCurrEduId, string strParentId)
        {
            int iScore = 0;
            try
            {
                //通过strParentId查询不是root 和root 数据；
                if (strParentId == "root")
                {
                    //string strwhere = "UserId= '" + strUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And CommentTypeId='" + strCommentTypeId + "' And ParentId = 'root' AND ScoreType = '2'";
                    string strwhere = "UserId= '" + strUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And CommentTypeId='" + strCommentTypeId + "' And ParentId = 'root'";
                    // 得到用户汇总总分  通过类型；
                    //通过用户Id 和评分类型查询得到实体，如果有则修改、 没有则插入；
                    List<clsSysCommentEN> SysCommentList = clsSysCommentBL.GetObjLst(strwhere);
                    if (SysCommentList.Count > 0)
                    {
                        foreach (clsSysCommentEN obj in SysCommentList)
                        {
                            iScore += Convert.ToInt32(obj.Score);
                        }
                    }
                }
                else
                {
                    //只要是给他人的评价 ，不管是不是同一类型  ；得到给他人评价分数
                    //string strwhere = "UserId= '" + strUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ParentId <> 'root' AND ScoreType = '2'";
                    string strwhere = "UserId= '" + strUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ParentId <> 'root'";
                    // 得到用户汇总总分  通过类型；
                    //通过用户Id 和评分类型查询得到实体，如果有则修改、 没有则插入；
                    List<clsSysCommentEN> SysCommentList = clsSysCommentBL.GetObjLst(strwhere);
                    if (SysCommentList.Count > 0)
                    {
                        foreach (clsSysCommentEN obj in SysCommentList)
                        {
                            iScore += Convert.ToInt32(obj.Score);
                        }

                    }
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取用户评分记录出错, {1}.(from {0})",
                   clsStackTrace.GetCurrClassFunction(),
                   objException.Message);
                throw new Exception(strMsg);

            }
            return iScore;
        }


        /// <param name="strTypeUserId"></param>
        /// <param name="strScore"></param>
        /// <param name="strScoreType"></param>
        /// <param name="strCommentTypeId"></param>
        /// <param name="strCurrEduId"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        //各类型观点，人员分数；----------------  通过得到的类型用户查询 分数统计表数据；同时还需要查询权重表数据比例；
        //2者数据相乘得到结果 存在则 原数据+传入数据；没有则添加 ，strViewpointRations(各个观点占比的权重)
        public static bool AddorUpdateScoreByWhere(string strTypeUserId, string strScore, string strScoreType, string strCommentTypeId, string strCurrEduId, string strUserId)
        {
            bool result = false;
            float fScore = 0;//用来存放分值，传递给占比分统计方法 统计 分数占比；
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                //通过用户Id 和评分类型查询得到实体，如果有则修改、 没有则插入；
                clsSysScoreSummaryEN objSysScoreSummary = clsSysScoreSummaryBL.GetFirstObj_S("UserId= '" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId='" + strScoreType + "'");
                if (objSysScoreSummary != null)
                {

                    ////0008是人员分，所以不能累计；除开人员 其他都可以累计积分；
                    //if (strScoreType == "0008")
                    //{
                    //    objSysScoreSummary.Score = float.Parse(strScore);
                    //}
                    //else
                    //{
                    //    objSysScoreSummary.Score += float.Parse(strScore);
                    //}
                    //直接把分值修改进去；
                    objSysScoreSummary.Score = float.Parse(strScore);

                    fScore = objSysScoreSummary.Score ?? 0;
                    objSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    #region 修改方法
                    bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objSysScoreSummary);
                    if (bolResult == true)
                    {
                        if (strCommentTypeId == "08")
                        {
                            //代表用户，不用统计总分；
                        }
                        else
                        {
                            //计算各观点总分；
                            bool i = AddViewpointTotal(strTypeUserId, strCurrEduId, strUserId);
                            if (i == true)
                            {

                                //再次调用学生打分 总计；
                                AddStuScoreTotal(strTypeUserId, strCurrEduId, strUserId);

                                string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                                result = true;
                            }
                            else
                            {
                                string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                                result = false;
                            }

                        }



                        ////修改各个观点、概念分数后，需要计算占比分数
                        //bool i = AddviewpointWeightScore(strTypeUserId, strCurrEduId, strScoreType, strCommentTypeId, strUserId, fScore);
                        //if (i == true)
                        //{
                        //    string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                        //    result = true;
                        //}
                        //else
                        //{
                        //    string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                        //    result = false;
                        //}

                    }
                    else
                    {
                        string strMsg = string.Format("SysScoreSummary统计分数修改数据失败");

                        result = false;
                    }
                    #endregion
                }
                else
                {

                    //添加；
                    clsSysScoreSummaryEN objNewSysScoreSummary = new clsSysScoreSummaryEN();

                    //SchoolYear 学年
                    objNewSysScoreSummary.SchoolYear = GetSchoolYearbyNow();
                    objNewSysScoreSummary.UserId = strTypeUserId;
                    objNewSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewSysScoreSummary.UpdUser = strUserId;
                    objNewSysScoreSummary.Score = float.Parse(strScore);//分数；
                    objNewSysScoreSummary.ScoreTypeId = strScoreType;//类型
                    objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;

                    //用户传值用；
                    fScore = objNewSysScoreSummary.Score ?? 0;


                    #region 添加方法
                    //添加方法
                    bool i = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);
                    if (i == true)
                    {
                        if (strCommentTypeId == "08")
                        {
                            //代表用户，不用统计总分；
                        }
                        else
                        {
                            //计算各观点总分；
                            bool iTotal = AddViewpointTotal(strTypeUserId, strCurrEduId, strUserId);
                            if (iTotal == true)
                            {

                                //再次调用学生打分 总计；
                                AddStuScoreTotal(strTypeUserId, strCurrEduId, strUserId);

                                string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                                result = true;
                            }
                            else
                            {
                                string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                                result = false;
                            }

                        }

                        ////修改各个观点、概念分数后，需要计算占比分数
                        //AddviewpointWeightScore(strTypeUserId, strCurrEduId, strScoreType, strCommentTypeId, strUserId, fScore);

                        //string msgpaper = string.Format("各观点统计数据添加成功");

                        //result = true;
                    }
                    else
                    {
                        string msgpaper = string.Format("各观点统计数据添加失败");

                        result = false;
                    }
                    #endregion

                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                result = false;

            }
            return result;

        }


        #endregion



        #region  四、用于学生总分统计 UpdUser用于记录当前是谁在核算操作；
        public static bool GetStuTotalRevalidation(string strUserId)
        {
            bool result = false;
            string strCurrEduId = string.Empty;
            string strCommentTypeId = string.Empty;
            int yNumber = 0;
            try
            {


                #region 获取教学班数据
                //1.获取评分教学班数据
                DataTable objDt = clsSysCommentBLEx.GetSysScoreSummaryCurrEduCls();
                if (objDt.Rows.Count > 0)
                {
                    foreach (DataRow row in objDt.Rows)
                    {
                        strCurrEduId = row["IdCurrEduCls"].ToString();



                        #region 根据条件获取用户数据，进行分数换算
                        //var strScore = string.Empty;//声明一个分数变量字段，用于存放学生评价的分数统计；
                        //2.获取学分评分打分内容；根据评论表SysComment ScoreType=1 代表学生；  ParentId='root代表是第一层回复根数据；
                        string strWhere = "	ScoreType='1' And ParentId='root' And IdCurrEduCls='" + strCurrEduId + "' order by score desc";
                        //2.1得到评价列表数据源
                        List<clsSysCommentEN> ArrList = clsSysCommentBL.GetObjLst(strWhere);

                        if (ArrList.Count > 0)
                        {
                            //2.3循环数据对象
                            foreach (clsSysCommentEN objSysCommentEN in ArrList)
                            {
                                yNumber++;
                                //2.4得到用户分数 和教学班Id .用户Id；评分类型；
                                float fScore = 0;
                                string strTypeUser = string.Empty;
                                float strScore = 0;//声明一个分数变量字段，用于存放学生评价的分数统计；
                                //分数类型，比如个人观点、子观点、技能等等类型；
                                string strSTypeId = string.Empty;
                                List<clsSysCommentEN> SysCommentList = null;

                                //stridCurrEduCls = objSysScoreSummaryEN.IdCurrEduCls;
                                fScore = objSysCommentEN.Score ?? 0;
                                strCommentTypeId = objSysCommentEN.CommentTypeId;
                                strTypeUser = objSysCommentEN.UserId;


                                //通过类型判断调用不同的表数据；
                                switch (strCommentTypeId)
                                {
                                    case "01":

                                        //论文

                                        break;
                                    case "02":

                                        //论文子观点
                                        strSTypeId = "0031";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blpsi == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据失败");
                                            result = false;
                                        }

                                        break;
                                    case "03":
                                        //个人观点

                                        strSTypeId = "0032";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blv = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blv == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据失败");
                                            result = false;
                                        }

                                        break;
                                    case "04":
                                        //专家观点
                                        strSTypeId = "0033";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blp = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blp == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据失败");
                                            result = false;
                                        }


                                        break;
                                    case "05":
                                        //概念
                                        strSTypeId = "0034";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blc = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blc == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据失败");
                                            result = false;
                                        }


                                        break;
                                    case "06":
                                        //客观事实
                                        strSTypeId = "0035";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blt = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blt == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据失败");
                                            result = false;
                                        }


                                        break;
                                    case "07":
                                        //客观数据
                                        strSTypeId = "0036";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blto = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blto == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据失败");
                                            result = false;
                                        }

                                        break;
                                    case "08":
                                        //人员评分
                                        ////必须是教师评分才统计
                                        //if (strScoreTypeId == "2")
                                        //{
                                        //    //这里strTableKeyId 存放的主键就是用户Id 所以直接赋值给类型用户；
                                        //    strTypeUser = strTableKeyId;
                                        //    //添加各个观点、概念 换算后的数据插入或修改； ---参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        //    bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0008", strCommentTypeId, strCurrEduId, strUserId);

                                        //    if (blpsi == true)
                                        //    {
                                        //        string msg = string.Format("客观数据更新完成，客观数据统计数据完成,客观数据评分统计完成");
                                        //        result = true;
                                        //    }
                                        //    else
                                        //    {
                                        //        string msg = string.Format("客观数据评分统计数据失败");
                                        //        result = false;
                                        //    }
                                        //}

                                        break;
                                    case "09":
                                        //技能
                                        strSTypeId = "0037";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blsk = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blsk == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据失败");
                                            result = false;
                                        }

                                        break;
                                    case "10":
                                        //社会关系
                                        strSTypeId = "0038";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blso = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blso == true)
                                        {
                                            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文子观点表数据失败");
                                            result = false;
                                        }

                                        break;
                                    case "11":
                                        //教师问题回答
                                        strSTypeId = "0039";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blqa = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blqa == true)
                                        {
                                            string msg = string.Format("教师问题回答数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("教师问题回答表数据失败");
                                            result = false;
                                        }

                                        break;
                                    case "12":
                                        //论文汇报
                                        strSTypeId = "0044";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpr = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blpr == true)
                                        {
                                            string msg = string.Format("论文汇报表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("论文汇报数据失败");
                                            result = false;
                                        }

                                        break;
                                    case "13":
                                        //研究成果
                                        strSTypeId = "0046";//论文子观点 学生分数类型

                                        //获取用户当前类型表的学生总分;
                                        SysCommentList = ArrList.Where(x => x.UserId == strTypeUser && x.CommentTypeId == strCommentTypeId).ToList();
                                        //循环输出分数相加
                                        foreach (clsSysCommentEN objComment in SysCommentList)
                                        {
                                            //把该类型分数计算统计；
                                            strScore += objComment.Score ?? 0;
                                        }

                                        //    //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blrr = AddorUpdateScore(strTypeUser, strScore, strSTypeId, strCommentTypeId, strCurrEduId, strUserId);

                                        if (blrr == true)
                                        {
                                            string msg = string.Format("研究成果表数据更新完成，统计数据完成");
                                            result = true;
                                        }
                                        else
                                        {
                                            string msg = string.Format("研究成果数据失败");
                                            result = false;
                                        }

                                        break;
                                    default:
                                        string strMsg = string.Format("没有获得类型数据");

                                        break;
                                }

                                //string strall = yNumber + "/" + strUserId + "/" + stridCurrEduCls + "/" + UpdUser + "/" + fScore;
                                //WriteTextLog("101.251.68.133", strall, "SysCommentLog");
                                //2.5、调用分数占比统计方法

                            }
                        }

                        #endregion


                    }

                }
                else
                {
                    result = false;
                }

                #endregion

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("核算评分记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return result;
        }

        //学生分 各类型表统计；
        public static bool AddorUpdateScore(string strTypeUserId, float strScore, string strScoreType, string strCommentTypeId, string strCurrEduId, string strUserId)
        {
            bool result = false;
            float fScore = 0;//用来存放分值，传递给占比分统计方法 统计 分数占比；
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                //通过用户Id 和评分类型查询得到实体，如果有则修改、 没有则插入；
                clsSysScoreSummaryEN objSysScoreSummary = clsSysScoreSummaryBL.GetFirstObj_S("UserId= '" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId='" + strScoreType + "'");
                if (objSysScoreSummary != null)
                {

                    ////0008是人员分，所以不能累计；除开人员 其他都可以累计积分；
                    //if (strScoreType == "0008")
                    //{
                    //    objSysScoreSummary.Score = float.Parse(strScore);
                    //}
                    //else
                    //{
                    //    objSysScoreSummary.Score += float.Parse(strScore);
                    //}
                    //fScore = objSysScoreSummary.Score;

                    objSysScoreSummary.Score = strScore;

                    objSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    #region 修改方法
                    bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objSysScoreSummary);
                    if (bolResult == true)
                    {
                        //修改各个观点、概念分数后，需要计算各观点分数
                        ////bool i = AddviewpointWeightScore(strTypeUserId, strCurrEduId, strScoreType, strCommentTypeId, strUserId, fScore);
                        ////这个地方判断评论类型、 调用统计各个观点的总分方法；
                        //if (strCommentTypeId == "08")
                        //{
                        //    //代表用户，不用统计总分；
                        //}
                        //else
                        //{
                        //计算各观点总分；
                        bool i = AddViewpointTotal(strTypeUserId, strCurrEduId, strUserId);
                        if (i == true)
                        {
                            //bool iTotal = AddViewpointTotal(strTypeUserId, strCurrEduId, strUserId);
                            //if (iTotal == true)
                            //{
                            //再次调用学生打分 总计；
                            AddStuScoreTotal(strTypeUserId, strCurrEduId, strUserId);
                            //}
                            string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                            result = true;
                        }
                        else
                        {
                            string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                            result = false;
                        }

                        // }

                    }
                    else
                    {
                        string strMsg = string.Format("SysScoreSummary统计分数修改数据失败");

                        result = false;
                    }
                    #endregion
                }
                else
                {

                    //添加；
                    clsSysScoreSummaryEN objNewSysScoreSummary = new clsSysScoreSummaryEN();

                    //SchoolYear 学年
                    objNewSysScoreSummary.SchoolYear = GetSchoolYearbyNow();
                    objNewSysScoreSummary.UserId = strTypeUserId;
                    objNewSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewSysScoreSummary.UpdUser = strUserId;
                    objNewSysScoreSummary.Score = strScore;//分数；
                    objNewSysScoreSummary.ScoreTypeId = strScoreType;//类型
                    objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;

                    //用户传值用；
                    fScore = objNewSysScoreSummary.Score ?? 0;


                    #region 添加方法
                    //添加方法
                    bool i = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);
                    if (i == true)
                    {
                        ////修改各个观点、概念分数后，需要计算占比分数
                        //// AddviewpointWeightScore(strTypeUserId, strCurrEduId, strScoreType, strCommentTypeId, strUserId, fScore);
                        ////这个地方判断评论类型、 调用统计各个观点的总分方法；
                        //if (strCommentTypeId == "08")
                        //{
                        //    //代表用户，不用统计总分；
                        //}
                        //else
                        //{
                        bool iTotal = AddViewpointTotal(strTypeUserId, strCurrEduId, strUserId);
                        if (iTotal == true)
                        {
                            //再次调用学生打分 总计；
                            AddStuScoreTotal(strTypeUserId, strCurrEduId, strUserId);
                        }
                        string msgpaper = string.Format("各观点统计数据添加成功");

                        result = true;
                        //  }

                    }
                    else
                    {
                        string msgpaper = string.Format("各观点统计数据添加失败");

                        result = false;
                    }
                    #endregion

                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                result = false;

            }
            return result;

        }

        #endregion


        #region 五、 //教师针对评价、讨论 、总的打分；
        //3个参数，页面参数、判断是添加还是修改；类型参数：是讨论还是评价；操作人；
        public static bool AddOrUpdateSysScoreSummary(clsSysScoreSummaryEN objSysScoreSummaryEN)
        {
            bool result = false;
            string strScoreTypeId = string.Empty;
            string strUserId = string.Empty;
            string strUpdUser = string.Empty;
            string stridCurrEduCls = string.Empty;
            float fScore = 0;

            try
            {
                //通过得到的对象 获取用户 和类型字段，通过这个2个条件查询  打分表，如果存在就是修改，否则就是添加；
                strScoreTypeId = objSysScoreSummaryEN.ScoreTypeId;
                strUserId = objSysScoreSummaryEN.UserId;
                strUpdUser = objSysScoreSummaryEN.UpdUser;
                stridCurrEduCls = objSysScoreSummaryEN.IdCurrEduCls;
                fScore = objSysScoreSummaryEN.Score ?? 0;


                    clsSysScoreSummaryEN objSysScoreSummary = clsSysScoreSummaryBL.GetFirstObj_S("UserId= '" + strUserId + "' And IdCurrEduCls='" + stridCurrEduCls + "' And ScoreTypeId='" + strScoreTypeId + "'");
                    if (objSysScoreSummary != null)
                    {
                    objSysScoreSummary.Score = fScore;

                    objSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    #region 修改方法
                    bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objSysScoreSummary);
                    if (bolResult == true)
                    {
                        //计算各观点总分；
                        bool i = AddViewpointTotal(strUserId, stridCurrEduCls, strUpdUser);
                        if (i == true)
                        {
                          
                            string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                            result = true;
                        }
                        else
                        {
                            string strMsg = string.Format("SysScoreSummary统计分数修改失败");

                            result = false;
                        }

                        // }

                    }
                    else
                    {
                        string strMsg = string.Format("SysScoreSummary统计分数修改数据失败");

                        result = false;
                    }

                    #endregion
                }
                else {

                    //添加；
                    clsSysScoreSummaryEN objNewSysScoreSummary = new clsSysScoreSummaryEN();

                    //SchoolYear 学年
                    objNewSysScoreSummary.SchoolYear = GetSchoolYearbyNow();
                    objNewSysScoreSummary.UserId = strUserId;
                    objNewSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewSysScoreSummary.UpdUser = strUpdUser;
                    objNewSysScoreSummary.Score = fScore;//分数；
                    objNewSysScoreSummary.ScoreTypeId = strScoreTypeId;//类型
                    objNewSysScoreSummary.IdCurrEduCls = stridCurrEduCls;

                  
                    #region 添加方法
                    //添加方法
                    bool i = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);
                    if (i == true)
                    {
                        bool iTotal = AddViewpointTotal(strUserId, stridCurrEduCls, strUpdUser);
                        if (iTotal == true)
                        {
                            string msgpaper = string.Format("各观点统计数据成功");

                            result = true;
                        }
                        else {

                            string msgpaper = string.Format("各观点统计失败");

                            result = true;
                        }

                    }
                    else
                    {
                        string msgpaper = string.Format("教师总评打分失败");

                        result = false;
                    }
                    #endregion

                }


            }
            catch (Exception objException)
            {
                string strMsg = string.Format("添加修改打分记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);


            }
            return result;

        }

      
        #endregion



    }
}
