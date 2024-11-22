using System;
using System.Collections.Generic;
using System.Text;

using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.dynamiccompiler;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System.Data;
using System.IO;


namespace ExamLib.BusinessLogicExs
{
    public static class clsSysCommentZxBLEx
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

        #region 获取数据类型 参数
        //评论表类型；主键；评分类型；
        public static DataTable GetSysCommentNumDataTable(string strCommentTypeId, string strTableKey)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsSysCommentDAEx.GetSysCommentNumDataTable(strCommentTypeId, strTableKey);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}),{2},{3}.({0})",
                clsStackTrace.GetCurrClassFunction(), strCommentTypeId, strTableKey, objException.Message);
                throw new Exception(strMsg);
            }
        }

        //根据条件 获取数据返回Datatable 查询去除重复的教学班数据
        public static System.Data.DataTable GetSysScoreSummaryCurrEduCls()
        {
            DataTable objDT = null;
            try
            {
                objDT = clsSysCommentDAEx.GetSysScoreSummaryCurrEduCls();
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!",
                clsStackTrace.GetCurrClassFunction(), objException.Message);
                throw new Exception(strMsg);
            }
        }


        #endregion


        #region  用于总分核算的方法 UpdUser用于记录当前是谁在核算操作；
        public static bool GetTotalRevalidation(string UpdUser)
        {
            bool bolResult = false;
            string stridCurrEduCls = string.Empty;
            string strScoreType = string.Empty;
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
                        stridCurrEduCls = row["IdCurrEduCls"].ToString();

                        //#region 获取当前教学班下 分数最高的用户，得到百分比值
                        ////1，首先需要通过总分类型来排序；得到百分比后的分值；
                        ////通过观点0009查询（各观点总分）， 根据分数排序；得到最高分
                        //clsSysScoreSummaryEN objSysScoreSummaryOrderby = clsSysScoreSummaryBL.GetFirstObj_S(" 1=1 And ScoreTypeId='0009' And IdCurrEduCls='" + stridCurrEduCls + "' order by score desc");
                        ////取出排序最高的各个观点统计分数，然后换算；
                        //float HighScore = objSysScoreSummaryOrderby.Score;
                        ////除以100；按百分比 换算
                        //float resultNum = HighScore / 100;
                        //#endregion


                        #region 根据条件获取用户数据，进行分数换算
                        //2.获取当前每个用户的数据总分 然后再通过最高分计算总分占比
                        //2.1 条件，根据ScoreTypeId 和教学班 获取每个用户总分，通过分数排序；
                        string strWhere = "ScoreTypeId='0009' And IdCurrEduCls='" + stridCurrEduCls + "' order by score desc";
                        //2.2得到数据源
                        List<clsSysScoreSummaryEN> ArrList = clsSysScoreSummaryBL.GetObjLst(strWhere);

                        if (ArrList.Count > 0)
                        {
                            //2.3循环数据对象
                            foreach (clsSysScoreSummaryEN objSysScoreSummaryEN in ArrList)
                            {
                                yNumber++;
                                //2.4得到用户分数 和教学班Id .用户Id；评分类型；
                                float fScore = 0;
                                string strUserId = string.Empty;


                                //stridCurrEduCls = objSysScoreSummaryEN.IdCurrEduCls;
                                fScore = objSysScoreSummaryEN.Score ?? 0;
                                strScoreType = objSysScoreSummaryEN.ScoreTypeId;
                                strUserId = objSysScoreSummaryEN.UserId;

                                string strall = yNumber + "/" + strUserId + "/" + stridCurrEduCls + "/" + UpdUser + "/" + fScore;
                                WriteTextLog("101.251.68.133", strall, "SysCommentLog");
                                //2.5、调用分数占比统计方法
                                bool i = clsSysCommentBLEx.AddWeightViewpointTotal(strUserId, stridCurrEduCls, UpdUser, fScore);
                                //bool i = RevalidationViewpointTotal(strUserId, stridCurrEduCls, UpdUser, fScore, resultNum);
                                if (i == true)
                                {
                                    bolResult = true;


                                    WriteTextLog("101.251.68.133", strall, "SysCommentLog");

                                }
                                else
                                {


                                    WriteTextLog("101.251.68.133", strall, "SysCommentLog");
                                    bolResult = false;
                                }
                            }
                        }

                        #endregion


                    }

                }
                else
                {
                    bolResult = false;
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
            return bolResult;
        }

        //各个观点总占比分用户，教学班、编辑用户，分数，最高分的占比值；
        public static bool RevalidationViewpointTotal(string strTypeUserId, string strCurrEduId, string strUserId, float ViewpointScore, float fNum)
        {
            #region 参数
            bool result = false;
            //float ViewpointScore = 0;//个观点占比分数总计；
            #endregion

            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                //除以100；按百分比 换算
                float resultNum = fNum;

                //通过用户得到当前用户观点的统计数据 0009 代表当前用户的观点统计分
                // clsSysScoreSummaryEN objViewpontNum = clsSysScoreSummaryBL.GetFirstObj_S("UserId ='" + strTypeUserId + "' And ScoreTypeId='0009'");
                if (ViewpointScore != 0)
                {
                    ////1,得到用户当前总分
                    //ViewpointScore = objViewpontNum.Score;
                    //2、得到换算分数(当前用户总分---除以-----最高分的换算值---乘以--- 各观点权重比=当前用户观点的占比分)
                    float resultViewpointScore = ViewpointScore / resultNum;
                    //3、得到观点权重
                    string strViewpointRatio = GetScoreWeightbyWhere(strCurrEduId, "0019");
                    //4、换算后的结果 --乘以-- 各个观点占比的权重 得到最终的各个观点统计分 0019(各观点总权重比乘以百分比0.01)
                    float fViewpointTotal = resultViewpointScore * (float.Parse(strViewpointRatio) * 0.01f);

                    //如果大于权重比分，那么则取整、否则就保留小数点后2位
                    Double ScoreTotal;
                    //向下取整 //字符串去掉小数点后取整数
                    if (fViewpointTotal >= float.Parse(strViewpointRatio))
                    {
                        ScoreTotal = Math.Floor(Convert.ToDouble(fViewpointTotal));//取整
                    }
                    else
                    {
                        ScoreTotal = Math.Round(fViewpointTotal, 2);//保留2位小数；
                    }


                    //通过用户得到 各观点总占比分 0019
                    clsSysScoreSummaryEN objWeightViewpontNum = clsSysScoreSummaryBL.GetFirstObj_S("UserId ='" + strTypeUserId + "' And ScoreTypeId='0019'");
                    if (objWeightViewpontNum != null)
                    {
                        objWeightViewpontNum.Score = float.Parse(ScoreTotal.ToString());
                        objWeightViewpontNum.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objWeightViewpontNum);
                        if (bolResult == true)
                        {
                            //调用总分方法
                            GetTotalScore(strTypeUserId, strCurrEduId, strUserId);

                            result = true;
                        }
                        else
                        {
                            string strMsg = string.Format("AddWeightViewpointTotal统计分数修改数据失败");

                            result = false;
                        }
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
                        objNewSysScoreSummary.Score = fViewpointTotal;
                        objNewSysScoreSummary.ScoreTypeId = "0019";//各个观点总计分；
                        objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;//教学班Id；

                        //添加方法
                        bool i = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);

                        if (i == true)
                        {
                            //调用总分方法
                            GetTotalScore(strTypeUserId, strCurrEduId, strUserId);
                        }
                        else
                        {

                            string msgpaper = string.Format("统计各观点占比合计分失败");

                            dictParam.Add("AddWeightViewpointTotal", msgpaper);

                            result = false;
                        }
                    }


                }
                else
                {
                    //如果各观点总分 都为空了，那么就先不统计总分；
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




        #region 添加评论 统计各个观点分 总分

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
                string strCommentId = objSysCommentEN.AddNewRecordWithMaxId();



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

                                //必须是教师评分才统计
                                if (strScoreTypeId == "2")
                                {
                                    //判断传入的parendId 是否是root 如果是root 则是针对观点的评价、否则就是针对他人评价的评价；
                                    if (strParentId == "root")
                                    {
                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0001", strCommentTypeId, strCurrEduId, strUserId);

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
                                //必须是教师评分才统计
                                if (strScoreTypeId == "2")
                                {

                                    if (strParentId == "root")
                                    {
                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0002", strCommentTypeId, strCurrEduId, strUserId);

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
                                }
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
                                //必须是教师评分才统计
                                if (strScoreTypeId == "2")
                                {

                                    if (strParentId == "root")
                                    {
                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0003", strCommentTypeId, strCurrEduId, strUserId);

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
                                }
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
                                //必须是教师评分才统计
                                if (strScoreTypeId == "2")
                                {

                                    if (strParentId == "root")
                                    {
                                        //添加各个观点、概念 换算后的数据插入或修改； ---参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0004", strCommentTypeId, strCurrEduId, strUserId);

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
                                }
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
                                //必须是教师评分才统计
                                if (strScoreTypeId == "2")
                                {
                                    if (strParentId == "root")
                                    {

                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0005", strCommentTypeId, strCurrEduId, strUserId);

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

                                }
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
                                //必须是教师评分才统计
                                if (strScoreTypeId == "2")
                                {

                                    if (strParentId == "root")
                                    {
                                        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0006", strCommentTypeId, strCurrEduId, strUserId);

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

                                }
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
                    default:
                        string strMsg = string.Format("没有获得类型数据");

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
                    #region 注释
                    //switch (strCommentTypeId)
                    //{
                    //    case "01":

                    //        break;
                    //    case "02":
                    //        //论文子观点
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeight = GetScoreWeightbyWhere(strCurrEduId, "0002");
                    //        string ScoreWeight = (Convert.ToDouble(strScoreWeight) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScore = (Convert.ToDouble(ScoreWeight) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        //得到当前原有分数；
                    //        objSysScoreSummary.Score += float.Parse(strNowScore);
                    //        break;
                    //    case "03":
                    //        //个人观点
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeightviewpoint = GetScoreWeightbyWhere(strCurrEduId, "0003");
                    //        string ScoreWeightViewpoint = (Convert.ToDouble(strScoreWeightviewpoint) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScorevp = (Convert.ToDouble(ScoreWeightViewpoint) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        //得到当前原有分数；
                    //        objSysScoreSummary.Score += float.Parse(strNowScorevp);
                    //        break;
                    //    case "04":
                    //        //专家观点
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeightExpert = GetScoreWeightbyWhere(strCurrEduId, "0004");
                    //        string ScoreWeightExpert = (Convert.ToDouble(strScoreWeightExpert) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScoreEx = (Convert.ToDouble(ScoreWeightExpert) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        objSysScoreSummary.Score += float.Parse(strNowScoreEx);
                    //        break;
                    //    case "05":
                    //        //概念
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeightCon = GetScoreWeightbyWhere(strCurrEduId, "0005");
                    //        string ScoreWeightCon = (Convert.ToDouble(strScoreWeightCon) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScoreC = (Convert.ToDouble(ScoreWeightCon) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        objSysScoreSummary.Score += float.Parse(strNowScoreC);
                    //        break;
                    //    case "06":
                    //        //客观事实
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeightFact = GetScoreWeightbyWhere(strCurrEduId, "0006");
                    //        string ScoreWeightFact = (Convert.ToDouble(strScoreWeightFact) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScoreFt = (Convert.ToDouble(ScoreWeightFact) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        objSysScoreSummary.Score += float.Parse(strNowScoreFt);
                    //        break;
                    //    case "07":
                    //        //客观数据
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeightBasis = GetScoreWeightbyWhere(strCurrEduId, "0007");
                    //        string ScoreWeightBasis = (Convert.ToDouble(strScoreWeightBasis) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScoreB = (Convert.ToDouble(ScoreWeightBasis) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        objSysScoreSummary.Score += float.Parse(strNowScoreB);
                    //        break;
                    //    case "08":
                    //        //人员评分
                    //        string strScoreWeightUser = GetScoreWeightbyWhere(strCurrEduId, "0011");
                    //        string ScoreWeightuser = (Convert.ToDouble(strScoreWeightUser) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strPeopleScore = (Convert.ToDouble(ScoreWeightuser) * Convert.ToDouble(strScore)).ToString();
                    //        objSysScoreSummary.Score = float.Parse(strPeopleScore);
                    //        break;
                    //    default:
                    //        string strMsg = string.Format("没有获得类型数据");
                    //         
                    //        break;
                    //}
                    #endregion

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
                        //修改各个观点、概念分数后，需要计算占比分数
                        bool i = AddviewpointWeightScore(strTypeUserId, strCurrEduId, strScoreType, strCommentTypeId, strUserId, fScore);
                        if (i == true)
                        {
                            string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                            result = true;
                        }
                        else
                        {
                            string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                            result = false;
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

                    #region 注释老方法
                    //switch (strCommentTypeId)
                    //{
                    //    case "01":

                    //        break;
                    //    case "02":
                    //        //论文子观点
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeight = GetScoreWeightbyWhere(strCurrEduId, "0002");
                    //        string ScoreWeight = (Convert.ToDouble(strScoreWeight) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScore = (Convert.ToDouble(ScoreWeight) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        //得到当前原有分数；
                    //        objNewSysScoreSummary.Score = float.Parse(strNowScore);
                    //        objNewSysScoreSummary.ScoreTypeId = "0002";
                    //        break;
                    //    case "03":
                    //        //个人观点
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeightviewpoint = GetScoreWeightbyWhere(strCurrEduId, "0003");
                    //        string ScoreWeightViewpoint = (Convert.ToDouble(strScoreWeightviewpoint) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScorevp = (Convert.ToDouble(ScoreWeightViewpoint) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        //得到当前原有分数；
                    //        objNewSysScoreSummary.Score = float.Parse(strNowScorevp);
                    //        objNewSysScoreSummary.ScoreTypeId = "0003";
                    //        break;
                    //    case "04":
                    //        //专家观点
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeightExpert = GetScoreWeightbyWhere(strCurrEduId, "0004");
                    //        string ScoreWeightExpert = (Convert.ToDouble(strScoreWeightExpert) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScoreEx = (Convert.ToDouble(ScoreWeightExpert) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        objNewSysScoreSummary.Score = float.Parse(strNowScoreEx);
                    //        objNewSysScoreSummary.ScoreTypeId = "0004";
                    //        break;
                    //    case "05":
                    //        //概念
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeightCon = GetScoreWeightbyWhere(strCurrEduId, "0005");
                    //        string ScoreWeightCon = (Convert.ToDouble(strScoreWeightCon) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScoreC = (Convert.ToDouble(ScoreWeightCon) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        objNewSysScoreSummary.Score = float.Parse(strNowScoreC);
                    //        objNewSysScoreSummary.ScoreTypeId = "0005";
                    //        break;
                    //    case "06":
                    //        //客观事实
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeightFact = GetScoreWeightbyWhere(strCurrEduId, "0006");
                    //        string ScoreWeightFact = (Convert.ToDouble(strScoreWeightFact) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScoreFt = (Convert.ToDouble(ScoreWeightFact) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        objNewSysScoreSummary.Score = float.Parse(strNowScoreFt);
                    //        objNewSysScoreSummary.ScoreTypeId = "0006";
                    //        break;
                    //    case "07":
                    //        //客观数据
                    //        //得到换算数据；分值乘以权重比；
                    //        string strScoreWeightBasis = GetScoreWeightbyWhere(strCurrEduId, "0007");
                    //        string ScoreWeightBasis = (Convert.ToDouble(strScoreWeightBasis) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strNowScoreB = (Convert.ToDouble(ScoreWeightBasis) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                    //        objNewSysScoreSummary.Score = float.Parse(strNowScoreB);
                    //        objNewSysScoreSummary.ScoreTypeId = "0007";
                    //        break;
                    //    case "08":
                    //        //人员评分(获取人员占比分数)
                    //        string strScoreWeightUser = GetScoreWeightbyWhere(strCurrEduId, "0011");//权重占比
                    //        string ScoreWeightuser = (Convert.ToDouble(strScoreWeightUser) * 0.1).ToString();//按百分比所有要乘以0.1
                    //        string strPeopleScore = (Convert.ToDouble(ScoreWeightuser) * Convert.ToDouble(strScore)).ToString();
                    //        objNewSysScoreSummary.Score = float.Parse(strPeopleScore);
                    //        objNewSysScoreSummary.ScoreTypeId = "0009";//用户分数类型；
                    //        break;
                    //    default:
                    //        string strMsg = string.Format("没有获得类型数据");
                    //         
                    //        break;
                    //}

                    #endregion


                    #region 添加方法
                    //添加方法
                    bool i = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);
                    if (i == true)
                    {
                        //修改各个观点、概念分数后，需要计算占比分数
                        AddviewpointWeightScore(strTypeUserId, strCurrEduId, strScoreType, strCommentTypeId, strUserId, fScore);

                        string msgpaper = string.Format("各观点统计数据添加成功");

                        result = true;
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

        //各类型观点，人员占比分  --------------、概念分数 事实、数据，需要计算他们的占比分数（占比分数是从权重表取权重*按百分比所有要乘以0.1 *分数；得到结果）
        //参数；评分用户，班级、评论类型；编辑人,统计分
        public static bool AddviewpointWeightScore(string strTypeUserId, string strCurrEduId, string strScoreType, string strCommentTypeId, string strUserId, float fScore)
        {
            #region 参数
            bool result = false;
            string strWhere = string.Empty;
            //根据评论类型来或的不同的权重Id
            string strWeightScoreType = string.Empty;
            #endregion

            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {

                //声明接收的条件;
                switch (strCommentTypeId)
                {
                    case "01":

                        break;
                    case "02":
                        //论文子观点 0007是其他人员的评论
                        if (strScoreType == "0007")
                        {
                            strWeightScoreType = "0017";
                        }
                        else
                        {
                            strWeightScoreType = "0011";
                        }

                        ////得到换算数据；分值乘以权重比；


                        //string strScoreWeight = GetScoreWeightbyWhere(strCurrEduId, "0011");
                        //string ScoreWeight = (Convert.ToDouble(strScoreWeight) * 0.1).ToString();//按百分比所有要乘以0.1
                        //string strNowScore = (Convert.ToDouble(ScoreWeight) * Convert.ToDouble(fScore)).ToString();//分数乘以权重
                        ////得到当前原有分数；
                        //objNewSysScoreSummary.Score = float.Parse(strNowScore);
                        //objNewSysScoreSummary.ScoreTypeId = "0002";
                        break;
                    case "03":
                        //个人观点
                        if (strScoreType == "0007")
                        {
                            strWeightScoreType = "0017";
                        }
                        else
                        {
                            strWeightScoreType = "0012";
                        }

                        ////得到换算数据；分值乘以权重比；
                        //string strScoreWeightviewpoint = GetScoreWeightbyWhere(strCurrEduId, "0012");
                        //string ScoreWeightViewpoint = (Convert.ToDouble(strScoreWeightviewpoint) * 0.1).ToString();//按百分比所有要乘以0.1
                        //string strNowScorevp = (Convert.ToDouble(ScoreWeightViewpoint) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                        ////得到当前原有分数；
                        //objNewSysScoreSummary.Score = float.Parse(strNowScorevp);
                        //objNewSysScoreSummary.ScoreTypeId = "0003";
                        break;
                    case "04":
                        //专家观点
                        if (strScoreType == "0007")
                        {
                            strWeightScoreType = "0017";
                        }
                        else
                        {
                            strWeightScoreType = "0013";
                        }

                        ////得到换算数据；分值乘以权重比；
                        //string strScoreWeightExpert = GetScoreWeightbyWhere(strCurrEduId, "0013");
                        //string ScoreWeightExpert = (Convert.ToDouble(strScoreWeightExpert) * 0.1).ToString();//按百分比所有要乘以0.1
                        //string strNowScoreEx = (Convert.ToDouble(ScoreWeightExpert) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                        //objNewSysScoreSummary.Score = float.Parse(strNowScoreEx);
                        //objNewSysScoreSummary.ScoreTypeId = "0004";
                        break;
                    case "05":
                        //概念
                        if (strScoreType == "0007")
                        {
                            strWeightScoreType = "0017";
                        }
                        else
                        {
                            strWeightScoreType = "0014";
                        }

                        //得到换算数据；分值乘以权重比；
                        //string strScoreWeightCon = GetScoreWeightbyWhere(strCurrEduId, "0014");
                        //string ScoreWeightCon = (Convert.ToDouble(strScoreWeightCon) * 0.1).ToString();//按百分比所有要乘以0.1
                        //string strNowScoreC = (Convert.ToDouble(ScoreWeightCon) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                        //objNewSysScoreSummary.Score = float.Parse(strNowScoreC);
                        //objNewSysScoreSummary.ScoreTypeId = "0005";
                        break;
                    case "06":
                        //客观事实
                        if (strScoreType == "0007")
                        {
                            strWeightScoreType = "0017";
                        }
                        else
                        {
                            strWeightScoreType = "0015";
                        }

                        ////得到换算数据；分值乘以权重比；
                        //string strScoreWeightFact = GetScoreWeightbyWhere(strCurrEduId, "0015");
                        //string ScoreWeightFact = (Convert.ToDouble(strScoreWeightFact) * 0.1).ToString();//按百分比所有要乘以0.1
                        //string strNowScoreFt = (Convert.ToDouble(ScoreWeightFact) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                        //objNewSysScoreSummary.Score = float.Parse(strNowScoreFt);
                        //objNewSysScoreSummary.ScoreTypeId = "0006";
                        break;
                    case "07":
                        //客观数据
                        if (strScoreType == "0007")
                        {
                            strWeightScoreType = "0017";
                        }
                        else
                        {
                            strWeightScoreType = "0016";
                        }

                        ////得到换算数据；分值乘以权重比；
                        //string strScoreWeightBasis = GetScoreWeightbyWhere(strCurrEduId, "0016");
                        //string ScoreWeightBasis = (Convert.ToDouble(strScoreWeightBasis) * 0.1).ToString();//按百分比所有要乘以0.1
                        //string strNowScoreB = (Convert.ToDouble(ScoreWeightBasis) * Convert.ToDouble(strScore)).ToString();//分数乘以权重
                        //objNewSysScoreSummary.Score = float.Parse(strNowScoreB);
                        //objNewSysScoreSummary.ScoreTypeId = "0007";
                        break;
                    case "08":
                        //人员评分(获取人员占比分数)
                        strWeightScoreType = "0018";

                        //string strScoreWeightUser = GetScoreWeightbyWhere(strCurrEduId, "0018");//权重占比
                        //string ScoreWeightuser = (Convert.ToDouble(strScoreWeightUser) * 0.1).ToString();//按百分比所有要乘以0.1
                        //string strPeopleScore = (Convert.ToDouble(ScoreWeightuser) * Convert.ToDouble(strScore)).ToString();
                        //objNewSysScoreSummary.Score = float.Parse(strPeopleScore);
                        //objNewSysScoreSummary.ScoreTypeId = "0009";//用户分数类型；
                        break;
                    case "09":
                        //技能
                        if (strScoreType == "0007")
                        {
                            strWeightScoreType = "0017";
                        }
                        else
                        {
                            strWeightScoreType = "0022";
                        }

                        //string strScoreWeightUser = GetScoreWeightbyWhere(strCurrEduId, "0018");//权重占比
                        //string ScoreWeightuser = (Convert.ToDouble(strScoreWeightUser) * 0.1).ToString();//按百分比所有要乘以0.1
                        //string strPeopleScore = (Convert.ToDouble(ScoreWeightuser) * Convert.ToDouble(strScore)).ToString();
                        //objNewSysScoreSummary.Score = float.Parse(strPeopleScore);
                        //objNewSysScoreSummary.ScoreTypeId = "0009";//用户分数类型；
                        break;
                    case "10":
                        //社会关系
                        if (strScoreType == "0007")
                        {
                            strWeightScoreType = "0017";
                        }
                        else
                        {
                            strWeightScoreType = "0024";
                        }

                        //string strScoreWeightUser = GetScoreWeightbyWhere(strCurrEduId, "0018");//权重占比
                        //string ScoreWeightuser = (Convert.ToDouble(strScoreWeightUser) * 0.1).ToString();//按百分比所有要乘以0.1
                        //string strPeopleScore = (Convert.ToDouble(ScoreWeightuser) * Convert.ToDouble(strScore)).ToString();
                        //objNewSysScoreSummary.Score = float.Parse(strPeopleScore);
                        //objNewSysScoreSummary.ScoreTypeId = "0009";//用户分数类型；
                        break;
                    default:
                        string strMsg = string.Format("没有获得类型数据");

                        break;
                }

                #region 权重换算
                //得到权重比
                string strScoreWeight = GetScoreWeightbyWhere(strCurrEduId, strWeightScoreType);
                //按百分比所有要乘以0.1
                string ScoreWeight = (Convert.ToDouble(strScoreWeight) * 0.1).ToString();
                //计算分数占比
                string strNowScore = (Convert.ToDouble(ScoreWeight) * Convert.ToDouble(fScore)).ToString();//分数乘以权重

                #endregion

                //通过用户Id 和评分类型查询得到 占比分数实体，如果有则修改、 没有则插入；
                clsSysScoreSummaryEN objSysScoreSummary = clsSysScoreSummaryBL.GetFirstObj_S("UserId= '" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId='" + strWeightScoreType + "'");
                if (objSysScoreSummary != null)
                {
                    #region 修改
                    objSysScoreSummary.Score = float.Parse(strNowScore);
                    objSysScoreSummary.ScoreTypeId = strWeightScoreType;//当前的分数的占比类型；
                    fScore = objSysScoreSummary.Score ?? 0;
                    objSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objSysScoreSummary);
                    if (bolResult == true)
                    {
                        //这个地方判断评论类型、如果是用户，那么直接去调取 统计总分方法、如果是各个观点占比分，那么则需要 调用统计各个观点的总分方法；
                        if (strCommentTypeId == "08")
                        {
                            // 直接调用统计总分方法；
                            bool i = GetTotalScore(strTypeUserId, strCurrEduId, strUserId);
                            if (i == true)
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        else
                        {
                            //调用统计各个观点的总分统计方法
                            bool i = AddViewpointTotal(strTypeUserId, strCurrEduId, strUserId);
                            if (i == true)
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                            }
                        }

                    }
                    else
                    {
                        string strMsg = string.Format("AddviewpointWeightScore统计分数修改数据失败");

                        result = false;
                    }
                    #endregion
                }
                else
                {
                    #region 添加
                    //添加；
                    clsSysScoreSummaryEN objNewSysScoreSummary = new clsSysScoreSummaryEN();
                    //SchoolYear 学年
                    objNewSysScoreSummary.SchoolYear = GetSchoolYearbyNow();
                    objNewSysScoreSummary.UserId = strTypeUserId;
                    objNewSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewSysScoreSummary.UpdUser = strUserId;
                    objNewSysScoreSummary.Score = float.Parse(strNowScore);//分数；
                    objNewSysScoreSummary.ScoreTypeId = strWeightScoreType;//类型
                    objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;//教学班Id；
                    //用户传值用；
                    fScore = objNewSysScoreSummary.Score ?? 0;

                    //添加方法
                    bool resultbool = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);
                    if (resultbool == true)
                    {
                        //这个地方判断评论类型、如果是用户，那么直接去调取 统计总分方法、如果是各个观点占比分，那么则需要 调用统计各个观点的总分方法；
                        if (strCommentTypeId == "08")
                        {
                            // 直接调用统计总分方法；
                            bool i = GetTotalScore(strTypeUserId, strCurrEduId, strUserId);
                            if (i == true)
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        else
                        {
                            //调用统计各个观点的总分统计方法
                            bool i = AddViewpointTotal(strTypeUserId, strCurrEduId, strUserId);
                            if (i == true)
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        string msgpaper = string.Format("各个观点占比分添加成功");


                    }
                    else
                    {

                        string msgpaper = string.Format("各个观点占比分添加失败");


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
                List<clsSysScoreSummaryEN> objList = clsSysScoreSummaryBL.GetObjLst("UserId= '" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId in('0001','0002','0003','0004','0005','0006','0007','0021','0023')");

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
                        bool i = AddWeightViewpointTotal(strTypeUserId, strCurrEduId, strUserId, ViewpointScore);
                        if (i == true)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }


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
                        //调用统计各个观点的总分 占比分方法
                        bool i = AddWeightViewpointTotal(strTypeUserId, strCurrEduId, strUserId, ViewpointScore);
                        if (i == true)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    else
                    {

                        string msgpaper = string.Format("统计各观点合计分，总分失败");


                        result = false;
                    }
                }

                #region 注释
                ////通过观点总占比0010查询， 根据分数排序；
                //clsSysScoreSummaryEN objSysScoreSummaryOrderby = clsSysScoreSummaryBL.GetFirstObj_S(" 1=1 And ScoreTypeId='0010' order by score desc");
                ////取出排序最高的各个观点统计分数，然后换算；
                //float HighScore = objSysScoreSummaryOrderby.Score;
                ////除以100；得到数据最为权重数据乘以当前用户的 各个观点的统计数据 存入个观点总分数字段
                //float resultNum = HighScore / 100;

                ////通过当前用户得到各个数据相加统计；
                //fPaperSubviews = objSysScoreSummary.PaperSubviewsS;
                //fPersonalViews = objSysScoreSummary.PersonalViewsS;
                //fExpertViews = objSysScoreSummary.ExpertViewsS;
                //fConceptsS = objSysScoreSummary.ConceptsS;
                //fObjectiveFactsS = objSysScoreSummary.ObjectiveFactsS;
                //fObjectiveDataS = objSysScoreSummary.ObjectiveDataS;

                //fPersonnelRatioS = objSysScoreSummary.PersonnelRatioS;//人员占比分数



                ////1、得到合计分数
                //float totalViewpointScore = fPaperSubviews + fPersonalViews + fExpertViews + fConceptsS + fObjectiveFactsS + fObjectiveDataS;
                ////2、得到换算分数(当前用户总分---除以-----最高分的换算值---乘以--- 各观点权重比=当前用户观点的占比分)
                //float resultViewpointScore = totalViewpointScore / resultNum;
                ////3、换算后的结果 --乘以-- 各个观点占比的权重 得到最终的各个观点统计分 0010(各观点权重比)
                //string strViewpointRatio = GetScoreWeightbyWhere(strCurrEduId,"0010");
                //fViewpointRatioS = resultViewpointScore * float.Parse(strViewpointRatio);
                ////4、总分= 各个观点占比统计结果分+ 人员占比分
                //fTotalScore = fViewpointRatioS + fPersonnelRatioS;


                //objSysScoreSummary.ViewpointRatioS = fViewpointRatioS;
                //objSysScoreSummary.TotalScore = fTotalScore;

                //bool i = clsSysScoreSummaryBL.UpdateBySql2(objSysScoreSummary);
                //if (i == true)
                //{
                //    string msgpaper = string.Format("统计各观点合计分，总分成功");

                //    dictParam.Add("AddSysScoreSummaryTotalScore", msgpaper);
                //    clsPubFun_WebApi.Log4Debug(this, "AddSysScoreSummaryTotalScore", dictParam);
                //    result = true;
                //}
                //else
                //{

                //    string msgpaper = string.Format("统计各观点合计分，总分失败");

                //    dictParam.Add("AddSysScoreSummaryTotalScore", msgpaper);
                //    clsPubFun_WebApi.Log4Debug(this, "AddSysScoreSummaryTotalScore", dictParam);
                //    result = false;
                //}
                #endregion
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                result = false;

            }
            return result;
        }


        //各个观点总占比折算分 -----------------权重换算后的占比折算总分
        public static bool AddWeightViewpointTotal(string strTypeUserId, string strCurrEduId, string strUserId, float ViewpointScore)
        {
            #region 参数
            bool result = false;
            //float ViewpointScore = 0;//个观点占比分数总计；
            #endregion

            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                //通过观点0009查询（各观点总分）同时按照教学班数据来查询， 根据分数排序；得到最高分
                clsSysScoreSummaryEN objSysScoreSummaryOrderby = clsSysScoreSummaryBL.GetFirstObj_S(" 1=1 And ScoreTypeId='0009' And IdCurrEduCls='" + strCurrEduId + "' order by score desc");
                //取出排序最高的各个观点统计分数，然后换算；
                float HighScore = objSysScoreSummaryOrderby.Score ?? 0;
                //除以100；按百分比 换算
                float resultNum = HighScore / 100;

                //通过用户得到当前用户观点的统计数据 0009 代表当前用户的观点统计分
                // clsSysScoreSummaryEN objViewpontNum = clsSysScoreSummaryBL.GetFirstObj_S("UserId ='" + strTypeUserId + "' And ScoreTypeId='0009'");
                if (ViewpointScore != 0)
                {
                    ////1,得到用户当前总分
                    //ViewpointScore = objViewpontNum.Score;
                    //2、得到换算分数(当前用户总分---除以-----最高分的换算值---乘以--- 各观点权重比=当前用户观点的占比分)
                    float resultViewpointScore = ViewpointScore / resultNum;
                    //3、得到观点权重
                    string strViewpointRatio = GetScoreWeightbyWhere(strCurrEduId, "0019");


                    WriteTextLog("GetScoreWeightbyWhere", strViewpointRatio, "SysCommentLog");

                    //4、换算后的结果 --乘以-- 各个观点占比的权重 得到最终的各个观点统计分 0019(各观点总权重比乘以百分比0.01)
                    float fViewpointTotal = resultViewpointScore * (float.Parse(strViewpointRatio) * 0.01f);

                    //如果大于权重比分，那么则取整、否则就保留小数点后2位
                    Double ScoreTotal;
                    //向下取整 //字符串去掉小数点后取整数
                    if (fViewpointTotal >= float.Parse(strViewpointRatio))
                    {
                        ScoreTotal = Math.Floor(Convert.ToDouble(fViewpointTotal));//取整
                    }
                    else
                    {
                        ScoreTotal = Math.Round(fViewpointTotal, 2);//保留2位小数；
                    }
                    WriteTextLog("ScoreTotal", ScoreTotal.ToString(), "SysCommentLog");

                    //通过用户得到 各观点总占比分 0019
                    clsSysScoreSummaryEN objWeightViewpontNum = clsSysScoreSummaryBL.GetFirstObj_S("UserId ='" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId='0019'");
                    if (objWeightViewpontNum != null)
                    {
                        objWeightViewpontNum.Score = float.Parse(ScoreTotal.ToString());
                        objWeightViewpontNum.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        objWeightViewpontNum.UpdUser = strUserId;

                        WriteTextLog("objWeightViewpontNum", objWeightViewpontNum.Score.ToString(), "SysCommentLog");
                        bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objWeightViewpontNum);
                        if (bolResult == true)
                        {
                            //调用总分方法
                            bool i = GetTotalScore(strTypeUserId, strCurrEduId, strUserId);
                            if (i == true)
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                            }


                        }
                        else
                        {
                            string strMsg = string.Format("AddWeightViewpointTotal统计分数修改数据失败");

                            result = false;
                        }
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
                        objNewSysScoreSummary.Score = fViewpointTotal;
                        objNewSysScoreSummary.ScoreTypeId = "0019";//各个观点总计分；
                        objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;//教学班Id；

                        //添加方法
                        bool boolresult = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);

                        if (boolresult == true)
                        {
                            //调用总分方法
                            bool i = GetTotalScore(strTypeUserId, strCurrEduId, strUserId);
                            if (i == true)
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        else
                        {

                            string msgpaper = string.Format("统计各观点占比合计分失败");

                            result = false;
                        }
                    }


                }
                else
                {
                    //如果各观点总分 都为空了，那么就先不统计总分；
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                result = false;

            }
            return result;
        }

        //得到观点总占比计分，----------------（0010） 各个观点总占比权重 各个相加得到；
        public static bool GetTotalScore(string strTypeUserId, string strCurrEduId, string strUserId)
        {
            #region 参数
            bool result = false;
            float TotalScore = 0;//总计分；
            //float UserScore = 0;//用户分
            #endregion

            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                ////通过观点0009查询（各观点总分）， 根据分数排序；
                //clsSysScoreSummaryEN objSysScoreSummaryOrderby = clsSysScoreSummaryBL.GetFirstObj_S(" 1=1 And ScoreTypeId='0009' order by score desc");
                ////取出排序最高的各个观点统计分数，然后换算；
                //float HighScore = objSysScoreSummaryOrderby.Score;
                ////除以100；按百分比 换算
                //float resultNum = HighScore / 100;

                ////通过用户得到当前用户观点的统计数据 0009 代表当前用户的观点统计分
                //clsSysScoreSummaryEN objViewpontNum = clsSysScoreSummaryBL.GetFirstObj_S("UserId ='"+strTypeUserId+"' And ScoreTypeId='0009'");
                //if (objViewpontNum != null) {
                //    ViewpointScore = objViewpontNum.Score;
                //}
                //else { }
                //得到各个观点占比分 相加得到 占比总分；
                List<clsSysScoreSummaryEN> objList = clsSysScoreSummaryBL.GetObjLst("UserId ='" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId in('0011','0012','0013','0014','0015','0016','0017','0022','0024')");
                if (objList.Count > 0)
                {
                    foreach (clsSysScoreSummaryEN objUserScoreNum in objList)
                    {
                        //得到的用户分就是 计算权重后的分数，所以不用换算；
                        TotalScore += objUserScoreNum.Score ?? 0;
                    }
                }
                WriteTextLog("TotalScore", TotalScore.ToString(), "SysCommentLog");

                //通过用户 和 0010（总分类型）
                clsSysScoreSummaryEN objViewpontNum = clsSysScoreSummaryBL.GetFirstObj_S("UserId ='" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId='0010'");
                if (objViewpontNum != null)
                {
                    objViewpontNum.Score = TotalScore;
                    objViewpontNum.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objViewpontNum.UpdUser = strUserId;

                    bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objViewpontNum);

                    WriteTextLog("GetWeightTotalScore", "objViewpontNum数据大于0", "SysCommentLog");

                    if (bolResult == true)
                    {
                        //调用总分占比方法
                        bool i = GetWeightTotalScore(strTypeUserId, strCurrEduId, strUserId);

                        if (i == true)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }

                    }
                    else
                    {
                        string strMsg = string.Format("GetTotalScore统计分数修改数据失败");

                        result = false;
                    }
                }
                else
                {
                    // 添加；
                    clsSysScoreSummaryEN objNewSysScoreSummary = new clsSysScoreSummaryEN();

                    //SchoolYear 学年
                    objNewSysScoreSummary.SchoolYear = GetSchoolYearbyNow();
                    objNewSysScoreSummary.UserId = strTypeUserId;
                    objNewSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewSysScoreSummary.UpdUser = strUserId;
                    objNewSysScoreSummary.Score = TotalScore;
                    objNewSysScoreSummary.ScoreTypeId = "0010";//总计各个观点占比分；
                    objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;//教学班Id；

                    //添加方法
                    bool boolresult = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);

                    if (boolresult == true)
                    {
                        //调用总分 占比；
                        bool i = GetWeightTotalScore(strTypeUserId, strCurrEduId, strUserId);
                        if (i == true)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }

                    }
                    else
                    {
                        string msgpaper = string.Format("统计各观点占比总分失败");

                        result = false;
                    }
                }
                #region 注释
                ////2、得到换算分数(当前用户总分---除以-----最高分的换算值---乘以--- 各观点权重比=当前用户观点的占比分)
                //float resultViewpointScore = ViewpointScore / resultNum;
                ////3、换算后的结果 --乘以-- 各个观点占比的权重 得到最终的各个观点统计分 0010(各观点权重比)
                //string strViewpointRatio = GetScoreWeightbyWhere(strCurrEduId, "0010");
                //float fViewpointTotal = resultViewpointScore * float.Parse(strViewpointRatio);
                //4、总分= 各个观点占比统计结果分+ 人员占比分
                //float fTotalScore = fViewpointTotal + UserScore;
                #endregion
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                result = false;

            }
            return result;
        }
        #region 注释
        ////得到总计分，----------------通过排序查询总分字段取最高分，换算百分比后，乘以对应的权重，得到分数；, （0010） 各个观点总占比权重
        //public bool GetTotalScore(string strTypeUserId, string strCurrEduId, string strUserId) {
        //    #region 参数
        //    bool result = false;
        //    float TotalScore = 0;//总计分；
        //    float UserScore = 0;//用户分
        //    #endregion

        //    Dictionary<string, string> dictParam = new Dictionary<string, string>();
        //    try
        //    {
        //        ////通过观点0009查询（各观点总分）， 根据分数排序；
        //        //clsSysScoreSummaryEN objSysScoreSummaryOrderby = clsSysScoreSummaryBL.GetFirstObj_S(" 1=1 And ScoreTypeId='0009' order by score desc");
        //        ////取出排序最高的各个观点统计分数，然后换算；
        //        //float HighScore = objSysScoreSummaryOrderby.Score;
        //        ////除以100；按百分比 换算
        //        //float resultNum = HighScore / 100;

        //        ////通过用户得到当前用户观点的统计数据 0009 代表当前用户的观点统计分
        //        //clsSysScoreSummaryEN objViewpontNum = clsSysScoreSummaryBL.GetFirstObj_S("UserId ='"+strTypeUserId+"' And ScoreTypeId='0009'");
        //        //if (objViewpontNum != null) {
        //        //    ViewpointScore = objViewpontNum.Score;
        //        //}
        //        //else { }
        //        //得到用户 0008 代表用户分；0009代表个观点总分；
        //        List<clsSysScoreSummaryEN> objList = clsSysScoreSummaryBL.GetObjLst("UserId ='" + strTypeUserId + "' And ScoreTypeId in('0008','0009')");
        //        if (objList.Count > 0)
        //        {
        //            foreach (clsSysScoreSummaryEN objUserScoreNum in objList)
        //            {
        //                //得到的用户分就是 计算权重后的分数，所以不用换算；
        //                TotalScore += objUserScoreNum.Score;
        //            }
        //        }

        //        //通过用户 和 0010（总分类型）
        //        clsSysScoreSummaryEN objViewpontNum = clsSysScoreSummaryBL.GetFirstObj_S("UserId ='" + strTypeUserId + "' And ScoreTypeId='0010'");
        //        if (objViewpontNum != null)
        //        {
        //            objViewpontNum.Score = TotalScore;
        //            objViewpontNum.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        //            bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objViewpontNum);
        //            if (bolResult == true)
        //            {
        //                //调用总分占比方法
        //                GetWeightTotalScore(strTypeUserId, strCurrEduId, strUserId);

        //                result = true;
        //            }
        //            else
        //            {
        //                string strMsg = string.Format("GetTotalScore统计分数修改数据失败");
        //                 
        //                result = false;
        //            }
        //        }
        //        else {
        //            // 添加；
        //            clsSysScoreSummaryEN objNewSysScoreSummary = new clsSysScoreSummaryEN();

        //            //SchoolYear 学年
        //            objNewSysScoreSummary.SchoolYear = GetSchoolYearbyNow();
        //            objNewSysScoreSummary.UserId = strTypeUserId;
        //            objNewSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //            objNewSysScoreSummary.UpdUser = strUserId;
        //            objNewSysScoreSummary.Score = TotalScore;
        //            objNewSysScoreSummary.ScoreTypeId = "0010";//总计分；
        //            objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;//教学班Id；

        //            //添加方法
        //            bool i = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);

        //            if (i == true)
        //            {
        //                //调用总分 占比；
        //                GetWeightTotalScore(strTypeUserId,strCurrEduId,strUserId);
        //                result = true;
        //            }
        //            else
        //            {
        //                string msgpaper = string.Format("统计合计分，总分失败");
        //                dictParam.Add("GetTotalScore", msgpaper);
        //                clsPubFun_WebApi.Log4Debug(this, "GetTotalScore", dictParam);
        //                result = false;
        //            }
        //        }
        //        #region 注释
        //        ////2、得到换算分数(当前用户总分---除以-----最高分的换算值---乘以--- 各观点权重比=当前用户观点的占比分)
        //        //float resultViewpointScore = ViewpointScore / resultNum;
        //        ////3、换算后的结果 --乘以-- 各个观点占比的权重 得到最终的各个观点统计分 0010(各观点权重比)
        //        //string strViewpointRatio = GetScoreWeightbyWhere(strCurrEduId, "0010");
        //        //float fViewpointTotal = resultViewpointScore * float.Parse(strViewpointRatio);
        //        //4、总分= 各个观点占比统计结果分+ 人员占比分
        //        //float fTotalScore = fViewpointTotal + UserScore;
        //        #endregion
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
        // 
        //        result = false;

        //    }
        //    return result;
        //}
        #endregion

        //得到总计占比分，----------------通过排序查询总分字段取最高分，换算百分比后，乘以对应的权重，得到分数；, （0010） 各个观点总占比权重
        public static bool GetWeightTotalScore(string strTypeUserId, string strCurrEduId, string strUserId)
        {
            #region 参数
            bool result = false;
            float WeightTotalScore = 0;//总计占比分；
            //float UserScore = 0;//用户分
            #endregion

            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                // 得到用户 018 代表用户分；0019代表个观点总分；
                List<clsSysScoreSummaryEN> objList = clsSysScoreSummaryBL.GetObjLst("UserId ='" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId in('0018','0019')");
                if (objList.Count > 0)
                {
                    foreach (clsSysScoreSummaryEN objUserScoreNum in objList)
                    {
                        //得到的用户分就是 计算权重后的分数，所以不用换算；
                        WeightTotalScore += objUserScoreNum.Score ?? 0;
                    }
                    WriteTextLog("TotalScore", WeightTotalScore.ToString(), "SysCommentLog");

                }

                //通过用户 和 0010（总分类型）
                clsSysScoreSummaryEN objViewpontNum = clsSysScoreSummaryBL.GetFirstObj_S("UserId ='" + strTypeUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId='0020'");
                if (objViewpontNum != null)
                {
                    objViewpontNum.Score = WeightTotalScore;
                    objViewpontNum.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objViewpontNum.UpdUser = strUserId;

                    bool bolResult = clsSysScoreSummaryBL.UpdateBySql2(objViewpontNum);
                    if (bolResult == true)
                    {
                        WriteTextLog("TotalScore", "统计占比合计分成功", "SysCommentLog");
                        result = true;
                    }
                    else
                    {
                        WriteTextLog("TotalScore", "统计占比合计分失败", "SysCommentLog");
                        string strMsg = string.Format("统计占比合计分失败");

                        result = false;
                    }
                }
                else
                {
                    // 添加；
                    clsSysScoreSummaryEN objNewSysScoreSummary = new clsSysScoreSummaryEN();

                    //SchoolYear 学年
                    objNewSysScoreSummary.SchoolYear = GetSchoolYearbyNow();
                    objNewSysScoreSummary.UserId = strTypeUserId;
                    objNewSysScoreSummary.UpdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    objNewSysScoreSummary.UpdUser = strUserId;
                    objNewSysScoreSummary.Score = WeightTotalScore;
                    objNewSysScoreSummary.ScoreTypeId = "0020";//占比总计分；
                    objNewSysScoreSummary.IdCurrEduCls = strCurrEduId;//教学班Id；

                    //添加方法
                    bool i = clsSysScoreSummaryBL.AddNewRecordBySql2(objNewSysScoreSummary);

                    if (i == true)
                    {
                        result = true;
                    }
                    else
                    {
                        string msgpaper = string.Format("统计占比合计分失败");


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



        //通过教学班Id和类型 作为条件得到权重比
        public static string GetScoreWeightbyWhere(string strCurrEduId, string strScoreTypeId)
        {

            string strsWeight = string.Empty;
            try
            {
                //1.通过教学班和权重类型来查询 权重表是否存在此记录，如果存在则获取，没有存在，那么则查询公开的ispublic 权重数据；
                clsvSysScoreWeightEN objCurrEduStu = clsvSysScoreWeightBL.GetFirstObj_S("IdCurrEduCls='" + strCurrEduId + "' And ScoreTypeId='" + strScoreTypeId + "'");
                if (objCurrEduStu != null)
                {
                    strsWeight = objCurrEduStu.ScoreWeightValue;//权重值
                }
                else
                {
                    //查询公开数据
                    clsvSysScoreWeightEN objCurrEduStuPublic = clsvSysScoreWeightBL.GetFirstObj_S("IsPublic='true' And ScoreTypeId='" + strScoreTypeId + "'");
                    if (objCurrEduStuPublic != null)
                    {
                        strsWeight = objCurrEduStuPublic.ScoreWeightValue;//权重值
                    }
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());


            }

            return strsWeight;
        }


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
                strSchoolYear = (Convert.ToInt32(strSchoolYear) - 1).ToString();
            }

            return strSchoolYear;
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



        #region 几个表的数据修改
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


        #endregion

        #endregion




        #region 权重表修改，总分统计计算；
        //如果更改了权重，那么需要重新统计下各个学生的分数统计；
        /// <summary>
        /// 通过JSON对象来修改记录对象
        /// 调用方法: Post /api/SysScoreWeightApi/UpdateRecord
        /// 在Body区传输objSysScoreWeightEN的JSON对象
        /// (AutoGCLib.WA_Srv4CSharp:Gen_UpdateRecord)
        /// </summary>
        /// <param name = "strSysScoreWeightJSONObj">JSON对象字符串</param>
        /// <returns>是否成功</returns>

        public static bool UpdateRecord(clsSysScoreWeightEN objSysScoreWeightEN)
        {
            bool result = false;
            try
            {
                clsSysScoreWeightBL.SetUpdFlag(objSysScoreWeightEN);
                bool bolResult = objSysScoreWeightEN.Update();
                if (bolResult == true)
                {
                    //1.通过对象得到教学班和权限比重类型
                    string stridCurrEduCls = string.Empty;
                    string strScoreTypeID = string.Empty;
                    string strScoreWeightValue = string.Empty;//权重比
                    //float fScore = 0;//存放分值
                    string strUpdUser = string.Empty;

                    stridCurrEduCls = objSysScoreWeightEN.IdCurrEduCls;
                    strScoreTypeID = objSysScoreWeightEN.ScoreTypeId;
                    strScoreWeightValue = objSysScoreWeightEN.ScoreWeightValue;
                    strUpdUser = objSysScoreWeightEN.UpdUser;

                    //如果教学班不为空，则去查询分数统计表该下教学班下面的学生数据，如果为空则查询教学班下面为空的教学班学生数据

                    bool i = GetStuScore(stridCurrEduCls, strScoreTypeID, strScoreWeightValue, strUpdUser);
                    if (i == true)
                    {
                        string strMsg = string.Format("GetStuScore更新成功");

                        result = true;

                    }
                    else
                    {
                        string strMsg = string.Format("GetStuScore更新失败");

                        result = false;
                    }

                }
                else
                {
                    string strMsg = string.Format("修改记录失败!({0})", clsStackTrace.GetCurrClassFunction());

                    result = false;
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());


                result = false;

            }
            return result;
        }

        //通过分数权重表得到教学班后 通过教学班得到学生数据；或者教学班为空，查询没有教学班的学生数据
        public static bool GetStuScore(string stridCurrEduCls, string strScoreTypeId, string strScoreWeightValue, string strUpdUser)
        {
            #region 参数
            bool bolResult = false;
            float ViewpointScore = 0;//存放分值；
            string strScoreType = string.Empty;
            #endregion
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                //如果教学班不为空，则去查询分数统计表该下教学班下面的学生数据，如果为空则查询教学班下面为空的教学班学生数据
                if (string.IsNullOrEmpty(stridCurrEduCls) == false)
                {
                    //通过教学班和权重类型得到学生分数数据；
                    string strWhere = "IdCurrEduCls='" + stridCurrEduCls + "' And ScoreTypeId='" + strScoreTypeId + "'";
                    List<clsSysScoreSummaryEN> ArrList = clsSysScoreSummaryBL.GetObjLst(strWhere);
                    //循环数据对象
                    foreach (clsSysScoreSummaryEN objSysScoreSummaryEN in ArrList)
                    {
                        //2.4得到用户分数 和教学班Id .用户Id；评分类型；
                        //float fScore = 0;
                        string strUserId = string.Empty;



                        strScoreType = objSysScoreSummaryEN.ScoreTypeId;
                        //根据权重类型得到评分类型数据，用户数据换算；得到占比分值
                        ViewpointScore = GetScorebyScoreTypeId(strUserId, strScoreType, stridCurrEduCls, strScoreWeightValue);

                        objSysScoreSummaryEN.Score = ViewpointScore;
                        objSysScoreSummaryEN.UpdUser = strUpdUser;
                        //更新
                        bool boolresult = clsSysScoreSummaryBL.UpdateBySql2(objSysScoreSummaryEN);
                        if (boolresult == true)
                        {

                            //这里调用通过数据评分类型，然后区分看调用哪个统计方法；
                            bool i = GetNewScoreTypeByScoreTypeId(strUserId, strScoreTypeId, stridCurrEduCls, strUpdUser);
                            if (i == true)
                            {
                                bolResult = true;
                            }
                            else
                            {
                                bolResult = false;
                            }
                        }
                        else
                        {
                            string strMsg = string.Format("UpdateBySql2更新失败");
                            bolResult = false;
                        }


                    }

                }
                else
                {
                    //

                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                bolResult = false;

            }
            return bolResult;
        }

        //通过评分类型和教学班来查询得到对应的数据，换算得到占比分；用来修改当前得到的数据；
        public static float GetScorebyScoreTypeId(string strUserId, string strScoreTypeId, string strCurrEduId, string strScoreWeightValue)
        {
            #region 参数
            //获取评分类型数据
            string strNewScoreTypeId = string.Empty;
            string strNewScoreWeightValue = string.Empty;//转换百分比后的权重
            string strWhere = "";
            float ViewpointScore = 0;//
            #endregion
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                //通过类型判断调用不同的表数据；
                switch (strScoreTypeId)
                {
                    case "0011":
                        //论文子观点
                        strNewScoreTypeId = "0001";
                        strNewScoreWeightValue = (Convert.ToDouble(strScoreWeightValue) * 0.1).ToString();
                        break;
                    case "0012":
                        //个人观点
                        strNewScoreTypeId = "0002";
                        strNewScoreWeightValue = (Convert.ToDouble(strScoreWeightValue) * 0.1).ToString();
                        break;
                    case "0013":
                        //专家观点
                        strNewScoreTypeId = "0003";
                        strNewScoreWeightValue = (Convert.ToDouble(strScoreWeightValue) * 0.1).ToString();
                        break;
                    case "0014":
                        //概念
                        strNewScoreTypeId = "0004";
                        strNewScoreWeightValue = (Convert.ToDouble(strScoreWeightValue) * 0.1).ToString();
                        break;
                    case "0015":
                        //客观事实
                        strNewScoreTypeId = "0005";
                        strNewScoreWeightValue = (Convert.ToDouble(strScoreWeightValue) * 0.1).ToString();
                        break;
                    case "0016":
                        //客观数据
                        strNewScoreTypeId = "0006";
                        strNewScoreWeightValue = (Convert.ToDouble(strScoreWeightValue) * 0.1).ToString();
                        break;
                    case "0017":
                        //他人评价
                        strNewScoreTypeId = "0007";
                        strNewScoreWeightValue = (Convert.ToDouble(strScoreWeightValue) * 0.1).ToString();
                        break;
                    case "0018":
                        //用户占比
                        strNewScoreTypeId = "0008";
                        strNewScoreWeightValue = (Convert.ToDouble(strScoreWeightValue) * 0.1).ToString();
                        break;
                    case "0019":
                        //个观点占比
                        strNewScoreTypeId = "0009";
                        strNewScoreWeightValue = (Convert.ToDouble(strScoreWeightValue) * 0.01).ToString();
                        break;
                    //case "0020":
                    //    //总分占比
                    //    strNewScoreTypeId = "0010";
                    //    strNewScoreWeightValue = (Convert.ToDouble(strScoreWeightValue) * 0.01).ToString();
                    //    break;
                    default:
                        string strMsg = string.Format("没有获得类型数据");

                        break;
                }
                if (string.IsNullOrEmpty(strNewScoreTypeId) == false)
                {
                    //通过用户 、教学班和评分类型 得到一条数据
                    strWhere = "UserId='" + strUserId + "' And ScoreTypeId='" + strNewScoreTypeId + "' And IdCurrEduCls='" + strCurrEduId + "'";
                    clsSysScoreSummaryEN obj = clsSysScoreSummaryBL.GetFirstObj_S(strWhere);
                    if (obj != null)
                    {
                        //换算占比分
                        ViewpointScore = obj.Score ?? 0 * float.Parse(strNewScoreWeightValue);

                    }
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());

                return 0;

            }
            return ViewpointScore;
        }

        //通过权重类型来获取评分类型方法
        public static bool GetNewScoreTypeByScoreTypeId(string strUserId, string strScoreTypeId, string strCurrEduId, string strUpdUser)
        {
            #region 参数
            bool result = false;
            //获取评分类型数据
            string strNewScoreTypeId = string.Empty;

            #endregion
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                //通过类型判断调用不同的表数据；
                switch (strScoreTypeId)
                {
                    case "0011":
                        //论文子观点
                        strNewScoreTypeId = "0001";
                        AddViewpointTotal(strUserId, strCurrEduId, strUpdUser);
                        break;
                    case "0012":
                        //个人观点
                        strNewScoreTypeId = "0002";
                        AddViewpointTotal(strUserId, strCurrEduId, strUpdUser);
                        break;
                    case "0013":
                        //专家观点
                        strNewScoreTypeId = "0003";
                        AddViewpointTotal(strUserId, strCurrEduId, strUpdUser);
                        break;
                    case "0014":
                        //概念
                        strNewScoreTypeId = "0004";
                        AddViewpointTotal(strUserId, strCurrEduId, strUpdUser);
                        break;
                    case "0015":
                        //客观事实
                        strNewScoreTypeId = "0005";
                        AddViewpointTotal(strUserId, strCurrEduId, strUpdUser);
                        break;
                    case "0016":
                        //客观数据
                        strNewScoreTypeId = "0006";
                        AddViewpointTotal(strUserId, strCurrEduId, strUpdUser);
                        break;
                    case "0017":
                        //他人评价
                        strNewScoreTypeId = "0007";
                        AddViewpointTotal(strUserId, strCurrEduId, strUpdUser);
                        break;
                    case "0018":
                        //用户占比
                        strNewScoreTypeId = "0008";
                        // 直接调用统计总分方法；
                        GetTotalScore(strUserId, strCurrEduId, strUpdUser);
                        break;
                    case "0019":
                        //个观点占比
                        strNewScoreTypeId = "0009";
                        // 直接调用统计总分方法；
                        GetTotalScore(strUserId, strCurrEduId, strUpdUser);
                        break;
                    //case "0020":
                    //    //总分占比
                    //    strNewScoreTypeId = "0010";
                    //    break;
                    default:
                        string strMsg = string.Format("没有获得类型数据");

                        break;
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




        #region 个人分数核算         20200603


        //通过用户Id 评论类型；以及 是否教师评论  和教学班 得到用户评论类型 汇总分数 
        public static int GetUserScore(string strUserId, string strCommentTypeId, string strCurrEduId, string strParentId)
        {
            int iScore = 0;
            try
            {
                //通过strParentId查询不是root 和root 数据；
                if (strParentId == "root")
                {
                    string strwhere = "UserId= '" + strUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And CommentTypeId='" + strCommentTypeId + "' And ParentId = 'root' AND ScoreType = '2'";
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
                    string strwhere = "UserId= '" + strUserId + "' And IdCurrEduCls='" + strCurrEduId + "' And ParentId <> 'root' AND ScoreType = '2'";
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

                        break;
                    case "02":

                        #region //论文子观点
                        clsPaperSubViewpointEN objsubviewpoint = clsPaperSubViewpointBL.GetObjBySubViewpointId(long.Parse(strTableKeyId));

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
                                #region 注释
                                ////必须是教师评分才统计
                                //if (strScoreTypeId == "2")
                                //{
                                //    //判断传入的parendId 是否是root 如果是root 则是针对观点的评价、否则就是针对他人评价的评价；
                                //    if (strParentId == "root")
                                //    {
                                //        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0001", strCommentTypeId, strCurrEduId, strUserId);

                                //        if (blpsi == true)
                                //        {
                                //            string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                //            result = true;
                                //        }
                                //        else
                                //        {
                                //            string msg = string.Format("论文子观点表数据失败");
                                //            result = false;
                                //        }
                                //    }
                                //    else
                                //    {
                                //        //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                //        clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                //        if (objSysment != null)
                                //        {
                                //            strTypeUser = objSysment.UpdUser;

                                //            //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //            bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                //            if (blpsi == true)
                                //            {
                                //                string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                //                result = true;
                                //            }
                                //            else
                                //            {
                                //                string msg = string.Format("论文子观点表数据更新失败");
                                //                result = false;
                                //            }
                                //        }

                                //    }

                                //}
                                #endregion

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
                                #region  注释
                                ////必须是教师评分才统计
                                //if (strScoreTypeId == "2")
                                //{

                                //    if (strParentId == "root")
                                //    {
                                //        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0002", strCommentTypeId, strCurrEduId, strUserId);

                                //        if (blpsi == true)
                                //        {
                                //            string msg = string.Format("个人观点表数据更新完成，统计数据完成");
                                //            result = true;

                                //        }
                                //        else
                                //        {
                                //            string msg = string.Format("个人观点统计数据失败");
                                //            result = false;

                                //        }
                                //    }
                                //    else
                                //    {
                                //        //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                //        clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                //        if (objSysment != null)
                                //        {
                                //            strTypeUser = objSysment.UpdUser;

                                //            //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //            bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                //            if (blpsi == true)
                                //            {
                                //                string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                //                result = true;
                                //            }
                                //            else
                                //            {
                                //                string msg = string.Format("论文子观点表数据更新失败");
                                //                result = false;
                                //            }
                                //        }

                                //    }
                                //}
                                #endregion


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
                                #region 注释
                                //必须是教师评分才统计
                                //if (strScoreTypeId == "2")
                                //{

                                //    if (strParentId == "root")
                                //    {
                                //        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0003", strCommentTypeId, strCurrEduId, strUserId);

                                //        if (blpsi == true)
                                //        {
                                //            string msg = string.Format("专家观点表数据更新完成，统计数据完成,评分统计完成");
                                //            result = true;
                                //        }
                                //        else
                                //        {
                                //            string msg = string.Format("专家观点评分统计数据失败");
                                //            result = false;
                                //        }
                                //    }
                                //    else
                                //    {
                                //        //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                //        clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                //        if (objSysment != null)
                                //        {
                                //            strTypeUser = objSysment.UpdUser;

                                //            //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //            bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                //            if (blpsi == true)
                                //            {
                                //                string msg = string.Format("论文子观点表数据更新完成，统计数据完成");
                                //                result = true;
                                //            }
                                //            else
                                //            {
                                //                string msg = string.Format("论文子观点表数据更新失败");
                                //                result = false;
                                //            }
                                //        }

                                //    }
                                //}
                                #endregion


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
                                #region 注释
                                //必须是教师评分才统计
                                //if (strScoreTypeId == "2")
                                //{

                                //    if (strParentId == "root")
                                //    {
                                //        //添加各个观点、概念 换算后的数据插入或修改； ---参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0004", strCommentTypeId, strCurrEduId, strUserId);

                                //        if (blpsi == true)
                                //        {
                                //            string msg = string.Format("概念表数据更新完成，概念统计数据完成,概念评分统计完成");
                                //            result = true;
                                //        }
                                //        else
                                //        {
                                //            string msg = string.Format("概念评分统计数据失败");
                                //            result = false;
                                //        }
                                //    }
                                //    else
                                //    {
                                //        //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                //        clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                //        if (objSysment != null)
                                //        {
                                //            strTypeUser = objSysment.UpdUser;

                                //            //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //            bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                //            if (blpsi == true)
                                //            {
                                //                string msg = string.Format("概念更新完成，统计数据完成");
                                //                result = true;
                                //            }
                                //            else
                                //            {
                                //                string msg = string.Format("概念更新失败");
                                //                result = false;
                                //            }
                                //        }

                                //    }
                                //}
                                #endregion


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
                                #region 注释
                                //必须是教师评分才统计
                                //if (strScoreTypeId == "2")
                                //{
                                //    if (strParentId == "root")
                                //    {

                                //        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0005", strCommentTypeId, strCurrEduId, strUserId);

                                //        if (blpsi == true)
                                //        {
                                //            string msg = string.Format("客观事实表数据更新完成，客观事实统计数据完成,客观事实评分统计完成");
                                //            result = true;
                                //        }
                                //        else
                                //        {
                                //            string msg = string.Format("客观事实评分统计数据失败");
                                //            result = false;
                                //        }
                                //    }
                                //    else
                                //    {
                                //        //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                //        clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                //        if (objSysment != null)
                                //        {
                                //            strTypeUser = objSysment.UpdUser;

                                //            //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //            bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                //            if (blpsi == true)
                                //            {
                                //                string msg = string.Format("客观事实数据更新完成，统计数据完成");
                                //                result = true;
                                //            }
                                //            else
                                //            {
                                //                string msg = string.Format("客观事实更新失败");
                                //                result = false;
                                //            }
                                //        }

                                //    }

                                //}
                                #endregion

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
                                #region 注释
                                //必须是教师评分才统计
                                //if (strScoreTypeId == "2")
                                //{

                                //    if (strParentId == "root")
                                //    {
                                //        //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //        bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0006", strCommentTypeId, strCurrEduId, strUserId);

                                //        if (blpsi == true)
                                //        {
                                //            string msg = string.Format("客观数据更新完成，客观数据统计数据完成,客观数据评分统计完成");
                                //            result = true;
                                //        }
                                //        else
                                //        {
                                //            string msg = string.Format("客观数据评分统计数据失败");
                                //            result = false;
                                //        }
                                //    }
                                //    else
                                //    {
                                //        //首先需要通过strParentId作为主键查询，得到当前他人评价的用户Id
                                //        clsSysCommentEN objSysment = clsSysCommentBL.GetObjByCommentId(strParentId);
                                //        if (objSysment != null)
                                //        {
                                //            strTypeUser = objSysment.UpdUser;

                                //            //添加各个观点、概念 换算后的数据插入或修改； --参数：类型用户；分值；评分类型；传入的类型；当前评论的打分人教学班,当前打分人
                                //            bool blpsi = AddorUpdateSysScoreSummaryByWhere(strTypeUser, strScore, "0007", strCommentTypeId, strCurrEduId, strUserId);
                                //            if (blpsi == true)
                                //            {
                                //                string msg = string.Format("客观数据更新完成，统计数据完成");
                                //                result = true;
                                //            }
                                //            else
                                //            {
                                //                string msg = string.Format("客观数据更新失败");
                                //                result = false;
                                //            }
                                //        }

                                //    }

                                //}

                                #endregion



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
                        break;
                    case "08":
                        #region 人员评分
                        //人员评分
                        //必须是教师评分才统计
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


                        iScore = GetUserScore(strUserId, strCommentTypeId, strCurrEduId, strParentId);
                        strScore = iScore.ToString();
                        strScoreType = "0008";
                        //if (strParentId == "root")
                        //{
                        //    strScoreType = "0006";
                        //}
                        //else
                        //{
                        //    strScoreType = "0007";
                        //}


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
                        break;
                    case "21":
                        #region 中学生课件
                        strTypeUser = UpdDatazx_TextReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                        if (string.IsNullOrEmpty(strTypeUser) == false)
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
                            string msgpaper = string.Format("更新失败");
                            result = false;
                        }
                        #endregion
                        break;
                    case "22":
                        #region 中学个人观点
                        strTypeUser = UpdDatazx_ViewpointReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                        if (string.IsNullOrEmpty(strTypeUser) == false)
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
                                    string msg = string.Format("中学个人观点，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("中学个人观点失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("更新失败");
                            result = false;
                        }
                        #endregion
                        break;
                    case "23":
                        #region 中学专家观点
                        strTypeUser = UpdDatazx_ViewpointReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                        if (string.IsNullOrEmpty(strTypeUser) == false)
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
                                    string msg = string.Format("中学个人观点，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("中学个人观点失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("更新失败");
                            result = false;
                        }
                        #endregion
                        break;
                    case "24":
                        #region 中学概念
                        strTypeUser = UpdDatazx_ConceptReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                        if (string.IsNullOrEmpty(strTypeUser) == false)
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
                                    string msg = string.Format("中学概念，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("中学概念失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("更新失败");
                            result = false;
                        }
                        #endregion
                        break;
                    case "25":
                        #region 中学客观事实
                        strTypeUser = UpdDatazx_TopicObjectiveReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                        if (string.IsNullOrEmpty(strTypeUser) == false)
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
                                    string msg = string.Format("中学客观事实，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("中学客观事实失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("更新失败");
                            result = false;
                        }
                        #endregion
                        break;
                    case "26":
                        #region 中学客观数据
                        strTypeUser = UpdDatazx_TopicObjectiveReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                        if (string.IsNullOrEmpty(strTypeUser) == false)
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
                                    string msg = string.Format("中学客观数据，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("中学客观数据失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("更新失败");
                            result = false;
                        }
                        #endregion
                        break;
                    case "27":
                        #region 中学技能 zx_Skill
                        strTypeUser = UpdDatazx_SkillReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                        if (string.IsNullOrEmpty(strTypeUser) == false)
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
                                    string msg = string.Format("中学技能，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("中学技能失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("更新失败");
                            result = false;
                        }
                        #endregion
                        break;
                    case "28":
                        #region 28	中学社会关系 zx_SocialRelations  SocialId
                        strTypeUser = UpdDatazx_SocialRelationsReturnUpdUser(strTableKeyId, allCount, fScore, fStuScore, fTeaScore);
                        if (string.IsNullOrEmpty(strTypeUser) == false)
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
                                    string msg = string.Format("中学社会关系，统计数据完成");
                                    result = true;
                                }
                                else
                                {
                                    string msg = string.Format("中学社会关系失败");
                                    result = false;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            string msgpaper = string.Format("更新失败");
                            result = false;
                        }
                        #endregion
                        break;
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

        /// <summary>
        /// 中学生管理函数部分；
        /// 21	中学课件	zx_Text	TextId
        //22	中学个人观点 zx_Viewpoint    ViewpointId
        //23	中学专家观点 zx_Viewpoint    ViewpointId
        //24	中学概念 zx_Concept  ConceptId
        //25	中学客观事实 zx_TopicObjective   TopicObjectiveId
        //26	中学客观数据 zx_TopicObjective   TopicObjectiveId
        //27	中学技能 zx_Skill    SkillId
        //28	中学社会关系 zx_SocialRelations  SocialId
        /// </summary>
        #region 中学函数统计

        //课件
        #region 课件相关
        //更新课件；
        public static string UpdDatazx_TextReturnUpdUser(string strTableKeyId, int allCount, float fScore, float fStuScore, float fTeaScore)
        {
            string strTypeUser = string.Empty;
            clszx_TextEN objText = clszx_TextBL.GetObjByTextId(strTableKeyId);

            objText.AppraiseCount = allCount;
            objText.Score = fScore;//总评分
            objText.StuScore = fStuScore;//学生评分
            objText.TeaScore = fTeaScore;//教师评分
            strTypeUser = objText.UpdUser;
            //调用课件修改；
            bool cSoci = clszx_TextBL.UpdateBySql2(objText);
            if (cSoci == true)
            {
                string strMsg = string.Format("修改课件成功");
            }

            return strTypeUser;
        }

        #endregion
        // #region 中学个人观点
        #region  22中学个人观点 zx_Viewpoint    ViewpointId   23中学专家观点 zx_Viewpoint    ViewpointId
        public static string UpdDatazx_ViewpointReturnUpdUser(string strTableKeyId, int allCount, float fScore, float fStuScore, float fTeaScore)
        {
            string strTypeUser = string.Empty;
            clszx_ViewpointEN objzx_Viewpoint = clszx_ViewpointBL.GetObjByzxViewpointId(strTableKeyId);

            objzx_Viewpoint.AppraiseCount = allCount;
            objzx_Viewpoint.Score = fScore;//总评分
            objzx_Viewpoint.StuScore = fStuScore;//学生评分
            objzx_Viewpoint.TeaScore = fTeaScore;//教师评分
            strTypeUser = objzx_Viewpoint.UpdUser;
            //调用课件修改；
            bool cSoci = clszx_ViewpointBL.UpdateBySql2(objzx_Viewpoint);
            if (cSoci == true)
            {
                string strMsg = string.Format("修改观点成功");
            }

            return strTypeUser;
        }
        #endregion

        #region 24中学概念 zx_Concept  ConceptId
        public static string UpdDatazx_ConceptReturnUpdUser(string strTableKeyId, int allCount, float fScore, float fStuScore, float fTeaScore)
        {
            string strTypeUser = string.Empty;
            clszx_ConceptEN objzx_Concept = clszx_ConceptBL.GetObjByzxConceptId(strTableKeyId);

            objzx_Concept.AppraiseCount = allCount;
            objzx_Concept.Score = fScore;//总评分
            objzx_Concept.StuScore = fStuScore;//学生评分
            objzx_Concept.TeaScore = fTeaScore;//教师评分
            strTypeUser = objzx_Concept.UpdUser;
            //调用课件修改；
            bool cSoci = clszx_ConceptBL.UpdateBySql2(objzx_Concept);
            if (cSoci == true)
            {
                string strMsg = string.Format("修改概念成功");
            }

            return strTypeUser;
        }
        #endregion

        #region  25 zx_TopicObjective   TopicObjectiveId /////// 26	中学客观数据 zx_TopicObjective   TopicObjectiveId
        public static string UpdDatazx_TopicObjectiveReturnUpdUser(string strTableKeyId, int allCount, float fScore, float fStuScore, float fTeaScore)
        {
            string strTypeUser = string.Empty;
            clszx_TopicObjectiveEN objzx_TopicObjective = clszx_TopicObjectiveBL.GetObjByzxTopicObjectiveId(strTableKeyId);

            objzx_TopicObjective.AppraiseCount = allCount;
            objzx_TopicObjective.Score = fScore;//总评分
            objzx_TopicObjective.StuScore = fStuScore;//学生评分
            objzx_TopicObjective.TeaScore = fTeaScore;//教师评分
            strTypeUser = objzx_TopicObjective.UpdUser;
            //调用课件修改；
            bool cSoci = clszx_TopicObjectiveBL.UpdateBySql2(objzx_TopicObjective);
            if (cSoci == true)
            {
                string strMsg = string.Format("修改中学客观数据成功");
            }

            return strTypeUser;
        }
        #endregion

        #region  27	中学技能 zx_Skill    SkillId
        public static string UpdDatazx_SkillReturnUpdUser(string strTableKeyId, int allCount, float fScore, float fStuScore, float fTeaScore)
        {
            string strTypeUser = string.Empty;
            clszx_SkillEN objzx_Skill = clszx_SkillBL.GetObjByzxSkillId(strTableKeyId);

            objzx_Skill.AppraiseCount = allCount;
            objzx_Skill.Score = fScore;//总评分
            objzx_Skill.StuScore = fStuScore;//学生评分
            objzx_Skill.TeaScore = fTeaScore;//教师评分
            strTypeUser = objzx_Skill.UpdUser;
            //调用课件修改；
            bool cSoci = clszx_SkillBL.UpdateBySql2(objzx_Skill);
            if (cSoci == true)
            {
                string strMsg = string.Format("修改技能数据成功");
            }

            return strTypeUser;
        }
        #endregion

        #region  28	中学社会关系 zx_SocialRelations  SocialId
        public static string UpdDatazx_SocialRelationsReturnUpdUser(string strTableKeyId, int allCount, float fScore, float fStuScore, float fTeaScore)
        {
            string strTypeUser = string.Empty;
            clszx_SocialRelationsEN objzx_SocialRelations = clszx_SocialRelationsBL.GetObjByzxSocialId(strTableKeyId);

            objzx_SocialRelations.AppraiseCount = allCount;
            objzx_SocialRelations.Score = fScore;//总评分
            objzx_SocialRelations.StuScore = fStuScore;//学生评分
            objzx_SocialRelations.TeaScore = fTeaScore;//教师评分
            strTypeUser = objzx_SocialRelations.UpdUser;
            //调用课件修改；
            bool cSoci = clszx_SocialRelationsBL.UpdateBySql2(objzx_SocialRelations);
            if (cSoci == true)
            {
                string strMsg = string.Format("修改社会关系数据成功");
            }

            return strTypeUser;
        }
        #endregion

        #endregion



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
                        //修改各个观点、概念分数后，需要计算占比分数
                        bool i = AddviewpointWeightScore(strTypeUserId, strCurrEduId, strScoreType, strCommentTypeId, strUserId, fScore);
                        if (i == true)
                        {
                            string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                            result = true;
                        }
                        else
                        {
                            string strMsg = string.Format("SysScoreSummary统计分数修改数据成功");

                            result = false;
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
                        AddviewpointWeightScore(strTypeUserId, strCurrEduId, strScoreType, strCommentTypeId, strUserId, fScore);

                        string msgpaper = string.Format("各观点统计数据添加成功");

                        result = true;
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



        #region 删除评论方法的扩展
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

                int intRecNum = SysCommentDA.DelRecord(strCommentId);
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                ReFreshCache();




                if (intRecNum > 0)
                {
                    string strall = strUserId + "/" + strTableKeyId + "/" + strCommentTypeId + "/" + strParentId + "/" + strid_CurrEducls;
                    bool i = clsSysCommentBLEx.PersonalScoreStatistics(strUserId, strTableKeyId, strCommentTypeId, strParentId, strid_CurrEducls);
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
        #endregion


        #region 修改教学班周到评论数据

        public static bool UpdateCommentWeek(string strCurrEduclsId, string strUpdUser)
        {
            bool bolResult = false;
            string strStartDate = string.Empty;//开始日期
            string strEndDate = string.Empty;//结束日期
            try
            {

                //获取教学班日期数据
                clsgs_TeachingDateEN objgs_TeachingDate = clsgs_TeachingDateBL.GetFirstObj_S("IdCurrEduCls ='" + strCurrEduclsId + "'");
                strStartDate = objgs_TeachingDate.StartDate;
                strEndDate = objgs_TeachingDate.EndDate;

                //获取统计类型数据
                List<clsSysCommentEN> arrSysCommentList = clsSysCommentBL.GetObjLst("IdCurrEduCls ='" + strCurrEduclsId + "'");
                //2.3循环数据对象

                foreach (clsSysCommentEN objSysCommentEN in arrSysCommentList)
                {
                    //评论日期
                    string strCommentData = objSysCommentEN.UpdDate;
                    //获取评论日期在教学班时间那边的第几周
                    int intWeek = GetWeekByDate(strStartDate, strCommentData);
                    //获取周的时间范围
                    string strWeekTimeRange = GetWeekTimeRange(intWeek, strStartDate);
                    //获取月
                    string strMonth = GetMonthDate(strCommentData);

                    clsSysCommentEN objSysComment = new clsSysCommentEN();
                    objSysComment.CommentId = objSysCommentEN.CommentId;
                    objSysComment.Week = intWeek;
                    objSysComment.Month = int.Parse(strMonth);
                    objSysComment.WeekTimeRange = strWeekTimeRange;

                    bolResult = clsSysCommentBL.UpdateBySql2(objSysComment);

                }



            }
            catch (Exception objException)
            {
                string strMsg = string.Format("统计记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
            //return bolResult;
            return bolResult;
        }

        /// <summary>
        /// 获取周日期
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="CurrDate"></param>
        /// <returns></returns>
        public static int GetWeekByDate(string BeginDate, string CurrDate)
        {

            string strBeginDate = BeginDate.Substring(0, 10);//2020-06-01
            clsDateTime objDT = new clsDateTime(strBeginDate);
            DateTime objBeginDate = objDT.GetDateTime();

            string strCurrDate = CurrDate.Substring(0, 10);//2020-08-01
            clsDateTime objDT2 = new clsDateTime(strCurrDate);
            DateTime objCurrDate = objDT2.GetDateTime();

            //第一种方式
            //var aa = objCurrDate - objBeginDate;
            //int strWeekTotalDayNum = Convert.ToInt32(Math.Ceiling(aa.TotalDays / 7));//向上取整；
            WriteTextLog(objBeginDate.ToString() + "---" + objCurrDate.ToString(), "开始日期/天--结束日期/天", "TotalDataLog");

            //得到第几周 用天数除以7取整得到周
            //第二种方式得到周；
            TimeSpan ts = objCurrDate.Subtract(objBeginDate);
            var DayNum = Convert.ToDecimal(ts.Days);
            int strWeekTotal = Convert.ToInt32(Math.Ceiling(DayNum / 7));//向上取整；
            WriteTextLog(DayNum.ToString(), "时间相减DayNum", "TotalDataLog");
            WriteTextLog(strWeekTotal.ToString(), "得到DayNum周", "TotalDataLog");

            //StringBuilder sbMsg = new StringBuilder();
            //sbMsg.AppendFormat("当前日期：{0} 周：{1}", objBeginDate.ToLongDateString(), objBeginDate.DayOfWeek.ToString());
            //sbMsg.AppendFormat("现在距开始日期的天数：{0}", aa.TotalDays);
            //sbMsg.AppendFormat("第：{0}周", strWeekTotal);

            return strWeekTotal;
        }


        /// <summary>
        /// 根据得到的周 和教学班时间范围起始时间、可以得到当前周的范围时间
        /// </summary>
        /// <param name="Week"></param>
        /// <param name="BeginDate"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 获取月
        /// </summary>
        /// <param name="NowDate"></param>
        /// <returns></returns>
        public static string GetMonthDate(string NowDate)
        {
            string strCurrDate = NowDate.Substring(5, 2);//2020-08-01
            StringBuilder sbMsg = new StringBuilder();

            //sbMsg.AppendFormat("当前月：{0}", strCurrDate);
            //return sbMsg.ToString();
            return strCurrDate;
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
    }
}
